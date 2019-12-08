using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Entidades.ControlEscolarApp;
using ConexionBd;

namespace AccesoDatos.ContolEscolarApp
{
    public class EscuelapruebaAccesoDatos
    {
        Conexion _conexion;
        public EscuelapruebaAccesoDatos()
        {
            _conexion = new Conexion("localhost", "root", "", "escolar", 3306);
        }
        public void EliminarEscuela(int idEscuela)
        {
            string cadena = string.Format("Delete * from pruebaescuela Where idesc = {0}", idEscuela);
        }
        public void Guardar(Escuelaprueba escuela)
        {
            if (escuela.Idesc == 0)
            {
                string consulta = string.Format("insert into pruebaescuela values ('{0}', '{1}', '{2}', '{3}')",
                    escuela.Idesc,
                    escuela.Nombre,
                    escuela.Director,
                    escuela.Logo);
                _conexion.EjecutarConsulta(consulta);
            }
            else
            {
                string consulta = ("update pruebaescuela set nombre = " + "'" + escuela.Nombre +
                   "', director = '" + escuela.Director +
                   "', logo = '" + escuela.Logo
                    + "'");
                _conexion.EjecutarConsulta(consulta);
            }
        }

        public Escuelaprueba GetEscuela()
        {
            var ds = new DataSet();
            string consulta = "Select * from pruebaescuela";
            ds = _conexion.ObtenerDatos(consulta, "pruebaescuela");
            var dt = new DataTable();
            dt = ds.Tables[0];
            var escuela = new Escuelaprueba();

            foreach (DataRow row in dt.Rows)
            {
                escuela.Idesc = Convert.ToInt32(row["idesc"]);
                escuela.Nombre = row["nombre"].ToString();
                escuela.Director = row["director"].ToString();
                escuela.Logo = row["logo"].ToString();
            }
            return escuela;
        }
    }
}
