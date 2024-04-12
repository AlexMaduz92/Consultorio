using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using Datos.Entidades;

namespace Datos.Core
{
    public class RepositorioMedico : Repository<Medico>
    {
        public RepositorioMedico(DbContext context) : base(context)
        {
        }

        public async Task<List<Medico>> ObtenerTodosAsync()
        {
            return await Context.Set<Medico>().ToListAsync();
        }
    }
}
