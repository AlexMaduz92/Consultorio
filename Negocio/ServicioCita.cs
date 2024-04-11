using Datos.Base_de_datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class ServicioCita
    {
        private readonly ConexDB _context;
        private readonly RepositorioCita _repositorioCita;

        public ServicioCita(ConexDB context)
        {
            _context = context;
            _repositorioCita = new RepositorioCita(context);
        }

    }

}
