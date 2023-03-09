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
  IlceId INT IDENTITY (1,1),
  FOREIGN KEY (IlId) REFERENCES Il(IlID),
  PRIMARY KEY (IlceId) 
)
ALTER TABLE Ilce
ADD IlceId INT IDENTITY (1,1)




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

INSERT INTO Il(IlAd) VALUES
('Adana'),('Ad�yaman'),('Afyon'),('A�r�'),('Amasya'),('Ankara'),('Antalya'),('Artvin'),('Ayd�n'),('Bal�kesir'),('Bilecik'),('Bing�l'),('Bitlis'),('Bolu'),('Burdur'),('Bursa'),('�anakkale'),('�ank�r�'),('�orum'),('Denizli'),('Diyarbak�r'),('Edirne'),('Elaz��'),('Erzincan'),('Erzurum'),('Eski�ehir'),('Gaziantep'),('Giresun'),('G�m��hane'),('Hakkari'),('Hatay'),('Isparta'),('Mersin ��el'),('�stanbul'),('�zmir'),('Kars'),('Kastamonu'),('Kayseri'),('K�rklareli'),('K�r�ehir'),('Kocaeli'),('Konya'),('K�tahya'),('Malatya'),('Manisa'),('Kahramanmara�'),('Mardin'),('Mu�la'),('Mu�'),('Nev�ehir'),('Ni�de'),('Ordu'),('Rize'),('Sakarya'),('Samsun'),('Siirt'),('Sinop'),('Sivas'),('Tekirda�'),('Tokat'),('Trabzon'),('Tunceli'),('�anl�urfa'),('U�ak'),('Van'),('Yozgat'),('Zonguldak'),('Aksaray'),('Bayburt'),('Karaman'),('K�r�kkale'),('Batman'),('��rnak'),('Bart�n'),('Ardahan'),('I�d�r'),('Yalova'),('Karab�k'),('Kilis'),('Osmaniye'),('D�zce')


