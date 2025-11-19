using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turnera_Medica__TP_Final.Controller
{
    public class SocialWork
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public SocialWork(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public double ApplyDiscount(decimal originalAmount)
        {
            return 0;
        }
    }
}
