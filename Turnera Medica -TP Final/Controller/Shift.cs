using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turnera_Medica__TP_Final.Controller
{
    public class Shift
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public TimeSpan Hour { get; set; }
        public Medic Assigned_Doctor { get; set; }
        public Patient PatientAssigned { get; set; } 
        public Consultation OfficeAssigned { get; set; }

        public Shift (int id, DateTime date, TimeSpan hour, Medic assigned_doctor, Patient patientassigned, Consultation officeassigned)
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
