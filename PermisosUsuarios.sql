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

SELECT * FROM modulotaller;

CREATE TABLE modulotaller(
codigoherramientas BIGINT PRIMARY KEY,
nombre VARCHAR(100),
medida VARCHAR(100),
marca VARCHAR(100),
descripcion VARCHAR(200));

CREATE TABLE permisosrefaccion(
idp VARCHAR(100) PRIMARY KEY,
FKidusuario INT,
FOREIGN KEY(FKidusuario) REFERENCES usuarios(idusuario),
lectura BOOL,
escritura BOOL,
eliminacion BOOL,
actualizacion BOOL);

CREATE TABLE permisosTaller(
FKidusuario INT,
FKcodigoherramientas BIGINT,
FOREIGN KEY(FKidusuario) REFERENCES usuarios(idusuario),
FOREIGN KEY(FKcodigoherramientas) REFERENCES modulotaller(codigoherramientas),
PRIMARY KEY (FKidusuario,FKcodigoherramientas),
lectura BOOL,
escritura BOOL,
eliminacion BOOL,
actualizacion BOOL);


/*--------------------------------------PORCEDURE DE USUARIO--------------------------------------------------------*/

delimiter ;;
CREATE PROCEDURE insertarusuario(
IN _nombre VARCHAR(100),
IN _apellidop VARCHAR(100),
IN _apellidom VARCHAR(100),
IN _fechanacimiento VARCHAR(13),
IN _rfc VARCHAR(13),
IN _idusuario INT)
BEGIN 
DECLARE x INT;
SELECT COUNT(*) FROM usuarios WHERE idusuario = _idusuario INTO X;
if x=0 AND _idusuario < 0 then
INSERT INTO usuarios VALUES(NULL,_nombre,_apellidop,_apellidom,_fechanacimiento,_rfc);
ELSE if x=0 AND _idusuarios > 0 then
UPDATE usuarios SET nombre = _nombre, apellidop = _apellidop, apellidom =_apellidom, fechanacimiento = _fechanacimiento, rfc = _rfc
WHERE idusuario = _idusuario;
END if;
END if;
END;;
delimiter ;;
CREATE PROCEDURE deleteusuario(
IN _idusuario INT)
BEGIN 
DELETE FROM usuarios WHERE idusuario =_idusuario;
END;;
delimiter ;;
CREATE PROCEDURE showusuario(
IN _filtro VARCHAR(100))
BEGIN
SELECT u.idusuario,u.nombre,u.apellidop,u.apellidom,u.fechanacimiento,u.rfc FROM usuarios u 
WHERE u.nombre LIKE _filtro;
END;;

/*--------------------------------------PORCEDURE DE MODULOTREFACCION--------------------------------------------------------*/

delimiter ;;
CREATE PROCEDURE insertarmodulorefaccion(
IN _codigobarras BIGINT,
IN _nombre VARCHAR(100),
IN _descripcion VARCHAR(200),
IN _marca VARCHAR(100))
BEGIN
INSERT INTO modulorefaccion VALUES(_codigobarras,_nombre,_descripcion,_marca);
END;;

delimiter ;;
CREATE PROCEDURE deletemodulorefaccion(
IN _codigobarras BIGINT)
BEGIN
DELETE FROM modulorefaccion WHERE codigobarras = _codigobarras;
END;;

delimiter ;;
CREATE PROCEDURE showmodulorefaccion(
IN _filtro VARCHAR(100))
BEGIN 
SELECT r.codigobarras,r.nombre,r.descripcion,r.marca FROM modulorefaccion r WHERE r.nombre LIKE _filtro;
END;;

delimiter ;;
CREATE PROCEDURE modificarmodulorefaccion(
IN _codigobarras BIGINT,
IN _nombre VARCHAR(100),
IN _descripcion VARCHAR(200),
IN _marca VARCHAR(100))
BEGIN 
UPDATE modulorefaccion SET nombre = _nombre, descripcion = _descripcion, marca = _marca WHERE codigobarras = _codigobarras;
END;;

/*--------------------------------------PORCEDURE DE MODULOTALLER--------------------------------------------------------- */

delimiter ;;
CREATE PROCEDURE insertarmodulotaller(
IN _codigoherramientas BIGINT,
IN _nombre VARCHAR(100),
IN _medida VARCHAR(100),
IN _marca VARCHAR(100),
IN _descripcion VARCHAR(200))
BEGIN 
INSERT INTO modulotaller VALUES(_codigoherramientas,_nombre,_medida,_marca,_descripcion);
END;;

