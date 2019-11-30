/********* ESPECIFICACION DE LA BASE DE DATOS QUE SE VA A USAR *********/
USE GD2C2019


/********* SE CREA EL ESESQUEMA *********/


if(not exists(select * from INFORMATION_SCHEMA.SCHEMATA where SCHEMA_NAME = 'LOS_BORBOTONES'))
  begin
      exec ('CREATE SCHEMA[LOS_BORBOTONES] AUTHORIZATION [gdCupon2019]');
      print 'exquema creado';
    end


/***************************************/
/********* CREACION DE TABLAS *********/
/*************************************/

/***TABLA PROVEEDOR***/

IF OBJECT_ID ('LOS_BORBOTONES.Proveedor', 'U') IS NOT NULL  
   DROP TABLE LOS_BORBOTONES.Proveedor;  
GO
create table LOS_BORBOTONES.Proveedor
(Provee_RS nvarchar(100),
Provee_Dom nvarchar(100),
Provee_Ciudad nvarchar(255),
Provee_Telefono numeric(18, 0),
Provee_CUIT nvarchar(20) NOT NULL,
Provee_Rubro nvarchar(100),
Provee_Mail nvarchar(255),
Provee_Cod_postal nvarchar(10),
Provee_Nombre_Contacto nvarchar(255),
User_name nvarchar(50)
);

/***TABLA ROL_USUARIO***/
IF OBJECT_ID ('LOS_BORBOTONES.Rol_Usuario', 'U') IS NOT NULL  
   DROP TABLE LOS_BORBOTONES.Rol_Usuario;  
GO
create table LOS_BORBOTONES.Rol_Usuario
(User_name nvarchar(50) NOT NULL,
Rol_Id INT NOT NULL,
Habilitado bit DEFAULT(1)
);

/***TABLA ROLE***/
IF OBJECT_ID ('LOS_BORBOTONES.Role', 'U') IS NOT NULL  
   DROP TABLE LOS_BORBOTONES.Role;  
GO
create table LOS_BORBOTONES.Role
(Rol_Id  int IDENTITY NOT NULL,
Rol_Nombre nvarchar(255),
Habilitado bit DEFAULT(1)
);

/***TABLA FUNC_ROL***/
IF OBJECT_ID ('LOS_BORBOTONES.Func_Rol', 'U') IS NOT NULL  
   DROP TABLE LOS_BORBOTONES.Func_Rol;  
GO
Create table LOS_BORBOTONES.Func_Rol
(Rol_Id int NOT NULL,
Func_Id int NOT NULL,
Habilitado bit DEFAULT(1)
);

/***TABLA FUNCIONALIDAD***/

IF OBJECT_ID ('LOS_BORBOTONES.Funcionalidad', 'U') IS NOT NULL  
   DROP TABLE LOS_BORBOTONES.Funcionalidad;  
GO
Create table LOS_BORBOTONES.Funcionalidad
(Func_Id int IDENTITY NOT NULL,
Func_Nombre nvarchar(255)
);

/***TABLA CARGA***/

IF OBJECT_ID ('LOS_BORBOTONES.Carga', 'U') IS NOT NULL  
   DROP TABLE LOS_BORBOTONES.Carga;  
GO
create table LOS_BORBOTONES.Carga
(Carga_Id int IDENTITY NOT NULL,
Cli_Dni numeric(18, 0) NOT NULL,
Carga_Credito numeric(18, 2) NOT NULL,
Carga_Fecha datetime NOT NULL,
Tipo_Pago_Id int NOT NULL, 
Datos_Tarjeta nvarchar(255)
);

/***TABLA TIPO DE PAGO***/

IF OBJECT_ID ('LOS_BORBOTONES.TipoDePago', 'U') IS NOT NULL  
   DROP TABLE LOS_BORBOTONES.TipoDePago;  
GO
create table LOS_BORBOTONES.TipoDePago
(Tipo_Pago_Id int IDENTITY NOT NULL,
Tipo_Pago_Desc nvarchar(100)
);

/***TABLA CUPON***/

