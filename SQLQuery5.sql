----sql function

--Fonksiyonlar istenen deðer tipinde geri dönüþ saðlayabilen sql kodlarýdýr.
--Differences between stored procedures and functýons:
--Fonksiyonlar her zaman geriye bir deðer döndürür(sayýlar,string ifadeler,tablolar vs.)fakat stored procedureler geriye bir deðer döndürebilir yada döndüremez
--fonksiyonlarda giriþ için parametreler verilir,stored procedulerde hem giriþ hem çýkýþ için parametreler verilebilmektedir.
--fonksiyonlar stored procedurler tarafýndan çalýþtýrýlabilir fakat spler fonksiyonlar içinde çalýþtýrýlamaz.
---fonksiyonlar içerisinde crud iþlemleri yapýlamaz.sadece select ifadesi için kullanýlabilir.sp içerisinde önceki örneklerimizdeki gibi bütün select/insert/update/delete iþlemleri yapýlabilmektedir.
--try catch yapýsý spde yapýlabilirken fonksiyonlarda geçerliliði yoktur.
--prýnt ifadeleri sp'de geçerliyken fonksiyonlarda geçerli deðildir.
--fonksiyonlar ile döndürmüþ olduðumuz bir tabloyu join ifadesi içerisinde kullanabilirsiniz.fakat stored procedure ile dödürdüðümüz bir tabloda bu iþlem gerçekleþmez.


----fonksiyon çeþitleri
--geriye sabit deðer döndürenler
--geriye sorgu döndürenler
--geriye tablo deðiþkeni döndürenler

--genelde geriye tablo döndürmek iiçin function kullanmak imkan dahilinde olsada çok öerilmemektedir.
--çünkü performansý etkilemektedir.bu iþlemler için spler yada vievler tercih edilmektedir.

--syntax þu þekildedir.
--create function functionismi(@param1 datatype ,@param2 datatype)
--Returns returntype
--AS
--BEGIN
--SQL DEÐERLERÝ
--END

--Örnek olarak int deðer alan tablo döndüren bir function yazalým.
CREATE FUNCTION fn_SelectFunction
(@sayi int)
RETURNS TABLE
AS
RETURN

Select *From Products Where UnitsInStock<=@sayi

SELECT * FROM fn_SelectFunction(40)
ORDER BY ProductName

--BÝR ÖRNEKDE DEÐER DÖNDÜREN FUNCTIONLAR ÜZERÝNDEN YAPALIM

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

--ürün fiyatý kullanýcýnýn girdiði deðer arasýndaürünleri listeyen bir fonksiyon yazalým
CREATE FUNCTION dbo.fn_Product
(@sayi1 int,@sayi2 int)
RETURNS TABLE
AS
RETURN
SELECT * FROM Products where UnitPrice<@sayi1 and UnitPrice>@sayi2

SELECT * FROM dbo.fn_Product(60,25)
ORDER BY ProductName

