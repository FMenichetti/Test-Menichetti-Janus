
--Uso Master
use master
GO

--Creación DB
CREATE DATABASE Test2;
GO

--Uso DB creada
use Test2;
GO

-- Script de creación de tabla de producto
CREATE TABLE Producto
(
    Id int IDENTITY(1,1) PRIMARY KEY  ,          -- ID autoincrementable
    IdTipoProducto INT ,               -- ID del tipo de producto
    Nombre VARCHAR (255),             -- Nombre del producto
    Precio DECIMAL(10, 2)       -- Precio del producto 
);
GO


-- Script de creación de tabla de TipoProducto

CREATE TABLE TipoProducto
(
    Id int Identity(1,1) Primary key,  -- ID autoincrementable
    Descripcion varchar(50),           -- Descripción de producto
);
GO


-- Script de creación de tabla de stock

CREATE TABLE Stock
(
    Id int Identity(1,1) Primary key,  -- ID autoincrementable
	IdProducto INT ,              --Id de producto
    Cantidad int,               -- Cantidad de producto
);
GO

--Modificacion de tabla producto

ALTER TABLE Producto   -- Se agrega FK a tabla producto
ADD CONSTRAINT IdTipo
FOREIGN KEY (IdTipoProducto) REFERENCES TipoProducto (Id);
GO

--Modificacion de tabla Stock

ALTER TABLE Stock     -- Se agrega FK a tabla stock
ADD CONSTRAINT IdProducto
FOREIGN KEY (IdProducto) REFERENCES Producto (Id);
GO


-- Creación de vista de Stock

Create VIEW vw_StockProducto
as
SELECT P.id, P.Nombre, T.Descripcion [Desc], P.Precio, S.Cantidad [Cant], T.id [IdTipo]
FROM Producto P
INNER JOIN Stock S ON P.Id = S.IdProducto
INNER JOIN TipoProducto T ON T.Id = P.IdTipoProducto;
GO

--Creación de Store Procedure sp_InsertarProducto

CREATE PROCEDURE sp_InsertarProducto
@idTipoProducto int,
@nombre varchar(50),
@precio decimal(10,2),
@cantidad int 
as
begin
insert into Producto values (@idTipoProducto, @nombre, @precio);
insert into Stock (IdProducto, Cantidad) values (SCOPE_IDENTITY(), @cantidad);
end
GO

--Creación de Store Procedure sp_ModificarProducto

Create PROCEDURE sp_ModificarProducto
@id int,
@idTipoProducto int,
@nombre varchar(50),
@precio decimal(10,2),
@cantidad int
as
begin 
update Producto set IdTipoProducto = @idTipoProducto, Nombre = @nombre, Precio = @precio 
Where Id = @id;
update Stock set Cantidad = @cantidad 
Where IdProducto = @id;
end
GO

--Creación de Store Procedure sp_EliminarProducto

Create PROCEDURE sp_EliminarProducto
@id int
as
begin
delete from Stock
where IdProducto = @id;
delete from Producto
Where Id = @id;
end
GO

--Insert de Tipos de Productos para ejemplo

INSERT INTO TipoProducto (Descripcion)
VALUES 
 ('Mecanico'),
 ('Electrico'),
 ('Libreria');
 GO

 --Insert de Productos para ejemplo

 INSERT INTO Producto (IdTipoProducto, Nombre, Precio)
VALUES 
(2,'Cables', 20500),
(3,'Lapicera', 10.50),
(1,'Engranaje', 25000),
(1,'Cadena', 14000);
GO

--Insert de Stock para ejemplo

insert into stock(IdProducto,Cantidad)
values 
(1, 5),
(2, 16),
(3, 4),
(4, 7);
GO