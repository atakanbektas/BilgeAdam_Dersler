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
ORDER BY 3; -- Noktal� virg�l�n kullan�m amac� kod blo�unun bitti�ini g�sterebilmek..

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

--6: Tedarik�i id si 1 veya 5 olan tedarik�ilerden al�nan �r�nlerin ad�n� ve stok say�s�n� g�steren sorgu.
SELECT S.CompanyName,S.ContactName,P.ProductName,P.UnitsInStock FROM Suppliers S
JOIN Products P ON P.SupplierID = S.SupplierID
WHERE S.SupplierID=1 OR S.SupplierID=5


--7: Stok say�s� kritik olan 10 �r�n�n tedarik�ilerinin ad�n� yazd�r�n.
SELECT TOP 10 P.ProductName, S.CompanyName,P.UnitsInStock 'Stoktaki Adedi',P.ReorderLevel 'Bulunmas� gereken en az miktar'
FROM Products P
JOIN Suppliers S ON P.SupplierID = S.SupplierID
WHERE P.UnitsInStock < P.ReorderLevel
ORDER BY P.UnitsInStock ASC

--8:Esparta b�lgesine g�nderilen en �ok 5 �r�n� listele.
SELECT TOP 5 OD.ProductID,SUM(Quantity) 'Toplam Sat�lan �r�n Say�s�' FROM Orders O
JOIN [Order Details] OD ON OD.OrderID LIKE O.OrderID
WHERE O.ShipRegion LIKE '%Esparta%'
GROUP BY OD.ProductID
ORDER BY 2 DESC


--9: En �ok �r�n alan m��teriye sat�� yapan personeller kimdir listele.
SELECT DISTINCT E.EmployeeID,E.FirstName,O.CustomerID FROM Employees E
JOIN Orders O ON O.EmployeeID = E.EmployeeID
WHERE O.CustomerID = (SELECT TOP 1 C.CustomerID FROM [Order Details] OD
JOIN Orders O ON OD.OrderID LIKE O.OrderID
JOIN Customers C ON C.CustomerID LIKE O.CustomerID
GROUP BY C.CustomerID,C.CompanyName,C.ContactName
ORDER BY SUM(Quantity) DESC)


--10: En �ok hangi kategori t�r�nde sat�� olmustur.
SELECT TOP 1 C.CategoryID,C.CategoryName,SUM(OD.Quantity*OD.UnitPrice*(1-OD.Discount)) 'Toplam Sat�� Tutar� ($)' FROM [Order Details] OD
JOIN Products P ON P.ProductID LIKE OD.ProductID
JOIN Categories C ON C.CategoryID LIKE P.CategoryID
GROUP BY C.CategoryID,C.CategoryName

--11- Ship PostalCode'u sadece say�lardan olu�mayan sipari�ler
SELECT ShipPostalCode FROM Orders
WHERE ShipPostalCode  LIKE '%[^(0-9)]%'
-- ^ bitwise xor, ^(0-9) dedi�imizde 0-9 aras� say�lardan farkl� bir char var m� onu ar�yor.. 
--        1^0 = 1 ; 0^1 = 1; 0^0 = 0; 1^1 = 0;


--12- ContactTitle'a g�re s�ralanm�� ve Kendi i�inde de s�ralanm�� tedarik�ilerin adres �ehir ve b�lgeleri tek kolonda, kolon ad� Adres
SELECT S.ContactTitle,S.SupplierID, S.[Address]+' '+S.City+' '+S.Region AS Adres FROM Suppliers S
ORDER BY (S.ContactTitle),(S.SupplierID)

--13- En ucuz sipari� kaleminin tutar�
SELECT MIN(Quantity*UnitPrice*(1-Discount)) 'En Ucuz Sipari� Tutar� ($)' FROM [Order Details]


--14- Ad�nda a ve e harfi birlikte bulunan �al��anlar�n ya�a g�re s�ralanm�� halde bilgileri, ad� ve soyad� Ad Soyad kolon ad�yla gelecek
SELECT E.FirstName,E.LastName,E.FirstName+' '+E.LastName 'Ad Soyad' FROM Employees E
WHERE E.FirstName LIKE '%a%e%' OR E.FirstName LIKE '%e%a%'
ORDER BY E.BirthDate DESC

--15- ��e girdi�inde ya�� en gen� olan top 3 �al��an
SELECT E.FirstName,CAST((DATEDIFF(DAY,E.BirthDate,E.HireDate)/365.242199) AS int) 'Ya�' FROM Employees E
ORDER BY DATEDIFF(DAY,E.BirthDate,E.HireDate) ASC
-- DATEDIFF E�ER 'YEAR' ALINIRSA, JANET 29 YA�INDA �IKIYOR.. VE AYNI YIL DO�ANLARI ALFABEYE G�RE KIYASLIYOR.


--16:5 numaral� �al��an�n yapt��� sat��lar�n toplam �creti ne kadard�r.
SELECT E.EmployeeID,SUM(OD.Quantity*OD.UnitPrice*(1-OD.Discount)) 'Toplam Sat�� �creti ($)' FROM [Order Details] OD
JOIN Orders O ON O.OrderID LIKE OD.OrderID
JOIN Employees E ON E.EmployeeID LIKE O.EmployeeID
WHERE E.EmployeeID = 5
GROUP BY E.EmployeeID

