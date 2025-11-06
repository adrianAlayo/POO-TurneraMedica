using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turnera_Medica__TP_Final.Controller
{
    public class Paciente : User
    {
        public Paciente(int id, int dni, string name, string lastname, string email, string telnumber, string password, int id_socialwork)
            : base(id, dni, name, lastname, email, telnumber, password)
        {
            
        }

        //Consultar un Turno especifico por fecha
        public override void specificShift(DateTime date)
        {

        }

        //Consultar todos los turnos
        public override void Shifts()
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
