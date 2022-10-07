CREATE DATABASE Permisosusuarios;
CREATE TABLE usuarios(
idusuario INT PRIMARY KEY AUTO_INCREMENT,
nombre VARCHAR(100),
apellidop VARCHAR(100),
apellidom VARCHAR(100),
fechanacimiento VARCHAR(13),
rfc VARCHAR(13));

CREATE TABLE ModuloRefaccion(
codigobarras BIGINT PRIMARY KEY,
nombre VARCHAR(100),
descripcion VARCHAR(200),
marca VARCHAR(100));

CREATE TABLE modulotaller(
codigoherramientas BIGINT PRIMARY KEY,
nombre VARCHAR(100),
medida VARCHAR(100),
marca VARCHAR(100),
descripcion VARCHAR(200));

CREATE TABLE PermisosRefaccion(
FKidusuario INT,
FKcodigobarras BIGINT,
FOREIGN KEY(FKidusuario) REFERENCES usuarios(idusuario),
FOREIGN KEY(FKcodigobarras) REFERENCES modulorefaccion(codigobarras),
PRIMARY KEY (FKidusuario,FKcodigobarras),
lectura BOOL,
escritura BOOL,
eliminacion BOOL,
actualizacion BOOL);

