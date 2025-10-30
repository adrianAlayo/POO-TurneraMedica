using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turnera_Medica__TP_Final.Controller
{
    abstract class User
    {
        public int Id { get; set; }
        public int Dni { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string TelNumber { get; set; }
        public string Password { get; set; }
        
        public User (int id, int dni, string name, string lastname, string email, string telnumber,string password)
        {
            Id = id;
            Dni = dni;
            Name = name;
            LastName = lastname;
            Email = email;
            TelNumber = telnumber;
            Password = password;
        }

        //Sobre cargar de metodo (1) - Consultar turno especifico
        public abstract void ConsultShifts(DateTime date);
        //Sobre cargar de metodo (2) -Consultar todos los turnos
        public abstract void ConsultShifts();
       
        public void Login()
        {
            //Aca hacer la logica de si la informacion existe en la base de datos, Si es asi moverlo a otra venta
            Console.WriteLine($"Hola {Name}, has iniciado sesion");
        }
        public void Logout()
        {
            //Cuando el usuario cierra sesion le envia a la ventana de "inicio sesion"
            Console.WriteLine($"Hola {Name}, has cerrado sesion");
        }

    }
}
