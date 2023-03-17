USE Northwind
--SORU1-En �ok sat�� yapt���m m��terim hangisi
SELECT TOP 1  C.CustomerID,SUM(OD.Quantity*OD.UnitPrice*(1-OD.Discount)) 'Satis Miktari' FROM [Order Details] OD
JOIN Orders O ON O.OrderID LIKE OD.OrderID
JOIN Customers C ON C.CustomerID LIKE O.CustomerID
GROUP BY C.CustomerID
ORDER BY SUM(OD.Quantity*OD.UnitPrice*(1-OD.Discount)) DESC

--SORU2-En �ok hangi sipari�ten para kazanm���m?
SELECT TOP 1 OD.OrderID,SUM(OD.Quantity*OD.UnitPrice*(1-OD.Discount)) 'Satis Miktari' FROM [Order Details] OD
JOIN Orders O ON O.OrderID LIKE OD.OrderID
JOIN Customers C ON C.CustomerID LIKE O.CustomerID
GROUP BY OD.OrderID,OD.Quantity*OD.UnitPrice*(1-OD.Discount)
ORDER BY SUM(OD.Quantity*OD.UnitPrice*(1-OD.Discount)) DESC


--SORU3 -2 ay �nce yapt���m sat��lar�n�n london �ehrinde ki x �r�n�n sat�� miktari
-- 2 AY �NCE DED��� ���N 60 G�N �NCES�N� ALDIK.. 60 > ... yap�l�rsa son 2 ay al�n�r... e�er g�n�m�ze g�re hesaplayacaksan GETDATE() metodu kullan�l�r...
SELECT P.ProductID,P.ProductName,SUM(OD.Quantity) 'Sat�lan Urun Adedi' FROM Products P
JOIN [Order Details] OD ON OD.ProductID = P.ProductID
JOIN Orders O ON O.OrderID = OD.OrderID
WHERE O.ShipCity LIKE 'London' AND P.ProductName = 'Chai' AND 60 = DATEDIFF(DAY,O.ShippedDate,(SELECT MAX(O.ShippedDate) FROM Orders O))
GROUP BY P.ProductID,P.ProductName

SELECT MAX(O.ShippedDate) FROM Orders O


--SORU4-son 2 y�l i�inde en �ok sat�lan �r�n ve en az sat�lan �r�n
SELECT TOP 1 P.ProductID,P.ProductName,SUM(OD.Quantity) 'Sat�lan Urun Adedi' FROM Products P
JOIN [Order Details] OD ON OD.ProductID = P.ProductID
JOIN Orders O ON O.OrderID = OD.OrderID
WHERE 720 > DATEDIFF(DAY,O.ShippedDate,(SELECT MAX(O.ShippedDate) FROM Orders O)) 
GROUP BY P.ProductID,P.ProductName
ORDER BY 3

SELECT TOP 1 P.ProductID,P.ProductName,SUM(OD.Quantity) 'Sat�lan Urun Adedi' FROM Products P
JOIN [Order Details] OD ON OD.ProductID = P.ProductID
JOIN Orders O ON O.OrderID = OD.OrderID
WHERE 720 > DATEDIFF(DAY,O.ShippedDate,(SELECT MAX(O.ShippedDate) FROM Orders O)) 
GROUP BY P.ProductID,P.ProductName
ORDER BY 3 DESC

--5-y�l�n �al��an� kim en �ok sat�� yapan
SELECT TOP 1 E.EmployeeID,E.FirstName 'Y�l�n �al��an�',SUM(OD.Quantity*OD.UnitPrice*(1-OD.Discount)) '1 Y�lda Sat�lan �r�nlerin Toplam Fiyat�' FROM Employees E
JOIN Orders O ON O.EmployeeID = E.EmployeeID
JOIN [Order Details] OD ON OD.OrderID = O.OrderID
WHERE 365<DATEDIFF(DAY,O.ShippedDate,(SELECT MAX(ShippedDate) FROM Orders))
GROUP BY E.EmployeeID,E.FirstName
ORDER BY SUM(OD.Quantity*OD.UnitPrice*(1-OD.Discount)) DESC

--6: Tedarik�i id si 1 ile 5 olan tedarik�ilerden al�nan �r�nlerin ad�n� ve stok say�s�n� g�steren sorgu.


