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
ORDER BY 3; -- Noktalý virgülün kullaným amacý kod bloðunun bittiðini gösterebilmek..

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

--6: Tedarikçi id si 1 veya 5 olan tedarikçilerden alýnan ürünlerin adýný ve stok sayýsýný gösteren sorgu.
SELECT S.CompanyName,S.ContactName,P.ProductName,P.UnitsInStock FROM Suppliers S
JOIN Products P ON P.SupplierID = S.SupplierID
WHERE S.SupplierID=1 OR S.SupplierID=5


--7: Stok sayýsý kritik olan 10 ürünün tedarikçilerinin adýný yazdýrýn.
SELECT TOP 10 P.ProductName, S.CompanyName,P.UnitsInStock 'Stoktaki Adedi',P.ReorderLevel 'Bulunmasý gereken en az miktar'
FROM Products P
JOIN Suppliers S ON P.SupplierID = S.SupplierID
WHERE P.UnitsInStock < P.ReorderLevel
ORDER BY P.UnitsInStock ASC

--8:Esparta bölgesine gönderilen en çok 5 ürünü listele.
SELECT TOP 5 OD.ProductID,SUM(Quantity) 'Toplam Satýlan Ürün Sayýsý' FROM Orders O
JOIN [Order Details] OD ON OD.OrderID LIKE O.OrderID
WHERE O.ShipRegion LIKE '%Esparta%'
GROUP BY OD.ProductID
ORDER BY 2 DESC


--9: En çok ürün alan müþteriye satýþ yapan personeller kimdir listele.
SELECT DISTINCT E.EmployeeID,E.FirstName,O.CustomerID FROM Employees E
JOIN Orders O ON O.EmployeeID = E.EmployeeID
WHERE O.CustomerID = (SELECT TOP 1 C.CustomerID FROM [Order Details] OD
JOIN Orders O ON OD.OrderID LIKE O.OrderID
JOIN Customers C ON C.CustomerID LIKE O.CustomerID
GROUP BY C.CustomerID,C.CompanyName,C.ContactName
ORDER BY SUM(Quantity) DESC)


--10: En çok hangi kategori türünde satýþ olmustur.
SELECT TOP 1 C.CategoryID,C.CategoryName,SUM(OD.Quantity*OD.UnitPrice*(1-OD.Discount)) 'Toplam Satýþ Tutarý ($)' FROM [Order Details] OD
JOIN Products P ON P.ProductID LIKE OD.ProductID
JOIN Categories C ON C.CategoryID LIKE P.CategoryID
GROUP BY C.CategoryID,C.CategoryName

--11- Ship PostalCode'u sadece sayýlardan oluþmayan sipariþler
SELECT ShipPostalCode FROM Orders
WHERE ShipPostalCode  LIKE '%[^(0-9)]%'
-- ^ bitwise xor, ^(0-9) dediðimizde 0-9 arasý sayýlardan farklý bir char var mý onu arýyor.. 
--        1^0 = 1 ; 0^1 = 1; 0^0 = 0; 1^1 = 0;


--12- ContactTitle'a göre sýralanmýþ ve Kendi içinde de sýralanmýþ tedarikçilerin adres þehir ve bölgeleri tek kolonda, kolon adý Adres
SELECT S.ContactTitle,S.SupplierID, S.[Address]+' '+S.City+' '+S.Region AS Adres FROM Suppliers S
ORDER BY (S.ContactTitle),(S.SupplierID)

--13- En ucuz sipariþ kaleminin tutarý
SELECT MIN(Quantity*UnitPrice*(1-Discount)) 'En Ucuz Sipariþ Tutarý ($)' FROM [Order Details]


--14- Adýnda a ve e harfi birlikte bulunan çalýþanlarýn yaþa göre sýralanmýþ halde bilgileri, adý ve soyadý Ad Soyad kolon adýyla gelecek
SELECT E.FirstName,E.LastName,E.FirstName+' '+E.LastName 'Ad Soyad' FROM Employees E
WHERE E.FirstName LIKE '%a%e%' OR E.FirstName LIKE '%e%a%'
ORDER BY E.BirthDate DESC

