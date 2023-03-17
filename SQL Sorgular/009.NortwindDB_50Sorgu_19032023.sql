USE Northwind
--SORU1-En çok satýþ yaptýðým müþterim hangisi
SELECT TOP 1  C.CustomerID,SUM(OD.Quantity*OD.UnitPrice*(1-OD.Discount)) 'Satis Miktari' FROM [Order Details] OD
JOIN Orders O ON O.OrderID LIKE OD.OrderID
JOIN Customers C ON C.CustomerID LIKE O.CustomerID
GROUP BY C.CustomerID
ORDER BY SUM(OD.Quantity*OD.UnitPrice*(1-OD.Discount)) DESC

--SORU2-En çok hangi sipariþten para kazanmýþým?
SELECT TOP 1 OD.OrderID,SUM(OD.Quantity*OD.UnitPrice*(1-OD.Discount)) 'Satis Miktari' FROM [Order Details] OD
JOIN Orders O ON O.OrderID LIKE OD.OrderID
JOIN Customers C ON C.CustomerID LIKE O.CustomerID
GROUP BY OD.OrderID,OD.Quantity*OD.UnitPrice*(1-OD.Discount)
ORDER BY SUM(OD.Quantity*OD.UnitPrice*(1-OD.Discount)) DESC


--SORU3 -2 ay önce yaptýðým satýþlarýnýn london þehrinde ki x ürünün satýþ miktari
-- 2 AY ÖNCE DEDÝÐÝ ÝÇÝN 60 GÜN ÖNCESÝNÝ ALDIK.. 60 > ... yapýlýrsa son 2 ay alýnýr... eðer günümüze göre hesaplayacaksan GETDATE() metodu kullanýlýr...
SELECT P.ProductID,P.ProductName,SUM(OD.Quantity) 'Satýlan Urun Adedi' FROM Products P
JOIN [Order Details] OD ON OD.ProductID = P.ProductID
JOIN Orders O ON O.OrderID = OD.OrderID
WHERE O.ShipCity LIKE 'London' AND P.ProductName = 'Chai' AND 60 = DATEDIFF(DAY,O.ShippedDate,(SELECT MAX(O.ShippedDate) FROM Orders O))
GROUP BY P.ProductID,P.ProductName

SELECT MAX(O.ShippedDate) FROM Orders O


--SORU4-son 2 yýl içinde en çok satýlan ürün ve en az satýlan ürün
SELECT TOP 1 P.ProductID,P.ProductName,SUM(OD.Quantity) 'Satýlan Urun Adedi' FROM Products P
JOIN [Order Details] OD ON OD.ProductID = P.ProductID
JOIN Orders O ON O.OrderID = OD.OrderID
WHERE 720 > DATEDIFF(DAY,O.ShippedDate,(SELECT MAX(O.ShippedDate) FROM Orders O)) 
GROUP BY P.ProductID,P.ProductName
ORDER BY 3

SELECT TOP 1 P.ProductID,P.ProductName,SUM(OD.Quantity) 'Satýlan Urun Adedi' FROM Products P
JOIN [Order Details] OD ON OD.ProductID = P.ProductID
JOIN Orders O ON O.OrderID = OD.OrderID
WHERE 720 > DATEDIFF(DAY,O.ShippedDate,(SELECT MAX(O.ShippedDate) FROM Orders O)) 
GROUP BY P.ProductID,P.ProductName
ORDER BY 3 DESC

--5-yýlýn çalýþaný kim en çok satýþ yapan
SELECT TOP 1 E.EmployeeID,E.FirstName 'Yýlýn Çalýþaný',SUM(OD.Quantity*OD.UnitPrice*(1-OD.Discount)) '1 Yýlda Satýlan Ürünlerin Toplam Fiyatý' FROM Employees E
JOIN Orders O ON O.EmployeeID = E.EmployeeID
JOIN [Order Details] OD ON OD.OrderID = O.OrderID
WHERE 365<DATEDIFF(DAY,O.ShippedDate,(SELECT MAX(ShippedDate) FROM Orders))
GROUP BY E.EmployeeID,E.FirstName
ORDER BY SUM(OD.Quantity*OD.UnitPrice*(1-OD.Discount)) DESC

--6: Tedarikçi id si 1 ile 5 olan tedarikçilerden alýnan ürünlerin adýný ve stok sayýsýný gösteren sorgu.


