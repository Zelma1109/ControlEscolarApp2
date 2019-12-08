using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.ControlEscolarApp
{
    public class Grupos
    {
        private int idGrupo;
        private string semestre;
        private string ciclo;
        private int fkCarrera;

        public int IdGrupo { get => idGrupo; set => idGrupo = value; }
        public string Semestre { get => semestre; set => semestre = value; }
        public string Ciclo { get => ciclo; set => ciclo = value; }
        public int FkCarrera { get => fkCarrera; set => fkCarrera = value; }
    }
}
