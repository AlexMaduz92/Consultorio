using System.Data.Entity;
using Datos.Entidades;

namespace Datos.Core
{
    public class RepositorioPaciente : Repository<Paciente>
    {
        public RepositorioPaciente(DbContext context) : base(context)
        {
        }

    }
}
