using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turnera_Medica__TP_Final.Controller
{
    public class Consultation
    {
        public int Id { get; set; }
        public string Location { get; set; }
        public TimeSpan HourOpen { get; set; }
        public TimeSpan TimeClosed { get; set; }
        public List<Medic> Assigned_Doctors { get; set; }

        public Consultation(int id, string location, TimeSpan houropen, TimeSpan timeclosed, List<Medic> assigned_doctors)
        {
            Id = id;
            Location = location;
            HourOpen = houropen;
            TimeClosed = timeclosed;
            Assigned_Doctors = assigned_doctors;
        }

        public bool CheckAvailability(DateTime date, TimeSpan hour)
        {
            return true;
        }

        public void AssignDoctor(Medic m)
        {

        }

    }
}
