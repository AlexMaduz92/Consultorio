using Datos.Base_de_datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos.Core;

namespace Negocio
{
    public class ServicioPaciente
    {
        private readonly ConexDB _context;
        private readonly RepositorioPaciente _repositorioPaciente;

        public ServicioPaciente(ConexDB context)
        {
            _context = context;
            _repositorioPaciente = new RepositorioPaciente(context);
        }

 
    }

}
