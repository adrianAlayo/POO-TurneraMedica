using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turnera_Medica__TP_Final.Controller
{
    class Turno
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public TimeSpan Hora { get; set; }
        public Medico MedicoAsignado { get; set; }
        public Paciente PacienteAsignado { get; set; } 
        public Consultorio ConsultorioAsignado { get; set; }

        public Turno (int id, DateTime fecha, TimeSpan hora, Medico medicoAsignado, Paciente pacienteAsignado, Consultorio consultorioAsignado)
        {
            Id = id;
            Fecha = fecha;
            Hora = hora;
            MedicoAsignado = medicoAsignado;
            PacienteAsignado = pacienteAsignado;
            ConsultorioAsignado = consultorioAsignado;
        }

        public bool ValidarDisponibilidad()
        {
            return true;
        }

        public void CalcularCosto()
        {

        }


    }
}
