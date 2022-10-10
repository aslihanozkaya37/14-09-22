CREATE DATABASE MyThirdDB ON PRIMARY
(
--Name Un�que olmal�d�r.LOgical Name anlam�na gelmektedir.
NAME=MyThirdDB_Data, 
--Filaname dosyayolumuzdur.dosyam�z�n uzant�s� mdf olacakt�r.
FILENAME='C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\MyThirdDBData.mdf',
--Size veritaban�n�n ilk boyutudur.
SIZE=8MB,
--Veritaban�n�n en fazla ula�abilece�i boyutuda maxsize �zerinden k�s�tlayabilirz.
MAXSIZE=10MB,
--Veritaban�n�n son boyutudur.
FILEGROWTH=10%
--yeterli alan kalmad���nda veritaban�n geni�leme miktar�n�da filegrowth ile belirliyoruz.


)
LOG ON
(
NAME=MyThirdDB_Log, 
FILENAME='C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\MyThirdDBLog.ldf',
SIZE=1MB,
MAXSIZE=10MB,
FILEGROWTH=10%

)