IF OBJECT_ID ('LOS_BORBOTONES.Cupon', 'U') IS NOT NULL  
   DROP TABLE LOS_BORBOTONES.Cupon;  
GO
create table LOS_BORBOTONES.Cupon
(Cupon_Id int IDENTITY NOT NULL,
Oferta_Codigo nvarchar(50),
Cli_Dni numeric(18, 0),
Cant_Comprada numeric(18, 0) DEFAULT(1),
Cli_Dest_Nombre nvarchar(255),
Cli_Dest_Apellido nvarchar(255),
Cli_Dest_Dni numeric(18, 0),
Cli_Dest_Direccion nvarchar(255),
Cli_Dest_Telefono numeric(18, 0),
Cli_Dest_Mail nvarchar(255),
Cli_Dest_Fecha_Nac datetime,
Cli_Dest_Ciudad nvarchar(255),
Oferta_Fecha_Compra datetime,
Oferta_Entregado_Fecha datetime,
Oferta_Fecha_Venc datetime,
Factura_Nro numeric(18, 0)
);

/***TABLA FACTURA***/

IF OBJECT_ID ('LOS_BORBOTONES.Factura', 'U') IS NOT NULL  
   DROP TABLE LOS_BORBOTONES.Factura;  
GO
create table LOS_BORBOTONES.Factura
(Factura_Nro numeric(18, 0) NOT NULL IDENTITY,
Factura_Fecha datetime,
Factura_Importe numeric(18, 2),
Fecha_Desde datetime,
Fecha_Hasta datetime,
Provee_CUIT nvarchar(20)
);

/***TABLA OFERTA***/

IF OBJECT_ID ('LOS_BORBOTONES.Oferta', 'U') IS NOT NULL  
   DROP TABLE LOS_BORBOTONES.Oferta;  
GO
create table LOS_BORBOTONES.Oferta
(Oferta_Codigo nvarchar(50) NOT NULL,
Oferta_Precio numeric(18, 2),
Oferta_Precio_Ficticio numeric(18, 2),
Oferta_Fecha datetime,
Oferta_Fecha_Venc datetime,
Oferta_Cantidad numeric(18, 0),
Oferta_Cantidad_Compra numeric(18, 0),
Oferta_Descripcion nvarchar(255),
Provee_CUIT nvarchar(20)
);

/***TABLA USUARIO***/

IF OBJECT_ID ('LOS_BORBOTONES.Usuario', 'U') IS NOT NULL  
   DROP TABLE LOS_BORBOTONES.Usuario;  
GO
create table LOS_BORBOTONES.Usuario
(User_name nvarchar(50) NOT NULL,
Password varbinary(70) NOT NULL,
Habilitado bit DEFAULT(1)
);

/***TABLA CLIENTE***/

IF OBJECT_ID ('LOS_BORBOTONES.Cliente', 'U') IS NOT NULL  
   DROP TABLE LOS_BORBOTONES.Cliente;  
GO
create table LOS_BORBOTONES.Cliente
(Cli_Nombre nvarchar(255),
Cli_Apellido nvarchar(255),
Cli_Dni numeric(18, 0) NOT NULL,
Cli_Direccion nvarchar(255),
Cli_Telefono numeric(18, 0),
Cli_Mail nvarchar(255),
Cli_Fecha_Nac datetime,
Cli_Ciudad nvarchar(255),
Cli_CodigoPostal nvarchar(10),
User_name nvarchar(50),
Cli_Saldo numeric(18,2) default(0.0),
Habilitado bit DEFAULT(1)
);

/***************************************/
/********* MIGRACIÓN DE DATOS *********/
/*************************************/

/*** MIGRACION USUARIOS ***/

insert into LOS_BORBOTONES.Usuario (User_name, Password)
	select distinct  Cli_Dni, HASHBYTES('SHA2_256', CAST( (cast (Cli_Dni as nvarchar(70))) AS varbinary(70))) 
	from gd_esquema.Maestra

insert into LOS_BORBOTONES.Usuario (User_name, Password)
	select distinct  Provee_CUIT, HASHBYTES('SHA2_256', CAST( Provee_CUIT AS varbinary(70))) 
	from gd_esquema.Maestra
	where Provee_CUIT is not null
