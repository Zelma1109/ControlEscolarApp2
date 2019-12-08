using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.ControlEscolarApp
{
    public class Uniongm
    {
        private int idUnion;
        private int fkGrupo;
        private string fkMateria;
        private string semestre;
        private string nombre;

        public int IdUnion { get => idUnion; set => idUnion = value; }
        public int FkGrupo { get => fkGrupo; set => fkGrupo = value; }
        public string FkMateria { get => fkMateria; set => fkMateria = value; }
        public string Semestre { get => semestre; set => semestre = value; }
        public string Nombre { get => nombre; set => nombre = value; }

    }
}
