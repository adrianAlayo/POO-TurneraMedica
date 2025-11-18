/*/LINEA Q COMENTA TODO LA CONSULTA PARA QUE NO SALGA ERROR, HAY QUE ELIMINAR ESTA LINEA ANTES DE IMPORTART 

CREATE DATABASE IF NOT EXISTS tp_turneriamedica_db CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci;
USE tp_turneriamedica_db;

-- Eliminación de tablas en orden correcto
DROP TABLE IF EXISTS medic_social_work;
DROP TABLE IF EXISTS assigned_doctors_office;
DROP TABLE IF EXISTS shifts;
DROP TABLE IF EXISTS patients;
DROP TABLE IF EXISTS medics;
DROP TABLE IF EXISTS social_works;
DROP TABLE IF EXISTS offices;
DROP TABLE IF EXISTS specialities;
DROP TABLE IF EXISTS users;

-- Tabla usuarios
CREATE TABLE users (
  id INT NOT NULL AUTO_INCREMENT,
  dni INT DEFAULT NULL,
  name VARCHAR(100) NOT NULL,
  last_name VARCHAR(100) NOT NULL,
  age INT DEFAULT NULL,
  email VARCHAR(150) DEFAULT NULL,
  telephone_number VARCHAR(50) DEFAULT NULL,
  password_hash VARCHAR(255) NOT NULL,
  rol ENUM('admin','medico','paciente') NOT NULL DEFAULT 'paciente',
  PRIMARY KEY (id),
  UNIQUE KEY dni (dni),
  UNIQUE KEY email (email)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- Tabla especialidades
CREATE TABLE specialities (
  id INT NOT NULL AUTO_INCREMENT,
  name VARCHAR(100) NOT NULL,
  PRIMARY KEY (id),
  UNIQUE KEY name (name)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- Tabla consultorios
CREATE TABLE offices (
  id INT NOT NULL AUTO_INCREMENT,
  ubication VARCHAR(250) NOT NULL,
  open_time TIME NOT NULL,
  close_time TIME NOT NULL,
  PRIMARY KEY (id)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- Tabla obras sociales
CREATE TABLE social_works (
  id INT NOT NULL AUTO_INCREMENT,
  name VARCHAR(150) NOT NULL,
  PRIMARY KEY (id),
  UNIQUE KEY name (name)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- Tabla médicos
CREATE TABLE medics (
  id INT NOT NULL AUTO_INCREMENT,
  user_id INT NOT NULL,
  speciality_id INT NOT NULL,
  consult_amount DECIMAL(10,2) NOT NULL,
  entry_time TIME NOT NULL,
  departure_time TIME NOT NULL,
  PRIMARY KEY (id),
  UNIQUE KEY user_id (user_id),
  FOREIGN KEY (user_id) REFERENCES users (id) ON DELETE CASCADE,
  FOREIGN KEY (speciality_id) REFERENCES specialities (id) ON DELETE RESTRICT
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;


-- Tabla pacientes
CREATE TABLE patients (
  id INT NOT NULL AUTO_INCREMENT,
  user_id INT NOT NULL,
  social_work_id INT DEFAULT NULL,
  PRIMARY KEY (id),
  UNIQUE KEY user_id (user_id),
  FOREIGN KEY (user_id) REFERENCES users (id) ON DELETE CASCADE,
  FOREIGN KEY (social_work_id) REFERENCES social_works (id) ON DELETE SET NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- Tabla asignación de médicos a consultorios
CREATE TABLE assigned_doctors_office (
  id INT NOT NULL AUTO_INCREMENT,
  medic_id INT NOT NULL,
  office_id INT NOT NULL,
  open_from TIME NOT NULL,
  close_after TIME NOT NULL,
  PRIMARY KEY (id),
  FOREIGN KEY (medic_id) REFERENCES medics (id) ON DELETE CASCADE,
  FOREIGN KEY (office_id) REFERENCES offices (id) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- Tabla médico - obra social
CREATE TABLE medic_social_work (
  medic_id INT NOT NULL,
  social_work_id INT NOT NULL,
  PRIMARY KEY (medic_id, social_work_id),
  FOREIGN KEY (medic_id) REFERENCES medics (id) ON DELETE CASCADE,
  FOREIGN KEY (social_work_id) REFERENCES social_works (id) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- ======================
-- ? NUEVA TABLA SHIFTS (fecha y hora separadas)
-- ======================
CREATE TABLE shifts (
  id INT NOT NULL AUTO_INCREMENT,
  medic_id INT NOT NULL,
  patient_id INT NULL,
  office_id INT NOT NULL,
  shift_date DATE NOT NULL,
  shift_time TIME NOT NULL,
  duration INT NOT NULL DEFAULT 30,
  original_price DECIMAL(10,2) NOT NULL,
  discount DECIMAL(5,2) NOT NULL DEFAULT 0.00,
  final_price DECIMAL(10,2) NOT NULL,
  state ENUM('programado','asistido','libre','cancelado') NOT NULL DEFAULT 'libre',
  PRIMARY KEY (id),
  UNIQUE KEY uq_turno_medico_fecha_hora (medic_id, shift_date, shift_time),
  FOREIGN KEY (medic_id) REFERENCES medics (id) ON DELETE RESTRICT,
  FOREIGN KEY (patient_id) REFERENCES patients (id) ON DELETE SET NULL,
  FOREIGN KEY (office_id) REFERENCES offices (id) ON DELETE RESTRICT
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- ===================
-- INSERTS
-- ===================

-- Usuarios
INSERT INTO users (dni, name, last_name, age, email, telephone_number, password_hash, rol) VALUES 
(30111222, 'Juan', 'Pérez', 45, 'juan.perez@hospital.com', '1122334455', '03ac674216f3e15c761ee1a5e255f067953623c8b388b4459e13f978d7c846f4', 'medico'),
(30999888, 'María', 'López', 38, 'maria.lopez@hospital.com', '1133445566', '03ac674216f3e15c761ee1a5e255f067953623c8b388b4459e13f978d7c846f4', 'medico'),
(40111222, 'Carlos', 'Gómez', 29, 'carlos.gomez@gmail.com', '1144556677', '03ac674216f3e15c761ee1a5e255f067953623c8b388b4459e13f978d7c846f4', 'paciente'),
(40999888, 'Lucía', 'Fernández', 35, 'lucia.fernandez@gmail.com', '1155667788', '03ac674216f3e15c761ee1a5e255f067953623c8b388b4459e13f978d7c846f4', 'paciente');


-- Especialidades
INSERT INTO specialities (name) VALUES 
('Cardiología'),
('Pediatría'),
('Dermatología'),
('Traumatología'),
('Clínica Médica');

-- Consultorios
INSERT INTO offices (ubication, open_time, close_time) VALUES
('Corrientes 1500', '08:00:00', '16:00:00'),
('Corrientes 3200', '07:00:00', '15:00:00'),
('Carabobo 3000', '08:00:00', '16:00:00'),
('México 2500', '09:00:00', '17:00:00'),
('Uruguay 4000', '09:00:00', '17:00:00'),
('Yrigoyen 3500', '07:00:00', '15:00:00');

-- Obras sociales
INSERT INTO social_works (name) VALUES 
('OSDE'),
('Swiss Medical'),
('Galeno'),
('PAMI'),
('IOMA'),
('Medife');

-- Médicos
INSERT INTO medics (user_id, speciality_id, consult_amount, entry_time, departure_time) VALUES 
(1, 1, 5000.00, '08:00:00', '16:00:00'),
(2, 2, 6000.00, '09:00:00', '17:00:00');


-- Pacientes
INSERT INTO patients (user_id, social_work_id) VALUES (3, 1), (4, 4);

-- Asignación consultorios
INSERT INTO assigned_doctors_office (medic_id, office_id, open_from, close_after) VALUES
(1, 1, '08:00:00', '12:00:00'),
(2, 3, '09:00:00', '13:00:00');

-- Médico - Obra social
INSERT INTO medic_social_work (medic_id, social_work_id) VALUES
(1, 1),(1, 2),(1, 3),
(2, 4),(2, 5),(2, 6);

-- Turnos (hora/fecha separadas)
INSERT INTO shifts (medic_id, patient_id, office_id, shift_date, shift_time, duration, original_price, discount, final_price, state) VALUES
(1, 1, 1, '2025-11-15', '09:00:00', 30, 5000.00, 0.00, 5000.00, 'programado'),
(1, 2, 1, '2025-11-15', '09:30:00', 30, 5000.00, 10.00, 4500.00, 'programado'),
(1, 1, 1, '2025-11-15', '10:00:00', 30, 5000.00, 0.00, 5000.00, 'asistido'),
(1, NULL, 1, '2025-11-15', '10:30:00', 30, 5000.00, 0.00, 5000.00, 'libre'),
(1, NULL, 2, '2025-11-15', '11:00:00', 30, 5000.00, 0.00, 5000.00, 'libre'),
(2, NULL, 3, '2025-11-16', '09:30:00', 30, 6000.00, 0.00, 6000.00, 'libre'),
(2, NULL, 4, '2025-11-16', '10:00:00', 30, 6000.00, 0.00, 6000.00, 'libre');
