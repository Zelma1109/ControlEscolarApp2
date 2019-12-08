using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.ControlEscolarApp
{
    public class Materias
    {
        private string matMateria;
        private string nombre;
        private int horas;
        private int creditos;
        private int fkCarrera;
        private string fkPredecesor;
        private string fkAntecesor;

        public string MatMateria { get => matMateria; set => matMateria = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public int Horas { get => horas; set => horas = value; }
        public int Creditos { get => creditos; set => creditos = value; }
        public int FkCarrera { get => fkCarrera; set => fkCarrera = value; }
        public string FkPredecesor { get => fkPredecesor; set => fkPredecesor = value; }
        public string FkAntecesor { get => fkAntecesor; set => fkAntecesor = value; }
    }
}
