-- MySQL dump 10.13  Distrib 8.0.41, for Win64 (x86_64)
--
-- Host: 127.0.0.1    Database: tp_turneriamedica_db
-- ------------------------------------------------------
-- Server version	8.0.41

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `consultorios`
--

DROP TABLE IF EXISTS `consultorios`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `consultorios` (
  `id` int NOT NULL AUTO_INCREMENT,
  `ubicacion` varchar(250) NOT NULL,
  `hora_abierto` time NOT NULL,
  `hora_cerrado` time NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `consultorios`
--

LOCK TABLES `consultorios` WRITE;
/*!40000 ALTER TABLE `consultorios` DISABLE KEYS */;
/*!40000 ALTER TABLE `consultorios` ENABLE KEYS */;
UNLOCK TABLES;




--
-- Table structure for table `medicos`
--

DROP TABLE IF EXISTS `medicos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `medicos` (
  `id` int NOT NULL AUTO_INCREMENT,
  `user_id` int NOT NULL,
  `especialidad` varchar(100) NOT NULL,
  `monto_consulta` decimal(10,2) NOT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `user_id` (`user_id`),
  CONSTRAINT `medicos_ibfk_1` FOREIGN KEY (`user_id`) REFERENCES `users` (`id`) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `medicos`
--

LOCK TABLES `medicos` WRITE;
/*!40000 ALTER TABLE `medicos` DISABLE KEYS */;
/*!40000 ALTER TABLE `medicos` ENABLE KEYS */;
UNLOCK TABLES;


--
-- Table structure for table `medico_consultorio_asignado`
--

DROP TABLE IF EXISTS `medico_consultorio_asignado`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `medico_consultorio_asignado` (
  `id` int NOT NULL AUTO_INCREMENT,
  `medico_id` int NOT NULL,
  `consultorio_id` int NOT NULL,
  `horario_desde` time NOT NULL,
  `horario_hasta` time NOT NULL,
  PRIMARY KEY (`id`),
  KEY `medico_id` (`medico_id`),
  KEY `consultorio_id` (`consultorio_id`),
  CONSTRAINT `medico_consultorio_asignado_ibfk_1` FOREIGN KEY (`medico_id`) REFERENCES `medicos` (`id`) ON DELETE CASCADE,
  CONSTRAINT `medico_consultorio_asignado_ibfk_2` FOREIGN KEY (`consultorio_id`) REFERENCES `consultorios` (`id`) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `medico_consultorio_asignado`
--


LOCK TABLES `medico_consultorio_asignado` WRITE;
/*!40000 ALTER TABLE `medico_consultorio_asignado` DISABLE KEYS */;
/*!40000 ALTER TABLE `medico_consultorio_asignado` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `obras_sociales`
--

DROP TABLE IF EXISTS `obras_sociales`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `obras_sociales` (
  `id` int NOT NULL AUTO_INCREMENT,
  `nombre` varchar(150) NOT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `nombre` (`nombre`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `obras_sociales`
--

LOCK TABLES `obras_sociales` WRITE;
/*!40000 ALTER TABLE `obras_sociales` DISABLE KEYS */;
/*!40000 ALTER TABLE `obras_sociales` ENABLE KEYS */;
UNLOCK TABLES;


--
-- Table structure for table `medico_obra_social`
--

DROP TABLE IF EXISTS `medico_obra_social`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `medico_obra_social` (
  `medico_id` int NOT NULL,
  `obra_social_id` int NOT NULL,
  PRIMARY KEY (`medico_id`,`obra_social_id`),
  KEY `obra_social_id` (`obra_social_id`),
  CONSTRAINT `medico_obra_social_ibfk_1` FOREIGN KEY (`medico_id`) REFERENCES `medicos` (`id`) ON DELETE CASCADE,
  CONSTRAINT `medico_obra_social_ibfk_2` FOREIGN KEY (`obra_social_id`) REFERENCES `obras_sociales` (`id`) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `medico_obra_social`
--

LOCK TABLES `medico_obra_social` WRITE;
/*!40000 ALTER TABLE `medico_obra_social` DISABLE KEYS */;
/*!40000 ALTER TABLE `medico_obra_social` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `pacientes`
--

DROP TABLE IF EXISTS `pacientes`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `pacientes` (
  `id` int NOT NULL AUTO_INCREMENT,
  `user_id` int NOT NULL,
  `obra_social_id` int DEFAULT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `user_id` (`user_id`),
  KEY `obra_social_id` (`obra_social_id`),
  CONSTRAINT `pacientes_ibfk_1` FOREIGN KEY (`user_id`) REFERENCES `users` (`id`) ON DELETE CASCADE,
  CONSTRAINT `pacientes_ibfk_2` FOREIGN KEY (`obra_social_id`) REFERENCES `obras_sociales` (`id`) ON DELETE SET NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `pacientes`
--

LOCK TABLES `pacientes` WRITE;
/*!40000 ALTER TABLE `pacientes` DISABLE KEYS */;
/*!40000 ALTER TABLE `pacientes` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `turnos`
--

DROP TABLE IF EXISTS `turnos`;

CREATE TABLE `turnos` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `medico_id` INT NOT NULL,
  `paciente_id` INT NULL,
  `consultorio_id` INT NOT NULL,
  `fecha_hora` DATETIME NOT NULL,
  `duracion` INT NOT NULL DEFAULT 30,
  `precio_original` DECIMAL(10,2) NOT NULL,
  `descuento` DECIMAL(5,2) NOT NULL DEFAULT 0.00,
  `precio_final` DECIMAL(10,2) NOT NULL,
  `estado` ENUM('programado','asistido','libre','cancelado') NOT NULL DEFAULT 'libre',
  PRIMARY KEY (`id`),
  UNIQUE KEY `uq_turno_medico_fecha` (`medico_id`,`fecha_hora`),
  KEY `paciente_id` (`paciente_id`),
  KEY `consultorio_id` (`consultorio_id`),
  CONSTRAINT `turnos_ibfk_1` FOREIGN KEY (`medico_id`) REFERENCES `medicos` (`id`) ON DELETE RESTRICT,
  CONSTRAINT `turnos_ibfk_2` FOREIGN KEY (`paciente_id`) REFERENCES `pacientes` (`id`) ON DELETE SET NULL,
  CONSTRAINT `turnos_ibfk_3` FOREIGN KEY (`consultorio_id`) REFERENCES `consultorios` (`id`) ON DELETE RESTRICT
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;


--
-- Dumping data for table `turnos`
--

LOCK TABLES `turnos` WRITE;
/*!40000 ALTER TABLE `turnos` DISABLE KEYS */;
/*!40000 ALTER TABLE `turnos` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `users`
--

DROP TABLE IF EXISTS `users`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `users` (
  `id` int NOT NULL AUTO_INCREMENT,
  `dni` int DEFAULT NULL,
  `nombre` varchar(100) NOT NULL,
  `apellido` varchar(100) NOT NULL,
  `email` varchar(150) DEFAULT NULL,
  `numero_tel` varchar(50) DEFAULT NULL,
  `password_hash` varchar(255) NOT NULL,
  `rol` enum('admin','medico','paciente') NOT NULL DEFAULT 'paciente',
  PRIMARY KEY (`id`),
  UNIQUE KEY `dni` (`dni`),
  UNIQUE KEY `email` (`email`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `users`
--

LOCK TABLES `users` WRITE;
/*!40000 ALTER TABLE `users` DISABLE KEYS */;
/*!40000 ALTER TABLE `users` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2025-10-10 23:54:10

USE tp_turneriamedica_db; 
-- ============================================ 
-- USERS 
-- ============================================ 
INSERT INTO users (dni, nombre, apellido, email, numero_tel, password_hash, rol) VALUES 
(30111222, 'Juan', 'Pérez', 'juan.perez@hospital.com', '1122334455', '1234', 'medico'), 
(30999888, 'María', 'López', 'maria.lopez@hospital.com', '1133445566', '1234', 'medico'),
(40111222, 'Carlos', 'Gómez', 'carlos.gomez@gmail.com', '1144556677', '1234', 'paciente'), 
(40999888, 'Lucía', 'Fernández', 'lucia.fernandez@gmail.com', '1155667788', '1234', 'paciente'); 
-- ============================================ 
-- CONSULTORIOS 
-- ============================================ 
INSERT INTO consultorios (ubicacion, hora_abierto, hora_cerrado) VALUES
('Corrientes 1500', '08:00:00', '16:00:00'),
('Carabobo 3000', '08:00:00', '16:00:00'),
('Mexico 2500', '09:00:00', '17:00:00'), 
('Uruguay 4000', '09:00:00', '17:00:00'), 
('Yrigoyen 3500 ', '07:00:00', '15:00:00'), 
('Corrientes 3200 - Edificio B', '07:00:00', '15:00:00'); 
-- ============================================ 
-- OBRAS SOCIALES 
-- ============================================ 
INSERT INTO obras_sociales (nombre) VALUES 
('OSDE'), 
('Swiss Medical'), 
('Galeno'), 
('PAMI'), 
('IOMA'), 
('Medife'); 

-- ============================================ 
-- MÉDICOS 
-- ============================================ 
INSERT INTO medicos (user_id, especialidad, monto_consulta) VALUES 
(1, 'Cardiologia', 5000.00), 
(2, 'Pediatria', 6000.00);
 
-- ============================================ 
-- PACIENTES 
-- ============================================ 
INSERT INTO pacientes (user_id, obra_social_id) VALUES 
(3, 1), 
(4, 4);

-- ============================================ 
-- MÉDICO - CONSULTORIO ASIGNADO 
-- ============================================ 
INSERT INTO medico_consultorio_asignado (medico_id, consultorio_id, horario_desde, horario_hasta) VALUES 
(1, 1, '08:00:00', '12:00:00'), 
(1, 2, '13:00:00', '16:00:00'), 
(2, 3, '09:00:00', '13:00:00'), 
(2, 4, '14:00:00', '17:00:00'); 

-- ============================================ 
-- MÉDICO - OBRA SOCIAL 
-- ============================================ 
INSERT INTO medico_obra_social (medico_id, obra_social_id) VALUES 
(1, 1), 
(1, 2), 
(1, 3), 
(2, 4), 
(2, 5), 
(2, 6); 

-- ============================================ 
-- TURNOS (a partir del 15 de noviembre de 2025) 
-- ============================================ 
INSERT INTO turnos (medico_id, paciente_id, consultorio_id, fecha_hora, duracion, precio_original, descuento, precio_final, estado)
VALUES
-- Médico 1 (Cardiología)
(1, 1, 1, '2025-11-15 09:00:00', 30, 5000.00, 0.00, 5000.00, 'programado'),
(1, 2, 1, '2025-11-15 09:30:00', 30, 5000.00, 10.00, 4500.00, 'programado'),
(1, 1, 1, '2025-11-15 10:00:00', 30, 5000.00, 0.00, 5000.00, 'asistido'),
(1, NULL, 1, '2025-11-15 10:30:00', 30, 5000.00, 0.00, 5000.00, 'libre'),
(1, NULL, 2, '2025-11-15 11:00:00', 30, 5000.00, 0.00, 5000.00, 'libre'),

-- Médico 2 (Pediatría)
(2, NULL, 3, '2025-11-16 09:30:00', 30, 6000.00, 0.00, 6000.00, 'libre'),
(2, NULL, 4, '2025-11-16 10:00:00', 30, 6000.00, 0.00, 6000.00, 'libre');
