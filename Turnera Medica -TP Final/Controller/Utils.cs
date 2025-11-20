using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Turnera_Medica__TP_Final.Controller
{
    internal static class Utils
    {
        public static string HashPassword(string password) //metodo para que la contraseña pase a estar hasheada 
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password)); //transforma la cadena de texto a una secuencia de bytes,y luego calcula el hash 
                StringBuilder builder = new StringBuilder();
                foreach (byte b in bytes)
                {
                    builder.Append(b.ToString("x2")); //este lo que hace es convertir cada byte a su valor hexadecimal de dos digitos 
                }
                return builder.ToString(); // devuelve la cadena hexadecimal en forma de string
            }
        }
    }
}
 