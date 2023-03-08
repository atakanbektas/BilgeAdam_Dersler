-- 2.SORU Ýþe giriþ tarihi en eski olan çalýþanýmýn adý ve soyadýný adSoyad isimli bir deðiþkende tutarak ekrana yazdýrýnýz. (Northwind Employees tablosundan)

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

-- 4.SORU negatif girelim girilen negatif bir deðeri pozitif olarak ekranda gösterelim
DECLARE @Sayi INT = -5
PRINT ABS(@Sayi)


-- 5.SORU Bir deðer giriþi yapalým girilen deðer negatif ise mutlak deðerini alalým deðil ise kendi deðerini ekrana yazdýralým
DECLARE @Sayi2 INT = 3
IF @Sayi2<0 PRINT ABS(@Sayi2)
ELSE PRINT @Sayi2

-- 6.SORU Çalýþanlarýn doðum tarihleri bilgilerini yýl, ay ve gün tablolarýnda ekranda gösterelim
SELECT Year(BirthDate) AS YIL ,MONTH(BirthDate) AS AY,DAY(BirthDate) AS GUN FROM Employees 

-- 7.SORU Çalýþanlarýn Yaþlarýný ekrana getirelim
SELECT FirstName,LastName,YEAR(BirthDate) 'Dogum Yili',(YEAR(GETDATE())-YEAR(BirthDate)) 'Yas' FROM Employees ORDER BY [Yas] DESC

-- 8.SORU Çalýþanlarýmýn bugüne kadar kaç gündür çalýþtýklarýný bulalým
SELECT FirstName,LastName, DATEDIFF(DAY,HireDate,GETDATE()) 'Çalýþýlan Süre' FROM Employees

--9.Soru Bugünden 2 gün sonrasýný ekrana yazdýralým

PRINT DATEADD(DAY,2,GETDATE())

-- 10.SORU a karakterinin ASCII kodundaki numarasýný bulalým
SELECT ASCII('A') 'Harf'


-- 11.SORU ASCII kodu 65 olan karakteri bulalým
SELECT NCHAR(65) AS 'Harf'

-- 12.SORU Bilge Adam Akademi metni içerisinde ilk e harfinin yerinin sayýsýný bulalým
SELECT CHARINDEX('e', 'Bilge Adam Akademi') [Metin]

-- 13.SORU Bilge Adam Akademi metnini Bilge Adam olarak ekrana yazdýralým
SELECT REPLACE('Bilge Adam Akademi', 'Bilge Adam Akademi','Bilge Adam') AS [Metin];
SELECT SUBSTRING('Bilge Adam Akademi',1,11) AS [KACK]

-- 14.SORU Bilge Adam Akademi metnini Akademi olarak ekrana yazdýralým
SELECT SUBSTRING('Bilge Adam Akademi',12,LEN('Bilge Adam '))
SELECT RIGHT('Bilge Adam Akademi',7)

-- 15.SORU Bilge Adam Akademi metninin karakter sayýsýný bulalým
SELECT 'Bilge Adam Akademi' [Metin], LEN('Bilge Adam Akademi') [Metnin Uzunlugu]


--16 SORU BÝLGE ADAM AKADEMÝ metnini küçük harflerle yazdýralým
SELECT LOWER('BÝLGE ADAM AKADEMÝ');

--17.SORU bilge adam akademi metnini büyük harflerle yazdýralým
SELECT UPPER('bilge adam akademi');

--18 19 20.SORU Bilge Adam Akdemi yazýsýný soldan boþluksuz yazalým
SELECT LTRIM('       Bilge Adam Akdemi                    ')
SELECT RTRIM('        Bilge Adam Akdemi        ')
SELECT TRIM('      Bilge Adam Akdemi       ')

-- 21.SORU Toplam çalýþan sayýsýný bulalým
SELECT COUNT(EmployeeID)
FROM Employees

-- 22.SORU Çalýþanlarým, kaç farklý þehirden geliyor, bulalým.
SELECT COUNT(DISTINCT(City)) FROM Employees 

--23.SORU Employees tablosundaki EmployeeID'lerin toplamý kaçtýr?
SELECT SUM(Employees.EmployeeID) FROM Employees


--24.SORU Employees tablosundaki EmployeeID'lerin ortalamasý kaçtýr?
SELECT AVG(EmployeeID) FROM Employees




