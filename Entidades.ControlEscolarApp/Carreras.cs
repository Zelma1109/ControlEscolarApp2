using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.ControlEscolarApp
{
    public class Carreras
    {
        private int idCarrera;
        private string nombre;

        public int IdCarrera { get => idCarrera; set => idCarrera = value; }
        public string Nombre { get => nombre; set => nombre = value; }
    }
}
