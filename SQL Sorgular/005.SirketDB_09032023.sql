CREATE DATABASE AtakAcademyDB
USE AtakAcademyDB

CREATE TABLE Birim(
  BirimId INT IDENTITY(1,1),
  BirimAd NVARCHAR(50)  
  PRIMARY KEY (BirimId) 
)
CREATE TABLE Unvan(
  UnvanId INT IDENTITY(1,1),
  UnvanAd NVARCHAR(50)  
  PRIMARY KEY (UnvanId) 
)
CREATE TABLE Il(
  ProjeId INT,
  IlId INT IDENTITY(1,1),
  IlAd NVARCHAR(50),
  FOREIGN KEY (ProjeId) REFERENCES Proje(ProjeId),
  PRIMARY KEY (IlId) 
)
CREATE TABLE Ilce(
  IlId INT,
  IlceAd NVARCHAR(50),
  IlceId INT,
  FOREIGN KEY (IlId) REFERENCES Il(IlID),
  PRIMARY KEY (IlceId) 
)
CREATE TABLE Proje(
  ProjeId INT IDENTITY(1,1),
  ProjeAd NVARCHAR(50),
  BaslamaTarihi DATE,
  BitisTarihi DATE,
  PRIMARY KEY (ProjeId)
)
CREATE TABLE Personel(
  PersonelTC NVARCHAR(11) UNIQUE,
  PersonelAdi NVARCHAR(50),
  PersonelSoyadi NVARCHAR(50),
  Cinsiyet NVARCHAR(25),
  DogumTarihi DATE,
  DogumYeri NVARCHAR(50),
  BaslamaTarihi DATE, 
  BirimNo INT,
  UnvanNo INT,
  Maas MONEY,
  Prim MONEY
  PRIMARY KEY (PersonelTC)
)

INSERT INTO Birim VALUES
('Hukuk'),
('Finans'),
('Pazarlama'),
('Planlama'),
('Proje Y�netimi')

INSERT INTO Unvan VALUES
('M�hendis'),
('IK Uzman�'),
('Teknisyen'),
('Mimar'),
('Temizlik G�revlisi'),
('M�d�r Yard�mc�s�'),
('Asistan'),
('Sekreter'),
('Denetmen'),
('M�d�r')

INSERT INTO Il VALUES
('Ankara'),
('Bursa'),
('Antalya'),
('Eski�ehir'),
('�stanbul'),
('�zmir'),
('Mu�la'),
('Bal�kesir'),
('Manisa'),
('Ayd�n')

INSERT INTO Ilce VALUES
('Polatl�'),
('Mustafa Kemal Pa�a'),
('Edremit'),
('Kad�k�y'),
('Bornova'),
('Ortaca'),
('Didim'),
('Odun Pazar�'),
('Manavgat'),
('Soma')









