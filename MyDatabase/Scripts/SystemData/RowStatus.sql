USE [$(DatabaseName)]
GO

IF(NOT EXISTS(SELECT 1 FROM RowStatus WHERE Id = 0))
INSERT INTO RowStatus 
VALUES(0, 'Unknown', 'Unknown');
GO

IF(NOT EXISTS(SELECT 1 FROM RowStatus WHERE Id = 1))
INSERT INTO RowStatus 
VALUES(1, 'Active', 'Active');
GO

IF(NOT EXISTS(SELECT 1 FROM RowStatus WHERE Id = 2))
INSERT INTO RowStatus 
VALUES(2, 'Inactive', 'Inactive');
GO

IF(NOT EXISTS(SELECT 1 FROM RowStatus WHERE Id = 3))
INSERT INTO RowStatus 
VALUES(3, 'Deleted', 'Deleted');
GO