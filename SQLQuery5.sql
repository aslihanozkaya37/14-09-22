----sql function

--Fonksiyonlar istenen de�er tipinde geri d�n�� sa�layabilen sql kodlar�d�r.
--Differences between stored procedures and funct�ons:
--Fonksiyonlar her zaman geriye bir de�er d�nd�r�r(say�lar,string ifadeler,tablolar vs.)fakat stored procedureler geriye bir de�er d�nd�rebilir yada d�nd�remez
--fonksiyonlarda giri� i�in parametreler verilir,stored procedulerde hem giri� hem ��k�� i�in parametreler verilebilmektedir.
--fonksiyonlar stored procedurler taraf�ndan �al��t�r�labilir fakat spler fonksiyonlar i�inde �al��t�r�lamaz.
---fonksiyonlar i�erisinde crud i�lemleri yap�lamaz.sadece select ifadesi i�in kullan�labilir.sp i�erisinde �nceki �rneklerimizdeki gibi b�t�n select/insert/update/delete i�lemleri yap�labilmektedir.
--try catch yap�s� spde yap�labilirken fonksiyonlarda ge�erlili�i yoktur.
--pr�nt ifadeleri sp'de ge�erliyken fonksiyonlarda ge�erli de�ildir.
--fonksiyonlar ile d�nd�rm�� oldu�umuz bir tabloyu join ifadesi i�erisinde kullanabilirsiniz.fakat stored procedure ile d�d�rd���m�z bir tabloda bu i�lem ger�ekle�mez.


----fonksiyon �e�itleri
--geriye sabit de�er d�nd�renler
--geriye sorgu d�nd�renler
--geriye tablo de�i�keni d�nd�renler

--genelde geriye tablo d�nd�rmek ii�in function kullanmak imkan dahilinde olsada �ok �erilmemektedir.
--��nk� performans� etkilemektedir.bu i�lemler i�in spler yada vievler tercih edilmektedir.

--syntax �u �ekildedir.
--create function functionismi(@param1 datatype ,@param2 datatype)
--Returns returntype
--AS
--BEGIN
--SQL DE�ERLER�
--END

--�rnek olarak int de�er alan tablo d�nd�ren bir function yazal�m.
CREATE FUNCTION fn_SelectFunction
(@sayi int)
RETURNS TABLE
AS
RETURN

Select *From Products Where UnitsInStock<=@sayi

SELECT * FROM fn_SelectFunction(40)
ORDER BY ProductName

--B�R �RNEKDE DE�ER D�ND�REN FUNCTIONLAR �ZER�NDEN YAPALIM

CREATE FUNCTION fn_MakeFullName
(@isim varchar(50),@soyisim varchar(50))
RETURNS varchar(50)
as
begin
return @isim+' '+@soyisim
end

select dbo.fn_MakeFullName('barb','ciga')

SELECT FirstName,LastName,dbo.fn_MakeFullName (FirstName,LastName)as FullName
From Employees

--�r�n fiyat� kullan�c�n�n girdi�i de�er aras�nda�r�nleri listeyen bir fonksiyon yazal�m
CREATE FUNCTION dbo.fn_Product
(@sayi1 int,@sayi2 int)
RETURNS TABLE
AS
RETURN
SELECT * FROM Products where UnitPrice<@sayi1 and UnitPrice>@sayi2

SELECT * FROM dbo.fn_Product(60,25)
ORDER BY ProductName

