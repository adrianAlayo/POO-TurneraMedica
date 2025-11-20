using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turnera_Medica__TP_Final.Controller
{
    public enum StateShift { programado, asistido, libre, cancelado } // creamos la lista de estados que puede tener el turno
    public class Shift
    {
        public int Id { get; set; } // guarda el id del turno
        public DateTime Date { get; set; } // guarda la fecha del turno
        public TimeSpan Hour { get; set; } // guarda la hora del turno
        public int Duration { get; set; } // guarda cuanto tiempo dura el turno
        public double OriginalPrice { get; set; } // guarda el precio del turno
        public Medic Assigned_Doctor { get; set; } // guarda a que doctor esta asignado este turno
        public Patient PatientAssigned { get; set; } // guarda a que paciente esta asignado este turno (si esta null es porque esta libre el turno)
        public Office OfficeAssigned { get; set; } // guarda en que consultorio se realizara este turno
        public StateShift State { get; set; } // guarda cual es el estado del turno



        public Shift (int id, DateTime date, TimeSpan hour, int duration, double originalprice, Medic assigned_doctor, Patient patientassigned, Office officeassigned, StateShift state)
        {
            Id = id;
            Date = date;
            Hour = hour;
            Duration = duration;
            OriginalPrice = originalprice;
            Assigned_Doctor = assigned_doctor;
            PatientAssigned = patientassigned;
            OfficeAssigned = officeassigned;
            State = state;
        }
    }
}
