﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turnera_Medica__TP_Final.Controller
{
    internal class ObraSocial
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Discount { get; set; }

        public ObraSocial(int id, string name, double discount)
        {
            Id = id;
            Name = name;
            Discount = discount;
        }

        public double ApplyDiscount(decimal originalAmount)
        {
            return 0;
        }
    }
}