INSERT INTO Ilce(IlId,IlceAd) VALUES
(	1	,'Seyhan'	),
(	1	,'Ceyhan'	),
(	1	,'Feke'	),
(	1	,'Karaisal�'	),
(	1	,'Karata�'	),
(	1	,'Kozan'	),
(	1	,'Pozant�'	),
(	1	,'Saimbeyli'	),
(	1	,'Tufanbeyli'	),
(	1	,'Yumurtal�k'	),
(	1	,'Y�re�ir'	),
(	1	,'Alada�'	),
(	1	,'�mamo�lu'	),
(	1	,'Sar��am'	),
(	1	,'�ukurova'	),
(	2	,'Ad�yaman Merkez'	),
(	2	,'Besni'	),
(	2	,'�elikhan'	),
(	2	,'Gerger'	),
(	2	,'G�lba�� / Ad�yaman'	),
(	2	,'Kahta'	),
(	2	,'Samsat'	),
(	2	,'Sincik'	),
(	2	,'Tut'	),
(	3	,'Afyonkarahisar Merkez'	),
(	3	,'Bolvadin'	),
(	3	,'�ay'	),
(	3	,'Dazk�r�'	),
(	3	,'Dinar'	),
(	3	,'Emirda�'	),
(	3	,'�hsaniye'	),
(	3	,'Sand�kl�'	),
(	3	,'Sinanpa�a'	),
(	3	,'Sultanda��'	),
(	3	,'�uhut'	),
(	3	,'Ba�mak��'	),
(	3	,'Bayat / Afyonkarahisar'	),
(	3	,'�scehisar'	),
(	3	,'�obanlar'	),
(	3	,'Evciler'	),
(	3	,'Hocalar'	),
(	3	,'K�z�l�ren'	),
(	4	,'A�r� Merkez'	),
(	4	,'Diyadin'	),
(	4	,'Do�ubayaz�t'	),
(	4	,'Ele�kirt'	),
(	4	,'Hamur'	),
(	4	,'Patnos'	),
(	4	,'Ta�l��ay'	),
(	4	,'Tutak'	),
(	5	,'Amasya Merkez'	),
(	5	,'G�yn�cek'	),
(	5	,'G�m��hac�k�y'	),
(	5	,'Merzifon'	),
(	5	,'Suluova'	),
(	5	,'Ta�ova'	),
(	5	,'Hamam�z�'	),
(	6	,'Alt�nda�'	),
(	6	,'Aya�'	),
(	6	,'Bala'	),
(	6	,'Beypazar�'	),
(	6	,'�aml�dere'	),
(	6	,'�ankaya'	),
(	6	,'�ubuk'	),
(	6	,'Elmada�'	),
(	6	,'G�d�l'	),
(	6	,'Haymana'	),
(	6	,'Kalecik'	),
(	6	,'K�z�lcahamam'	),
(	6	,'Nall�han'	),
(	6	,'Polatl�'	),
(	6	,'�erefliko�hisar'	),
(	6	,'Yenimahalle'	),
(	6	,'G�lba�� / Ankara'	),
(	6	,'Ke�i�ren'	),
(	6	,'Mamak'	),
(	6	,'Sincan'	),
(	6	,'Kazan'	),
(	6	,'Akyurt'	),
(	6	,'Etimesgut'	),
(	6	,'Evren'	),
(	6	,'Pursaklar'	),
(	7	,'Akseki'	),
(	7	,'Alanya'	),
(	7	,'Elmal�'	),
(	7	,'Finike'	),
(	7	,'Gazipa�a'	),
(	7	,'G�ndo�mu�'	),
(	7	,'Ka�'	),
(	7	,'Korkuteli'	),
(	7	,'Kumluca'	),
(	7	,'Manavgat'	),
(	7	,'Serik'	),
(	7	,'Demre'	),
(	7	,'�brad�'	),
(	7	,'Kemer / Antalya'	),
(	7	,'Aksu / Antalya'	),
(	7	,'D��emealt�'	),
(	7	,'Kepez'	),
(	7	,'Konyaalt�'	),
(	7	,'Muratpa�a'	),
(	8	,'Ardanu�'	),
(	8	,'Arhavi'	),
(	8	,'Artvin Merkez'	),
(	8	,'Bor�ka'	),
(	8	,'Hopa'	),
(	8	,'�av�at'	),
(	8	,'Yusufeli'	),
(	8	,'Murgul'	),
(	9	,'Bozdo�an'	),
(	9	,'�ine'	),
(	9	,'Germencik'	),
(	9	,'Karacasu'	),
(	9	,'Ko�arl�'	),
(	9	,'Ku�adas�'	),
(	9	,'Kuyucak'	),
(	9	,'Nazilli'	),
(	9	,'S�ke'	),
(	9	,'Sultanhisar'	),
(	9	,'Yenipazar / Ayd�n'	),
(	9	,'Buharkent'	),
(	9	,'�ncirliova'	),
(	9	,'Karpuzlu'	),
(	9	,'K��k'	),
(	9	,'Didim'	),
(	9	,'Efeler'	),
(	10	,'Ayval�k'	),
(	10	,'Balya'	),
(	10	,'Band�rma'	),
(	10	,'Bigadi�'	),
(	10	,'Burhaniye'	),
(	10	,'Dursunbey'	),
(	10	,'Edremit / Bal�kesir'	),
(	10	,'Erdek'	),
(	10	,'G�nen / Bal�kesir'	),
(	10	,'Havran'	),
(	10	,'�vrindi'	),
(	10	,'Kepsut'	),
(	10	,'Manyas'	),
(	10	,'Sava�tepe'	),
(	10	,'S�nd�rg�'	),
(	10	,'Susurluk'	),
(	10	,'Marmara'	),
(	10	,'G�me�'	),
(	10	,'Alt�eyl�l'	),
(	10	,'Karesi'	),
(	11	,'Bilecik Merkez'	),
(	11	,'Boz�y�k'	),
(	11	,'G�lpazar�'	),
(	11	,'Osmaneli'	),
(	11	,'Pazaryeri'	),
(	11	,'S���t'	),
(	11	,'Yenipazar / Bilecik'	),
(	11	,'�nhisar'	),
(	12	,'Bing�l Merkez'	),
(	12	,'Gen�'	),
(	12	,'Karl�ova'	),
(	12	,'Ki��'	),
(	12	,'Solhan'	),
(	12	,'Adakl�'	),
(	12	,'Yayladere'	),
(	12	,'Yedisu'	),
(	13	,'Adilcevaz'	),
(	13	,'Ahlat'	),
(	13	,'Bitlis Merkez'	),
(	13	,'Hizan'	),
(	13	,'Mutki'	),
(	13	,'Tatvan'	),
(	13	,'G�roymak'	),
(	14	,'Bolu Merkez'	),
(	14	,'Gerede'	),
(	14	,'G�yn�k'	),
(	14	,'K�br�sc�k'	),
(	14	,'Mengen'	),
(	14	,'Mudurnu'	),
(	14	,'Seben'	),
(	14	,'D�rtdivan'	),
(	14	,'Yeni�a�a'	),
(	15	,'A�lasun'	),
(	15	,'Bucak'	),
(	15	,'Burdur Merkez'	),
(	15	,'G�lhisar'	),
(	15	,'Tefenni'	),
(	15	,'Ye�ilova'	),
(	15	,'Karamanl�'	),
(	15	,'Kemer / Burdur'	),
(	15	,'Alt�nyayla / Burdur'	),
(	15	,'�avd�r'	),
(	15	,'�eltik�i'	),
(	16	,'Gemlik'	),
(	16	,'�neg�l'	),
(	16	,'�znik'	),
(	16	,'Karacabey'	),
(	16	,'Keles'	),
(	16	,'Mudanya'	),
(	16	,'Mustafakemalpa�a'	),
(	16	,'Orhaneli'	),
(	16	,'Orhangazi'	),
(	16	,'Yeni�ehir / Bursa'	),
(	16	,'B�y�korhan'	),
(	16	,'Harmanc�k'	),
(	16	,'Nil�fer'	),
(	16	,'Osmangazi'	),
(	16	,'Y�ld�r�m'	),
(	16	,'G�rsu'	),
(	16	,'Kestel'	),
(	17	,'Ayvac�k / �anakkale'	),
(	17	,'Bayrami�'	),
(	17	,'Biga'	),
(	17	,'Bozcaada'	),
(	17	,'�an'	),
(	17	,'�anakkale Merkez'	),
(	17	,'Eceabat'	),
(	17	,'Ezine'	),
(	17	,'Gelibolu'	),
(	17	,'G�k�eada'	),
(	17	,'Lapseki'	),
(	17	,'Yenice / �anakkale'	),
(	18	,'�ank�r� Merkez'	),
(	18	,'�erke�'	),
(	18	,'Eldivan'	),
(	18	,'Ilgaz'	),
(	18	,'Kur�unlu'	),
(	18	,'Orta'	),
(	18	,'�aban�z�'	),
(	18	,'Yaprakl�'	),
(	18	,'Atkaracalar'	),
(	18	,'K�z�l�rmak'	),
(	18	,'Bayram�ren'	),
(	18	,'Korgun'	),
(	19	,'Alaca'	),
(	19	,'Bayat / �orum'	),
(	19	,'�orum Merkez'	),
(	19	,'�skilip'	),
(	19	,'Karg�'	),
(	19	,'Mecit�z�'	),
(	19	,'Ortak�y / �orum'	),
(	19	,'Osmanc�k'	),
(	19	,'Sungurlu'	),
(	19	,'Bo�azkale'	),
(	19	,'U�urluda�'	),
(	19	,'Dodurga'	),
(	19	,'La�in'	),
(	19	,'O�uzlar'	),
(	20	,'Ac�payam'	),
(	20	,'Buldan'	),
(	20	,'�al'	),
(	20	,'�ameli'	),
(	20	,'�ardak'	),
(	20	,'�ivril'	),
(	20	,'G�ney'	),
(	20	,'Kale / Denizli'	),
(	20	,'Sarayk�y'	),
(	20	,'Tavas'	),
(	20	,'Babada�'	),
(	20	,'Bekilli'	),
(	20	,'Honaz'	),
(	20	,'Serinhisar'	),
(	20	,'Pamukkale'	),
(	20	,'Baklan'	),
(	20	,'Beya�a�'	),
(	20	,'Bozkurt / Denizli'	),
(	20	,'Merkezefendi'	),
(	21	,'Bismil'	),
(	21	,'�ermik'	),
(	21	,'��nar'	),
(	21	,'��ng��'	),
(	21	,'Dicle'	),
(	21	,'Ergani'	),
(	21	,'Hani'	),
(	21	,'Hazro'	),
(	21	,'Kulp'	),
(	21	,'Lice'	),
(	21	,'Silvan'	),
(	21	,'E�il'	),
(	21	,'Kocak�y'	),
(	21	,'Ba�lar'	),
(	21	,'Kayap�nar'	),
(	21	,'Sur'	),
(	21	,'Yeni�ehir / Diyarbak�r'	),
(	22	,'Edirne Merkez'	),
(	22	,'Enez'	),
(	22	,'Havsa'	),
(	22	,'�psala'	),
(	22	,'Ke�an'	),
(	22	,'Lalapa�a'	),
(	22	,'Meri�'	),
(	22	,'Uzunk�pr�'	),
(	22	,'S�lo�lu'	),
(	23	,'A��n'	),
(	23	,'Baskil'	),
(	23	,'Elaz�� Merkez'	),
(	23	,'Karako�an'	),
(	23	,'Keban'	),
(	23	,'Maden'	),
(	23	,'Palu'	),
(	23	,'Sivrice'	),
(	23	,'Ar�cak'	),
(	23	,'Kovanc�lar'	),
(	23	,'Alacakaya'	),
(	24	,'�ay�rl�'	),
(	24	,'Erzincan Merkez'	),
(	24	,'�li�'	),
(	24	,'Kemah'	),
(	24	,'Kemaliye'	),
(	24	,'Refahiye'	),
(	24	,'Tercan'	),
(	24	,'�z�ml�'	),
(	24	,'Otlukbeli'	),
(	25	,'A�kale'	),
(	25	,'�at'	),
(	25	,'H�n�s'	),
(	25	,'Horasan'	),
(	25	,'�spir'	),
(	25	,'Karayaz�'	),
(	25	,'Narman'	),
(	25	,'Oltu'	),
(	25	,'Olur'	),
(	25	,'Pasinler'	),
(	25	,'�enkaya'	),
(	25	,'Tekman'	),
(	25	,'Tortum'	),
(	25	,'Kara�oban'	),
(	25	,'Uzundere'	),
(	25	,'Pazaryolu'	),
(	25	,'Aziziye'	),
(	25	,'K�pr�k�y'	),
(	25	,'Paland�ken'	),
(	25	,'Yakutiye'	),
(	26	,'�ifteler'	),
(	26	,'Mahmudiye'	),
(	26	,'Mihal����k'	),
(	26	,'Sar�cakaya'	),
(	26	,'Seyitgazi'	),
(	26	,'Sivrihisar'	),
(	26	,'Alpu'	),
(	26	,'Beylikova'	),
(	26	,'�n�n�'	),
(	26	,'G�ny�z�'	),
(	26	,'Han'	),
(	26	,'Mihalgazi'	),
(	26	,'Odunpazar�'	),
(	26	,'Tepeba��'	),
(	27	,'Araban'	),
(	27	,'�slahiye'	),
(	27	,'Nizip'	),
(	27	,'O�uzeli'	),
(	27	,'Yavuzeli'	),
(	27	,'�ahinbey'	),
(	27	,'�ehitkamil'	),
(	27	,'Karkam��'	),
(	27	,'Nurda��'	),
(	28	,'Alucra'	),
(	28	,'Bulancak'	),
(	28	,'Dereli'	),
(	28	,'Espiye'	),
(	28	,'Eynesil'	),
(	28	,'Giresun Merkez'	),
(	28	,'G�rele'	),
(	28	,'Ke�ap'	),
(	28	,'�ebinkarahisar'	),
(	28	,'Tirebolu'	),
(	28	,'Piraziz'	),
(	28	,'Ya�l�dere'	),
(	28	,'�amoluk'	),
(	28	,'�anak��'	),
(	28	,'Do�ankent'	),
(	28	,'G�ce'	),
(	29	,'G�m��hane Merkez'	),
(	29	,'Kelkit'	),
(	29	,'�iran'	),
(	29	,'Torul'	),
(	29	,'K�se'	),
(	29	,'K�rt�n'	),
(	30	,'�ukurca'	),
(	30	,'Hakkari Merkez'	),
(	30	,'�emdinli'	),
(	30	,'Y�ksekova'	),
(	31	,'Alt�n�z�'	),
(	31	,'D�rtyol'	),
(	31	,'Hassa'	),
(	31	,'�skenderun'	),
(	31	,'K�r�khan'	),
(	31	,'Reyhanl�'	),
(	31	,'Samanda�'	),
(	31	,'Yaylada��'	),
(	31	,'Erzin'	),
(	31	,'Belen'	),
(	31	,'Kumlu'	),
(	31	,'Antakya'	),
(	31	,'Arsuz'	),
(	31	,'Defne'	),
(	31	,'Payas'	),
(	32	,'Atabey'	),
(	32	,'E�irdir'	),
(	32	,'Gelendost'	),
(	32	,'Isparta Merkez'	),
(	32	,'Ke�iborlu'	),
(	32	,'Senirkent'	),
(	32	,'S�t��ler'	),
(	32	,'�arkikaraa�a�'	),
(	32	,'Uluborlu'	),
(	32	,'Yalva�'	),
(	32	,'Aksu / Isparta'	),
(	32	,'G�nen / Isparta'	),
(	32	,'Yeni�arbademli'	),
(	33	,'Anamur'	),
(	33	,'Erdemli'	),
(	33	,'G�lnar'	),
(	33	,'Mut'	),
(	33	,'Silifke'	),
(	33	,'Tarsus'	),
(	33	,'Ayd�nc�k / Mersin'	),
(	33	,'Bozyaz�'	),
(	33	,'�aml�yayla'	),
(	33	,'Akdeniz'	),
(	33	,'Mezitli'	),
(	33	,'Toroslar'	),
(	33	,'Yeni�ehir / Mersin'	),
(	34	,'Adalar'	),
(	34	,'Bak�rk�y'	),
(	34	,'Be�ikta�'	),
(	34	,'Beykoz'	),
(	34	,'Beyo�lu'	),
(	34	,'�atalca'	),
(	34	,'Ey�p'	),
(	34	,'Fatih'	),
(	34	,'Gaziosmanpa�a'	),
(	34	,'Kad�k�y'	),
(	34	,'Kartal'	),
(	34	,'Sar�yer'	),
(	34	,'Silivri'	),
(	34	,'�ile'	),
(	34	,'�i�li'	),
(	34	,'�sk�dar'	),
(	34	,'Zeytinburnu'	),
(	34	,'B�y�k�ekmece'	),
(	34	,'Ka��thane'	),
(	34	,'K���k�ekmece'	),
(	34	,'Pendik'	),
(	34	,'�mraniye'	),
(	34	,'Bayrampa�a'	),
(	34	,'Avc�lar'	),
(	34	,'Ba�c�lar'	),
(	34	,'Bah�elievler'	),
(	34	,'G�ng�ren'	),
(	34	,'Maltepe'	),
(	34	,'Sultanbeyli'	),
(	34	,'Tuzla'	),
(	34	,'Esenler'	),
(	34	,'Arnavutk�y'	),
(	34	,'Ata�ehir'	),
(	34	,'Ba�ak�ehir'	),
(	34	,'Beylikd�z�'	),
(	34	,'�ekmek�y'	),
(	34	,'Esenyurt'	),
(	34	,'Sancaktepe'	),
(	34	,'Sultangazi'	),
(	35	,'Alia�a'	),
(	35	,'Bay�nd�r'	),
(	35	,'Bergama'	),
(	35	,'Bornova'	),
(	35	,'�e�me'	),
(	35	,'Dikili'	),
(	35	,'Fo�a'	),
(	35	,'Karaburun'	),
(	35	,'Kar��yaka'	),
(	35	,'Kemalpa�a / �zmir'	),
(	35	,'K�n�k'	),
(	35	,'Kiraz'	),
(	35	,'Menemen'	),
(	35	,'�demi�'	),
(	35	,'Seferihisar'	),
(	35	,'Sel�uk'	),
(	35	,'Tire'	),
(	35	,'Torbal�'	),
(	35	,'Urla'	),
(	35	,'Beyda�'	),
(	35	,'Buca'	),
(	35	,'Konak'	),
(	35	,'Menderes'	),
(	35	,'Bal�ova'	),
(	35	,'�i�li'	),
(	35	,'Gaziemir'	),
(	35	,'Narl�dere'	),
(	35	,'G�zelbah�e'	),
(	35	,'Bayrakl�'	),
(	35	,'Karaba�lar'	),
(	36	,'Arpa�ay'	),
(	36	,'Digor'	),
(	36	,'Ka��zman'	),
(	36	,'Kars Merkez'	),
(	36	,'Sar�kam��'	),
(	36	,'Selim'	),
(	36	,'Susuz'	),
(	36	,'Akyaka'	),
(	37	,'Abana'	),
(	37	,'Ara�'	),
(	37	,'Azdavay'	),
(	37	,'Bozkurt / Kastamonu'	),
(	37	,'Cide'	),
(	37	,'�atalzeytin'	),
(	37	,'Daday'	),
(	37	,'Devrekani'	),
(	37	,'�nebolu'	),
(	37	,'Kastamonu Merkez'	),
(	37	,'K�re'	),
(	37	,'Ta�k�pr�'	),
(	37	,'Tosya'	),
(	37	,'�hsangazi'	),
(	37	,'P�narba�� / Kastamonu'	),
(	37	,'�enpazar'	),
(	37	,'A�l�'	),
(	37	,'Do�anyurt'	),
(	37	,'Han�n�'	),
(	37	,'Seydiler'	),
(	38	,'B�nyan'	),
(	38	,'Develi'	),
(	38	,'Felahiye'	),
(	38	,'�ncesu'	),
(	38	,'P�narba�� / Kayseri'	),
(	38	,'Sar�o�lan'	),
(	38	,'Sar�z'	),
(	38	,'Tomarza'	),
(	38	,'Yahyal�'	),
(	38	,'Ye�ilhisar'	),
(	38	,'Akk��la'	),
(	38	,'Talas'	),
(	38	,'Kocasinan'	),
(	38	,'Melikgazi'	),
(	38	,'Hac�lar'	),
(	38	,'�zvatan'	),
(	39	,'Babaeski'	),
(	39	,'Demirk�y'	),
(	39	,'K�rklareli Merkez'	),
(	39	,'Kof�az'	),
(	39	,'L�leburgaz'	),
(	39	,'Pehlivank�y'	),
(	39	,'P�narhisar'	),
(	39	,'Vize'	),
(	40	,'�i�ekda��'	),
(	40	,'Kaman'	),
(	40	,'K�r�ehir Merkez'	),
(	40	,'Mucur'	),
(	40	,'Akp�nar'	),
(	40	,'Ak�akent'	),
(	40	,'Boztepe'	),
(	41	,'Gebze'	),
(	41	,'G�lc�k'	),
(	41	,'Kand�ra'	),
(	41	,'Karam�rsel'	),
(	41	,'K�rfez'	),
(	41	,'Derince'	),
(	41	,'Ba�iskele'	),
(	41	,'�ay�rova'	),
(	41	,'Dar�ca'	),
(	41	,'Dilovas�'	),
(	41	,'�zmit'	),
(	41	,'Kartepe'	),
(	42	,'Ak�ehir'	),
(	42	,'Bey�ehir'	),
(	42	,'Bozk�r'	),
(	42	,'Cihanbeyli'	),
(	42	,'�umra'	),
(	42	,'Do�anhisar'	),
(	42	,'Ere�li / Konya'	),
(	42	,'Hadim'	),
(	42	,'Ilg�n'	),
(	42	,'Kad�nhan�'	),
(	42	,'Karap�nar'	),
(	42	,'Kulu'	),
(	42	,'Saray�n�'	),
(	42	,'Seydi�ehir'	),
(	42	,'Yunak'	),
(	42	,'Ak�ren'	),
(	42	,'Alt�nekin'	),
(	42	,'Derebucak'	),
(	42	,'H�y�k'	),
(	42	,'Karatay'	),
(	42	,'Meram'	),
(	42	,'Sel�uklu'	),
(	42	,'Ta�kent'	),
(	42	,'Ah�rl�'	),
(	42	,'�eltik'	),
(	42	,'Derbent'	),
(	42	,'Emirgazi'	),
(	42	,'G�neys�n�r'	),
(	42	,'Halkap�nar'	),
(	42	,'Tuzluk�u'	),
(	42	,'Yal�h�y�k'	),
(	43	,'Alt�nta�'	),
(	43	,'Domani�'	),
(	43	,'Emet'	),
(	43	,'Gediz'	),
(	43	,'K�tahya Merkez'	),
(	43	,'Simav'	),
(	43	,'Tav�anl�'	),
(	43	,'Aslanapa'	),
(	43	,'Dumlup�nar'	),
(	43	,'Hisarc�k'	),
(	43	,'�aphane'	),
(	43	,'�avdarhisar'	),
(	43	,'Pazarlar'	),
(	44	,'Ak�ada�'	),
(	44	,'Arapgir'	),
(	44	,'Arguvan'	),
(	44	,'Darende'	),
(	44	,'Do�an�ehir'	),
(	44	,'Hekimhan'	),
(	44	,'P�t�rge'	),
(	44	,'Ye�ilyurt / Malatya'	),
(	44	,'Battalgazi'	),
(	44	,'Do�anyol'	),
(	44	,'Kale / Malatya'	),
(	44	,'Kuluncak'	),
(	44	,'Yaz�han'	),
(	45	,'Akhisar'	),
(	45	,'Ala�ehir'	),
(	45	,'Demirci'	),
(	45	,'G�rdes'	),
(	45	,'K�rka�a�'	),
(	45	,'Kula'	),
(	45	,'Salihli'	),
(	45	,'Sar�g�l'	),
(	45	,'Saruhanl�'	),
(	45	,'Selendi'	),
(	45	,'Soma'	),
(	45	,'Turgutlu'	),
(	45	,'Ahmetli'	),
(	45	,'G�lmarmara'	),
(	45	,'K�pr�ba�� / Manisa'	),
(	45	,'�ehzadeler'	),
(	45	,'Yunusemre'	),
(	46	,'Af�in'	),
(	46	,'And�r�n'	),
(	46	,'Elbistan'	),
(	46	,'G�ksun'	),
(	46	,'Pazarc�k'	),
(	46	,'T�rko�lu'	),
(	46	,'�a�layancerit'	),
(	46	,'Ekin�z�'	),
(	46	,'Nurhak'	),
(	46	,'Dulkadiro�lu'	),
(	46	,'Oniki�ubat'	),
(	47	,'Derik'	),
(	47	,'K�z�ltepe'	),
(	47	,'Maz�da��'	),
(	47	,'Midyat'	),
(	47	,'Nusaybin'	),
(	47	,'�merli'	),
(	47	,'Savur'	),
(	47	,'Darge�it'	),
(	47	,'Ye�illi'	),
(	47	,'Artuklu'	),
(	48	,'Bodrum'	),
(	48	,'Dat�a'	),
(	48	,'Fethiye'	),
(	48	,'K�yce�iz'	),
(	48	,'Marmaris'	),
(	48	,'Milas'	),
(	48	,'Ula'	),
(	48	,'Yata�an'	),
(	48	,'Dalaman'	),
(	48	,'Ortaca'	),
(	48	,'Kavakl�dere'	),
(	48	,'Mente�e'	),
(	48	,'Seydikemer'	),
(	49	,'Bulan�k'	),
(	49	,'Malazgirt'	),
(	49	,'Mu� Merkez'	),
(	49	,'Varto'	),
(	49	,'Hask�y'	),
(	49	,'Korkut'	),
(	50	,'Avanos'	),
(	50	,'Derinkuyu'	),
(	50	,'G�l�ehir'	),
(	50	,'Hac�bekta�'	),
(	50	,'Kozakl�'	),
(	50	,'Nev�ehir Merkez'	),
(	50	,'�rg�p'	),
(	50	,'Ac�g�l'	),
(	51	,'Bor'	),
(	51	,'�amard�'	),
(	51	,'Ni�de Merkez'	),
(	51	,'Uluk��la'	),
(	51	,'Altunhisar'	),
(	51	,'�iftlik'	),
(	52	,'Akku�'	),
(	52	,'Aybast�'	),
(	52	,'Fatsa'	),
(	52	,'G�lk�y'	),
(	52	,'Korgan'	),
(	52	,'Kumru'	),
(	52	,'Mesudiye'	),
(	52	,'Per�embe'	),
(	52	,'Ulubey / Ordu'	),
(	52	,'�nye'	),
(	52	,'G�lyal�'	),
(	52	,'G�rgentepe'	),
(	52	,'�ama�'	),
(	52	,'�atalp�nar'	),
(	52	,'�ayba��'	),
(	52	,'�kizce'	),
(	52	,'Kabad�z'	),
(	52	,'Kabata�'	),
(	52	,'Alt�nordu'	),
(	53	,'Arde�en'	),
(	53	,'�aml�hem�in'	),
(	53	,'�ayeli'	),
(	53	,'F�nd�kl�'	),
(	53	,'�kizdere'	),
(	53	,'Kalkandere'	),
(	53	,'Pazar / Rize'	),
(	53	,'Rize Merkez'	),
(	53	,'G�neysu'	),
(	53	,'Derepazar�'	),
(	53	,'Hem�in'	),
(	53	,'�yidere'	),
(	54	,'Akyaz�'	),
(	54	,'Geyve'	),
(	54	,'Hendek'	),
(	54	,'Karasu'	),
(	54	,'Kaynarca'	),
(	54	,'Sapanca'	),
(	54	,'Kocaali'	),
(	54	,'Pamukova'	),
(	54	,'Tarakl�'	),
(	54	,'Ferizli'	),
(	54	,'Karap�r�ek'	),
(	54	,'S���tl�'	),
(	54	,'Adapazar�'	),
(	54	,'Arifiye'	),
(	54	,'Erenler'	),
(	54	,'Serdivan'	),
(	55	,'Ala�am'	),
(	55	,'Bafra'	),
(	55	,'�ar�amba'	),
(	55	,'Havza'	),
(	55	,'Kavak'	),
(	55	,'Ladik'	),
(	55	,'Terme'	),
(	55	,'Vezirk�pr�'	),
(	55	,'Asarc�k'	),
(	55	,'19.May'	),
(	55	,'Sal�pazar�'	),
(	55	,'Tekkek�y'	),
(	55	,'Ayvac�k / Samsun'	),
(	55	,'Yakakent'	),
(	55	,'Atakum'	),
(	55	,'Canik'	),
(	55	,'�lkad�m'	),
(	56	,'Baykan'	),
(	56	,'Eruh'	),
(	56	,'Kurtalan'	),
(	56	,'Pervari'	),
(	56	,'Siirt Merkez'	),
(	56	,'�irvan'	),
(	56	,'Tillo'	),
(	57	,'Ayanc�k'	),
(	57	,'Boyabat'	),
(	57	,'Dura�an'	),
(	57	,'Erfelek'	),
(	57	,'Gerze'	),
(	57	,'Sinop Merkez'	),
(	57	,'T�rkeli'	),
(	57	,'Dikmen'	),
(	57	,'Sarayd�z�'	),
(	58	,'Divri�i'	),
(	58	,'Gemerek'	),
(	58	,'G�r�n'	),
(	58	,'Hafik'	),
(	58	,'�mranl�'	),
(	58	,'Kangal'	),
(	58	,'Koyulhisar'	),
(	58	,'Sivas Merkez'	),
(	58	,'Su�ehri'	),
(	58	,'�ark��la'	),
(	58	,'Y�ld�zeli'	),
(	58	,'Zara'	),
(	58	,'Ak�nc�lar'	),
(	58	,'Alt�nyayla / Sivas'	),
(	58	,'Do�an�ar'	),
(	58	,'G�lova'	),
(	58	,'Ula�'	),
(	59	,'�erkezk�y'	),
(	59	,'�orlu'	),
(	59	,'Hayrabolu'	),
(	59	,'Malkara'	),
(	59	,'Muratl�'	),
(	59	,'Saray / Tekirda�'	),
(	59	,'�ark�y'	),
(	59	,'Marmaraere�lisi'	),
(	59	,'Ergene'	),
(	59	,'Kapakl�'	),
(	59	,'S�leymanpa�a'	),
(	60	,'Almus'	),
(	60	,'Artova'	),
(	60	,'Erbaa'	),
(	60	,'Niksar'	),
(	60	,'Re�adiye'	),
(	60	,'Tokat Merkez'	),
(	60	,'Turhal'	),
(	60	,'Zile'	),
(	60	,'Pazar / Tokat'	),
(	60	,'Ye�ilyurt / Tokat'	),
(	60	,'Ba��iftlik'	),
(	60	,'Sulusaray'	),
(	61	,'Ak�aabat'	),
(	61	,'Arakl�'	),
(	61	,'Arsin'	),
(	61	,'�aykara'	),
(	61	,'Ma�ka'	),
(	61	,'Of'	),
(	61	,'S�rmene'	),
(	61	,'Tonya'	),
(	61	,'Vakf�kebir'	),
(	61	,'Yomra'	),
(	61	,'Be�ikd�z�'	),
(	61	,'�alpazar�'	),
(	61	,'�ar��ba��'	),
(	61	,'Dernekpazar�'	),
(	61	,'D�zk�y'	),
(	61	,'Hayrat'	),
(	61	,'K�pr�ba�� / Trabzon'	),
(	61	,'Ortahisar'	),
(	62	,'�emi�gezek'	),
(	62	,'Hozat'	),
(	62	,'Mazgirt'	),
(	62	,'Naz�miye'	),
(	62	,'Ovac�k / Tunceli'	),
(	62	,'Pertek'	),
(	62	,'P�l�m�r'	),
(	62	,'Tunceli Merkez'	),
(	63	,'Ak�akale'	),
(	63	,'Birecik'	),
(	63	,'Bozova'	),
(	63	,'Ceylanp�nar'	),
(	63	,'Halfeti'	),
(	63	,'Hilvan'	),
(	63	,'Siverek'	),
(	63	,'Suru�'	),
(	63	,'Viran�ehir'	),
(	63	,'Harran'	),
(	63	,'Eyy�biye'	),
(	63	,'Haliliye'	),
(	63	,'Karak�pr�'	),
(	64	,'Banaz'	),
(	64	,'E�me'	),
(	64	,'Karahall�'	),
(	64	,'Sivasl�'	),
(	64	,'Ulubey / U�ak'	),
(	64	,'U�ak Merkez'	),
(	65	,'Ba�kale'	),
(	65	,'�atak'	),
(	65	,'Erci�'	),
(	65	,'Geva�'	),
(	65	,'G�rp�nar'	),
(	65	,'Muradiye'	),
(	65	,'�zalp'	),
(	65	,'Bah�esaray'	),
(	65	,'�ald�ran'	),
(	65	,'Edremit / Van'	),
(	65	,'Saray / Van'	),
(	65	,'�pekyolu'	),
(	65	,'Tu�ba'	),
(	66	,'Akda�madeni'	),
(	66	,'Bo�azl�yan'	),
(	66	,'�ay�ralan'	),
(	66	,'�ekerek'	),
(	66	,'Sar�kaya'	),
(	66	,'Sorgun'	),
(	66	,'�efaatli'	),
(	66	,'Yerk�y'	),
(	66	,'Yozgat Merkez'	),
(	66	,'Ayd�nc�k / Yozgat'	),
(	66	,'�and�r'	),
(	66	,'Kad��ehri'	),
(	66	,'Saraykent'	),
(	66	,'Yenifak�l�'	),
(	67	,'�aycuma'	),
(	67	,'Devrek'	),
(	67	,'Ere�li / Zonguldak'	),
(	67	,'Zonguldak Merkez'	),
(	67	,'Alapl�'	),
(	67	,'G�k�ebey'	),
(	67	,'Kilimli'	),
(	67	,'Kozlu'	),
(	68	,'Aksaray Merkez'	),
(	68	,'Ortak�y / Aksaray'	),
(	68	,'A�a��ren'	),
(	68	,'G�zelyurt'	),
(	68	,'Sar�yah�i'	),
(	68	,'Eskil'	),
(	68	,'G�la�a�'	),
(	69	,'Bayburt Merkez'	),
(	69	,'Ayd�ntepe'	),
(	69	,'Demir�z�'	),
(	70	,'Ermenek'	),
(	70	,'Karaman Merkez'	),
(	70	,'Ayranc�'	),
(	70	,'Kaz�mkarabekir'	),
(	70	,'Ba�yayla'	),
(	70	,'Sar�veliler'	),
(	71	,'Delice'	),
(	71	,'Keskin'	),
(	71	,'K�r�kkale Merkez'	),
(	71	,'Sulakyurt'	),
(	71	,'Bah�ili'	),
(	71	,'Bal��eyh'	),
(	71	,'�elebi'	),
(	71	,'Karake�ili'	),
(	71	,'Yah�ihan'	),
(	72	,'Batman Merkez'	),
(	72	,'Be�iri'	),
(	72	,'Gerc��'	),
(	72	,'Kozluk'	),
(	72	,'Sason'	),
(	72	,'Hasankeyf'	),
(	73	,'Beyt���ebap'	),
(	73	,'Cizre'	),
(	73	,'�dil'	),
(	73	,'Silopi'	),
(	73	,'��rnak Merkez'	),
(	73	,'Uludere'	),
(	73	,'G��l�konak'	),
(	74	,'Bart�n Merkez'	),
(	74	,'Kuruca�ile'	),
(	74	,'Ulus'	),
(	74	,'Amasra'	),
(	75	,'Ardahan Merkez'	),
(	75	,'��ld�r'	),
(	75	,'G�le'	),
(	75	,'Hanak'	),
(	75	,'Posof'	),
(	75	,'Damal'	),
(	76	,'Aral�k'	),
(	76	,'I�d�r Merkez'	),
(	76	,'Tuzluca'	),
(	76	,'Karakoyunlu'	),
(	77	,'Yalova Merkez'	),
(	77	,'Alt�nova'	),
(	77	,'Armutlu'	),
(	77	,'��narc�k'	),
(	77	,'�iftlikk�y'	),
(	77	,'Termal'	),
(	78	,'Eflani'	),
(	78	,'Eskipazar'	),
(	78	,'Karab�k Merkez'	),
(	78	,'Ovac�k / Karab�k'	),
(	78	,'Safranbolu'	),
(	78	,'Yenice / Karab�k'	),
(	79	,'Kilis Merkez'	),
(	79	,'Elbeyli'	),
(	79	,'Musabeyli'	),
(	79	,'Polateli'	),
(	80	,'Bah�e'	),
(	80	,'Kadirli'	),
(	80	,'Osmaniye Merkez'	),
(	80	,'D�zi�i'	),
(	80	,'Hasanbeyli'	),
(	80	,'Sumbas'	),
(	80	,'Toprakkale'	),
(	81	,'Ak�akoca'	),
(	81	,'D�zce Merkez'	),
(	81	,'Y���lca'	),
(	81	,'Cumayeri'	),
(	81	,'G�lyaka'	),
(	81	,'�ilimli'	),
(	81	,'G�m��ova'	),
(	81	,'Kayna�l�'	)







