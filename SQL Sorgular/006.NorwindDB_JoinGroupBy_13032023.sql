-- 1.SORU Toplam tutarý 2500 ile 3500 arasýnda olan sipariþleri listeleyelim.
SELECT OrderID,CAST(SUM(UnitPrice*Quantity*(1-Discount)) AS decimal(7,2)) AS 'Siparis Tutari' FROM [Order Details]
GROUP BY OrderID
HAVING CAST(SUM(UnitPrice*Quantity*(1-Discount)) AS decimal(7,2))  BETWEEN 2500 AND 3500
ORDER BY [Siparis Tutari] DESC


-----------------------------------------------------------------------------
-- 2.SORU Toplam tutarý 2500 ile 3500 arasýnda olan sipariþleri ve Siparis nosu 10500-11000 arasýný listeleyelim.

SELECT OrderID,CAST(SUM(UnitPrice*Quantity*(1-Discount)) AS decimal(7,2)) AS 'Siparis Tutari' FROM [Order Details]
GROUP BY OrderID
HAVING (CAST(SUM(UnitPrice*Quantity*(1-Discount)) AS decimal(7,2)) BETWEEN 2500 AND 3500) AND (OrderID BETWEEN 10500 AND 11000)    
ORDER BY [Siparis Tutari] DESC

-- 3.SORU Her bir sipariþteki toplam ürün sayýsý 220'den fazla olan sipariþleri gruplandýrarak, adet bilgisi artan sýrada sýralayýnýz.

SELECT SUM(Quantity) 'Toplam Urun' FROM [Order Details]
GROUP BY OrderID
HAVING SUM(Quantity) > 220 ORDER BY 1 ASC

--4- En çok çalýþtýðýmýz kargo firmasý ile en çok gönderdiðimiz ürün

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

--5- Bölgelere Göre en çok hangi nakliye firmasý ile çalýþtýk
SELECT  S.CompanyName, COUNT(*) 'Siparis Adedi' ,R.RegionDescription,T.TerritoryDescription FROM Region R
JOIN Territories T ON T.RegionID = R.RegionID
JOIN EmployeeTerritories ET ON ET.TerritoryID = T.TerritoryID
JOIN Employees E ON E.EmployeeID = ET.EmployeeID
JOIN Orders O ON O.EmployeeID = E.EmployeeID
JOIN Shippers S ON S.ShipperID = O.ShipVia
GROUP BY S.CompanyName,R.RegionDescription,T.TerritoryDescription
ORDER BY 2 DESC

--6- Hangi kargo þirketine toplam ne kadar taþýma ücreti ödemesi yapmýþým?
SELECT CompanyName,SUM(O.Freight) 'Toplam Ucret' FROM Orders O
JOIN Shippers S ON S.ShipperID = O.ShipVia
GROUP BY S.CompanyName, O.ShipVia
ORDER BY [Toplam Ucret] DESC


--7- En deðerli müþterim hangisi?
SELECT TOP 5 C.CustomerID,C.CompanyName, SUM(OD.Quantity*OD.UnitPrice*(1-OD.Discount)) 'TOPLAM SATIS' FROM Orders O
JOIN [Order Details] OD ON O.OrderID = OD.OrderID
JOIN Customers C ON C.CustomerID = O.CustomerID
GROUP BY C.CustomerID,C.CompanyName
ORDER BY 'TOPLAM SATIS' DESC

--8- Zamanýnda teslim edemediðim sipariþlerim ID’leri  nelerdir ve kaç gün geç göndermiþim?
SELECT OrderID,DATEDIFF(day,RequiredDate,ShippedDate) 'Geciken Gün' FROM Orders
WHERE ShippedDate>RequiredDate
-----Gönderilen tarih > varmasý gereken tarih
SELECT * FROM [Order Details]

--9- Satýþlarýmý kaç günde teslim etmiþim?





