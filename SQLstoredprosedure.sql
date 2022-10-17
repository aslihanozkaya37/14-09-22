USE [NORTHWND]Adres
GO
/****** Object:  StoredProcedure [dbo].[NORTHWND]    Script Date: 17.10.2022 14:17:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[NORTHWND]
AS
SELECT * FROM NORTHWND
GO;

CREATE PROCEDURE dbo.supp
(@CompanyName nvarchar(40),@ContactName nvarchar(30),@ContactTitle nvarchar(30),@Adress nvarchar(60),@City nvarchar(15),@Region nvarchar(15),@PostalCode nvarchar(10),@Country nvarchar(15),@Phone nvarchar(24),@Fax nvarchar(24))
As
Begin
Insert into Suppliers(CompanyName,ContactName,ContactTitle,Address,City,Region,PostalCode,Country,Phone,Fax)
Values(@CompanyName,@ContactName,@ContactTitle,@Adress,@City,@Region,@PostalCode,@Country,@Phone,@Fax)
END
EXEC dbo.supp 'BAŞKENTLER','MERHABA','BE','JHFJHG','KXDF','SHCFKZD','6565','AVUSTRULYA','63563','KSUDZ'

