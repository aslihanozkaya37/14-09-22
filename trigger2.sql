--instead of trigger
--insert update delete gibi komutlar�m�z� yine kullan�yoruz fakat burada demek istedi�imiz �u oluyor insert yerine �unu yap,ya da delete yap�lmak istendi�inde bunu yap gibi

CREATE TRIGGER InsteadOfSilmeOrnek1
ON Employees
INSTEAD OF DELETE
AS
DECLARE @PName varchar(50),@PSurname varchar(50)
Select @PName=FirstName ,@PSurname=LastName From deleted
Insert into RecordTable (RecordDescription) VALUES ('Ad�: '+@PName+'Soyad�:'+@PSurname+'olan personel silinmeye �al���ld�.')

DELETE FROM Employees WHERE EmployeeID=13
select * from RecordTable
--belli bir ki�i silinemeyip istedi�imiz ki�iyi silebilmek ad�na yazaca��m�z trigger modeli

CREATE TRIGGER BilimSil
On Personeller
After Delete
As
Declare @PersonelAdi varchar(50)
Select @PersonelAdi=PersonelAdi From Deleted
If @PersonelAdi='Bilim'
BEGIN
RAISERROR('B�L�M S�L�NEMEZ!',0,0)
ROLLBACK
END

DELETE FROM Personeller where PersonelAdi='Bilim'
--erkekleri kay�t etmeyip k�zlar� kay�t eden program.
CREATE TRIGGER ErkekKay�t
On Personeller
After insert
As

If (EXISTS (SELECT* FROM inserted where Cinsiyet=1 ))
BEGIN
RAISERROR('Erkek personel kayd� engellenmi�tir',0,0)
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
RAISERROR('G�ncellenemez',0,0)
ROLLBACK
END

UPDATE Personeller SET Cinsiyet =1 where PersonelID=1