delimiter ;;
CREATE PROCEDURE deletemodulotaller(
IN _codigoherramientas BIGINT)
BEGIN 
DELETE FROM modulotaller WHERE codigoherramientas = _codigoherramientas;
END;;

delimiter ;;
CREATE PROCEDURE showmodulotaller(
_filtro VARCHAR(100))
BEGIN
SELECT t.codigoherramientas,t.nombre,t.medida,t.marca,t.descripcion FROM modulotaller t WHERE t.nombre LIKE _filtro;
END;;

delimiter ;; 
CREATE PROCEDURE modificarmodulotaller(
IN _codigoherramientas BIGINT,
IN _nombre VARCHAR(100),
IN _medida VARCHAR(100),
IN _marca VARCHAR(100),
IN _descripcion VARCHAR(200))
BEGIN 
UPDATE modulotaller SET nombre = _nombre, medida = _medida, marca = _marca, descripcion = _descripcion WHERE
codigoherramientas = _codigoherramientas;
END;;

/*--------------------------------------PORCEDURE DE PERMISOSMODULOREFACCIONES---------------------------------------------- */
delimiter ;; 
CREATE PROCEDURE insertarpermisosrefaccion(
IN _idp VARCHAR(100),
IN _FKidusuario INT,
IN _lectura BOOL,
IN _escritura BOOL,
IN _eliminacion BOOL,
IN _actualizacion BOOL)
BEGIN 
INSERT INTO permisosrefaccion VALUES(_idp,_FKidusuario,_lectura,_escritura,_eliminacion,_actualizacion);
END;;

delimiter ;; 
CREATE PROCEDURE deletepermisosrefaccion(
IN _idp VARCHAR(100))
BEGIN 
DELETE FROM permisosrefaccion WHERE idp = _idp;
END;;

delimiter ;; 
CREATE PROCEDURE showpermisosrefaccion(
_filtro VARCHAR(100))
BEGIN 
SELECT u.nombre,u.apellidop,u.apellidom,p.lectura,p.escritura,p.eliminacion,p.actualizacion 
FROM permisosrefaccion as p ,usuarios AS u
WHERE p.FKidusuario=u.idusuario AND u.nombre LIKE _filtro;
END;;

delimiter ;; 
CREATE PROCEDURE modificarpermisosrefaccion(
IN _idp VARCHAR(100),
IN _FKidusuario INT,
IN _lectura BOOL,
IN _escritura BOOL,
IN _eliminacion BOOL,
IN _actualizacion BOOL)
BEGIN
UPDATE permisosrefaccion SET lectura=_lectura,escritura=_escritura,eliminacion=_eliminacion,actualizacion=_actualizacion WHERE 
FKidusuario = _FKidusuario AND idp= _idp;
END;;

/*--------------------------------------PORCEDURE DE PERMISOSMODULOTALLER---------------------------------------------- */
delimiter ;;
CREATE PROCEDURE insertarpermisostaller(
IN _FKidusuario INT,
IN _FKcodigoherramientas BIGINT,
IN _lectura BOOL,
IN _escritura BOOL,
IN _eliminacion BOOL,
IN _actualizacion BOOL)
BEGIN 
INSERT INTO permisosTaller VALUES(_FKidusuario,_FKcodigoherramientas,_lectura,_escritura,_eliminacion,_actualizacion);
END;;

delimiter ;; 
CREATE PROCEDURE deletepermisostaller(
IN _FKidusuario INT,
IN _FKcodigoherramientas BIGINT)
BEGIN 
DELETE FROM permisostaller WHERE FKidusuario = _FKidusuario AND FKcodigoherramientas = _FKcodigoherramientas;
END;;

delimiter ;;
CREATE PROCEDURE showpermisostaller(
_filtro VARCHAR(100))
BEGIN 
SELECT u.nombre,u.apellidop,u.apellidom,t.lectura,t.escritura,t.eliminacion,t.actualizacion 
FROM permisosTaller AS t,usuarios as u,modulotaller m 
WHERE  t.FKidusuario = u.idusuario AND t.FKcodigoherramientas = m.codigoherramientas AND 
u.nombre LIKE _filtro;
END;;

delimiter ;;
CREATE PROCEDURE modificarpermisostaller(
IN _FKidusuario INT,
IN _FKcodigoherramientas BIGINT,
IN _lectura BOOL,
IN _escritura BOOL,
IN _eliminacion BOOL,
IN _actualizacion BOOL)
BEGIN 
UPDATE permisosTaller SET lectura=_lectura,escritura=_escritura,eliminacion=_eliminacion,actualizacion=_actualizacion WHERE 
FKidusuario = _FKidusuario AND FKcodigoherramientas = _FKcodigoherramientas;
END;


