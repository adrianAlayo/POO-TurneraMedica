using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turnera_Medica__TP_Final.Controller
{
    class Medico : User
    {
        //Saber la especialidad del Medico
        public string Specialty { get; set; }
        
        //Saber Cuando cobra la consulta
        public double ConsultationAmount { get; set; }
        
        //Consultorio/lugar donde trabaja
        public int OfficeAssigned { get; set; } //Guarda el ID del consultario, en la tabla que relaciona medico con consultorio

        public Medico (int id, int dni, string name, string lastname, string email, string telnumber, string password, string specialty, double consultationamount, int officeassigned) 
            : base(id, dni, name, lastname, email, telnumber, password)
        {
            Specialty = specialty;
            ConsultationAmount = consultationamount;
            OfficeAssigned = officeassigned;
        }

        //Consultar un Turno especifico por fecha
        public override void specificShift(DateTime date)
        {
            //CREAR LA LOGICA DE HACER LAS CONSULTAS
        }

        //Consultar todos los turnos
        public override void Shifts()
        {

        }

        //Calcular cuanto recaudo El medico en un rango de una fecha. 
        public double CalculateReceipt(DateTime from, DateTime until)
        {
            return 0;
        }

        //Sirve para que el medico agrega una obra social a su lista de Obras Sociales.
        public void AddSocialWork(ObraSocial Os)
        {

        }
        //Cuando el usuario elegiga que quiere hacer el turno con este medico, a el ese turno especifico se le actualizara el estado del turno
        public void ActualizarTurnoPorUsuario()
        {

        }

        //Cuando el paciente no asista al turno el emdico tendra que actualizar el turno como no asistido de parte del paciente
        public void ActulizarUsuarioNoAsistido()
        {

        }
    }
}
