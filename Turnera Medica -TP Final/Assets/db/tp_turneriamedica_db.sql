/*LINEA Q COMENTA TODO LA CONSULTA PARA QUE NO SALGA ERROR, HAY QUE ELIMINAR ESTA LINEA ANTES DE IMPORTART

CREATE DATABASE IF NOT EXISTS tp_turneriamedica_db CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci;
USE tp_turneriamedica_db;

DROP TABLE IF EXISTS medico_obra_social;
DROP TABLE IF EXISTS medico_consultorio_asignado;
DROP TABLE IF EXISTS turnos;
DROP TABLE IF EXISTS pacientes;
DROP TABLE IF EXISTS medicos;
DROP TABLE IF EXISTS obras_sociales;
DROP TABLE IF EXISTS consultorios;
DROP TABLE IF EXISTS users;

CREATE TABLE users (
  id INT NOT NULL AUTO_INCREMENT,
  dni INT DEFAULT NULL,
  nombre VARCHAR(100) NOT NULL,
  apellido VARCHAR(100) NOT NULL,
  email VARCHAR(150) DEFAULT NULL,
  numero_tel VARCHAR(50) DEFAULT NULL,
  password_hash VARCHAR(255) NOT NULL,
  rol ENUM('admin','medico','paciente') NOT NULL DEFAULT 'paciente',
  PRIMARY KEY (id),
  UNIQUE KEY dni (dni),
  UNIQUE KEY email (email)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

CREATE TABLE consultorios (
  id INT NOT NULL AUTO_INCREMENT,
  ubicacion VARCHAR(250) NOT NULL,
  hora_abierto TIME NOT NULL,
  hora_cerrado TIME NOT NULL,
  PRIMARY KEY (id)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

CREATE TABLE obras_sociales (
  id INT NOT NULL AUTO_INCREMENT,
  nombre VARCHAR(150) NOT NULL,
  PRIMARY KEY (id),
  UNIQUE KEY nombre (nombre)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

CREATE TABLE medicos (
  id INT NOT NULL AUTO_INCREMENT,
  user_id INT NOT NULL,
  especialidad VARCHAR(100) NOT NULL,
  monto_consulta DECIMAL(10,2) NOT NULL,
  PRIMARY KEY (id),
  UNIQUE KEY user_id (user_id),
  FOREIGN KEY (user_id) REFERENCES users (id) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

CREATE TABLE pacientes (
  id INT NOT NULL AUTO_INCREMENT,
  user_id INT NOT NULL,
  obra_social_id INT DEFAULT NULL,
  PRIMARY KEY (id),
  UNIQUE KEY user_id (user_id),
  FOREIGN KEY (user_id) REFERENCES users (id) ON DELETE CASCADE,
  FOREIGN KEY (obra_social_id) REFERENCES obras_sociales (id) ON DELETE SET NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

CREATE TABLE medico_consultorio_asignado (
  id INT NOT NULL AUTO_INCREMENT,
  medico_id INT NOT NULL,
  consultorio_id INT NOT NULL,
  horario_desde TIME NOT NULL,
  horario_hasta TIME NOT NULL,
  PRIMARY KEY (id),
  FOREIGN KEY (medico_id) REFERENCES medicos (id) ON DELETE CASCADE,
  FOREIGN KEY (consultorio_id) REFERENCES consultorios (id) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

CREATE TABLE medico_obra_social (
  medico_id INT NOT NULL,
  obra_social_id INT NOT NULL,
  PRIMARY KEY (medico_id, obra_social_id),
  FOREIGN KEY (medico_id) REFERENCES medicos (id) ON DELETE CASCADE,
  FOREIGN KEY (obra_social_id) REFERENCES obras_sociales (id) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

CREATE TABLE turnos (
  id INT NOT NULL AUTO_INCREMENT,
  medico_id INT NOT NULL,
  paciente_id INT NULL,
  consultorio_id INT NOT NULL,
  fecha_hora DATETIME NOT NULL,
  duracion INT NOT NULL DEFAULT 30,
  precio_original DECIMAL(10,2) NOT NULL,
  descuento DECIMAL(5,2) NOT NULL DEFAULT 0.00,
  precio_final DECIMAL(10,2) NOT NULL,
  estado ENUM('programado','asistido','libre','cancelado') NOT NULL DEFAULT 'libre',
  PRIMARY KEY (id),
  UNIQUE KEY uq_turno_medico_fecha (medico_id, fecha_hora),
  FOREIGN KEY (medico_id) REFERENCES medicos (id) ON DELETE RESTRICT,
  FOREIGN KEY (paciente_id) REFERENCES pacientes (id) ON DELETE SET NULL,
  FOREIGN KEY (consultorio_id) REFERENCES consultorios (id) ON DELETE RESTRICT
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- INSERTS

INSERT INTO users (dni, nombre, apellido, email, numero_tel, password_hash, rol) VALUES 
(30111222, 'Juan', 'Pérez', 'juan.perez@hospital.com', '1122334455', '1234', 'medico'), 
(30999888, 'María', 'López', 'maria.lopez@hospital.com', '1133445566', '1234', 'medico'),
(40111222, 'Carlos', 'Gómez', 'carlos.gomez@gmail.com', '1144556677', '1234', 'paciente'), 
(40999888, 'Lucía', 'Fernández', 'lucia.fernandez@gmail.com', '1155667788', '1234', 'paciente');

INSERT INTO consultorios (ubicacion, hora_abierto, hora_cerrado) VALUES
('Corrientes 1500', '08:00:00', '16:00:00'),
('Carabobo 3000', '08:00:00', '16:00:00'),
('México 2500', '09:00:00', '17:00:00'), 
('Uruguay 4000', '09:00:00', '17:00:00'), 
('Yrigoyen 3500', '07:00:00', '15:00:00'), 
('Corrientes 3200 - Edificio B', '07:00:00', '15:00:00');

INSERT INTO obras_sociales (nombre) VALUES 
('OSDE'), 
('Swiss Medical'), 
('Galeno'), 
('PAMI'), 
('IOMA'), 
('Medife');

INSERT INTO medicos (user_id, especialidad, monto_consulta) VALUES 
(1, 'Cardiología', 5000.00), 
(2, 'Pediatría', 6000.00);

INSERT INTO pacientes (user_id, obra_social_id) VALUES 
(3, 1), 
(4, 4);

INSERT INTO medico_consultorio_asignado (medico_id, consultorio_id, horario_desde, horario_hasta) VALUES 
(1, 1, '08:00:00', '12:00:00'), 
(1, 2, '13:00:00', '16:00:00'), 
(2, 3, '09:00:00', '13:00:00'), 
(2, 4, '14:00:00', '17:00:00');

INSERT INTO medico_obra_social (medico_id, obra_social_id) VALUES 
(1, 1), 
(1, 2), 
(1, 3), 
(2, 4), 
(2, 5), 
(2, 6);

INSERT INTO turnos (medico_id, paciente_id, consultorio_id, fecha_hora, duracion, precio_original, descuento, precio_final, estado)
VALUES
(1, 1, 1, '2025-11-15 09:00:00', 30, 5000.00, 0.00, 5000.00, 'programado'),
(1, 2, 1, '2025-11-15 09:30:00', 30, 5000.00, 10.00, 4500.00, 'programado'),
(1, 1, 1, '2025-11-15 10:00:00', 30, 5000.00, 0.00, 5000.00, 'asistido'),
(1, NULL, 1, '2025-11-15 10:30:00', 30, 5000.00, 0.00, 5000.00, 'libre'),
(1, NULL, 2, '2025-11-15 11:00:00', 30, 5000.00, 0.00, 5000.00, 'libre'),
(2, NULL, 3, '2025-11-16 09:30:00', 30, 6000.00, 0.00, 6000.00, 'libre'),
(2, NULL, 4, '2025-11-16 10:00:00', 30, 6000.00, 0.00, 6000.00, 'libre');