insert into LOS_BORBOTONES.Usuario(User_name, Password)
	values('admin', HASHBYTES('SHA2_256', CAST( cast('w23e' as nvarchar(20)) AS varbinary(70))))


/*** MIGRACION ROLE ***/

insert into LOS_BORBOTONES.Role (Rol_Nombre)
	values  ('Administrador General'), ('Cliente'), ('Proveedor')

/*** MIGRACION FUNCIONALIDAD ***/

insert into LOS_BORBOTONES.Funcionalidad (Func_Nombre)
	values ('Login y seguridad'), ('ABM de Rol'), ('Registro de Usuario'), ('ABM de Cliente'), ('ABM de Proveedor'), 
			('Cargar Crédito'), ('Comprar Oferta'), ('Confeccion y publicacion de Ofertas'), ('Facturacion a Proveedor'), 
			('Listado Estadistico')

/*** MIGRACION OFERTA ***/

insert into LOS_BORBOTONES.Oferta (Oferta_Codigo, Oferta_Precio, Oferta_Precio_Ficticio, 
			Oferta_Fecha, Oferta_Fecha_Venc, Oferta_Cantidad, Oferta_Descripcion, Provee_CUIT)
	select distinct Oferta_Codigo ,Oferta_Precio, Oferta_Precio_Ficticio, Oferta_Fecha, 
			Oferta_Fecha_Venc, Oferta_Cantidad, Oferta_Descripcion, Provee_CUIT 
			from gd_esquema.Maestra
			where Oferta_Codigo is not null 

/*** MIGRACION TIPO DE PAGO ***/

insert into LOS_BORBOTONES.TipoDePago (Tipo_Pago_Desc)
	select distinct Tipo_Pago_Desc 
	from gd_esquema.Maestra
	where Tipo_Pago_Desc is not null

/*** MIGRACION CARGA***/

insert into LOS_BORBOTONES.Carga (Cli_Dni, Carga_Credito, Carga_Fecha, Tipo_Pago_Id)
	select distinct Cli_Dni, Carga_Credito, Carga_Fecha, Tipo_Pago_Id 
		from gd_esquema.Maestra g join LOS_BORBOTONES.TipoDePago t 
		on (g.Tipo_Pago_Desc = t.Tipo_Pago_Desc)

/*** MIGRACION FACTURA ***/

SET IDENTITY_INSERT LOS_BORBOTONES.Factura ON;
insert into LOS_BORBOTONES.Factura
	(Factura_Nro, Factura_Fecha, Factura_Importe, Provee_CUIT, Fecha_Desde, Fecha_Hasta)
	select Factura_Nro, Factura_Fecha, SUM(Oferta_Cantidad*Oferta_Precio), Provee_CUIT, min(Oferta_Fecha_Compra), max(Oferta_Fecha_Compra)
	from gd_esquema.Maestra
	where Oferta_Fecha_Compra is not null AND Factura_Nro is not null
	group by Factura_Nro, Factura_Fecha, Provee_CUIT
	order by Factura_Nro
SET IDENTITY_INSERT LOS_BORBOTONES.Factura OFF;


/*** MIGRACION PROVEEDOR ***/

insert into LOS_BORBOTONES.Proveedor
	(Provee_RS, Provee_Dom, Provee_Ciudad, Provee_Telefono, Provee_CUIT,
		Provee_Rubro, User_name)
	select distinct Provee_RS, Provee_Dom, Provee_Ciudad, Provee_Telefono, Provee_CUIT,
		Provee_Rubro, Provee_CUIT
		from gd_esquema.Maestra
		where Provee_RS is not null

/*** MIGRACION CUPON ***/

