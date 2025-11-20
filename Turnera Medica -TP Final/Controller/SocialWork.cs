using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turnera_Medica__TP_Final.Controller
{
    public class SocialWork
    {
        public int Id { get; set; } // guarda el id de la obra social
        public string Name { get; set; } // guarda el nombre de la obra social

        public SocialWork(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
