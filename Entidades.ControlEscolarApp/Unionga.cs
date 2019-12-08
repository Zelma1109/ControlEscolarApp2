using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.ControlEscolarApp
{
    public class Unionga
    {
        private int idUnion;
        private string semestre;
        private string nombre;
        private string apellidoPaterno;
        private string apellidoMaterno;
        private int fkGrupo;
        private string fkAlumno;

        public int IdUnion { get => idUnion; set => idUnion = value; }
        public string Semestre { get => semestre; set => semestre = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string ApellidoPaterno { get => apellidoPaterno; set => apellidoPaterno = value; }
        public string ApellidoMaterno { get => apellidoMaterno; set => apellidoMaterno = value; }
        public int FkGrupo { get => fkGrupo; set => fkGrupo = value; }
        public string FkAlumno { get => fkAlumno; set => fkAlumno = value; }
    }
}