--7: Stok sayýsý kritik olan 10 ürünün tedarikçilerinin adýný yazdýrýn.
--8:Esparta bölgesine gönderilen en çok 5 ürünü listele.
--9: En çok ürün alan müþteriye satýþ yapan personeller kimdir listele.
--10: En çok hangi kategori türünde satýþ olmustur.
--11- Ship PostalCode'u sadece sayýlardan oluþmayan sipariþler
--12- ContactTitle'a göre sýralanmýþ ve Kendi içinde de sýralanmýþ tedarikçilerin adres þehir ve bölgeleri tek kolonda, kolon adý Adres
--13- En ucuz sipariþ kaleminin tutarý
--14- Adýnda a ve e harfi birlikte bulunan çalýþanlarýn yaþa göre sýralanmýþ halde bilgileri, adý ve soyadý Ad Soyad kolon adýyla gelecek
--15- Ýþe girdiðinde yaþý en genç olan top 3 çalýþan
--16:5 numaralý çalýþanýn yaptýðý satýþlarýn toplam ücreti ne kadardýr.
--17:Kategorisi 1,3,5,7 olan ürünleri ürün isimlerine göre listeleyiniz.
--18: 5 numaralý ürünü 2 numaralý kargocuya taþýtan müþterileri gösteriniz
--19: Chai ürününü en çok alan müþterileri ve ödenen fiyatý azalan þekilde listeleyiniz.
--20:ürün adý cha ile baþlayan ve 4 harften oluþan ürünleri sorgusunu yazýnýz.
--21-Tekrar sipariþ etme seviyesi 25'ten fazla olan ürünlerden birim fiyatý en yüksek olan ilk 3 ürünün ürün adý ve birim fiyatýný gösterin
--22-sipariþ tarihi 01.01.1997 den önce olan sipariþlerden bölge bilgisi boþ olmayan ve ülkesi Meksika olan sipariþlerin sipariþ idsi tarihi ve ülkesini listeleyin
--23-stoklarý 10 ve 50 arasýnda olan ürünlerin indirim yapýlmayanlarýnýn birim fiyatlarýný azdan çoða doðru listeleyin.
--24-4 numaralý kategoriye ait olan birim fiyatý 10'dan büyük olan ürünlerin ismini ve fiyatýný fiyat çoktan aza sýralanacak þekilde listeleyin
--25-müþteri ismi T ile baþlayan ve ülkesi USA olan müþterilerin müþteri ismi ve telefon numaralarýný listeleyin
--26-En çok sipariþ veren müþteri bilgileri listele
--27-UnitPrice ý 15 ile 100 arasýnda olan, devam ettirilen ürünlerin adý ve fiyat bilgilerini fiyata göre artan sekilde sýralayýn
--28-1 numaralý kargo ile Cork sehrine gönderilen veya taþýma ücreti 111 den küçük olanlarýn siparis tarihini ve gönderim tarihlerini listeleyin
--29-Tedarikci adýnýn 2. harfi a veya e olan ve sonu n veya s ile bitmeyenlerin listesi
--30-Sales Representative  lerin ad ve soyadlarýný bir kolonda, iþe girisinden sonra geçen günü 'Geçen Gün' kolonunda gösterip sýralamayý geçen güne göre artan yapýn
--31-personelleri yaþ sýralamasý yapýp 25ten büyük olanlarýn ünvan kolonu açýp usta küçükse çýrak yazsýn
--32-personellerin yaþýný hesaplayýp ayrý bir yaþ kolonunda yazýn
--33-ürün tablosundan categorisi 2 olanlarýn stoklarýný 10 ar arttýrarak yenileyelim ve indirim uygulayalým
--34-ürün stoklarý 100ün üzerinde olanlarýa indirim uygulayýp birim fiyatýnýda 1$ düþürelim
--35-costumers tablosundaki country kolonunda mexico yerine siesta yazalým
--36-En çok satilan 10 ürünün kategorileri
--37-1994 Ocak ayýnda en çok alýþveriþ yapan müþterinin en çok aldýðý ürünün indirim oraný
--38-1993 yýlýnýn en çok satilan ürünün ülkesi ve totalprice
--39-Stok miktari 20 altýna düþen ürünlerin tedarikçilerinin telefon numalarý
--40-bu ay en çok satýþ yapan çalýþanýn en fazla satýþ yaptýðý ürünün devamý var mý
--41-en fazla ürünü bulunan tedarikçinin kaç adet ürünü vardýr.
--42-Ürünlerden en az bir kere satýlmýþ olanlarýn listesi
--43-Hiç alýþveriþ yapmamýþ kullanýcýlarýn listesi
--44-Þehri londra olan müþterilerin ürünlerinden an çok satanlar
--45-Tedarikçi Id'si 1 olan ürünleri en çok sipariþ eden 3 müþteri
--46- Toplam kargo ya ödediðimiz ücret toplamý ciromuzun %'de kaçýdýr ?
--47-En çok sattýðýmýz ürün ile en az sattýðýmýz ürün arasýndaki adet fark kaçtýr ?
--48-  Ýndirim yapýlan ürünler ile indirim yapýlmamýþ halleri arasýndaki fiyat farký nedir hepsi için gruplayarak?
--49- En çok hangi ülkelere satýþ yapmýþýz top 5 sýralayýn ?
--50- En çok ürünü hangi city deki müþteri almýþtýr