--15- Ýþe girdiðinde yaþý en genç olan top 3 çalýþan
SELECT E.FirstName,CAST((DATEDIFF(DAY,E.BirthDate,E.HireDate)/365.242199) AS int) 'Yaþ' FROM Employees E
ORDER BY DATEDIFF(DAY,E.BirthDate,E.HireDate) ASC
-- DATEDIFF EÐER 'YEAR' ALINIRSA, JANET 29 YAÞINDA ÇIKIYOR.. VE AYNI YIL DOÐANLARI ALFABEYE GÖRE KIYASLIYOR.


--16:5 numaralý çalýþanýn yaptýðý satýþlarýn toplam ücreti ne kadardýr.
SELECT E.EmployeeID,SUM(OD.Quantity*OD.UnitPrice*(1-OD.Discount)) 'Toplam Satýþ Ücreti ($)' FROM [Order Details] OD
JOIN Orders O ON O.OrderID LIKE OD.OrderID
JOIN Employees E ON E.EmployeeID LIKE O.EmployeeID
WHERE E.EmployeeID = 5
GROUP BY E.EmployeeID

--17:Kategorisi 1,3,5,7 olan ürünleri ürün isimlerine göre listeleyiniz.
SELECT * FROM Products P
WHERE CategoryID IN (1,3,5,7)
ORDER BY LEN(P.ProductName)

--18: 5 numaralý ürünü 2 numaralý kargocuya taþýtan müþterileri gösteriniz.


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

--30-Sales Representative  lerin ad ve soyadlarýný bir kolonda, iþe girisinden sonra geçen günü 'Geçen Gün' kolonunda gösterip sýralamayý geçen güne göre artan yapýn.

--31-personelleri yaþ sýralamasý yapýp 25ten büyük olanlarýn ünvan kolonu açýp usta küçükse çýrak yazsýn
SELECT LastName, FirstName, BirthDate,
  CASE
    WHEN DATEDIFF(year, BirthDate, GETDATE()) > 25 THEN Title + '- Usta'
    ELSE Title + '- Çýrak' 
  END AS Unvan
FROM Employees
ORDER BY BirthDate

--32-personellerin yaþýný hesaplayýp ayrý bir yaþ kolonunda yazýn
SELECT E.FirstName,E.LastName,DATEDIFF(YEAR,E.BirthDate,GETDATE()) AS YAS FROM Employees E

--33-ürün tablosundan categorisi 2 olanlarýn stoklarýný 10 ar arttýrarak yenileyelim ve indirim uygulayalým
SELECT ProductName,(UnitsInStock+10) 'Stok Miktarý',(UnitPrice*0.9) 'Yeni Birim Fiyat' FROM Products P
JOIN  Categories C ON P.CategoryID = C.CategoryID
WHERE P.CategoryID = 2

--34-ürün stoklarý 100ün üzerinde olanlarýa indirim uygulayýp birim fiyatýnýda 1$ düþürelim
SELECT P.ProductName,P.UnitPrice 'Eski Fiyat',(P.UnitPrice*0.9)-1 AS 'Yeni Fiyat' FROM Products P
WHERE P.UnitsInStock>100 

--35-costumers tablosundaki country kolonunda mexico yerine siesta yazalým
CREATE OR ALTER VIEW Musteriler AS
SELECT Country FROM Customers
UPDATE Musteriler
SET Country = 'Siesta'
WHERE Country = 'Mexico'
SELECT * FROM Musteriler;

--36-En çok satilan 10 ürünün kategorileri
SELECT TOP 10 P.ProductID,SUM(OD.Quantity)'Satis Miktari',C.CategoryName  FROM [Order Details] OD
JOIN Products P ON P.ProductID = OD.ProductID
JOIN Categories C ON C.CategoryID = P.CategoryID
GROUP BY P.ProductID,C.CategoryName
ORDER BY 2 DESC