insert into LOS_BORBOTONES.Cupon (
	Oferta_Codigo, Cli_Dni, Cli_Dest_Nombre, Cli_Dest_Apellido, Cli_Dest_Dni,
		Cli_Dest_Direccion, Cli_Dest_Telefono, Cli_Dest_Mail, Cli_Dest_Fecha_Nac,
		Cli_Dest_Ciudad, Oferta_Fecha_Compra, Oferta_Entregado_Fecha, Oferta_Fecha_Venc,
		Factura_Nro)
	Select distinct
		g1.Oferta_Codigo, g1.Cli_Dni, g1.Cli_Dest_Nombre, g1.Cli_Dest_Apellido, g1.Cli_Dest_Dni,
		g1.Cli_Dest_Direccion, g1.Cli_Dest_Telefono, g1.Cli_Dest_Mail, g1.Cli_Dest_Fecha_Nac,
		g1.Cli_Dest_Ciudad, g1.Oferta_Fecha_Compra, 
		(select g2.Oferta_Entregado_Fecha from gd_esquema.Maestra g2 
			where g1.Cli_Dni = g2.Cli_Dni and g1.Oferta_Codigo = g2.Oferta_Codigo 
					and g1.Oferta_Fecha_Compra = g2.Oferta_Fecha_Compra 
					and g2.Oferta_Entregado_Fecha is not null) Oferta_Entregado_Fecha, 
		Oferta_Fecha_Venc, 
		(select g2.Factura_Nro from gd_esquema.Maestra g2 
			where g1.Cli_Dni = g2.Cli_Dni and g1.Oferta_Codigo = g2.Oferta_Codigo 
			and g1.Oferta_Fecha_Compra = g2.Oferta_Fecha_Compra 
			and g2.Factura_Nro is not null) Factura_Nro
		from gd_esquema.Maestra g1
		where Oferta_Fecha_Compra is not null
		order by Cli_Dni, Oferta_Fecha_Compra
;

/*** MIGRACION CLIENTES ***/

insert into LOS_BORBOTONES.Cliente (Cli_Nombre, Cli_Apellido,Cli_Dni, Cli_Direccion, 
			Cli_Telefono, Cli_Mail, Cli_Fecha_Nac, Cli_Ciudad, User_name, Cli_Saldo)
	select  Cli_Nombre, Cli_Apellido, m.Cli_Dni, Cli_Direccion, Cli_Telefono, 
			Cli_Mail, Cli_Fecha_Nac, Cli_Ciudad, m.Cli_Dni, coalesce( (select sum(Carga_Credito) from LOS_BORBOTONES.Carga c where c.Cli_Dni =m.Cli_Dni ) - (select sum( c.Cant_Comprada*o.Oferta_Precio) from LOS_BORBOTONES.Cupon c join LOS_BORBOTONES.Oferta o on (c.Oferta_Codigo = o.Oferta_Codigo) where c.Cli_Dni = m.Cli_Dni),0)
	from gd_esquema.Maestra m
	group by Cli_Nombre, Cli_Apellido, m.Cli_Dni, Cli_Direccion, Cli_Telefono, 
			Cli_Mail, Cli_Fecha_Nac, Cli_Ciudad

/*** MIGRACION ROL_USUARIO ***/

insert into LOS_BORBOTONES.Rol_Usuario(User_name, Rol_Id)
	select User_name, 1 from LOS_BORBOTONES.Usuario
	where User_name = 'admin'

insert into LOS_BORBOTONES.Rol_Usuario (User_name,Rol_Id)
	select User_name, 2 
	from LOS_BORBOTONES.Cliente

insert into LOS_BORBOTONES.Rol_Usuario (User_name,Rol_Id)
	select User_name, 3 
	from LOS_BORBOTONES.Proveedor

/*** MIGRACION FUNC_ROL ***/

insert into LOS_BORBOTONES.Func_Rol (Rol_Id, Func_Id)
 values (1,1),(1,2),(1,3),(1,4),(1,5),(1,9),(1,10),(2,1),(2,6),(2,7),(3,1),(3,8)

GO
/******************************************/
/********* CREACION DE CONSTRAIN *********/
/****************************************/

/*
/*** PK Proveedor ***/
ALTER TABLE LOS_BORBOTONES.Proveedor
	ADD CONSTRAINT PK_Proveedor
	PRIMARY KEY (Provee_CUIT);

