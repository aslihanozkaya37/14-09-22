--instead of trigger
--insert update delete gibi komutlarýmýzý yine kullanýyoruz fakat burada demek istediðimiz þu oluyor insert yerine þunu yap,ya da delete yapýlmak istendiðinde bunu yap gibi

CREATE TRIGGER InsteadOfSilmeOrnek1
ON Employees
INSTEAD OF DELETE
AS
DECLARE @PName varchar(50),@PSurname varchar(50)
Select @PName=FirstName ,@PSurname=LastName From deleted
Insert into RecordTable (RecordDescription) VALUES ('Adý: '+@PName+'Soyadý:'+@PSurname+'olan personel silinmeye çalýþýldý.')

DELETE FROM Employees WHERE EmployeeID=13
select * from RecordTable
--belli bir kiþi silinemeyip istediðimiz kiþiyi silebilmek adýna yazacaðýmýz trigger modeli

CREATE TRIGGER BilimSil
On Personeller
After Delete
As
Declare @PersonelAdi varchar(50)
Select @PersonelAdi=PersonelAdi From Deleted
If @PersonelAdi='Bilim'
BEGIN
RAISERROR('BÝLÝM SÝLÝNEMEZ!',0,0)
ROLLBACK
END

DELETE FROM Personeller where PersonelAdi='Bilim'
--erkekleri kayýt etmeyip kýzlarý kayýt eden program.
CREATE TRIGGER ErkekKayýt
On Personeller
After insert
As

If (EXISTS (SELECT* FROM inserted where Cinsiyet=1 ))
BEGIN
RAISERROR('Erkek personel kaydý engellenmiþtir',0,0)
ROLLBACK
END


INSERT INTO Personeller (PersonelAdi,PersonelSoyadi,Cinsiyet)
Values('Kemal Emre','Erol',1)

Create trigger Silineyemeyen
On Personeller
After Update
As

If (EXISTS(Select * From inserted,deleted where inserted.PersonelID=deleted.PersonelID and inserted.Cinsiyet!=deleted.Cinsiyet    ))
BEGIN
RAISERROR('Güncellenemez',0,0)
ROLLBACK
END

UPDATE Personeller SET Cinsiyet =1 where PersonelID=1