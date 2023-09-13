use Smart_Facts
create table Productos (
id_producto INT IDENTITY(1,1) PRIMARY KEY,
marca_producto nvarchar(50),
nombre_producto nvarchar(50),
stock INT,
precio float,
almacenamiento float)
insert into Productos values ('Apple', 'Iphone 11', 10, 500, 128)
use Smart_Facts
select * from Productos