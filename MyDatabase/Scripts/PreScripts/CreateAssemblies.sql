
ALTER DATABASE MyDatabase
SET TRUSTWORTHY ON
GO

USE [$(DatabaseName)]
GO

sp_configure 'show advanced options', 1;  
GO  
RECONFIGURE;  
GO  
sp_configure 'clr enabled', 1;  
GO  
RECONFIGURE;  
GO  

