CREATE DATABASE RestoranDB
USE RestoranDB
CREATE TABLE dbo.Musteriler (
    MusteriID INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
	--CONSTRAINT PK_Musteriler_MusteriID PRIMARY KEY (MusteriID),
    MusteriAdi NVARCHAR(50) NOT NULL,
    MusteriSoyadi NVARCHAR(50) NOT NULL,
)
CREATE TABLE dbo.MusteriDetaylari (
MusteriID INT UNIQUE NOT NULL,
CONSTRAINT FK_MusteriDetaylari_MusteriID FOREIGN KEY (MusteriID) 
REFERENCES Musteriler (MusteriID),
Adres NVARCHAR(50) NOT NULL,
TelefonNo bigint NOT NULL, 
Sehir NVARCHAR(50) NOT NULL,
Ulke NVARCHAR(50) DEFAULT 'Turkiye',
);
CREATE TABLE dbo.Siparisler (
   SiparisID INT IDENTITY(1,1) NOT NULL
   CONSTRAINT PK_Siparisler_SiparisID PRIMARY KEY (SiparisID),
   MusteriID INT NOT NULL,
   CONSTRAINT FK_Siparisler_MusteriID FOREIGN KEY (MusteriID)
   REFERENCES Musteriler (MusteriID),
   YemekSirketi NVARCHAR(50) NOT NULL,
   Urun NVARCHAR(50) NOT NULL,
   Adet INT NOT NULL,
   BirimFiyat MONEY NOT NULL,
   ToplamTutar AS (Adet*BirimFiyat),
   SiparisTarihi DATETIME DEFAULT GETDATE(),
);
SELECT * FROM Musteriler
SELECT * FROM MusteriDetaylari
SELECT * FROM Siparisler

SELECT * FROM Musteriler
INSERT INTO Musteriler(MusteriAdi,MusteriSoyadi) VALUES
('Atakan','Bektas'),
('Mustafa','Ozcan'),
('Gokcehan','Gucuk'),
('Burak','Oðuzkaan'),
('Fatih','Baðcýoðlu')
SELECT*FROM MusteriDetaylari
INSERT INTO MusteriDetaylari(MusteriID,Adres,TelefonNo,Sehir,Ulke) VALUES
(1,'Akpýnar Mah.850.Cad 12/2',5071043929,'Ankara','Turkiye'),
(2,'Akpýnar Mah.850.Cad 12/2',5725842353,'Çorum','Turkiye'),
(3,'Akpýnar Mah.850.Cad 12/2',5021001012,'Yozgan','Turkiye'),
(4,'Akpýnar Mah.850.Cad 12/2',5068775821,'London','Ýngiltere'),
(5,'Akpýnar Mah.850.Cad 12/2',5325215236,'Pekin','Çin')

INSERT INTO Siparisler(MusteriID,YemekSirketi,Urun,Adet,BirimFiyat) VALUES
(1,'Burger King','Hamburger',3,100),
(1,'Burger King','Pizza',4,50)

CREATE DATABASE KursDB
CREATE TABLE dbo.Ogrenciler
(
OgrenciID INT IDENTITY(1000,1) NOT NULL,
CONSTRAINT PK_Ogrenciler_OgrenciID PRIMARY KEY (OgrenciID),
OgrenciAdi NVARCHAR(50) NOT NULL,
OgrenciSoyadi NVARCHAR(50) NOT NULL,
);
CREATE TABLE dbo.Dersler
(
DersID INT IDENTITY (1,1) NOT NULL,
CONSTRAINT PK_Dersler_DersID PRIMARY KEY(DersID),
DersAdi NVARCHAR(50) NOT NULL
);
CREATE TABLE dbo.OgrencilerDersler
(
OgrenciID INT NOT NULL,
DersID INT NOT NULL
);