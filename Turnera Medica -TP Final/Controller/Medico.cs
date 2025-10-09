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
        public string Especialidad { get; set; }
        
        //Saber Cuando cobra la consulta
        public double MontoConsulta { get; set; }
        
        //Lista de turnos que añadio el medico
        public List<Turno> ListaTurnos { get; set; } = new List<Turno>();
        public List<Turno> listaTurnosPorAceptar { get; set; } = new List<Turno>();
        
        //Consultorio/lugar donde trabaja
        public Consultorio ConsultorioAsignado { get; set; }

        //Las multiples obras sociales que tiene
        public List<ObraSocial> ObrasSocialesAtendidas { get; set; } = new List<ObraSocial>();

        public Medico (int id, int dni, string nombre, string apellido, string email, string numerotel, string password, string especialidad, double montoConsulta, Consultorio consultorioAsignado) 
            : base(id, dni, nombre, apellido, email, numerotel, password)
        {
            Especialidad = especialidad;
            MontoConsulta = montoConsulta;
            ConsultorioAsignado = consultorioAsignado;
        }

        //Consultar un Turno especifico por fecha
        public override void ConsultarTurnos(DateTime fecha)
        {

        }

        //Consultar todos los turnos
        public override void ConsultarTurnos()
        {

        }

        //Aceptar turno del paciente, para que se guarde en nuestra lista de turnos
        public void AceptarTurno()
        {

        }

        //Calcular cuanto recaudo El medico en un rango de una fecha. 
        public double CalcularRecaudacion(DateTime desde, DateTime hasta)
        {
            return 0;
        }

        //Sirve para que el medico agrega una obra social a su lista de Obras Sociales.
        public void AgregarObraSocial(ObraSocial Os)
        {

        }

    }
}
