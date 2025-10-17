# Turnería Médica - Proyecto TP

Este repositorio contiene el código y recursos para el desarrollo de una turnería médica, basada en la consigna del trabajo práctico pero con funcionalidades ampliadas que mejoran la gestión de turnos y la experiencia tanto de médicos como pacientes.

## Descripción del Proyecto

El sistema desarrollado permite gestionar de manera integral la turnería médica, incluyendo las siguientes funcionalidades:

### Funcionalidades básicas (según consigna)

- **Administrar médicos:** Cada médico es un usuario del sistema que puede consultar sus turnos para una fecha determinada.
- **Cobro por consulta:** Cada médico tiene un valor asignado por consulta.
- **Administrar pacientes:** Registro y gestión de pacientes.
- **Administrar turnos:** Gestión de turnos por fecha y hora, evitando solapamientos con un mismo médico. La selección de médico y paciente se realiza desde listas predefinidas.
- **Reportes:** Generación de informes sobre cuánto ha cobrado un médico y la cantidad de consultas realizadas entre dos fechas.

### Funcionalidades adicionales implementadas

- **Pacientes como usuarios:** Los pacientes pueden consultar sus turnos asignados.
- **Administrar lugares de atención (consultorios):** Cada médico tiene asignado un consultorio para períodos específicos, y los turnos deben tomarse en el consultorio correspondiente.
- **Reporte adicional:** Listado de médicos con su recaudación entre dos fechas.
- **Obras sociales:** Si un paciente y un médico comparten la misma obra social, se aplica un descuento del 50% en la consulta.
- **Vista en calendario:** Se implementa una grilla semanal o mensual para visualizar los turnos de manera intuitiva.

---

## Estructura del repositorio

- `/Controller`: Contiene las clases que gestionan la lógica del sistema.
- `/GUI`: Carpeta principal de las interfaces gráficas (Windows Forms).
  - `/GUI_General`: Formularios generales y comunes a todo el sistema.
  - `/GUI_Medic`: Formularios y ventanas relacionadas con la gestión de médicos.
  - `/GUI_Pacient`: Formularios y ventanas relacionadas con la gestión de pacientes.
- `/Models`: Contiene la conexión y modelos relacionados con la base de datos.
- `/Assets`: Recursos estáticos del proyecto.
  - `/db`: Archivo comprimido con la estructura y datos iniciales de la base de datos.
  - `/img`: Imágenes y bocetos, incluyendo el archivo PNG del bosquejo de la interfaz.

---

## Base de datos

En la carpeta `/models` encontrarás el archivo comprimido con la estructura y datos iniciales de la base de datos utilizada para el proyecto.

---

¡Gracias por visitar el repositorio!
