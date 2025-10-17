using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turnera_Medica__TP_Final.Controller
{
    class Paciente : User
    {
        public ObraSocial SocialWorkAssigned { get; set; }
        public List<Turno> ShiftList { get; set; } = new List<Turno>();

        public Paciente(int id, int dni, string name, string lastname, string email, string telnumber, string password, ObraSocial socialworkassigned)
            : base(id, dni, name, lastname, email, telnumber, password)
        {
            SocialWorkAssigned = socialworkassigned;
        }

        //Consultar un Turno especifico por fecha
        public override void ConsultShifts(DateTime date)
        {

        }

        //Consultar todos los turnos
        public override void ConsultShifts()
        {

        }

        //Seleccionar un turno disponible, esta informacion se guardara en la lista 
        // de TURNOS del paciente y del Medico asignado
        public void RequestAppointment()
        {
            // Medico m, DateTime fecha, DateTime hora, Consultorio c
           
        }

    }
}
