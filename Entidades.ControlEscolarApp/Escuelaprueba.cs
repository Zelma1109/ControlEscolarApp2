using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.ControlEscolarApp
{
    public class Escuelaprueba
    {
        private int _idesc;
        private string _nombre;
        private string _director;
        private string _logo;

        public int Idesc { get => _idesc; set => _idesc = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Director { get => _director; set => _director = value; }
        public string Logo { get => _logo; set => _logo = value; }
    }
}