--7: Stok say�s� kritik olan 10 �r�n�n tedarik�ilerinin ad�n� yazd�r�n.
--8:Esparta b�lgesine g�nderilen en �ok 5 �r�n� listele.
--9: En �ok �r�n alan m��teriye sat�� yapan personeller kimdir listele.
--10: En �ok hangi kategori t�r�nde sat�� olmustur.
--11- Ship PostalCode'u sadece say�lardan olu�mayan sipari�ler
--12- ContactTitle'a g�re s�ralanm�� ve Kendi i�inde de s�ralanm�� tedarik�ilerin adres �ehir ve b�lgeleri tek kolonda, kolon ad� Adres
--13- En ucuz sipari� kaleminin tutar�
--14- Ad�nda a ve e harfi birlikte bulunan �al��anlar�n ya�a g�re s�ralanm�� halde bilgileri, ad� ve soyad� Ad Soyad kolon ad�yla gelecek
--15- ��e girdi�inde ya�� en gen� olan top 3 �al��an
--16:5 numaral� �al��an�n yapt��� sat��lar�n toplam �creti ne kadard�r.
--17:Kategorisi 1,3,5,7 olan �r�nleri �r�n isimlerine g�re listeleyiniz.
--18: 5 numaral� �r�n� 2 numaral� kargocuya ta��tan m��terileri g�steriniz
--19: Chai �r�n�n� en �ok alan m��terileri ve �denen fiyat� azalan �ekilde listeleyiniz.
--20:�r�n ad� cha ile ba�layan ve 4 harften olu�an �r�nleri sorgusunu yaz�n�z.
--21-Tekrar sipari� etme seviyesi 25'ten fazla olan �r�nlerden birim fiyat� en y�ksek olan ilk 3 �r�n�n �r�n ad� ve birim fiyat�n� g�sterin
--22-sipari� tarihi 01.01.1997 den �nce olan sipari�lerden b�lge bilgisi bo� olmayan ve �lkesi Meksika olan sipari�lerin sipari� idsi tarihi ve �lkesini listeleyin
--23-stoklar� 10 ve 50 aras�nda olan �r�nlerin indirim yap�lmayanlar�n�n birim fiyatlar�n� azdan �o�a do�ru listeleyin.
--24-4 numaral� kategoriye ait olan birim fiyat� 10'dan b�y�k olan �r�nlerin ismini ve fiyat�n� fiyat �oktan aza s�ralanacak �ekilde listeleyin
--25-m��teri ismi T ile ba�layan ve �lkesi USA olan m��terilerin m��teri ismi ve telefon numaralar�n� listeleyin
--26-En �ok sipari� veren m��teri bilgileri listele
--27-UnitPrice � 15 ile 100 aras�nda olan, devam ettirilen �r�nlerin ad� ve fiyat bilgilerini fiyata g�re artan sekilde s�ralay�n
--28-1 numaral� kargo ile Cork sehrine g�nderilen veya ta��ma �creti 111 den k���k olanlar�n siparis tarihini ve g�nderim tarihlerini listeleyin
--29-Tedarikci ad�n�n 2. harfi a veya e olan ve sonu n veya s ile bitmeyenlerin listesi
--30-Sales Representative  lerin ad ve soyadlar�n� bir kolonda, i�e girisinden sonra ge�en g�n� 'Ge�en G�n' kolonunda g�sterip s�ralamay� ge�en g�ne g�re artan yap�n
--31-personelleri ya� s�ralamas� yap�p 25ten b�y�k olanlar�n �nvan kolonu a��p usta k���kse ��rak yazs�n
--32-personellerin ya��n� hesaplay�p ayr� bir ya� kolonunda yaz�n
--33-�r�n tablosundan categorisi 2 olanlar�n stoklar�n� 10 ar artt�rarak yenileyelim ve indirim uygulayal�m
--34-�r�n stoklar� 100�n �zerinde olanlar�a indirim uygulay�p birim fiyat�n�da 1$ d���relim
--35-costumers tablosundaki country kolonunda mexico yerine siesta yazal�m
--36-En �ok satilan 10 �r�n�n kategorileri
--37-1994 Ocak ay�nda en �ok al��veri� yapan m��terinin en �ok ald��� �r�n�n indirim oran�
--38-1993 y�l�n�n en �ok satilan �r�n�n �lkesi ve totalprice
--39-Stok miktari 20 alt�na d��en �r�nlerin tedarik�ilerinin telefon numalar�
--40-bu ay en �ok sat�� yapan �al��an�n en fazla sat�� yapt��� �r�n�n devam� var m�
--41-en fazla �r�n� bulunan tedarik�inin ka� adet �r�n� vard�r.
--42-�r�nlerden en az bir kere sat�lm�� olanlar�n listesi
--43-Hi� al��veri� yapmam�� kullan�c�lar�n listesi
--44-�ehri londra olan m��terilerin �r�nlerinden an �ok satanlar
--45-Tedarik�i Id'si 1 olan �r�nleri en �ok sipari� eden 3 m��teri
--46- Toplam kargo ya �dedi�imiz �cret toplam� ciromuzun %'de ka��d�r ?
--47-En �ok satt���m�z �r�n ile en az satt���m�z �r�n aras�ndaki adet fark ka�t�r ?
--48-  �ndirim yap�lan �r�nler ile indirim yap�lmam�� halleri aras�ndaki fiyat fark� nedir hepsi i�in gruplayarak?
--49- En �ok hangi �lkelere sat�� yapm���z top 5 s�ralay�n ?
--50- En �ok �r�n� hangi city deki m��teri alm��t�r