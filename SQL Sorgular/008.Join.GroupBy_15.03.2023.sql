USE Northwind
--1. En k�sa s�rede giden sipari�i hangi kargo firmas� yapt� ?
SELECT S.CompanyName,DATEDIFF(DAY,OrderDate,ShippedDate) AS 'G�nderilen S�re' FROM Orders
JOIN Shippers S ON S.ShipperID = Orders.ShipVia
WHERE 'G�nderilen S�re' NOT LIKE NULL
ORDER BY 2

--2. �irketim, �imdiye kadar ne kadar ciro yapm�� ?
SELECT SUM(UnitPrice*Quantity*(1-Discount))  FROM [Order Details] OD

--3. Kategori idsi 1 ve 6 olan sipari�lerden en �ok sat�lan �r�n�n fiyat� ?
SELECT TOP 1 SUM(OD.Quantity),P.ProductName,P.UnitPrice,C.CategoryName,P.ProductID FROM [Order Details] OD
JOIN Products P ON P.ProductID = OD.ProductID
JOIN Categories C ON C.CategoryID = P.CategoryID
WHERE C.CategoryID = 1 OR C.CategoryID = 6
GROUP BY P.ProductID,P.ProductName,P.UnitPrice,C.CategoryName
ORDER BY 1 DESC

SELECT SUM(Quantity) FROM [Order Details]
WHERE ProductID = 75

--4. En �ok sipari� veren �al��an�m�n ya��n� foto�raf�n� ve satt��� �r�n say�s�n� g�ster ?
SELECT COUNT(*),DATEDIFF(YEAR,E.BirthDate,GETDATE()) FROM Employees E
JOIN Orders O ON O.EmployeeID = E.EmployeeID
GROUP BY E.EmployeeID, DATEDIFF(YEAR,E.BirthDate,GETDATE())
ORDER BY 1 DESC


--5. Kargo �dsi 2 olan kargo �irketine en �ok hangi �r�nleri teslim ettim ?
SELECT OD.ProductID,SUM(Quantity) FROM Shippers S
JOIN Orders O ON O.ShipVia = S.ShipperID
JOIN [Order Details] OD ON OD.OrderID = O.OrderID
WHERE S.ShipperID = 2 AND O.ShippedDate IS NOT NULL
GROUP BY OD.ProductID
ORDER BY 2 DESC



--6: Fax numaras� olmayan ve posta kodu d ile biten tedarik�ilerden al�n�p 1 numaral� kargo firmas� ile ismi m ile ba�layan �al��an taraf�ndan g�nderilen fakat kargoya belirtilen tarihten ge� verilmi�, s ile biten kategoriye ait �r�nleri g�steriniz.
SELECT * FROM Categories C
JOIN Products P ON P.CategoryID = C.CategoryID
JOIN Suppliers S ON P.SupplierID = S.SupplierID
JOIN [Order Details] OD ON OD.ProductID = P.ProductID
JOIN Orders O ON O.OrderID = OD.OrderID
JOIN Employees E ON E.EmployeeID = O.EmployeeID
JOIN Shippers Sh ON Sh.ShipperID = O.ShipVia
WHERE 
C.CategoryName LIKE '%S' AND 
S.Fax IS NULL AND 
S.PostalCode LIKE '%D' AND 
Sh.ShipperID=1 AND
E.FirstName LIKE 'M%'AND
O.RequiredDate<O.ShippedDate 


--7: �stenen tarihten 3 haftadan k�sa s�rede m��teriye g�nderilmesi i�in kargoya verilmi� olan sipari�lerin ilk 3 �(kargo tarihi ile s�rala) hangi kargo firmalar� ile g�nderilmi�tir.
SELECT TOP 3 S.CompanyName, O.OrderID, RequiredDate, ShippedDate,DATEDIFF(WEEK, RequiredDate, ShippedDate) FROM Orders O 
JOIN Shippers S ON S.ShipperID = O.ShipVia 
WHERE DATEDIFF(WEEK, RequiredDate, ShippedDate) < 3
ORDER BY 5 DESC



--8: Amerika k�tas� d���ndan tedarik edilmi� olan �r�nlerin hangileri sipari� �zerine Amerika k�tas�n�n WA region a teslim edilmi�tir.
SELECT * FROM Suppliers S
JOIN Products P ON P.SupplierID LIKE S.SupplierID
JOIN [Order Details] OD ON OD.ProductID LIKE P.ProductID
JOIN Orders O ON O.OrderID LIKE OD.OrderID
WHERE S.Country NOT LIKE 'USA' AND S.Country NOT LIKE 'CANADA' AND O.ShipRegion LIKE 'WA'



--9: ID'si 2 olan kategoriye ait �r�nlerin ilk 5 i ni birim fiyat� pahal�dan ucuza do�ru olacak �ekilde g�steriniz.
SELECT  P.ProductName,P.UnitPrice,C.CategoryID FROM Categories C
JOIN Products P ON P.CategoryID = C.CategoryID
WHERE C.CategoryID = 2
ORDER BY P.UnitPrice DESC



--10: 10 kere den fazla sipari� edilmi� �r�nlerin stoklar� kritik d�zeyde olanlar� listeleyiniz.
SELECT P.ProductName,COUNT(*) 'Siparis Edilme Sayisi',(P.UnitsInStock-P.UnitsOnOrder) 'Eksik �r�n' FROM [Order Details] OD
JOIN Products P  ON P.ProductID = OD.ProductID
GROUP BY P.ProductID,P.UnitsInStock-P.UnitsOnOrder,P.ProductName
HAVING (COUNT(*) > 10) AND (P.UnitsInStock-P.UnitsOnOrder < 0)
ORDER BY 3



