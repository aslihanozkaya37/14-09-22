
--CREATE KOMUTU �LE TABLO SEGMENT� VE �ST SEGMENTLERDE OLU�TURMA ��LEM� GER�EKLE�T�R�L�R.DATA KATMANINDAK� OLU�TURMA KOMUTU �NSERT �KEN BU KATMANDA BUNU CREATE �LE GER�EKLE�T�RMEKTEY�Z
CREATE TABLE Ilceler
(
ID int IDENTITY(1,1)PRIMARY KEY NOT NULL,
IlceAdi varchar (50)
)

--TABLO VE �ST SEGMENTLERDE (database segmenti gibi ,function,trigger,store procedure gibi) g�ncelle�tirme i�lemi yapabilmemiz i�in alter komutunu kullanmaktay�z.data segmentinde bu i�lemi update komutu ile yapaca��z.)
ALTER TABLE Ilceler
ADD IlceMerkezi varchar(50)
---Add komutu ile s�tun ekleme i�lemi ger�ekle�tirdik.

ALTER TABLE Ilceler
ADD Email varchar(50)

ALTER TABLE Ilceler
DROP COLUMN Email --DROP COLUMN S�LMEK �STED���M�Z S�TUNUN S�L�NMES� ��LEM�N� GER�EKLE�T�R�YORUZ.YAN� DATA KATMANINDAK� DELETE  KOMUTUNA KAR�ILIK GELMEKTED�R.

ALTER TABLE Ilceler
ALTER COLUMN Email varchar(30)

ALTER TABLE Ilceler
Alter column Email int
----Alter column diyerek ilgili s�tunun veri tipi �zerinde de�ii�iklik hakk�m�z bulunmaktad�r.fakat rename i�lemi i�in store procedure gereklili�i bulunmaktad�r.

Select *
From Projeler

--DML �RNEKLER�--
--data katman�nda tablomuza veri eklemek i�in insert komutunu kullanmatay�z.�nce insert into <tabload�< girerek parantez a��p (<kolonadi1<,<kolonadi2<,....) �eklinde hangi tablonun hangi kolonlar�na ver, girece�imizi belirtiyoruz.tabi buralarda nullable'l�k durumu �nemlidir.sonra values diyip parantez a�arak s�ras�yla �ncesinde tan�mlam�� oldu�umuz s�tunlara de�erlerimizi at�yoruz.
INSERT INTO Projeler(ProjeAdi,Adres,SehirID)
Values('Kanyon Avm','Levent',34)
--DATA �ZER�NDE DE����KL�K G�NCELLEME MOD�F�YE ��LEMLER�N�N GER�EKLE�T�R�L�B�LMES� ���N UPDATE KOMUTUNU KULLANMAKTAYIZ.BU KOMUTUN KULLANIMI ���N B�ZE HANG� SATIRDA DE����KL�K GER�EKLE�T�RECE��M�Z� BEL�RTEN B�R UN�QUE DE�ER TUTUCUYA �HT�YA� DUYMAKTAYIZ.GENELDE BU ��LEM IDLER �ZER�NDEN GER�EKLE�T�R�RL�R.KULLANIM�EKL� UPDATE<TABLOAD�< SET<DE���T�RMEK �STED���M�Z DATANIN BULUNDU�U S�TUN< =<YEN� DE�ER< WHERE <�ARTISA�LAYANS�TUNADI<=<�ARTDE�ER�<
UPDATE PROJELER
SET ProjeAdi='KANYON AVM',SehirID=35,Adres='MENEMEN'
WHERE ProjeID=4
--WHERE KOMUTU UPDATE ��LEM�N�N YAPILMASI ���N GEREKL� DE��LD�R.FAKAT WHERE KULLANILMADAN B�R UPDATE ��LEM� GER�EKLE�T�R�LD���NDE 
UPDATE Projeler
SET Adres ='MALTEPE'

INSERT INTO Projeler(ProjeAdi,Adres,SehirID)
Values('Forum �stanbul','Bayrampa�a',34,'2021-12-12')
---delete i�leminin ger�ekle�mesi i�in e�erki ili�kili tablolar var ise �oklu silmi ii�lemi ger�ekle�mez.�nce ili�kileri ay�rmak gerekir.fakat tekli sat�r silmekte problem bulunmaz.bu durumdada bize yine unique de�er verebilecek bir s�tun �zerinden where kullanarak ilgili �art� yaz�p o sat�r�n silinmesini sa�layabiliriz.
Delete 
From Projeler
Where ProjeID=6

CREATE TABLE BOSBELES
(ID int identity(1,1) primary key,
BosbelesSutun varchar(50)

)
---drop table komutu ile tabl�yu sildik.
Drop Table BOSBELES
