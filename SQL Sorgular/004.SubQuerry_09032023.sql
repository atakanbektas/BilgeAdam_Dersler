-- 1.SORU Hangi ülkede kaçar kiþi olduklarýný bulalým
SELECT Country,Count(EmployeeID) FROM Employees
GROUP BY Country

SELECT Country FROM Employees

-- 2.SORU Çalýþanlarýmýn yapmýþ olduklarý sipariþ sayýsýna göre gruplandýrarak azalan sýrada sýralayýnýz.

SELECT EmployeeID,COUNT(OrderID) 'Siparis Sayisi' FROM Orders
GROUP BY EmployeeID
ORDER BY [Siparis Sayisi] DESC

-- 3.SORU Hangi kategoride kaç ürün var, gruplandýrarak azalan sýrada sýralayýnýz...
SELECT CategoryID,Count(ProductID) FROM Products
GROUP BY CategoryID
ORDER BY 2 DESC

SELECT CategoryID,Count(ProductID) 'Urun Adeti' FROM Products
GROUP BY CategoryID
ORDER BY [Urun Adeti] DESC

--4.SORU Her bir sipariþteki toplam ürün sayýsýný gruplandýrarak artan sýrada sýralayýnýz...
SELECT OrderID,SUM(Quantity) 'Toplam Urun Sayisi' FROM [Order Details]
GROUP BY OrderID
ORDER BY 2 ASC

SELECT * FROM [Order Details]

--5.SORU Birim fiyatý ortalamanýn üzerinde olan ürünleri listeleyelim.
SELECT ProductID,ProductName,UnitPrice FROM Products
WHERE UnitPrice> (SELECT AVG(UnitPrice) FROM Products) ORDER BY 3

--6.SORU Maksimum fiyata sahip olan ürünün adý ve birim fiyatýný getiriniz.
SELECT ProductName,UnitPrice FROM Products
WHERE UnitPrice = (SELECT MAX(UnitPrice) FROM Products) 

--7.SORU Ürünler tablosundaki ürünlerden SATILAN ürünleri listeleyiniz...
SELECT DISTINCT ProductID FROM [Order Details]
WHERE Quantity>0 ORDER BY ProductID
SELECT * FROM [Order Details] ORDER BY ProductID
SELECT * FROM Products

-- 8. gökçehandan al.

--9.SORU Ürünler tablosundaki her bir ürünü, ürün adý, birim fiyatý, stok miktarý ve ürünün kategori adý bilgisiyle listeleyiniz...

SELECT ProductName,UnitPrice,UnitsInStock,Categories.CategoryName FROM Products
INNER JOIN Categories ON Products.CategoryID = Categories.CategoryID



