CREATE DATABASE MyThirdDB ON PRIMARY
(
--Name Unýque olmalýdýr.LOgical Name anlamýna gelmektedir.
NAME=MyThirdDB_Data, 
--Filaname dosyayolumuzdur.dosyamýzýn uzantýsý mdf olacaktýr.
FILENAME='C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\MyThirdDBData.mdf',
--Size veritabanýnýn ilk boyutudur.
SIZE=8MB,
--Veritabanýnýn en fazla ulaþabileceði boyutuda maxsize üzerinden kýsýtlayabilirz.
MAXSIZE=10MB,
--Veritabanýnýn son boyutudur.
FILEGROWTH=10%
--yeterli alan kalmadýðýnda veritabanýn geniþleme miktarýnýda filegrowth ile belirliyoruz.


)
LOG ON
(
NAME=MyThirdDB_Log, 
FILENAME='C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\MyThirdDBLog.ldf',
SIZE=1MB,
MAXSIZE=10MB,
FILEGROWTH=10%

)