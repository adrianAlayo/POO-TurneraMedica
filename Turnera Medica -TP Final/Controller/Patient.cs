using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turnera_Medica__TP_Final.Controller
{
    public class Patient : User
    {   
        public int Social_work_id {  get; set; }
        public Patient(int id, int dni, string name, string lastname, int age,string email, string telnumber, string password, int id_socialwork)
            : base(id, dni, name, lastname, age ,email, telnumber, password)
        {
            Social_work_id = id_socialwork;   
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
            
           
        }

    }
}