--37-1997 Ocak ayýnda en çok alýþveriþ yapan müþterinin en çok aldýðý ürünün indirim oraný
SELECT TOP 1 C.CustomerID,SUM(OD.Quantity*OD.UnitPrice*(1-OD.Discount)) 'Urune Odediði Ucret',P.ProductID,P.ProductName,OD.Discount FROM [Order Details] OD
JOIN Orders O ON O.OrderID = OD.OrderID
JOIN Customers C ON C.CustomerID = O.CustomerID
JOIN Products P  ON P.ProductID = OD.ProductID
WHERE O.OrderDate BETWEEN '1997-01-01' AND '1997-01-31'
GROUP BY C.CustomerID,P.ProductID,P.ProductName,OD.Discount
ORDER BY 2 DESC

--38-1997 yýlýnýn en çok satilan ürünün ülkesi ve totalprice
SELECT TOP 1 P.ProductID,P.ProductName,SUM(Quantity) 'Satis Miktari', S.Country,SUM(OD.Quantity*OD.UnitPrice*(1-OD.Discount)) 'Toplam Odeme'
FROM [Order Details] OD
JOIN Orders O ON O.OrderID = OD.OrderID
JOIN Products P ON P.ProductID = OD.ProductID
JOIN Suppliers S ON S.SupplierID = P.SupplierID
WHERE O.OrderDate BETWEEN '1997-01-01' AND '1998-01-01'
GROUP BY P.ProductID,P.ProductName, S.Country
ORDER BY 3 DESC

--39-Stok miktari 20 altýna düþen ürünlerin tedarikçilerinin telefon numalarý
SELECT P.ProductName,S.CompanyName,S.Phone FROM Products P
JOIN Suppliers S ON P.SupplierID = S.SupplierID
WHERE P.UnitsInStock<20
ORDER BY CompanyName -- Hangi firmadan hangi ürünleri isteyecek, kolay ulaþmasý için þirket ismine göre sýraladým.


--40-bu ay en çok satýþ yapan çalýþanýn en fazla satýþ yaptýðý ürünün devamý var mý?
SELECT TOP 1  E.EmployeeID,E.FirstName,P.ProductName,OD.Quantity,P.Discontinued FROM  [Order Details] OD
JOIN Products P ON P.ProductID = OD.ProductID
JOIN Orders O ON O.OrderID = OD.OrderID
JOIN Employees E ON E.EmployeeID = O.EmployeeID
WHERE DATEDIFF(DAY,O.OrderDate,(SELECT MAX(OrderDate) FROM Orders)) <= 30 AND E.EmployeeID = 2
ORDER BY 4 DESC

--41-en fazla ürünü bulunan tedarikçinin kaç adet ürünü vardýr.
-- En fazla ürünü bulunan 2 Tedarikçi olduðu için TOP 2 yaptým..;
SELECT TOP 2 S.SupplierID,COUNT(*) 'Urun Cesid Sayisi',SUM(P.UnitsInStock) 'Elindeki Ürün Sayýsý' FROM Suppliers S
JOIN Products P ON P.SupplierID = S.SupplierID
GROUP BY S.SupplierID
ORDER BY 2 DESC 

--42-Ürünlerden en az bir kere satýlmýþ olanlarýn listesi
SELECT DISTINCT P.ProductID,P.ProductName 'En az 1 kere satýlan ürün adý' FROM [Order Details] OD
JOIN Products P ON P.ProductID LIKE OD.ProductID
ORDER BY P.ProductID

--43-Hiç alýþveriþ yapmamýþ kullanýcýlarýn listesi
SELECT C.CustomerID FROM Customers C
FULL JOIN Orders O ON C.CustomerID = O.CustomerID
FULL JOIN [Order Details] OD ON OD.OrderID = O.OrderID
WHERE O.OrderID IS NULL
GROUP BY C.CustomerID

