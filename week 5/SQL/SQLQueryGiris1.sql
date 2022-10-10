CREATE DATABASE MyThirdDB ON PRIMARY
(
--Name Unıque olmalıdır.LOgical Name anlamına gelmektedir.
NAME=MyThirdDB_Data, 
--Filaname dosyayolumuzdur.dosyamızın uzantısı mdf olacaktır.
FILENAME='C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\MyThirdDBData.mdf',
--Size veritabanının ilk boyutudur.
SIZE=8MB,
--Veritabanının en fazla ulaşabileceği boyutuda maxsize üzerinden kısıtlayabilirz.
MAXSIZE=10MB,
--Veritabanının son boyutudur.
FILEGROWTH=10%
--yeterli alan kalmadığında veritabanın genişleme miktarınıda filegrowth ile belirliyoruz.


)
LOG ON
(
NAME=MyThirdDB_Log, 
FILENAME='C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\MyThirdDBLog.ldf',
SIZE=1MB,
MAXSIZE=10MB,
FILEGROWTH=10%

)