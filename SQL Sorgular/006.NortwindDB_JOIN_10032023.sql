-- 1.SORU Her �r�n i�in �r�nler tablosundan �r�n Ad�, Kategoriler tablosundan Kategori Ad� bilgilerini listeleyiniz...

SELECT p.ProductName,c.CategoryName FROM Products p
JOIN Categories c ON p.CategoryID = c.CategoryID


-- 2.SORU Hangi sipari�in, hangi �al��an taraf�ndan al�nd���n�, hangi m��teriye g�nderilece�ini listeleyiniz...

SELECT Ord.OrderID,Emp.FirstName + ' ' + Emp.LastName [Calisan],Cus.ContactName[M�steri] FROM Orders Ord
JOIN Employees Emp ON Emp.EmployeeID = Ord.EmployeeID
JOIN Customers Cus ON Ord.CustomerID = Cus.CustomerID
ORDER BY Calisan

-- 3.SORU Products tablosundan T�M KAYITLARI, Categories tablosundan ili�kili kay�tlar� listeleyelim. (ProductName, CategoryName)  

SELECT Pro.ProductName, Cat.CategoryName FROM Products Pro
LEFT JOIN Categories Cat ON Pro.CategoryID = Cat.CategoryID 

-- 4.SORU T�M �al��anlar� ve e�er varsa rapor verdi�i ki�ilerle birlikte listeleyiniz...
SELECT e2.EmployeeId,e2.FirstName,e1.EmployeeID,e1.FirstName FROM Employees e1  
JOIN Employees e2 ON e2.ReportsTo = e1.EmployeeID

--5.SORU Fransaya en �ok satt���m�z �r�n
SELECT SUM(Quantity),P.ProductName,S.[Address],C.Country FROM Orders O
JOIN Customers C ON O.CustomerID = C.CustomerID
JOIN [Order Details] OD ON O.OrderID = OD.OrderID 
JOIN Products P ON OD.ProductID = P.ProductID
JOIN Suppliers S ON P.SupplierID = S.SupplierID
WHERE C.Country='France'
GROUP BY (ProductName),(S.[Address]),(C.Country)
ORDER BY 1 DESC

-- 6.SORU Kargo �irketlerinin kargo �irket kodu ve �irket ad� bilgileriyle, toplam ta��d�klar� sipari� say�s�n� listeleyiniz...

SELECT S.ShipperID,S.CompanyName,COUNT(S.ShipperID) AS 'Sat�lan Siparis Say�s�' FROM Shippers S
JOIN Orders O ON O.ShipVia = S.ShipperID
GROUP BY (S.ShipperID),(S.CompanyName)

-- 7.SORU Brezilya'dan sipari� veren (orada ya�ayan) m��terilerin verdi�i en y�ksek sipari� tutar�n� getiriniz...

SELECT TOP 1  C.CompanyName,(UnitPrice*Quantity) AS 'Siparis Ucreti' FROM [Order Details] OD
JOIN Orders O ON O.OrderID = OD.OrderID
JOIN Customers C ON C.CustomerID = O.CustomerID AND C.Country='Brazil'
ORDER BY 2 DESC

--GELEN SESLENS�N

SELECT * FROM Customers
