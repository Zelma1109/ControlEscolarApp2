using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.ControlEscolarApp
{
    public class Documentos
    {
        private string claveMaestro;
        private string tipo;
        private string archivo;
        private string fecha;

        public string ClaveMaestro { get => claveMaestro; set => claveMaestro = value; }
        public string Tipo { get => tipo; set => tipo = value; }
        public string Archivo { get => archivo; set => archivo = value; }
        public string Fecha { get => fecha; set => fecha = value; }
    }
}
