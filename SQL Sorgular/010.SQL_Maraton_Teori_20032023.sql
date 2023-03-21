USE Northwind
--11.�Federal Shipping� ile ta��nm�� ve Nancy'nin alm�� oldu�u sipari�leri g�steriniz.(4 Puan)
SELECT E.FirstName,S.CompanyName,O.ShipName FROM Orders O
JOIN Shippers S ON O.ShipVia LIKE S.ShipperID
JOIN Employees E ON E.EmployeeID LIKE O.EmployeeID
WHERE S.CompanyName = 'Federal Shipping' AND E.FirstName = 'Nancy'

--12.Bat� konumundaki b�lgeleri listeleyiniz.
SELECT R.RegionDescription, T.TerritoryDescription FROM Territories T
JOIN Region R ON R.RegionID LIKE T.RegionID
WHERE R.RegionDescription LIKE '%western%'

--13.Adet olarak en az sipari� verilen �r�n�n ad�n� getiriniz
SELECT P.ProductID,P.ProductName,SUM(Quantity) 'Siparis Say�s� (Adet)' FROM [Order Details] OD
JOIN Products P ON P.ProductID LIKE OD.ProductID
GROUP BY P.ProductID,P.ProductName
ORDER BY 3 ASC

--14.Sat��� durdurulmu� ve ayn� zamanda sto�u kalmam�� �r�nlerimin tedarik�ilerinin isimlerini ve telefon numaralar�n� listeleyiniz.
SELECT S.CompanyName,S.ContactName,S.Phone FROM Suppliers S
JOIN Products P ON P.SupplierID LIKE S.SupplierID
WHERE P.Discontinued = 1 AND P.UnitsInStock = 0


--15.1 Ocak 1998 tarihinden sonra sipari� veren m��terilerimin isimlerini artan olarak s�ralay�n�z.
SELECT C.CompanyName,O.OrderDate FROM Customers C
JOIN Orders O ON O.CustomerID LIKE C.CustomerID
WHERE O.OrderDate > '1998-01-01'
ORDER BY O.OrderDate ASC

--16.Meksikal� m��terilerimden �irket sahibi ile ileti�ime ge�ti�im, kargo �creti 30 dolar�n alt�nda olan sipari�lerle hangi �al��anlar�m ilgilenmi�tir?
SELECT E.EmployeeID,E.FirstName,C.Country,C.ContactTitle,O.Freight FROM Employees E
JOIN Orders O ON O.EmployeeID LIKE E.EmployeeID
JOIN Customers C ON C.CustomerID LIKE O.CustomerID
WHERE O.Freight < 30 AND C.ContactTitle = 'Owner' AND C.Country = 'Mexico'
ORDER BY O.Freight DESC

--17.Personelli Ad ve Soyadlar�n� tek alan olarak birle�tirip soyad�na g�re s�ralay�n.
SELECT E.FirstName+' '+E.LastName 'Ad Soyad'  FROM Employees E
ORDER BY E.LastName

--18.Gelecek y�l 70 ya��n� ge�en personeli do�du�u aya g�re s�ralay�n.
SELECT E.BirthDate,CAST(DATEDIFF(DAY,E.BirthDate,GETDATE())/365.24219 AS INT) '�uanki ya��',CAST(DATEDIFF(DAY,E.BirthDate,GETDATE())/365.24219 + 1 AS INT) '1 sene sonraki ya��' FROM Employees E
WHERE (DATEDIFF(DAY,E.BirthDate,GETDATE())/365.24219) + 1 > 70
ORDER BY MONTH(E.BirthDate) ASC


--19.Tedarik�ilerimden ald���m �r�nlerimden toplam stok miktar� 150 ten fazla olanlar hangi �lkelerden listeleyiniz
SELECT S.Country,P.UnitsInStock FROM Suppliers S
JOIN Products P ON P.SupplierID LIKE S.SupplierID
WHERE P.UnitsInStock > 150
ORDER BY P.UnitsInStock DESC

--20.Condiments kategorisinde en pahal� 10 �r�n� ProductID, �r�n ad�, tedarik�i ad� �eklinde listelenen bir VIEW olu�turunuz
CREATE OR ALTER VIEW [Condiments Category] AS
SELECT TOP 10 P.ProductID,P.ProductName,S.CompanyName,P.UnitPrice FROM Categories C
JOIN Products P ON P.CategoryID LIKE C.CategoryID
JOIN Suppliers S ON S.SupplierID LIKE P.SupplierID
ORDER BY P.UnitPrice DESC

SELECT * FROM [Condiments Category]

--21.Kritik seviyede olan ve gelecek sipari�i olmayan �r�nlerimin tedarik�ilerini, kategorilerini, minimum ne kadar sipari� vermem gerekti�ini listeleyen bir view olu�turunuz VIEW ismi �KritikSeviyeUrunBilgileri�
CREATE OR ALTER VIEW [KritikSeviyeUrunBilgileri] AS
SELECT P.ProductName,S.CompanyName,C.CategoryName,(P.ReorderLevel-P.UnitsInStock) 'Siparis Verilmesi Gereken Miktar(Minimum)' FROM Products P
JOIN Suppliers S ON S.SupplierID LIKE P.SupplierID
JOIN Categories C ON P.CategoryID LIKE C.CategoryID
WHERE P.UnitsOnOrder = 0 AND P.UnitsInStock<P.ReorderLevel

SELECT * FROM KritikSeviyeUrunBilgileri

--22.Klavyeden Girilen Shipvia numaras�na g�re 300'den az veya fazla oldu�unu g�steren prosed�r� yaz�n�z. E�er Shipvia de�eri yoksa Hata mesaj� versin. Kay�t ��kt�s� �u �ekilde Olacak: 300den fazla kay�t var. Kay�t Say�s�= 330
CREATE OR ALTER PROCEDURE ShipViaKontrol @shipvia INT AS
BEGIN
    DECLARE @count INT
    SELECT @count = COUNT(*) FROM Orders WHERE ShipVia = @shipvia;

    IF @count >= 300
        PRINT '300''den fazla kay�t var. Kay�t Say�s� = ' + CAST(@count AS NVARCHAR)
    ELSE IF @count < 300 AND @count > 0
        PRINT '300''den az kay�t var. Kay�t Say�s� = ' + CAST(@count AS NVARCHAR)
    ELSE
        PRINT 'Verilen ShipVia de�eri bulunamad�.'
END

EXEC ShipViaKontrol @shipvia = 1 
EXEC ShipViaKontrol @shipvia = 2
EXEC ShipViaKontrol @shipvia = 3
EXEC ShipViaKontrol @shipvia = 4



--23.G�nl�k olarak rapor almak istiyorum. Girdi�im kategoriye g�re �r�n ad� ve stok miktar�n� getiren bir PROCEDURE olu�turunuz.
CREATE OR ALTER PROCEDURE KategoriyeGoreUrunStok @categoryID INT AS
BEGIN
    SELECT C.CategoryName,P.ProductName, P.UnitsInStock 
    FROM Products P 
    JOIN Categories C ON P.CategoryID LIKE C.CategoryID 
    WHERE C.CategoryID = @categoryID
END

EXEC KategoriyeGoreUrunStok @categoryID = 1





--24.Girilen iki tarih aras�ndaki g�nler i�in toplam ciromu veren bir FUNCTION olu�turunuz.
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

