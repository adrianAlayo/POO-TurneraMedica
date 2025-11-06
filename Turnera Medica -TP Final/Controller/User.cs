using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turnera_Medica__TP_Final.Controller
{
    public abstract class User
    {
        public int Id { get; set; }
        public int Dni { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
        public string TelNumber { get; set; }
        public string Password { get; set; }
        public List<SocialWork> listObraSocial { get; set; }
        public List<Shift> listTurno { get; set; }

        
        public User (int id, int dni, string name, string lastname, int age, string email, string telnumber,string password)
        {
            Id = id;
            Dni = dni;
            Name = name;
            LastName = lastname;
            Age = age;
            Email = email;
            TelNumber = telnumber;
            Password = password;
        }

        //Sobre cargar de metodo (1) - Consultar turno especifico
        public abstract void specificShift(DateTime date);
        //Sobre cargar de metodo (2) -Consultar todos los turnos
        public abstract void Shifts();
       
        public string Login()
        {
            return $"Hola {Name}, has iniciado sesion";
        }
        public string Logout()
        {
            return $"Hola {Name}, has cerrado sesion";
        }

    }
}
