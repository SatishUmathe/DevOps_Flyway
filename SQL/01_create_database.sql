IF NOT EXISTS (
    SELECT 1
    FROM sys.databases
    WHERE name = 'TestDB'
)
BEGIN
    CREATE DATABASE TestDB;
END;
GO
