USE Northwind
--1. En kýsa sürede giden sipariþi hangi kargo firmasý yaptý ?
SELECT S.CompanyName,DATEDIFF(DAY,OrderDate,ShippedDate) AS 'Gönderilen Süre' FROM Orders
JOIN Shippers S ON S.ShipperID = Orders.ShipVia
WHERE 'Gönderilen Süre' NOT LIKE NULL
ORDER BY 2

--2. Þirketim, þimdiye kadar ne kadar ciro yapmýþ ?
SELECT SUM(UnitPrice*Quantity*(1-Discount))  FROM [Order Details] OD

--3. Kategori idsi 1 ve 6 olan sipariþlerden en çok satýlan ürünün fiyatý ?
SELECT TOP 1 SUM(OD.Quantity),P.ProductName,P.UnitPrice,C.CategoryName,P.ProductID FROM [Order Details] OD
JOIN Products P ON P.ProductID = OD.ProductID
JOIN Categories C ON C.CategoryID = P.CategoryID
WHERE C.CategoryID = 1 OR C.CategoryID = 6
GROUP BY P.ProductID,P.ProductName,P.UnitPrice,C.CategoryName
ORDER BY 1 DESC

SELECT SUM(Quantity) FROM [Order Details]
WHERE ProductID = 75

--4. En çok sipariþ veren çalýþanýmýn yaþýný fotoðrafýný ve sattýðý ürün sayýsýný göster ?
SELECT COUNT(*),DATEDIFF(YEAR,E.BirthDate,GETDATE()) FROM Employees E
JOIN Orders O ON O.EmployeeID = E.EmployeeID
GROUP BY E.EmployeeID, DATEDIFF(YEAR,E.BirthDate,GETDATE())
ORDER BY 1 DESC


--5. Kargo ýdsi 2 olan kargo þirketine en çok hangi ürünleri teslim ettim ?
SELECT OD.ProductID,SUM(Quantity) FROM Shippers S
JOIN Orders O ON O.ShipVia = S.ShipperID
JOIN [Order Details] OD ON OD.OrderID = O.OrderID
WHERE S.ShipperID = 2 AND O.ShippedDate IS NOT NULL
GROUP BY OD.ProductID
ORDER BY 2 DESC



--6: Fax numarasý olmayan ve posta kodu d ile biten tedarikçilerden alýnýp 1 numaralý kargo firmasý ile ismi m ile baþlayan çalýþan tarafýndan gönderilen fakat kargoya belirtilen tarihten geç verilmiþ, s ile biten kategoriye ait ürünleri gösteriniz.
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


--7: Ýstenen tarihten 3 haftadan kýsa sürede müþteriye gönderilmesi için kargoya verilmiþ olan sipariþlerin ilk 3 ü(kargo tarihi ile sýrala) hangi kargo firmalarý ile gönderilmiþtir.
SELECT TOP 3 S.CompanyName, O.OrderID, RequiredDate, ShippedDate,DATEDIFF(WEEK, RequiredDate, ShippedDate) FROM Orders O 
JOIN Shippers S ON S.ShipperID = O.ShipVia 
WHERE DATEDIFF(WEEK, RequiredDate, ShippedDate) < 3
ORDER BY 5 DESC



--8: Amerika kýtasý dýþýndan tedarik edilmiþ olan ürünlerin hangileri sipariþ üzerine Amerika kýtasýnýn WA region a teslim edilmiþtir.
SELECT * FROM Suppliers S
JOIN Products P ON P.SupplierID LIKE S.SupplierID
JOIN [Order Details] OD ON OD.ProductID LIKE P.ProductID
JOIN Orders O ON O.OrderID LIKE OD.OrderID
WHERE S.Country NOT LIKE 'USA' AND S.Country NOT LIKE 'CANADA' AND O.ShipRegion LIKE 'WA'



--9: ID'si 2 olan kategoriye ait ürünlerin ilk 5 i ni birim fiyatý pahalýdan ucuza doðru olacak þekilde gösteriniz.
SELECT  P.ProductName,P.UnitPrice,C.CategoryID FROM Categories C
JOIN Products P ON P.CategoryID = C.CategoryID
WHERE C.CategoryID = 2
ORDER BY P.UnitPrice DESC



--10: 10 kere den fazla sipariþ edilmiþ ürünlerin stoklarý kritik düzeyde olanlarý listeleyiniz.
SELECT P.ProductName,COUNT(*) 'Siparis Edilme Sayisi',(P.UnitsInStock-P.UnitsOnOrder) 'Eksik Ürün' FROM [Order Details] OD
JOIN Products P  ON P.ProductID = OD.ProductID
GROUP BY P.ProductID,P.UnitsInStock-P.UnitsOnOrder,P.ProductName
HAVING (COUNT(*) > 10) AND (P.UnitsInStock-P.UnitsOnOrder < 0)
ORDER BY 3



