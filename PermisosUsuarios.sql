CREATE DATABASE Permisosusuarios;
CREATE TABLE usuarios(
idusuario INT PRIMARY KEY AUTO_INCREMENT,
nombre VARCHAR(100),
apellidop VARCHAR(100),
apellidom VARCHAR(100),
fechanacimiento VARCHAR(13),
rfc VARCHAR(13));
CREATE TABLE ModuloRefaccion(
codigobarras VARCHAR(100) PRIMARY KEY,
nombre VARCHAR(100),
descripcion VARCHAR(200),
marca VARCHAR(100));
CREATE TABLE ModuloTaller(
codigoherramientas VARCHAR(100) PRIMARY KEY,
nombre VARCHAR(100),
medida VARCHAR(100),
marca VARCHAR(100),
descripcion VARCHAR(200));