--17:Kategorisi 1,3,5,7 olan �r�nleri �r�n isimlerine g�re listeleyiniz.
SELECT * FROM Products P
WHERE CategoryID IN (1,3,5,7)
ORDER BY LEN(P.ProductName)

--18: 5 numaral� �r�n� 2 numaral� kargocuya ta��tan m��terileri g�steriniz.


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

--30-Sales Representative  lerin ad ve soyadlar�n� bir kolonda, i�e girisinden sonra ge�en g�n� 'Ge�en G�n' kolonunda g�sterip s�ralamay� ge�en g�ne g�re artan yap�n.

--31-personelleri ya� s�ralamas� yap�p 25ten b�y�k olanlar�n �nvan kolonu a��p usta k���kse ��rak yazs�n
SELECT LastName, FirstName, BirthDate,
  CASE
    WHEN DATEDIFF(year, BirthDate, GETDATE()) > 25 THEN Title + '- Usta'
    ELSE Title + '- ��rak' 
  END AS Unvan
FROM Employees
ORDER BY BirthDate

--32-personellerin ya��n� hesaplay�p ayr� bir ya� kolonunda yaz�n
SELECT E.FirstName,E.LastName,DATEDIFF(YEAR,E.BirthDate,GETDATE()) AS YAS FROM Employees E

--33-�r�n tablosundan categorisi 2 olanlar�n stoklar�n� 10 ar artt�rarak yenileyelim ve indirim uygulayal�m
SELECT ProductName,(UnitsInStock+10) 'Stok Miktar�',(UnitPrice*0.9) 'Yeni Birim Fiyat' FROM Products P
JOIN  Categories C ON P.CategoryID = C.CategoryID
WHERE P.CategoryID = 2

--34-�r�n stoklar� 100�n �zerinde olanlar�a indirim uygulay�p birim fiyat�n�da 1$ d���relim
SELECT P.ProductName,P.UnitPrice 'Eski Fiyat',(P.UnitPrice*0.9)-1 AS 'Yeni Fiyat' FROM Products P
WHERE P.UnitsInStock>100 

--35-costumers tablosundaki country kolonunda mexico yerine siesta yazal�m
CREATE OR ALTER VIEW Musteriler AS
SELECT Country FROM Customers
UPDATE Musteriler
SET Country = 'Siesta'
WHERE Country = 'Mexico'
SELECT * FROM Musteriler;

--36-En �ok satilan 10 �r�n�n kategorileri
SELECT TOP 10 P.ProductID,SUM(OD.Quantity)'Satis Miktari',C.CategoryName  FROM [Order Details] OD
JOIN Products P ON P.ProductID = OD.ProductID
JOIN Categories C ON C.CategoryID = P.CategoryID
GROUP BY P.ProductID,C.CategoryName
ORDER BY 2 DESC


--37-1997 Ocak ay�nda en �ok al��veri� yapan m��terinin en �ok ald��� �r�n�n indirim oran�
SELECT TOP 1 C.CustomerID,SUM(OD.Quantity*OD.UnitPrice*(1-OD.Discount)) 'Urune Odedi�i Ucret',P.ProductID,P.ProductName,OD.Discount FROM [Order Details] OD
JOIN Orders O ON O.OrderID = OD.OrderID
JOIN Customers C ON C.CustomerID = O.CustomerID
JOIN Products P  ON P.ProductID = OD.ProductID
WHERE O.OrderDate BETWEEN '1997-01-01' AND '1997-01-31'
GROUP BY C.CustomerID,P.ProductID,P.ProductName,OD.Discount
ORDER BY 2 DESC

--38-1997 y�l�n�n en �ok satilan �r�n�n �lkesi ve totalprice
SELECT TOP 1 P.ProductID,P.ProductName,SUM(Quantity) 'Satis Miktari', S.Country,SUM(OD.Quantity*OD.UnitPrice*(1-OD.Discount)) 'Toplam Odeme'
FROM [Order Details] OD
JOIN Orders O ON O.OrderID = OD.OrderID
JOIN Products P ON P.ProductID = OD.ProductID
JOIN Suppliers S ON S.SupplierID = P.SupplierID
WHERE O.OrderDate BETWEEN '1997-01-01' AND '1998-01-01'
GROUP BY P.ProductID,P.ProductName, S.Country
ORDER BY 3 DESC

--39-Stok miktari 20 alt�na d��en �r�nlerin tedarik�ilerinin telefon numalar�
SELECT P.ProductName,S.CompanyName,S.Phone FROM Products P
JOIN Suppliers S ON P.SupplierID = S.SupplierID
WHERE P.UnitsInStock<20
ORDER BY CompanyName -- Hangi firmadan hangi �r�nleri isteyecek, kolay ula�mas� i�in �irket ismine g�re s�ralad�m.


