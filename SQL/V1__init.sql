IF NOT EXISTS (
    SELECT name 
    FROM sys.databases 
    WHERE name = N'DevopsTest'
)
BEGIN
    CREATE DATABASE [DevopsTest];
END;