CREATE TABLE ProjeVeIller
(
    ProjeId INT,
	IlId INT,
	FOREIGN KEY (ProjeID) REFERENCES  Proje(ProjeID),
	FOREIGN KEY (IlId) REFERENCES  Il(IlId)
)

INSERT INTO Proje(ProjeAd,BaslamaTarihi,BitisTarihi) VALUES
('FullStack - Yaz�l�mc� Geli�tirme','2025-01-07','2025-08-07'),
('Back-End - Yaz�l�mc� Gelistirme','2025-01-07','2025-08-07'),
('Front-End - Yaz�l�mc� Gelistirme','2025-01-07','2025-08-07'),
('Dev-Opps - Yaz�l�mc� Gelistirme','2025-01-07','2025-08-07'),
('Database - Yaz�l�mc� Gelistirme','2025-01-07','2025-08-07'),
('Yapay Zeka - Yaz�l�mc� Gelistirme','2025-01-07','2025-08-07'),
('Robotik - Yaz�l�mc� Gelistirme','2025-01-07','2025-08-07'),
('G�m�l� - Yaz�l�mc� Gelistirme','2025-01-07','2025-08-07'),
('Mobil - Yaz�l�mc� Gelistirme','2025-01-07','2025-08-07'),
('IOS - Yaz�l�mc� Gelistirme','2025-01-07','2025-08-07')

