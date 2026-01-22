USE TestDB;
GO

IF NOT EXISTS (
    SELECT 1
    FROM sys.tables
    WHERE name = 'TestTable_a'
)
BEGIN
    CREATE TABLE TestTable_a (
        Id INT IDENTITY(1,1) PRIMARY KEY,
        Name NVARCHAR(100),
        CreatedDate DATETIME DEFAULT GETDATE()
    );
END;
GO
