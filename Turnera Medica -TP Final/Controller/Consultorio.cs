using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turnera_Medica__TP_Final.Controller
{
    public class Consultorio
    {
        public int Id { get; set; }
        public string Location { get; set; }
        public TimeSpan HourOpen { get; set; }
        public TimeSpan TimeClosed { get; set; }
        public List<Medico> Assigned_Doctors { get; set; }

        public Consultorio(int id, string location, TimeSpan houropen, TimeSpan timeclosed, List<Medico> assigned_doctors)
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

        public void AssignDoctor(Medico m)
        {

        }

    }
}
