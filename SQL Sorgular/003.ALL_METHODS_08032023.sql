-- 2.SORU ��e giri� tarihi en eski olan �al��an�m�n ad� ve soyad�n� adSoyad isimli bir de�i�kende tutarak ekrana yazd�r�n�z. (Northwind Employees tablosundan)

USE Northwind


SELECT * FROM Employees
SELECT FirstName,LastName FROM Employees 
WHERE HireDate = (SELECT MIN(HireDate) FROM Employees)


SELECT CONCAT(FirstName , ' ', LastName) AS 'FullName' FROM  Employees
WHERE HireDate = (SELECT MIN(HireDate) FROM Employees)

SELECT FirstName,LastName,Country,
(CASE
    WHEN Country = 'USA' THEN 'Amerika'
    WHEN Country = 'UK' THEN 'Ingiltere'
    WHEN Country = 'TR' THEN 'Turkiye'
    ELSE 'Ulke Belirtilmedi'
END) AS Ulkesi
FROM Employees;
SELECT * FROM Employees

-- 4.SORU negatif girelim girilen negatif bir de�eri pozitif olarak ekranda g�sterelim
DECLARE @Sayi INT = -5
PRINT ABS(@Sayi)


-- 5.SORU Bir de�er giri�i yapal�m girilen de�er negatif ise mutlak de�erini alal�m de�il ise kendi de�erini ekrana yazd�ral�m
DECLARE @Sayi2 INT = 3
IF @Sayi2<0 PRINT ABS(@Sayi2)
ELSE PRINT @Sayi2

-- 6.SORU �al��anlar�n do�um tarihleri bilgilerini y�l, ay ve g�n tablolar�nda ekranda g�sterelim
SELECT Year(BirthDate) AS YIL ,MONTH(BirthDate) AS AY,DAY(BirthDate) AS GUN FROM Employees 

-- 7.SORU �al��anlar�n Ya�lar�n� ekrana getirelim
SELECT FirstName,LastName,YEAR(BirthDate) 'Dogum Yili',(YEAR(GETDATE())-YEAR(BirthDate)) 'Yas' FROM Employees ORDER BY [Yas] DESC

-- 8.SORU �al��anlar�m�n bug�ne kadar ka� g�nd�r �al��t�klar�n� bulal�m
SELECT FirstName,LastName, DATEDIFF(DAY,HireDate,GETDATE()) '�al���lan S�re' FROM Employees

--9.Soru Bug�nden 2 g�n sonras�n� ekrana yazd�ral�m

PRINT DATEADD(DAY,2,GETDATE())

-- 10.SORU a karakterinin ASCII kodundaki numaras�n� bulal�m
SELECT ASCII('A') 'Harf'


-- 11.SORU ASCII kodu 65 olan karakteri bulal�m
SELECT NCHAR(65) AS 'Harf'

-- 12.SORU Bilge Adam Akademi metni i�erisinde ilk e harfinin yerinin say�s�n� bulal�m
SELECT CHARINDEX('e', 'Bilge Adam Akademi') [Metin]

-- 13.SORU Bilge Adam Akademi metnini Bilge Adam olarak ekrana yazd�ral�m
SELECT REPLACE('Bilge Adam Akademi', 'Bilge Adam Akademi','Bilge Adam') AS [Metin];
SELECT SUBSTRING('Bilge Adam Akademi',1,11) AS [KACK]

-- 14.SORU Bilge Adam Akademi metnini Akademi olarak ekrana yazd�ral�m
SELECT SUBSTRING('Bilge Adam Akademi',12,LEN('Bilge Adam '))
SELECT RIGHT('Bilge Adam Akademi',7)

-- 15.SORU Bilge Adam Akademi metninin karakter say�s�n� bulal�m
SELECT 'Bilge Adam Akademi' [Metin], LEN('Bilge Adam Akademi') [Metnin Uzunlugu]


--16 SORU B�LGE ADAM AKADEM� metnini k���k harflerle yazd�ral�m
SELECT LOWER('B�LGE ADAM AKADEM�');

--17.SORU bilge adam akademi metnini b�y�k harflerle yazd�ral�m
SELECT UPPER('bilge adam akademi');

--18 19 20.SORU Bilge Adam Akdemi yaz�s�n� soldan bo�luksuz yazal�m
SELECT LTRIM('       Bilge Adam Akdemi                    ')
SELECT RTRIM('        Bilge Adam Akdemi        ')
SELECT TRIM('      Bilge Adam Akdemi       ')

-- 21.SORU Toplam �al��an say�s�n� bulal�m
SELECT COUNT(EmployeeID)
FROM Employees

-- 22.SORU �al��anlar�m, ka� farkl� �ehirden geliyor, bulal�m.
SELECT COUNT(DISTINCT(City)) FROM Employees 

--23.SORU Employees tablosundaki EmployeeID'lerin toplam� ka�t�r?
SELECT SUM(Employees.EmployeeID) FROM Employees


--24.SORU Employees tablosundaki EmployeeID'lerin ortalamas� ka�t�r?
SELECT AVG(EmployeeID) FROM Employees




