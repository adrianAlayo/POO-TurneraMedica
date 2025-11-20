using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turnera_Medica__TP_Final.Controller
{
    public abstract class User
    {
        public int Id { get; set; } //guarda el id del user
        public int Dni { get; set; } // guarda el dni del user
        public string Name { get; set; } // guarda el nombre del user
        public string LastName { get; set; } // guarda el apellido del user
        public int Age { get; set; } // guarda la edad del user
        public string Email { get; set; } // guarda el email del user
        public string TelNumber { get; set; } // guarda el telefono del user
        public string Password { get; set; } // guarda la contraseña del user
        public List<SocialWork> listObraSocial { get; set; } // guarda la/s obras sociales que esten asignados al user
        public List<Shift> listTurno { get; set; } // guarda los turnos que esten asignados al usuario

        
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
