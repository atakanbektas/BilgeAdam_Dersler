USE Northwind
--11.“Federal Shipping” ile taþýnmýþ ve Nancy'nin almýþ olduðu sipariþleri gösteriniz.(4 Puan)
SELECT E.FirstName,S.CompanyName,O.ShipName FROM Orders O
JOIN Shippers S ON O.ShipVia LIKE S.ShipperID
JOIN Employees E ON E.EmployeeID LIKE O.EmployeeID
WHERE S.CompanyName = 'Federal Shipping' AND E.FirstName = 'Nancy'

--12.Batý konumundaki bölgeleri listeleyiniz.
SELECT R.RegionDescription, T.TerritoryDescription FROM Territories T
JOIN Region R ON R.RegionID LIKE T.RegionID
WHERE R.RegionDescription LIKE '%western%'

--13.Adet olarak en az sipariþ verilen ürünün adýný getiriniz
SELECT P.ProductID,P.ProductName,SUM(Quantity) 'Siparis Sayýsý (Adet)' FROM [Order Details] OD
JOIN Products P ON P.ProductID LIKE OD.ProductID
GROUP BY P.ProductID,P.ProductName
ORDER BY 3 ASC

--14.Satýþý durdurulmuþ ve ayný zamanda stoðu kalmamýþ ürünlerimin tedarikçilerinin isimlerini ve telefon numaralarýný listeleyiniz.
SELECT S.CompanyName,S.ContactName,S.Phone FROM Suppliers S
JOIN Products P ON P.SupplierID LIKE S.SupplierID
WHERE P.Discontinued = 1 AND P.UnitsInStock = 0


--15.1 Ocak 1998 tarihinden sonra sipariþ veren müþterilerimin isimlerini artan olarak sýralayýnýz.
SELECT C.CompanyName,O.OrderDate FROM Customers C
JOIN Orders O ON O.CustomerID LIKE C.CustomerID
WHERE O.OrderDate > '1998-01-01'
ORDER BY O.OrderDate ASC

--16.Meksikalý müþterilerimden þirket sahibi ile iletiþime geçtiðim, kargo ücreti 30 dolarýn altýnda olan sipariþlerle hangi çalýþanlarým ilgilenmiþtir?
SELECT E.EmployeeID,E.FirstName,C.Country,C.ContactTitle,O.Freight FROM Employees E
JOIN Orders O ON O.EmployeeID LIKE E.EmployeeID
JOIN Customers C ON C.CustomerID LIKE O.CustomerID
WHERE O.Freight < 30 AND C.ContactTitle = 'Owner' AND C.Country = 'Mexico'
ORDER BY O.Freight DESC

--17.Personelli Ad ve Soyadlarýný tek alan olarak birleþtirip soyadýna göre sýralayýn.
SELECT E.FirstName+' '+E.LastName 'Ad Soyad'  FROM Employees E
ORDER BY E.LastName

--18.Gelecek yýl 70 yaþýný geçen personeli doðduðu aya göre sýralayýn.
SELECT E.BirthDate,CAST(DATEDIFF(DAY,E.BirthDate,GETDATE())/365.24219 AS INT) 'Þuanki yaþý',CAST(DATEDIFF(DAY,E.BirthDate,GETDATE())/365.24219 + 1 AS INT) '1 sene sonraki yaþý' FROM Employees E
WHERE (DATEDIFF(DAY,E.BirthDate,GETDATE())/365.24219) + 1 > 70
ORDER BY MONTH(E.BirthDate) ASC


--19.Tedarikçilerimden aldýðým ürünlerimden toplam stok miktarý 150 ten fazla olanlar hangi ülkelerden listeleyiniz
SELECT S.Country,P.UnitsInStock FROM Suppliers S
JOIN Products P ON P.SupplierID LIKE S.SupplierID
WHERE P.UnitsInStock > 150
ORDER BY P.UnitsInStock DESC

