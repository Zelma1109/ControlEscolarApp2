using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.ControlEscolarApp
{
    public class Estudios
    {
        private int idForm;
        private string tipo;
        private string nombreArchivo;
        private string fechaRecibido;

        public int IdForm { get => idForm; set => idForm = value; }
        public string Tipo { get => tipo; set => tipo = value; }
        public string NombreArchivo { get => nombreArchivo; set => nombreArchivo = value; }
        public string FechaRecibido { get => fechaRecibido; set => fechaRecibido = value; }
    }
}
