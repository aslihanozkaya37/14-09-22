
--CREATE KOMUTU ÝLE TABLO SEGMENTÝ VE ÜST SEGMENTLERDE OLUÞTURMA ÝÞLEMÝ GERÇEKLEÞTÝRÝLÝR.DATA KATMANINDAKÝ OLUÞTURMA KOMUTU ÝNSERT ÝKEN BU KATMANDA BUNU CREATE ÝLE GERÇEKLEÞTÝRMEKTEYÝZ
CREATE TABLE Ilceler
(
ID int IDENTITY(1,1)PRIMARY KEY NOT NULL,
IlceAdi varchar (50)
)

--TABLO VE ÜST SEGMENTLERDE (database segmenti gibi ,function,trigger,store procedure gibi) güncelleþtirme iþlemi yapabilmemiz için alter komutunu kullanmaktayýz.data segmentinde bu iþlemi update komutu ile yapacaðýz.)
ALTER TABLE Ilceler
ADD IlceMerkezi varchar(50)
---Add komutu ile sütun ekleme iþlemi gerçekleþtirdik.

ALTER TABLE Ilceler
ADD Email varchar(50)

ALTER TABLE Ilceler
DROP COLUMN Email --DROP COLUMN SÝLMEK ÝSTEDÝÐÝMÝZ SÜTUNUN SÝLÝNMESÝ ÝÞLEMÝNÝ GERÇEKLEÞTÝRÝYORUZ.YANÝ DATA KATMANINDAKÝ DELETE  KOMUTUNA KARÞILIK GELMEKTEDÝR.

ALTER TABLE Ilceler
ALTER COLUMN Email varchar(30)

ALTER TABLE Ilceler
Alter column Email int
----Alter column diyerek ilgili sütunun veri tipi üzerinde deðiiþiklik hakkýmýz bulunmaktadýr.fakat rename iþlemi için store procedure gerekliliði bulunmaktadýr.

Select *
From Projeler

--DML ÖRNEKLERÝ--
--data katmanýnda tablomuza veri eklemek için insert komutunu kullanmatayýz.önce insert into <tabloadý< girerek parantez açýp (<kolonadi1<,<kolonadi2<,....) þeklinde hangi tablonun hangi kolonlarýna ver, gireceðimizi belirtiyoruz.tabi buralarda nullable'lýk durumu önemlidir.sonra values diyip parantez açarak sýrasýyla öncesinde tanýmlamýþ olduðumuz sütunlara deðerlerimizi atýyoruz.
INSERT INTO Projeler(ProjeAdi,Adres,SehirID)
Values('Kanyon Avm','Levent',34)
--DATA ÜZERÝNDE DEÐÝÞÝKLÝK GÜNCELLEME MODÝFÝYE ÝÞLEMLERÝNÝN GERÇEKLEÞTÝRÝLÝBÝLMESÝ ÝÇÝN UPDATE KOMUTUNU KULLANMAKTAYIZ.BU KOMUTUN KULLANIMI ÝÇÝN BÝZE HANGÝ SATIRDA DEÐÝÞÝKLÝK GERÇEKLEÞTÝRECEÐÝMÝZÝ BELÝRTEN BÝR UNÝQUE DEÐER TUTUCUYA ÝHTÝYAÇ DUYMAKTAYIZ.GENELDE BU ÝÞLEM IDLER ÜZERÝNDEN GERÇEKLEÞTÝRÝRLÝR.KULLANIMÞEKLÝ UPDATE<TABLOADÝ< SET<DEÐÝÞTÝRMEK ÝSTEDÝÐÝMÝZ DATANIN BULUNDUÐU SÜTUN< =<YENÝ DEÐER< WHERE <ÞARTISAÐLAYANSÜTUNADI<=<ÞARTDEÐERÝ<
UPDATE PROJELER
SET ProjeAdi='KANYON AVM',SehirID=35,Adres='MENEMEN'
WHERE ProjeID=4
--WHERE KOMUTU UPDATE ÝÞLEMÝNÝN YAPILMASI ÝÇÝN GEREKLÝ DEÐÝLDÝR.FAKAT WHERE KULLANILMADAN BÝR UPDATE ÝÞLEMÝ GERÇEKLEÞTÝRÝLDÝÐÝNDE 
UPDATE Projeler
SET Adres ='MALTEPE'

INSERT INTO Projeler(ProjeAdi,Adres,SehirID)
Values('Forum Ýstanbul','Bayrampaþa',34,'2021-12-12')
---delete iþleminin gerçekleþmesi için eðerki iliþkili tablolar var ise çoklu silmi iiþlemi gerçekleþmez.önce iliþkileri ayýrmak gerekir.fakat tekli satýr silmekte problem bulunmaz.bu durumdada bize yine unique deðer verebilecek bir sütun üzerinden where kullanarak ilgili þartý yazýp o satýrýn silinmesini saðlayabiliriz.
Delete 
From Projeler
Where ProjeID=6

CREATE TABLE BOSBELES
(ID int identity(1,1) primary key,
BosbelesSutun varchar(50)

)
---drop table komutu ile tablýyu sildik.
Drop Table BOSBELES
