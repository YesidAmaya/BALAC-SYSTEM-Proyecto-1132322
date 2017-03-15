create database CoffeeOnline;
use CoffeeOnline;
create table Cliente
( 
idcliente int auto_increment not null,
identificacion varchar(20) not null,
Nombrecliente Varchar(35) not null,
Telefono varchar(21) not null,
Direccion varchar(30) not null,
primary key (idcliente)
);
LOAD DATA local INFILE 'C:/DATOS/Cliente.txt'
INTO TABLE  Cliente
FIELDS TERMINATED BY ','
LINES TERMINATED BY '\r\n'
IGNORE 1 LINES ( identificacion, Nombrecliente, Telefono, Direccion);


create table Proveedor
( 
idproveedor int auto_increment not null,
DocumentoId varchar(20) not null,
Nombre Varchar(30) not null,
Direccion varchar(30) not null,
Telefono varchar(21) not null,
primary key (idproveedor)
);
LOAD DATA local INFILE 'C:/DATOS/Proveedor.txt'
INTO TABLE  Proveedor
FIELDS TERMINATED BY ','
LINES TERMINATED BY '\r\n'
IGNORE 1 LINES ( DocumentoId,  Nombre, Direccion, Telefono);


create table Presentacion
( 
idPresentacion int not null,
Nombre Varchar(45) not null,
primary key (idPresentacion)
);
LOAD DATA local INFILE 'C:/DATOS/Presentacion.txt'
INTO TABLE  Presentacion
FIELDS TERMINATED BY ','
LINES TERMINATED BY '\r\n'
IGNORE 1 LINES (idPresentacion, Nombre);


create table Venta
( 
idventa int auto_increment not null,
Cantvendida int not null,
Fechaventa date not null,
idcliente int not null,
idPresentacion int not null,

primary key (idventa),
foreign key (idcliente) references Cliente,
foreign key (idPresentacion) references Presentacion
);
LOAD DATA local INFILE 'C:/DATOS/Venta.txt'
INTO TABLE  Venta
FIELDS TERMINATED BY ','
LINES TERMINATED BY '\r\n'
IGNORE 1 LINES (Cantvendida, Fechaventa, idcliente);



create table Materiaprima
( 
idmateria int auto_increment not null,
clasificacion Varchar(45) not null,
Fechaingreso date not null,
Cantmateriaprima int not null,
Costo double not null,
idproveedor int not null,
primary key (idmateria),
foreign key (idproveedor) references Proveedor
);
LOAD DATA local INFILE 'C:/DATOS/Materiaprima.txt'
INTO TABLE  Materiaprima
FIELDS TERMINATED BY ','
LINES TERMINATED BY '\r\n'
IGNORE 1 LINES (clasificacion, Fechaingreso, Cantmateriaprima,Costo,idproveedor);


create table Producto
( 
Lote int not null,
FechaVencimineto date not null,
Fechafabricacion date not null,
Cantunidades varchar(45) not null,
idPresentacion int not null,
primary key (Lote),
foreign key (idPresentacion) references Presentacion
);
LOAD DATA local INFILE 'C:/DATOS/Producto.txt'
INTO TABLE  Producto
FIELDS TERMINATED BY ','
LINES TERMINATED BY '\r\n'
IGNORE 1 LINES (Lote, FechaVencimineto, Fechafabricacion, Cantunidades, idPresentacion);