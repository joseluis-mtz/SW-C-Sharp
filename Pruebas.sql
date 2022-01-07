use evaluacion
go

select * from Productos
go

select * from Ventas
go

-- Ventas por artículo
select Titulo as [Título], Descripcion as [Descripción], CantidadVendida as [Cantidad vendida] from Productos INNER JOIN Ventas ON Productos.IDProductos = Ventas.IDVentas where Titulo Like '%Cloralex%'
go

-- Ventas globales
select Titulo as [Título], Descripcion as [Descripción], CantidadVendida as [Cantidad vendida] from Productos INNER JOIN Ventas ON Productos.IDProductos = Ventas.IDVentas
GO

-- Mas vendidos
select top 5 Titulo as [Título], Descripcion as [Descripción], CantidadVendida as [Cantidad vendida] from Productos INNER JOIN Ventas ON Productos.IDProductos = Ventas.IDVentas Order By CantidadVendida DESC
go

-- Productos existentes
select Titulo, Descripcion, Existencias from Productos where Existencias > 0
go

-- Notificacion
select Titulo, Existencias from Productos where Existencias < 100
go