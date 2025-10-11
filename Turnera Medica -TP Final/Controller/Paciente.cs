using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turnera_Medica__TP_Final.Controller
{
    class Paciente : User
    {
        public ObraSocial ObraSocialAsignado { get; set; }
        public List<Turno> ListaTurnos { get; set; } = new List<Turno>();

        public Paciente(int id, int dni, string nombre, string apellido, string email, string numerotel, string password, ObraSocial obraSocialAsignado)
            : base(id, dni, nombre, apellido, email, numerotel, password)
        {   
            ObraSocialAsignado = obraSocialAsignado;
        }

        //Consultar un Turno especifico por fecha
        public override void ConsultarTurnos(DateTime fecha)
        {

        }

        //Consultar todos los turnos
        public override void ConsultarTurnos()
        {

        }

        //Seleccionar un turno disponible, esta informacion se guardara en la lista 
        // de TURNOS del paciente y del Medico asignado
        public void SolicitarTurno()
        {
            // Medico m, DateTime fecha, DateTime hora, Consultorio c
           
        }

    }
}
