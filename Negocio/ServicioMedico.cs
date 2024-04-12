using System.Collections.Generic;
using System.Threading.Tasks;
using Datos.Base_de_datos;
using Datos.Core;
using Datos.Entidades;

namespace Negocio
{
    public class ServicioMedico
    {
        private readonly RepositorioMedico _repositorioMedico;

        public ServicioMedico(ConexDB context)
        {
            _repositorioMedico = new RepositorioMedico(context);
        }

        public async Task<List<Medico>> ObtenerTodosLosMedicosAsync()
        {
            return await _repositorioMedico.ObtenerTodosAsync();
        }

    }
}
