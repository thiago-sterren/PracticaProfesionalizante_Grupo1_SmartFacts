select * from Admins
create table Admins
( id int IDENTITY(1,1) PRIMARY KEY,
  nombre nvarchar(50),
  apellido nvarchar(50),
  usuario nvarchar(50),
  contrasenia nvarchar(50),
  salario float)
insert into Admins values ('Thiago', 'Sterren', 'thiagoadm', 'thiagosterren123', 120000)
insert into Admins values ('Fabrizio', 'Failla', 'fabrizioadm', 'fabriziofailla123', 100000)
insert into Admins values ('Santiago', 'Gutierrez', 'gutiadm', 'guti123', 120000)
insert into Admins values ('Alan', 'Ferri', 'alansitoadm', 'ferrigol123', 120000)
create table Clientes
( id int IDENTITY(1,1) PRIMARY KEY,
  nombre nvarchar(50),
  apellido nvarchar(50),
  contrasenia nvarchar(50),
  usuario nvarchar(50))
create table CelularNuevo
()
