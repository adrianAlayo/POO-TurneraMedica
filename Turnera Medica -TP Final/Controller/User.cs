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
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Email { get; set; }
        public string NumeroTel { get; set; }
        public string Password { get; set; }
        
        public User (int id, int dni, string nombre, string apellido, string email, string numerotel,string password)
        {
            Id = id;
            Dni = dni;
            Nombre = nombre;
            Apellido = apellido;
            Email = email;
            NumeroTel = numerotel;
            Password = password;
        }

        //Sobre cargar de metodo (1) - Consultar turno especifico
        public abstract void ConsultarTurnos(DateTime fecha);
        //Sobre cargar de metodo (2) -Consultar todos los turnos
        public abstract void ConsultarTurnos();
       
        public void Login()
        {
            //Aca hacer la logica de si la informacion existe en la base de datos, Si es asi moverlo a otra venta
            Console.WriteLine($"Hola {Nombre}, has iniciado sesion");
        }
        public void Logout()
        {
            //Cuando el usuario cierra sesion le envia a la ventana de "inicio sesion"
            Console.WriteLine($"Hola {Nombre}, has cerrado sesion");
        }

    }
}
