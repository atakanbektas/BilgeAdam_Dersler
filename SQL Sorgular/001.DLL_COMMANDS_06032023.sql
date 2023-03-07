-- 1.SORU �al��anlar�m�n aras�nda ad�n�n ilk harfi A veya R olanlar� listeleyiniz...
SELECT * FROM Employees
WHERE SUBSTRING(FirstName, 1, 1)='A' OR SUBSTRING(FirstName, 1, 1)='R'


-- 2.SORU �al��anlar�m�n aras�nda soyad�n�n i�inde A harfi ge�enleri listeleyelim...
SELECT * FROM Employees
WHERE LastName LIKE '%a%' 

-- 3.SORU �al��anlar�m�n aras�nda ad� alfabetik olarak B ile S aras�nda olanlar� listeleyiniz...
SELECT TitleOfCourtesy,FirstName,LastName  FROM  Employees
WHERE  FirstName  BETWEEN 'J' AND 'S'
ORDER BY FirstName -- ASC OR DESC yaz�larak s�ralama �ekli belirtilebilir.


-- 4.SORU �al��anlar�m�n aras�nda ad�n�n i�inde A ve E harfi olan ve bu karakterler aras�nda yaln�zca 1 karakter olanlar� listeleyiniz...
SELECT * FROM Employees
WHERE 
FirstName LIKE '%A_E%' OR
FirstName LIKE '%E_A%'

-- 5.SORU �al��anlar�m�n aras�nda ad�n�n i�inde A ve E harfi olan ve bu karakterler aras�nda yaln�zca 2 karakter olanlar� listeleyiniz... (�rnek: AyfEr, AskEr gibi)
SELECT FirstName FROM Employees 
WHERE 
FirstName LIKE '%A__E%' OR 
FirstName LIKE '%E__A%'

-- 6.SORU Employees tablosundan ID'si 2 ile 8 aras�nda olan �al��anlar�n bilgilerini, FirstName kolonuna g�re ARTAN s�rada s�ralay�n�z (A'dan Z'ye)
SELECT EmployeeID,FirstName FROM Employees
WHERE EmployeeID BETWEEN 2 AND 8
ORDER BY FirstName ASC


-- 7.SORU Employees tablosundan, �al��anlar�n, Ad�, Soyad�, Do�um tarihi bilgilerini,
--BirthDate kolonuna g�re ARTAN s�rada s�ralayarak listeleyiniz...

SELECT FirstName,LastName,BirthDate FROM Employees
ORDER BY BirthDate


-- 8.SORU Kategoriler tablosuna 'Meyveler' kategorisini, 
--'Mevsim meyveleri taze t�ketilirse faydal� olur.' a��klamas�yla birlikte ekleyiniz...
SELECT * FROM Categories
INSERT INTO Categories (CategoryName,Description)   
VALUES ('Meyvalar','TEST');

-- 9. soru employees kendini ekle
SELECT * FROM Employees
INSERT INTO Employees (LastName,FirstName,Title,TitleOfCourtesy,BirthDate,HireDate,Address,City,Region,PostalCode,Country,HomePhone,Extension,Notes)
VALUES ('Bekta�','Atakan','Software Developer','Mr.','1995-02-22','09.01.2023','Akp�nar Mah. 850 Cad. 12/2 Dikmen','Ankara','�ankaya','06420','Turkey','(312) 4838937','TR','I am coming for everybody')


-- 10.SORU Tek bir INSERT komutu ile Employees tablosuna 3 ki�i ekleyiniz... FirstName, LastName, TitleOfCourtesy, Title
SELECT * FROM Employees
INSERT INTO Employees (FirstName,LastName,TitleOfCourtesy,Title)
VALUES ('G�k�ehan','G�c�k','Mrs.','Unemployee'),('Aykut','Terzi','Mr.','Software Arc'),('Fatih','Ba�c�o�lu','Mr.','Software Teacher') 


-- 11.SORU �al��anlar tablosundan ID'si 7 olan �al��an�n soyad�n� g�ncelleyiniz...
SELECT * FROM Employees
UPDATE Employees
SET LastName = 'Levandowski'
WHERE EmployeeID=7

 --12. SORU �al��anlar tablosundaki b�t�n �al��anlar�n soyad�n� g�ncelleyiniz...
 SELECT * FROM Employees
UPDATE Employees
SET LastName = 'Levandowski'

-- 13.SORU �al��anlar tablosunda Unvan� 'Mr.' olanlar� 'Bay' olarak g�ncelleyiniz...
SELECT * FROM Employees
UPDATE Employees
SET TitleOfCourtesy = 'Bay'
WHERE TitleOfCourtesy = 'Mr.'


-- 14.SORU Bayan �al��anlar i�erisinde g�revi Sales Representative olanlar� Sat�� Temsilcisi olarak g�ncelleyiniz...
UPDATE Employees
SET Title = 'Sat�� Temsilcisi'
WHERE Title = 'Sales Representative' AND  TitleOfCourtesy = 'Ms.'
SELECT * FROM Employees


-- 15.SORU �al��anlar tablosundan ID'si 5 olan �al��an� silelim...
SELECT * INTO Calisanlar FROM Employees
SELECT * FROM Calisanlar
DELETE FROM Calisanlar WHERE EmployeeID = 5


-- 16.SORU �al��anlar tablosundan unvan� bayan olan �al��anlar� silmek istersek;
SELECT * FROM Calisanlar
DELETE FROM Calisanlar WHERE TitleOfCourtesy = 'Ms.' 


DELETE FROM Calisanlar

DROP TABLE Calisanlar


 







