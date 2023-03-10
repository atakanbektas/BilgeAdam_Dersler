-- 1.SORU Her ürün için ürünler tablosundan Ürün Adý, Kategoriler tablosundan Kategori Adý bilgilerini listeleyiniz...

SELECT p.ProductName,c.CategoryName FROM Products p
JOIN Categories c ON p.CategoryID = c.CategoryID


-- 2.SORU Hangi sipariþin, hangi çalýþan tarafýndan alýndýðýný, hangi müþteriye gönderileceðini listeleyiniz...

SELECT Ord.OrderID,Emp.FirstName + ' ' + Emp.LastName [Calisan],Cus.ContactName[Müsteri] FROM Orders Ord
JOIN Employees Emp ON Emp.EmployeeID = Ord.EmployeeID
JOIN Customers Cus ON Ord.CustomerID = Cus.CustomerID
ORDER BY Calisan

-- 3.SORU Products tablosundan TÜM KAYITLARI, Categories tablosundan iliþkili kayýtlarý listeleyelim. (ProductName, CategoryName)  

SELECT Pro.ProductName, Cat.CategoryName FROM Products Pro
LEFT JOIN Categories Cat ON Pro.CategoryID = Cat.CategoryID 

-- 4.SORU TÜM çalýþanlarý ve eðer varsa rapor verdiði kiþilerle birlikte listeleyiniz...
SELECT e2.EmployeeId,e2.FirstName,e1.EmployeeID,e1.FirstName FROM Employees e1  
JOIN Employees e2 ON e2.ReportsTo = e1.EmployeeID

--5.SORU Fransaya en çok sattýðýmýz ürün
SELECT SUM(Quantity),P.ProductName,S.[Address],C.Country FROM Orders O
JOIN Customers C ON O.CustomerID = C.CustomerID
JOIN [Order Details] OD ON O.OrderID = OD.OrderID 
JOIN Products P ON OD.ProductID = P.ProductID
JOIN Suppliers S ON P.SupplierID = S.SupplierID
WHERE C.Country='France'
GROUP BY (ProductName),(S.[Address]),(C.Country)
ORDER BY 1 DESC

-- 6.SORU Kargo þirketlerinin kargo þirket kodu ve þirket adý bilgileriyle, toplam taþýdýklarý sipariþ sayýsýný listeleyiniz...

SELECT S.ShipperID,S.CompanyName,COUNT(S.ShipperID) AS 'Satýlan Siparis Sayýsý' FROM Shippers S
JOIN Orders O ON O.ShipVia = S.ShipperID
GROUP BY (S.ShipperID),(S.CompanyName)

-- 7.SORU Brezilya'dan sipariþ veren (orada yaþayan) müþterilerin verdiði en yüksek sipariþ tutarýný getiriniz...

SELECT TOP 1  C.CompanyName,(UnitPrice*Quantity) AS 'Siparis Ucreti' FROM [Order Details] OD
JOIN Orders O ON O.OrderID = OD.OrderID
JOIN Customers C ON C.CustomerID = O.CustomerID AND C.Country='Brazil'
ORDER BY 2 DESC

--GELEN SESLENSÝN

SELECT * FROM Customers
