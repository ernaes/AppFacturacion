create database db_facturacion;-- crea la base de datos

use db_facturacion; -- usar/seleccionar la base de datos

--crea tabla clientes
create table cliente(
    id int not null auto_increment primary key,
    rfc varchar(20),
    nombre varchar(255),
    apellido_paterno varchar(255),
    apellido_materno varchar(255)
);

create table factura(
    id int not null auto_increment primary key,
    fecha_facturacion date,
    cliente_id int,
    FOREIGN KEY(cliente_id) REFERENCES cliente(id)
);