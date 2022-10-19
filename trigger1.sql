--Trigger'lar
--TÜRKÇESÝ TETÝKLEYÝCÝ OLARAK GEÇEN YAPPILANDIR VE BELÝRLÝ ANLAMLARDA STORE PROCEDURED'lere benzemektedirler
--her düzeyde triggerlar bulunmaktadýr ama genel olarak yapýlan iþlemler DML TRIGGERLAR Seviyesinde yapýlmaktadýr.
--dml triggerlar bir tabloda insert,update veya delete iþlemleri gerçekleþtiðinde devreye girerler.
--örneðin bir tabloda insert iþlemi gerçekleþtiðinde ram bellek üzerinde ggeçici bir inserted tablosu oluþturulur.
--eðer bu insert iþlemi soorunsuzsa "inserted"tablosundski bu veriler gerçek tabloya insert edilir.
--eðer bir tabloda delete iþlemi gerçekleþiyorsa yine ayný þekile de ram bellek üzerinde geçici bir"deleted"
--tablosunda veriler tutulur.Eðerki bu ttransaction 'da bir hata yoksa gerçek tablodan veri silinir.
--Eðerki bir tabloda update iþlemi gerçekleþtiriyorsa uptated adýnda geçici bir tablo oluþturulmaz.
--yani özet olarak trigerlar belirli bir olay maydana geldiðinde yada gelmeden önce otomatik olarak istedðimiz þekilde çalýþan özel yapýlardýr.
--2 çeþit trigger kullanýmý bulunmaktadýr.
--Birincisi olay gerçekleþtikten sonra olacaklarý tasarlamak üzere (after trigger)
--Diðer olayýn gerçekleþmesi yerine þu iþlemi gerçekleþtir þeklinde.(instead of trigger)

--syntax
--CREATE TRÝGGER -TRÝGGER ADÝ
--ON--Ýslem Yapýlan Tablo
--AFTER//FOR --Hangi iþlemden sonra olacaðýný belirtiyoruz.örneðin delete yada update yada insert gibi
--AS
--KOD BLOKLARI

CREATE TRIGGER UyariVer
On Personeller
After Delete
As
Print 'Bir adet personel silinmiþtir.'

Select*From Personeller
Delete 
From Personeller
Where PersonelID=2

Create Trigger FiyatEkle
On Products
After Insert
AS
Print 'Bir adet ürün eklenmiþtir.'
Update Products
Set UnitPrice=UnitPrice+50


Select*From Products

Insert into 
Products(ProductName)
Values('Çorum Mamülleri')

Alter Trigger Güncelleme1
On Suppliers
After Update 
As
Insert into 
Products(ProductName)
Values ('Mahmut Bey Çoraplarý')

Update Suppliers
Set CompanyName='Aslýhan'
Where SupplierID='1'
--Ram bellekte oluþan geçici tablolarý kullanmak üzerine örnek

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
VALUES ('ismi'+@EmployeeName+'olan ve soyismi '+@EmployeeSurName+'olan kullanýcý'+CONVERT(varchar(50),getdate())+'tarihinde silinmiþtir.')

Delete From Employees where EmployeeID=15
Select *from RecordTable
--personel tablosunda isim ve soyismi güncelleneen personelin isminin önceki hali ve sonraki halini log tablomuzda kaydeden 

Alter Trigger RecordTrigger2
on Employees
After Update
As
Declare @EmployeeName varchar(10),@AfterEmployeeName varchar(10)
Select  @EmployeeName=FirstName From deleted
Select @AfterEmployeeName=FirstName from inserted
Insert RecordTable(RecordDescription)
Values ('Adý :'+@EmployeeName+'olan kullanýcýnýn eski adý'+@AfterEmployeeName +'OLARAK GÜNCELLENMÝÞTÝR.')

Update Employees set FirstName='aslýhan' where EmployeeID=16

Select *From RecordTable