/*** PK Usuario ***/
ALTER TABLE LOS_BORBOTONES.Usuario
ADD CONSTRAINT PK_Usuario
PRIMARY KEY (User_name);

/*** PK Rol_Usuario ***/
ALTER TABLE LOS_BORBOTONES.Rol_Usuario
ADD CONSTRAINT PK_Rol_Usuario
PRIMARY KEY (User_name, Rol_Id);

/*** PK Role ***/
ALTER TABLE LOS_BORBOTONES.Role	
ADD CONSTRAINT PK_Rol
PRIMARY KEY (Rol_Id);

/*** PK Func_Rol ***/
ALTER TABLE LOS_BORBOTONES.Func_Rol
ADD CONSTRAINT PK_Func_Rol
PRIMARY KEY (Rol_id,Func_Id);

/*** PK Funcionalidad ***/
ALTER TABLE LOS_BORBOTONES.Funcionalidad
ADD CONSTRAINT PK_Funcionalidad
PRIMARY KEY (Func_Id);

/*** PK Carga ***/
ALTER TABLE LOS_BORBOTONES.Carga
ADD CONSTRAINT PK_Carga
PRIMARY KEY (Carga_Id);

/*** PK TipoDePago ***/
ALTER TABLE LOS_BORBOTONES.TipoDePago
ADD CONSTRAINT PK_TipoDePago
PRIMARY KEY (Tipo_Pago_Id);

/*** PK Cupon ***/
ALTER TABLE LOS_BORBOTONES.Cupon
ADD CONSTRAINT PK_Cupon
PRIMARY KEY (Cupon_Id);

/*** PK Factura ***/
ALTER TABLE LOS_BORBOTONES.Factura
ADD CONSTRAINT PK_Factura
PRIMARY KEY (Factura_Nro);
ALTER TABLE LOS_BORBOTONES.Factura
MODIFY Factura_Nro Numeric(18,0) Identity(153611,1)

/*** PK Oferta ***/
ALTER TABLE LOS_BORBOTONES.Oferta
ADD CONSTRAINT PK_Oferta
PRIMARY KEY (Oferta_Codigo);

/*** PK Cliente ***/
ALTER TABLE LOS_BORBOTONES.Cliente
ADD CONSTRAINT PK_Cliente
PRIMARY KEY (Cli_DNI);

/*** FK tabla Cliente ***/
ALTER TABLE LOS_BORBOTONES.Cliente
ADD CONSTRAINT FK_Cliente
FOREIGN KEY (user_name) REFERENCES LOS_BORBOTONES.Usuario(user_name);

/*** FK tabla Proveedor ***/
ALTER TABLE LOS_BORBOTONES.Proveedor
ADD CONSTRAINT FK_Proveedor
FOREIGN KEY (user_name) REFERENCES LOS_BORBOTONES.Usuario(user_name);

/*** FK tabla Carga ***/
ALTER TABLE LOS_BORBOTONES.Carga
ADD CONSTRAINT FK_Carga
FOREIGN KEY (Cli_Dni) REFERENCES LOS_BORBOTONES.Cliente(Cli_Dni);

/*** FK tabla Cupon ***/
ALTER TABLE LOS_BORBOTONES.Cupon
ADD CONSTRAINT FK_Cupon
FOREIGN KEY (Oferta_Codigo) REFERENCES LOS_BORBOTONES.Oferta(Oferta_Codigo),
FOREIGN KEY (Cli_Dni) REFERENCES LOS_BORBOTONES.Cliente(Cli_Dni),
FOREIGN KEY (Factura_Nro) REFERENCES LOS_BORBOTONES.Factura(Factura_Nro);
*/


/******************************************/
/********* CREACION DE VISTAS ************/
/****************************************/

/*
create view LOS_BORBOTONES.vistaLogin
as
select ro.Rol_Nombre from LOS_BORBOTONES.Usuario u join LOS_BORBOTONES.Rol_Usuario r on (u.User_name = r.User_name) join LOS_BORBOTONES.Role ro on (r.Rol_Id = ro.Rol_Id);
GO*/