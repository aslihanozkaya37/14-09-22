--Trigger'lar
--T�RK�ES� TET�KLEY�C� OLARAK GE�EN YAPPILANDIR VE BEL�RL� ANLAMLARDA STORE PROCEDURED'lere benzemektedirler
--her d�zeyde triggerlar bulunmaktad�r ama genel olarak yap�lan i�lemler DML TRIGGERLAR Seviyesinde yap�lmaktad�r.
--dml triggerlar bir tabloda insert,update veya delete i�lemleri ger�ekle�ti�inde devreye girerler.
--�rne�in bir tabloda insert i�lemi ger�ekle�ti�inde ram bellek �zerinde gge�ici bir inserted tablosu olu�turulur.
--e�er bu insert i�lemi soorunsuzsa "inserted"tablosundski bu veriler ger�ek tabloya insert edilir.
--e�er bir tabloda delete i�lemi ger�ekle�iyorsa yine ayn� �ekile de ram bellek �zerinde ge�ici bir"deleted"
--tablosunda veriler tutulur.E�erki bu ttransaction 'da bir hata yoksa ger�ek tablodan veri silinir.
--E�erki bir tabloda update i�lemi ger�ekle�tiriyorsa uptated ad�nda ge�ici bir tablo olu�turulmaz.
--yani �zet olarak trigerlar belirli bir olay maydana geldi�inde yada gelmeden �nce otomatik olarak isted�imiz �ekilde �al��an �zel yap�lard�r.
--2 �e�it trigger kullan�m� bulunmaktad�r.
--Birincisi olay ger�ekle�tikten sonra olacaklar� tasarlamak �zere (after trigger)
--Di�er olay�n ger�ekle�mesi yerine �u i�lemi ger�ekle�tir �eklinde.(instead of trigger)

--syntax
--CREATE TR�GGER -TR�GGER AD�
--ON--�slem Yap�lan Tablo
--AFTER//FOR --Hangi i�lemden sonra olaca��n� belirtiyoruz.�rne�in delete yada update yada insert gibi
--AS
--KOD BLOKLARI

CREATE TRIGGER UyariVer
On Personeller
After Delete
As
Print 'Bir adet personel silinmi�tir.'

Select*From Personeller
Delete 
From Personeller
Where PersonelID=2

Create Trigger FiyatEkle
On Products
After Insert
AS
Print 'Bir adet �r�n eklenmi�tir.'
Update Products
Set UnitPrice=UnitPrice+50


Select*From Products

Insert into 
Products(ProductName)
Values('�orum Mam�lleri')

Alter Trigger G�ncelleme1
On Suppliers
After Update 
As
Insert into 
Products(ProductName)
Values ('Mahmut Bey �oraplar�')

Update Suppliers
Set CompanyName='Asl�han'
Where SupplierID='1'
--Ram bellekte olu�an ge�ici tablolar� kullanmak �zerine �rnek

CREATE TABLE RecordTable
(
RecordId int primary key Identity (1,1),
RecordDescription varchar(100)

)
Alter TRIGGER RecordTrigger
On Employees
After Delete 
As
Declare @EmployeeName varchar(50),@EmployeeSurname varchar(50)
Select @EmployeeName=FirstName ,@EmployeeSurname=LastName
From deleted
Insert RecordTable (RecordDescription ) 
VALUES ('ismi'+@EmployeeName+'olan ve soyismi '+@EmployeeSurName+'olan kullan�c�'+CONVERT(varchar(50),getdate())+'tarihinde silinmi�tir.')

Delete From Employees where EmployeeID=15
Select *from RecordTable
--personel tablosunda isim ve soyismi g�ncelleneen personelin isminin �nceki hali ve sonraki halini log tablomuzda kaydeden 

Alter Trigger RecordTrigger2
on Employees
After Update
As
Declare @EmployeeName varchar(10),@AfterEmployeeName varchar(10)
Select  @EmployeeName=FirstName From deleted
Select @AfterEmployeeName=FirstName from inserted
Insert RecordTable(RecordDescription)
Values ('Ad� :'+@EmployeeName+'olan kullan�c�n�n eski ad�'+@AfterEmployeeName +'OLARAK G�NCELLENM��T�R.')

Update Employees set FirstName='asl�han' where EmployeeID=16

Select *From RecordTable



