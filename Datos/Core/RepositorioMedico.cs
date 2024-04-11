using Datos.Entidades;
using System.Data.Entity;

namespace Datos.Core
{
    public class RepositorioMedico : Repository<Medico>
    {
        public RepositorioMedico(DbContext context) : base(context)
        {
        }
    }
}
