-- 1.SORU Toplam tutar� 2500 ile 3500 aras�nda olan sipari�leri listeleyelim.
SELECT OrderID,CAST(SUM(UnitPrice*Quantity*(1-Discount)) AS decimal(7,2)) AS 'Siparis Tutari' FROM [Order Details]
GROUP BY OrderID
HAVING CAST(SUM(UnitPrice*Quantity*(1-Discount)) AS decimal(7,2))  BETWEEN 2500 AND 3500
ORDER BY [Siparis Tutari] DESC


-----------------------------------------------------------------------------
-- 2.SORU Toplam tutar� 2500 ile 3500 aras�nda olan sipari�leri ve Siparis nosu 10500-11000 aras�n� listeleyelim.

SELECT OrderID,CAST(SUM(UnitPrice*Quantity*(1-Discount)) AS decimal(7,2)) AS 'Siparis Tutari' FROM [Order Details]
GROUP BY OrderID
HAVING (CAST(SUM(UnitPrice*Quantity*(1-Discount)) AS decimal(7,2)) BETWEEN 2500 AND 3500) AND (OrderID BETWEEN 10500 AND 11000)    
ORDER BY [Siparis Tutari] DESC

-- 3.SORU Her bir sipari�teki toplam �r�n say�s� 220'den fazla olan sipari�leri grupland�rarak, adet bilgisi artan s�rada s�ralay�n�z.

SELECT SUM(Quantity) 'Toplam Urun' FROM [Order Details]
GROUP BY OrderID
HAVING SUM(Quantity) > 220 ORDER BY 1 ASC

--4- En �ok �al��t���m�z kargo firmas� ile en �ok g�nderdi�imiz �r�n

SELECT * FROM [Order Details] OD


SELECT SUM(Quantity),S.CompanyName,P.ProductID,P.ProductName FROM [Order Details] OD
JOIN Orders O ON O.OrderID = OD.OrderID
JOIN Shippers S ON S.ShipperID = O.ShipVia
JOIN Products P ON P.ProductID = OD.ProductID
GROUP BY (S.ShipperID),(S.CompanyName),(P.ProductID),(P.ProductName))
ORDER BY 1 DESC


SELECT SUM(Quantity),S.CompanyName, S.ShipperID FROM [Order Details] OD
JOIN Orders O ON O.OrderID = OD.OrderID
JOIN Shippers S ON S.ShipperID = O.ShipVia
JOIN Products P ON P.ProductID = OD.ProductID
GROUP BY S.ShipperID, S.CompanyName, S.ShipperID
ORDER BY 1 DESC

--5- B�lgelere G�re en �ok hangi nakliye firmas� ile �al��t�k
SELECT  S.CompanyName, COUNT(*) 'Siparis Adedi' ,R.RegionDescription,T.TerritoryDescription FROM Region R
JOIN Territories T ON T.RegionID = R.RegionID
JOIN EmployeeTerritories ET ON ET.TerritoryID = T.TerritoryID
JOIN Employees E ON E.EmployeeID = ET.EmployeeID
JOIN Orders O ON O.EmployeeID = E.EmployeeID
JOIN Shippers S ON S.ShipperID = O.ShipVia
GROUP BY S.CompanyName,R.RegionDescription,T.TerritoryDescription
ORDER BY 2 DESC

--6- Hangi kargo �irketine toplam ne kadar ta��ma �creti �demesi yapm���m?
SELECT CompanyName,SUM(O.Freight) 'Toplam Ucret' FROM Orders O
JOIN Shippers S ON S.ShipperID = O.ShipVia
GROUP BY S.CompanyName, O.ShipVia
ORDER BY [Toplam Ucret] DESC


--7- En de�erli m��terim hangisi?
SELECT TOP 5 C.CustomerID,C.CompanyName, SUM(OD.Quantity*OD.UnitPrice*(1-OD.Discount)) 'TOPLAM SATIS' FROM Orders O
JOIN [Order Details] OD ON O.OrderID = OD.OrderID
JOIN Customers C ON C.CustomerID = O.CustomerID
GROUP BY C.CustomerID,C.CompanyName
ORDER BY 'TOPLAM SATIS' DESC

--8- Zaman�nda teslim edemedi�im sipari�lerim ID�leri� nelerdir ve ka� g�n ge� g�ndermi�im?
SELECT OrderID,DATEDIFF(day,RequiredDate,ShippedDate) 'Geciken G�n' FROM Orders
WHERE ShippedDate>RequiredDate
-----G�nderilen tarih > varmas� gereken tarih
SELECT * FROM [Order Details]

--9- Sat��lar�m� ka� g�nde teslim etmi�im?





