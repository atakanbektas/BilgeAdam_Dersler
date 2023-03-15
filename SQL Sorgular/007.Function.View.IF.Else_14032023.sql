USE Northwind
--1- Customers tablosundan CustomerID’sinin 2. harfi A, 4. harfi T olanlarýn %15 lik kýsmýný getiren sorguyu yazýnýz.
SELECT TOP 15 PERCENT * FROM Customers
WHERE CustomerID LIKE '_A_T%'

--2. En çok ürün alan müþteri
SELECT SUM(OD.Quantity),C.CompanyName FROM [Order Details] OD
JOIN Orders O ON O.OrderID = OD.OrderID
JOIN Customers C ON C.CustomerID = O.CustomerID
GROUP BY C.CustomerID,C.CompanyName
ORDER BY 1 DESC

--3. En yüksek ücreti ödeyen müþteri
SELECT  C.CustomerID,SUM(OD.Quantity*OD.UnitPrice*(1-OD.Discount)),COUNT(DISTINCT O.OrderID) FROM Customers C
JOIN Orders O ON O.CustomerID = C.CustomerID
JOIN [Order Details] OD ON OD.OrderID = O.OrderID
GROUP BY C.CustomerID
ORDER BY 2 DESC

--4. En çok ürün satan ilk 5 çalýþan
SELECT TOP 5 E.EmployeeID,SUM(OD.Quantity) 'Toplam Satilan Urun',SUM(OD.Quantity*OD.UnitPrice*(1-OD.Discount)) 'Toplam Fiyat' FROM Employees E
JOIN Orders O ON O.EmployeeID = E.EmployeeID
JOIN [Order Details] OD ON OD.OrderID = O.OrderID
GROUP BY E.EmployeeID
ORDER BY 'Toplam Satilan Urun' DESC

--5. Fransýzca konuþabilen çalýþaným hangisi ?
SELECT * FROM Employees
WHERE Notes LIKE '%french%'

-- 6.SORU vw_SiparisRaporlari adý altýnda view oluþturulacak-- Bir sipariþin, hangi çalýþan tarafýndan, hangi müþteriye, hangi kategorideki üründen, hangi fiyattan, kaç adet satýldýðýný lisleteliyiniz... -- Yukarýdaki sorgu için; (Orders orta tablo gibi düþünülebilir, ilgili ID'leri eþleþtirmek için)
-- Çalýþanýn: FirstName, LastName, TitleOfCourtesy, Title kolonlarý
-- Müþterinin: CompanyName, ContactName, Phone,
-- Ürünün: ProductName, UnitsInStock,
-- Kategorinin: CategoryName kolonlarý,
-- Sipariþ Detayýnýn: UnitPrice, Quantity kolonlarý,
-- tek bir sorguda yazýlacak.



CREATE VIEW vw_SiparisRaporlari AS
SELECT E.FirstName,E.LastName,E.TitleOfCourtesy,E.Title,C.CompanyName,C.ContactName,C.Phone,P.ProductName,P.UnitsInStock,Ca.CategoryName,OD.UnitPrice,OD.Quantity FROM Orders O
JOIN Customers C ON C.CustomerID = O.CustomerID
JOIN Employees E ON E.EmployeeID = O.EmployeeID
JOIN [Order Details] OD ON OD.OrderID = O.OrderID
JOIN Products P ON P.ProductID = OD.ProductID
JOIN Categories Ca ON Ca.CategoryID = P.CategoryID
SELECT * FROM vw_SiparisRaporlari

ALTER VIEW vw_SiparisRaporlari AS
SELECT E.FirstName,E.LastName,E.TitleOfCourtesy,E.Title,C.CompanyName,C.ContactName,C.Phone,P.ProductName,P.UnitsInStock,Ca.CategoryName,OD.UnitPrice,OD.Quantity,E.HireDate FROM Orders O
JOIN Customers C ON C.CustomerID = O.CustomerID
JOIN Employees E ON E.EmployeeID = O.EmployeeID
JOIN [Order Details] OD ON OD.OrderID = O.OrderID
JOIN Products P ON P.ProductID = OD.ProductID
JOIN Categories Ca ON Ca.CategoryID = P.CategoryID

DROP VIEW vw_SiparisRaporlari

-- 7.SORU @fiyat adýnda bir function tanýmlayalým bu function taþýma ücretlerine Yüzde 18 lik kdv uygulasýn
CREATE FUNCTION fun_KdvHesaplaa(@fiyat MONEY)
RETURNS	MONEY
AS	
BEGIN
	RETURN (@fiyat*1.18) 
END
SELECT dbo.fun_KdvHesaplaa(Freight) FROM Orders
PRINT dbo.fun_KdvHesaplaa(5)

-- 8.SORU oluþturduðumuz bu function ile ProductName, CategoryName, UnitPrice, ve UnitPrice*functionýmýz


SELECT P.ProductName,C.CategoryName,OD.UnitPrice,dbo.fun_KdvHesaplaa(OD.UnitPrice) FROM Categories C
JOIN Products P ON P.CategoryID = C.CategoryID
JOIN [Order Details] OD ON OD.ProductID = P.ProductID

--9.Soru Sadece Beverages kategorisinde ürünlerin KDV oraný %8 olsun, diðer kategorilerdeki ürünlerin KDV oraný %18 olsun.ProductNmae, CategoryName, UnitPrice, KDVLi Fiyat tablolarý oluþturulcak

SELECT P.ProductName,C.CategoryName,OD.UnitPrice,dbo.fun_KdvHesaplaa(OD.UnitPrice) FROM Categories C
JOIN Products P ON P.CategoryID = C.CategoryID
JOIN [Order Details] OD ON OD.ProductID = P.ProductID

ALTER FUNCTION fun_KdvHesapla2(@fiyat MONEY,@CategoryID INT)
RETURNS	MONEY
AS	
BEGIN
		IF @CategoryID = 1
	BEGIN
		RETURN (@fiyat*1.08)
	END
		RETURN (@fiyat*1.18)
END

SELECT P.ProductName,C.CategoryName,OD.UnitPrice,dbo.fun_KdvHesapla2(OD.UnitPrice,C.CategoryID) FROM Categories C
JOIN Products P ON P.CategoryID = C.CategoryID
JOIN [Order Details] OD ON OD.ProductID = P.ProductID



SELECT dbo.fun_KdvHesapla2(Freight) FROM Orders
PRINT dbo.fun_KdvHesaplaa(5)