--44-Þehri London olan müþterilerin ürünlerinden an çok satanlar
SELECT P.ProductID,P.ProductName,SUM(OD.Quantity) FROM Customers C
JOIN Orders O ON C.CustomerID = O.CustomerID
JOIN [Order Details] OD ON OD.OrderID = O.OrderID
JOIN Products P ON P.ProductID = OD.ProductID
WHERE C.City = 'London'
GROUP BY P.ProductID,P.ProductName
ORDER BY 3 DESC 


--45-Tedarikçi Id'si 1 olan ürünleri en çok sipariþ eden 3 müþteri
SELECT  C.CustomerID,COUNT(*) FROM Customers C
JOIN Orders O ON O.CustomerID = C.CustomerID
JOIN [Order Details] OD ON OD.OrderID = O.OrderID
JOIN Products P ON P.ProductID = OD.ProductID
JOIN Suppliers S ON S.SupplierID = P.SupplierID
WHERE S.SupplierID = 1
GROUP BY C.CustomerID
ORDER BY 2 DESC

--46- Toplam kargo ya ödediðimiz ücret toplamý ciromuzun %'de kaçýdýr ?
SELECT ((SELECT SUM(Freight) FROM Orders)/(SELECT SUM(OD.Quantity*OD.UnitPrice*(1-OD.Discount)) 'Toplam Cüro' FROM [Order Details] OD))*100 AS 'Ciro''da Kargoya Ödenen Yüzde'
 
 ----TOPLAM NAKLÝYE UCRETÝ---------
 -- SELECT SUM(Freight) FROM Orders 

 ----TOPLAM CÝRO-----
 -- SELECT SUM(OD.Quantity*OD.UnitPrice*(1-OD.Discount)) 'Toplam Ciro' FROM [Order Details] OD
 


--47-En çok sattýðýmýz ürün ile en az sattýðýmýz ürün arasýndaki adet fark kaçtýr ?
/*SELECT TOP 1 SUM(OD.Quantity) FROM [Order Details] OD
GROUP BY OD.ProductID
ORDER BY 1 ASC

SELECT TOP 1 SUM(OD.Quantity) FROM [Order Details] OD
GROUP BY OD.ProductID
ORDER BY 1 DESC*/

SELECT (SELECT TOP 1 SUM(OD.Quantity) FROM [Order Details] OD
GROUP BY OD.ProductID
ORDER BY 1 DESC) - (SELECT TOP 1 SUM(OD.Quantity) FROM [Order Details] OD
GROUP BY OD.ProductID
ORDER BY 1 ASC) 'En çok satýlan ürün ile en az satýlan ürün arasýndaki satýþ miktarý farký' 

--48-  Ýndirim yapýlan ürünler ile indirim yapýlmamýþ halleri arasýndaki fiyat farký nedir hepsi için gruplayarak?
SELECT OD.ProductID,(OD.UnitPrice*OD.Discount) 'Indirim Miktari' FROM [Order Details] OD
WHERE OD.Discount NOT LIKE 0
GROUP BY OD.ProductID,OD.UnitPrice,OD.Discount

--49- En çok hangi ülkelere satýþ yapmýþýz top 5 sýralayýn ?
SELECT TOP 5 C.Country,SUM(OD.Quantity*OD.UnitPrice*(1-OD.Discount)) 'Satis Miktari ($)' FROM Customers C
JOIN Orders O ON O.CustomerID LIKE C.CustomerID
JOIN [Order Details] OD ON OD.OrderID LIKE O.OrderID
GROUP BY C.Country
ORDER BY 2 DESC

--50- En çok ürünü hangi city deki müþteri almýþtýr
SELECT C.CustomerID,C.ContactName,SUM(OD.Quantity),C.City FROM Customers C
JOIN Orders O ON C.CustomerID = O.CustomerID
JOIN [Order Details] OD ON OD.OrderID = O.OrderID
GROUP BY C.CustomerID,C.ContactName,C.City
ORDER BY 3 DESC
