USE Northwind
--1- Customers tablosundan CustomerID�sinin 2. harfi A, 4. harfi T olanlar�n %15 lik k�sm�n� getiren sorguyu yaz�n�z.
SELECT TOP 15 PERCENT * FROM Customers
WHERE CustomerID LIKE '_A_T%'

--2. En �ok �r�n alan m��teri
SELECT SUM(OD.Quantity),C.CompanyName FROM [Order Details] OD
JOIN Orders O ON O.OrderID = OD.OrderID
JOIN Customers C ON C.CustomerID = O.CustomerID
GROUP BY C.CustomerID,C.CompanyName
ORDER BY 1 DESC

--3. En y�ksek �creti �deyen m��teri
SELECT  C.CustomerID,SUM(OD.Quantity*OD.UnitPrice*(1-OD.Discount)),COUNT(DISTINCT O.OrderID) FROM Customers C
JOIN Orders O ON O.CustomerID = C.CustomerID
JOIN [Order Details] OD ON OD.OrderID = O.OrderID
GROUP BY C.CustomerID
ORDER BY 2 DESC

--4. En �ok �r�n satan ilk 5 �al��an
SELECT TOP 5 E.EmployeeID,SUM(OD.Quantity) 'Toplam Satilan Urun',SUM(OD.Quantity*OD.UnitPrice*(1-OD.Discount)) 'Toplam Fiyat' FROM Employees E
JOIN Orders O ON O.EmployeeID = E.EmployeeID
JOIN [Order Details] OD ON OD.OrderID = O.OrderID
GROUP BY E.EmployeeID
ORDER BY 'Toplam Satilan Urun' DESC

--5. Frans�zca konu�abilen �al��an�m hangisi ?
SELECT * FROM Employees
WHERE Notes LIKE '%french%'

-- 6.SORU vw_SiparisRaporlari ad� alt�nda view olu�turulacak-- Bir sipari�in, hangi �al��an taraf�ndan, hangi m��teriye, hangi kategorideki �r�nden, hangi fiyattan, ka� adet sat�ld���n� lisleteliyiniz...�-- Yukar�daki sorgu i�in; (Orders orta tablo gibi d���n�lebilir, ilgili ID'leri e�le�tirmek i�in)
-- �al��an�n: FirstName, LastName, TitleOfCourtesy, Title kolonlar�
-- M��terinin: CompanyName, ContactName, Phone,
-- �r�n�n: ProductName, UnitsInStock,
-- Kategorinin: CategoryName kolonlar�,
-- Sipari� Detay�n�n: UnitPrice, Quantity kolonlar�,
-- tek bir sorguda yaz�lacak.



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

-- 7.SORU @fiyat ad�nda bir function tan�mlayal�m bu function ta��ma �cretlerine Y�zde 18 lik kdv uygulas�n
CREATE FUNCTION fun_KdvHesaplaa(@fiyat MONEY)
RETURNS	MONEY
AS	
BEGIN
	RETURN (@fiyat*1.18) 
END
SELECT dbo.fun_KdvHesaplaa(Freight) FROM Orders
PRINT dbo.fun_KdvHesaplaa(5)

-- 8.SORU olu�turdu�umuz bu function ile ProductName, CategoryName, UnitPrice, ve UnitPrice*function�m�z


SELECT P.ProductName,C.CategoryName,OD.UnitPrice,dbo.fun_KdvHesaplaa(OD.UnitPrice) FROM Categories C
JOIN Products P ON P.CategoryID = C.CategoryID
JOIN [Order Details] OD ON OD.ProductID = P.ProductID

--9.Soru Sadece Beverages kategorisinde �r�nlerin KDV oran� %8 olsun, di�er kategorilerdeki �r�nlerin KDV oran� %18 olsun.ProductNmae, CategoryName, UnitPrice, KDVLi Fiyat tablolar� olu�turulcak

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