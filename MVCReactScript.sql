USE master ;  
GO  
DROP DATABASE ReactMVC ;  
GO  

CREATE DATABASE ReactMVC;

USE ReactMVC;

CREATE TABLE Empleado (
    IdEmpleado INT IDENTITY(1,1) PRIMARY KEY,
    Nombre NVARCHAR(50),
    Correo NVARCHAR(100),
    Direccion NVARCHAR(100),
    Telefono NVARCHAR(50)
);

SELECT * FROM Empleado;
INSERT INTO Empleado (Nombre, Correo, Direccion, Telefono) values('Miguel', 'migueram_5@hotmail.com', 'Calle 1', '4281000000');