INSERT INTO Personel([PersonelTC],[PersonelAdi],[Cinsiyet],[DogumTarihi],[DogumYeri],[BaslamaTarihi],[BirimNo],[UnvanNo],[Maas],[Prim],[ProjeId]) VALUES
('31236720195','Atakan','Erkek','1995-01-05','Ankara','2020-06-06',   1,1,10000,0,2),
('36324242334','Mustafa','Erkek','1990-01-05','�stanbul','2020-06-06',1,1,10000,0,4),
('85452342345','G�k�ehan','Erkek','1985-01-05','Ankara','2020-06-06' ,2,3,10000,0,5),
('12352323442','Aykut','Erkek','1958-01-05','Ankara','2020-06-06'    ,4,3,10000,0,1),
('12462342344','Hasret','Kad�n','2000-01-05','�stanbul','2020-06-06' ,2,5,10000,0,1),
('12345234234','Ege','Erkek','1992-01-05','Ankara','2020-06-06'      ,5,6,10000,0,3),
('12341251232','Baran','Erkek','2010-01-05','Ankara','2020-06-06'    ,2,7,10000,0,9),
('53235234234','O�uz','Erkek','2000-01-05','�zmir','2020-06-06'      ,1,8,10000,0,8),
('75365645645','Fatih','Erkek','1996-01-05','Ankara','2020-06-06'    ,3,9,11000,1,8),
('23423523434','Kaan','Erkek','1994-01-05','Mara�','2020-06-06'      ,2,7,12000,2,8),
('12312312312','Can','Erkek','1910-01-05','Ankara','2020-06-06'      ,5,8,10000,0,7)



ALTER TABLE Personel
ADD FOREIGN KEY (UnvanNo) REFERENCES Unvan(UnvanId)


ALTER TABLE Personel
ADD FOREIGN KEY (BirimNo) REFERENCES Birim(BirimId)

ALTER TABLE Personel
ADD ProjeId INT FOREIGN KEY (ProjeId) REFERENCES Proje(ProjeId) 

INSERT INTO ProjeVeIller(IlId,ProjeId) VALUES
(1,2),
(1,6),
(1,9),
(6,1),
(6,5),
(6,7),
(6,9),
(6,2),
(6,3),
(6,4),
(34,1),
(34,2),
(34,3),
(34,4),
(34,5),
(34,6),
(34,7),
(34,8),
(34,9),
(35,1),
(35,2),
(35,4),
(35,8),
(61,1),
(61,3),
(61,7),
(55,4),
(55,6)








