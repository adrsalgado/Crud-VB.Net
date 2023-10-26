/*
 Navicat Premium Data Transfer

 Source Server         : Localhost MySQL 8.0
 Source Server Type    : MySQL
 Source Server Version : 80018 (8.0.18)
 Source Host           : localhost:3306
 Source Schema         : bd_crud

 Target Server Type    : MySQL
 Target Server Version : 80018 (8.0.18)
 File Encoding         : 65001

 Date: 17/08/2023 16:45:14
*/

SET NAMES utf8mb4;
SET FOREIGN_KEY_CHECKS = 0;

-- ----------------------------
-- Table structure for lectores
-- ----------------------------
DROP TABLE IF EXISTS `lectores`;
CREATE TABLE `lectores`  (
  `id` int(10) UNSIGNED NOT NULL AUTO_INCREMENT,
  `Id_Lectores` int(10) NOT NULL,
  `Nombre` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL,
  `Telefono` varchar(20) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL,
  `Direccion` varchar(100) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL,
  `Observaciones` varchar(100) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL,
  PRIMARY KEY (`id`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 6 CHARACTER SET = utf8mb4 COLLATE = utf8mb4_general_ci ROW_FORMAT = DYNAMIC;

-- ----------------------------
-- Records of lectores
-- ----------------------------
INSERT INTO `lectores` VALUES (3, 1027662199, 'Adriana Salgado Cardenas', '3107285899', 'Bello', 'Lector frecuente');
INSERT INTO `lectores` VALUES (4, 100922362, 'Sebastian Granada Montes', '3133436011', 'Itagüí', 'Lector poco frecuente');
INSERT INTO `lectores` VALUES (5, 1089486482, 'Patricia Gaviria', '3116209713', 'Bello', 'Lector Ausente');

-- ----------------------------
-- Procedure structure for Buscar_Lector
-- ----------------------------
DROP PROCEDURE IF EXISTS `Buscar_Lector`;
delimiter ;;
CREATE PROCEDURE `Buscar_Lector`(IN Busqueda VARCHAR(50))
BEGIN
    SELECT id,Id_Lectores, Nombre, Telefono, Direccion, Observaciones FROM lectores WHERE CONCAT(Id_Lectores, ' ', Nombre) LIKE CONCAT('%', Busqueda, '%');
END
;;
delimiter ;

-- ----------------------------
-- Procedure structure for Editar_Lector
-- ----------------------------
DROP PROCEDURE IF EXISTS `Editar_Lector`;
delimiter ;;
CREATE PROCEDURE `Editar_Lector`(IN id_L  int,
		IN Id_Lectores VARCHAR(13),
    IN Nombre VARCHAR(50),
    IN Telefono VARCHAR(20),
    IN Direccion VARCHAR(100),
    IN Observaciones VARCHAR(100))
BEGIN
    UPDATE lectores
    SET Nombre = Nombre,
        Telefono = Telefono,
        Direccion = Direccion,
        Observaciones = Observaciones
    WHERE id = id_L;
END
;;
delimiter ;

-- ----------------------------
-- Procedure structure for Eliminar_Lector
-- ----------------------------
DROP PROCEDURE IF EXISTS `Eliminar_Lector`;
delimiter ;;
CREATE PROCEDURE `Eliminar_Lector`(IN id_L  int)
BEGIN
    DELETE FROM lectores WHERE Id = Id_L;
END
;;
delimiter ;

-- ----------------------------
-- Procedure structure for Ingresar_Lector
-- ----------------------------
DROP PROCEDURE IF EXISTS `Ingresar_Lector`;
delimiter ;;
CREATE PROCEDURE `Ingresar_Lector`(IN Id_Lectores VARCHAR(13),
    IN Nombre VARCHAR(50),
    IN Telefono VARCHAR (20),
    IN Direccion VARCHAR(100),
    IN Observaciones VARCHAR(100))
BEGIN
      INSERT INTO lectores (Id_Lectores, Nombre, Telefono, Direccion, Observaciones) VALUES (Id_Lectores, Nombre, Telefono, Direccion, Observaciones);
   
END
;;
delimiter ;

-- ----------------------------
-- Procedure structure for Mostrar_Lector
-- ----------------------------
DROP PROCEDURE IF EXISTS `Mostrar_Lector`;
delimiter ;;
CREATE PROCEDURE `Mostrar_Lector`()
BEGIN
    SELECT id, Id_Lectores, Nombre, Telefono, Direccion, Observaciones FROM lectores;
END
;;
delimiter ;

SET FOREIGN_KEY_CHECKS = 1;