--20.Condiments kategorisinde en pahalý 10 ürünü ProductID, ürün adý, tedarikçi adý þeklinde listelenen bir VIEW oluþturunuz
CREATE OR ALTER VIEW [Condiments Category] AS
SELECT TOP 10 P.ProductID,P.ProductName,S.CompanyName,P.UnitPrice FROM Categories C
JOIN Products P ON P.CategoryID LIKE C.CategoryID
JOIN Suppliers S ON S.SupplierID LIKE P.SupplierID
ORDER BY P.UnitPrice DESC

SELECT * FROM [Condiments Category]

--21.Kritik seviyede olan ve gelecek sipariþi olmayan ürünlerimin tedarikçilerini, kategorilerini, minimum ne kadar sipariþ vermem gerektiðini listeleyen bir view oluþturunuz VIEW ismi “KritikSeviyeUrunBilgileri”
CREATE OR ALTER VIEW [KritikSeviyeUrunBilgileri] AS
SELECT P.ProductName,S.CompanyName,C.CategoryName,(P.ReorderLevel-P.UnitsInStock) 'Siparis Verilmesi Gereken Miktar(Minimum)' FROM Products P
JOIN Suppliers S ON S.SupplierID LIKE P.SupplierID
JOIN Categories C ON P.CategoryID LIKE C.CategoryID
WHERE P.UnitsOnOrder = 0 AND P.UnitsInStock<P.ReorderLevel

SELECT * FROM KritikSeviyeUrunBilgileri

--22.Klavyeden Girilen Shipvia numarasýna göre 300'den az veya fazla olduðunu gösteren prosedürü yazýnýz. Eðer Shipvia deðeri yoksa Hata mesajý versin. Kayýt Çýktýsý Þu Þekilde Olacak: 300den fazla kayýt var. Kayýt Sayýsý= 330
CREATE OR ALTER PROCEDURE ShipViaKontrol @shipvia INT AS
BEGIN
    DECLARE @count INT
    SELECT @count = COUNT(*) FROM Orders WHERE ShipVia = @shipvia;

    IF @count >= 300
        PRINT '300''den fazla kayýt var. Kayýt Sayýsý = ' + CAST(@count AS NVARCHAR)
    ELSE IF @count < 300 AND @count > 0
        PRINT '300''den az kayýt var. Kayýt Sayýsý = ' + CAST(@count AS NVARCHAR)
    ELSE
        PRINT 'Verilen ShipVia deðeri bulunamadý.'
END

EXEC ShipViaKontrol @shipvia = 1 
EXEC ShipViaKontrol @shipvia = 2
EXEC ShipViaKontrol @shipvia = 3
EXEC ShipViaKontrol @shipvia = 4



--23.Günlük olarak rapor almak istiyorum. Girdiðim kategoriye göre ürün adý ve stok miktarýný getiren bir PROCEDURE oluþturunuz.
CREATE OR ALTER PROCEDURE KategoriyeGoreUrunStok @categoryID INT AS
BEGIN
    SELECT C.CategoryName,P.ProductName, P.UnitsInStock 
    FROM Products P 
    JOIN Categories C ON P.CategoryID LIKE C.CategoryID 
    WHERE C.CategoryID = @categoryID
END

EXEC KategoriyeGoreUrunStok @categoryID = 1





--24.Girilen iki tarih arasýndaki günler için toplam ciromu veren bir FUNCTION oluþturunuz.
CREATE OR ALTER FUNCTION dbo.fn_ToplamCiro(@BaslangicTarihi DATE, @BitisTarihi DATE) RETURNS DECIMAL(8,2) AS
	BEGIN
		DECLARE @ToplamCiro MONEY
		SELECT @ToplamCiro = SUM(OD.Quantity * OD.UnitPrice*(1-OD.Discount))
		FROM Orders O
		JOIN [Order Details] OD ON O.OrderID = OD.OrderID
		WHERE (O.OrderDate >= @BaslangicTarihi) AND (O.OrderDate <= @BitisTarihi)
		RETURN @ToplamCiro
	END

SELECT dbo.fn_ToplamCiro('1998-01-01','1999-01-01')

