using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Entidades
{
    public class Cita
    {
        public int CitaId { get; set; }
        public int MedicoId { get; set; }
        public int PacienteId { get; set; }
        public DateTime FechaCita { get; set; }
        public bool Estado { get; set; }

        public virtual Medico Medico { get; set; }
        public virtual Paciente Paciente { get; set; }
    }
}
