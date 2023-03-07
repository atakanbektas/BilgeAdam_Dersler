-- 1.SORU Çalýþanlarýmýn arasýnda adýnýn ilk harfi A veya R olanlarý listeleyiniz...
SELECT * FROM Employees
WHERE SUBSTRING(FirstName, 1, 1)='A' OR SUBSTRING(FirstName, 1, 1)='R'


-- 2.SORU Çalýþanlarýmýn arasýnda soyadýnýn içinde A harfi geçenleri listeleyelim...
SELECT * FROM Employees
WHERE LastName LIKE '%a%' 

-- 3.SORU Çalýþanlarýmýn arasýnda adý alfabetik olarak B ile S arasýnda olanlarý listeleyiniz...
SELECT TitleOfCourtesy,FirstName,LastName  FROM  Employees
WHERE  FirstName  BETWEEN 'J' AND 'S'
ORDER BY FirstName -- ASC OR DESC yazýlarak sýralama þekli belirtilebilir.


-- 4.SORU Çalýþanlarýmýn arasýnda adýnýn içinde A ve E harfi olan ve bu karakterler arasýnda yalnýzca 1 karakter olanlarý listeleyiniz...
SELECT * FROM Employees
WHERE 
FirstName LIKE '%A_E%' OR
FirstName LIKE '%E_A%'

-- 5.SORU Çalýþanlarýmýn arasýnda adýnýn içinde A ve E harfi olan ve bu karakterler arasýnda yalnýzca 2 karakter olanlarý listeleyiniz... (Örnek: AyfEr, AskEr gibi)
SELECT FirstName FROM Employees 
WHERE 
FirstName LIKE '%A__E%' OR 
FirstName LIKE '%E__A%'

-- 6.SORU Employees tablosundan ID'si 2 ile 8 arasýnda olan çalýþanlarýn bilgilerini, FirstName kolonuna göre ARTAN sýrada sýralayýnýz (A'dan Z'ye)
SELECT EmployeeID,FirstName FROM Employees
WHERE EmployeeID BETWEEN 2 AND 8
ORDER BY FirstName ASC


-- 7.SORU Employees tablosundan, çalýþanlarýn, Adý, Soyadý, Doðum tarihi bilgilerini,
--BirthDate kolonuna göre ARTAN sýrada sýralayarak listeleyiniz...

SELECT FirstName,LastName,BirthDate FROM Employees
ORDER BY BirthDate


-- 8.SORU Kategoriler tablosuna 'Meyveler' kategorisini, 
--'Mevsim meyveleri taze tüketilirse faydalý olur.' açýklamasýyla birlikte ekleyiniz...
SELECT * FROM Categories
INSERT INTO Categories (CategoryName,Description)   
VALUES ('Meyvalar','TEST');

-- 9. soru employees kendini ekle
SELECT * FROM Employees
INSERT INTO Employees (LastName,FirstName,Title,TitleOfCourtesy,BirthDate,HireDate,Address,City,Region,PostalCode,Country,HomePhone,Extension,Notes)
VALUES ('Bektaþ','Atakan','Software Developer','Mr.','1995-02-22','09.01.2023','Akpýnar Mah. 850 Cad. 12/2 Dikmen','Ankara','Çankaya','06420','Turkey','(312) 4838937','TR','I am coming for everybody')


-- 10.SORU Tek bir INSERT komutu ile Employees tablosuna 3 kiþi ekleyiniz... FirstName, LastName, TitleOfCourtesy, Title
SELECT * FROM Employees
INSERT INTO Employees (FirstName,LastName,TitleOfCourtesy,Title)
VALUES ('Gökçehan','Gücük','Mrs.','Unemployee'),('Aykut','Terzi','Mr.','Software Arc'),('Fatih','Baðcýoðlu','Mr.','Software Teacher') 


-- 11.SORU Çalýþanlar tablosundan ID'si 7 olan çalýþanýn soyadýný güncelleyiniz...
SELECT * FROM Employees
UPDATE Employees
SET LastName = 'Levandowski'
WHERE EmployeeID=7

 --12. SORU Çalýþanlar tablosundaki bütün çalýþanlarýn soyadýný güncelleyiniz...
 SELECT * FROM Employees
UPDATE Employees
SET LastName = 'Levandowski'

-- 13.SORU Çalýþanlar tablosunda Unvaný 'Mr.' olanlarý 'Bay' olarak güncelleyiniz...
SELECT * FROM Employees
UPDATE Employees
SET TitleOfCourtesy = 'Bay'
WHERE TitleOfCourtesy = 'Mr.'


-- 14.SORU Bayan çalýþanlar içerisinde görevi Sales Representative olanlarý Satýþ Temsilcisi olarak güncelleyiniz...
UPDATE Employees
SET Title = 'Satýþ Temsilcisi'
WHERE Title = 'Sales Representative' AND  TitleOfCourtesy = 'Ms.'
SELECT * FROM Employees


-- 15.SORU Çalýþanlar tablosundan ID'si 5 olan çalýþaný silelim...
SELECT * INTO Calisanlar FROM Employees
SELECT * FROM Calisanlar
DELETE FROM Calisanlar WHERE EmployeeID = 5


-- 16.SORU Çalýþanlar tablosundan unvaný bayan olan çalýþanlarý silmek istersek;
SELECT * FROM Calisanlar
DELETE FROM Calisanlar WHERE TitleOfCourtesy = 'Ms.' 


DELETE FROM Calisanlar

DROP TABLE Calisanlar


 







