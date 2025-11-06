using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turnera_Medica__TP_Final.Controller
{
    public class Turno
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public TimeSpan Hour { get; set; }
        public Medico Assigned_Doctor { get; set; }
        public Paciente PatientAssigned { get; set; } 
        public Consultorio OfficeAssigned { get; set; }

        public Turno (int id, DateTime date, TimeSpan hour, Medico assigned_doctor, Paciente patientassigned, Consultorio officeassigned)
        {
            Id = id;
            Date = date;
            Hour = hour;
            Assigned_Doctor = assigned_doctor;
            PatientAssigned = patientassigned;
            OfficeAssigned = officeassigned;
        }

        public bool ValidateAvailability()
        {
            return true;
        }

        public void CalculateCost()
        {

        }


    }
}
