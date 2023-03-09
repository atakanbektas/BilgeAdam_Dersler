-- 1.SORU Hangi �lkede ka�ar ki�i olduklar�n� bulal�m
SELECT Country,Count(EmployeeID) FROM Employees
GROUP BY Country

SELECT Country FROM Employees

-- 2.SORU �al��anlar�m�n yapm�� olduklar� sipari� say�s�na g�re grupland�rarak azalan s�rada s�ralay�n�z.

SELECT EmployeeID,COUNT(OrderID) 'Siparis Sayisi' FROM Orders
GROUP BY EmployeeID
ORDER BY [Siparis Sayisi] DESC

-- 3.SORU Hangi kategoride ka� �r�n var, grupland�rarak azalan s�rada s�ralay�n�z...
SELECT CategoryID,Count(ProductID) FROM Products
GROUP BY CategoryID
ORDER BY 2 DESC

SELECT CategoryID,Count(ProductID) 'Urun Adeti' FROM Products
GROUP BY CategoryID
ORDER BY [Urun Adeti] DESC

--4.SORU Her bir sipari�teki toplam �r�n say�s�n� grupland�rarak artan s�rada s�ralay�n�z...
SELECT OrderID,SUM(Quantity) 'Toplam Urun Sayisi' FROM [Order Details]
GROUP BY OrderID
ORDER BY 2 ASC

SELECT * FROM [Order Details]

--5.SORU Birim fiyat� ortalaman�n �zerinde olan �r�nleri listeleyelim.
SELECT ProductID,ProductName,UnitPrice FROM Products
WHERE UnitPrice> (SELECT AVG(UnitPrice) FROM Products) ORDER BY 3

--6.SORU Maksimum fiyata sahip olan �r�n�n ad� ve birim fiyat�n� getiriniz.
SELECT ProductName,UnitPrice FROM Products
WHERE UnitPrice = (SELECT MAX(UnitPrice) FROM Products) 

--7.SORU �r�nler tablosundaki �r�nlerden SATILAN �r�nleri listeleyiniz...
SELECT DISTINCT ProductID FROM [Order Details]
WHERE Quantity>0 ORDER BY ProductID
SELECT * FROM [Order Details] ORDER BY ProductID
SELECT * FROM Products

-- 8. g�k�ehandan al.

--9.SORU �r�nler tablosundaki her bir �r�n�, �r�n ad�, birim fiyat�, stok miktar� ve �r�n�n kategori ad� bilgisiyle listeleyiniz...

SELECT ProductName,UnitPrice,UnitsInStock,Categories.CategoryName FROM Products
INNER JOIN Categories ON Products.CategoryID = Categories.CategoryID



