using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turnera_Medica__TP_Final.Controller
{
    public enum StateShift { programado, asistido, libre, cancelado }
    public class Shift
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public TimeSpan Hour { get; set; }
        public int Duration { get; set; }
        public double OriginalPrice { get; set; }
        public Medic Assigned_Doctor { get; set; }
        public Patient PatientAssigned { get; set; } 
        public Office OfficeAssigned { get; set; }
        public StateShift State { get; set; } 



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

        public bool ValidateAvailability()
        {
            return true; 
        }

        public void CalculateCost()
        {

        }


    }
}
