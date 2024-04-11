using System.Data.Entity;
using Datos.Entidades;

namespace Datos.Core
{
    public class RepositorioCita : Repository<Cita>
    {
        public RepositorioCita(DbContext context) : base(context)
        {
        }

    }
}