--40-bu ay en �ok sat�� yapan �al��an�n en fazla sat�� yapt��� �r�n�n devam� var m�?
SELECT TOP 1  E.EmployeeID,E.FirstName,P.ProductName,OD.Quantity,P.Discontinued FROM  [Order Details] OD
JOIN Products P ON P.ProductID = OD.ProductID
JOIN Orders O ON O.OrderID = OD.OrderID
JOIN Employees E ON E.EmployeeID = O.EmployeeID
WHERE DATEDIFF(DAY,O.OrderDate,(SELECT MAX(OrderDate) FROM Orders)) <= 30 AND E.EmployeeID = 2
ORDER BY 4 DESC

--41-en fazla �r�n� bulunan tedarik�inin ka� adet �r�n� vard�r.
-- En fazla �r�n� bulunan 2 Tedarik�i oldu�u i�in TOP 2 yapt�m..;
SELECT TOP 2 S.SupplierID,COUNT(*) 'Urun Cesid Sayisi',SUM(P.UnitsInStock) 'Elindeki �r�n Say�s�' FROM Suppliers S
JOIN Products P ON P.SupplierID = S.SupplierID
GROUP BY S.SupplierID
ORDER BY 2 DESC 

--42-�r�nlerden en az bir kere sat�lm�� olanlar�n listesi
SELECT DISTINCT P.ProductID,P.ProductName 'En az 1 kere sat�lan �r�n ad�' FROM [Order Details] OD
JOIN Products P ON P.ProductID LIKE OD.ProductID
ORDER BY P.ProductID

--43-Hi� al��veri� yapmam�� kullan�c�lar�n listesi
SELECT C.CustomerID FROM Customers C
FULL JOIN Orders O ON C.CustomerID = O.CustomerID
FULL JOIN [Order Details] OD ON OD.OrderID = O.OrderID
WHERE O.OrderID IS NULL
GROUP BY C.CustomerID

--44-�ehri London olan m��terilerin �r�nlerinden an �ok satanlar
SELECT P.ProductID,P.ProductName,SUM(OD.Quantity) FROM Customers C
JOIN Orders O ON C.CustomerID = O.CustomerID
JOIN [Order Details] OD ON OD.OrderID = O.OrderID
JOIN Products P ON P.ProductID = OD.ProductID
WHERE C.City = 'London'
GROUP BY P.ProductID,P.ProductName
ORDER BY 3 DESC 


--45-Tedarik�i Id'si 1 olan �r�nleri en �ok sipari� eden 3 m��teri
SELECT  C.CustomerID,COUNT(*) FROM Customers C
JOIN Orders O ON O.CustomerID = C.CustomerID
JOIN [Order Details] OD ON OD.OrderID = O.OrderID
JOIN Products P ON P.ProductID = OD.ProductID
JOIN Suppliers S ON S.SupplierID = P.SupplierID
WHERE S.SupplierID = 1
GROUP BY C.CustomerID
ORDER BY 2 DESC

--46- Toplam kargo ya �dedi�imiz �cret toplam� ciromuzun %'de ka��d�r ?
SELECT ((SELECT SUM(Freight) FROM Orders)/(SELECT SUM(OD.Quantity*OD.UnitPrice*(1-OD.Discount)) 'Toplam C�ro' FROM [Order Details] OD))*100 AS 'Ciro''da Kargoya �denen Y�zde'
 
 ----TOPLAM NAKL�YE UCRET�---------
 -- SELECT SUM(Freight) FROM Orders 

 ----TOPLAM C�RO-----
 -- SELECT SUM(OD.Quantity*OD.UnitPrice*(1-OD.Discount)) 'Toplam Ciro' FROM [Order Details] OD
 


--47-En �ok satt���m�z �r�n ile en az satt���m�z �r�n aras�ndaki adet fark ka�t�r ?
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
ORDER BY 1 ASC) 'En �ok sat�lan �r�n ile en az sat�lan �r�n aras�ndaki sat�� miktar� fark�' 

--48-  �ndirim yap�lan �r�nler ile indirim yap�lmam�� halleri aras�ndaki fiyat fark� nedir hepsi i�in gruplayarak?
SELECT OD.ProductID,(OD.UnitPrice*OD.Discount) 'Indirim Miktari' FROM [Order Details] OD
WHERE OD.Discount NOT LIKE 0
GROUP BY OD.ProductID,OD.UnitPrice,OD.Discount

--49- En �ok hangi �lkelere sat�� yapm���z top 5 s�ralay�n ?
SELECT TOP 5 C.Country,SUM(OD.Quantity*OD.UnitPrice*(1-OD.Discount)) 'Satis Miktari ($)' FROM Customers C
JOIN Orders O ON O.CustomerID LIKE C.CustomerID
JOIN [Order Details] OD ON OD.OrderID LIKE O.OrderID
GROUP BY C.Country
ORDER BY 2 DESC

--50- En �ok �r�n� hangi city deki m��teri alm��t�r
SELECT C.CustomerID,C.ContactName,SUM(OD.Quantity),C.City FROM Customers C
JOIN Orders O ON C.CustomerID = O.CustomerID
JOIN [Order Details] OD ON OD.OrderID = O.OrderID
GROUP BY C.CustomerID,C.ContactName,C.City
ORDER BY 3 DESC
