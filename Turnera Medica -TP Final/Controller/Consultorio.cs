using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turnera_Medica__TP_Final.Controller
{
    class Consultorio
    {
        public int Id { get; set; }
        public string Ubicacion { get; set; }
        public TimeSpan HoraAbierto { get; set; }
        public TimeSpan HoraCerrado { get; set; }
        public List<Medico> MedicosAsignados { get; set; }

        public Consultorio(int id, string ubicacion, TimeSpan horaAbierto, TimeSpan horaCerrado, List<Medico> medicosAsignados)
        {
            Id = id;
            Ubicacion = ubicacion;
            HoraAbierto = horaAbierto;
            HoraCerrado = horaCerrado;
            MedicosAsignados = medicosAsignados;
        }

        public bool VerificarDisponibilidad(DateTime fecha, TimeSpan hora)
        {
            return true;
        }

        public void AsignarMedico(Medico m)
        {

        }

    }
}
