using System;
using System.Collections.Generic;
using System.Data;
using Entidades.ControlEscolarApp;
using ConexionBd;

namespace AccesoDatos.ContolEscolarApp
{
   public class CarrerasAccesoDatos
    {
        Conexion _conexion;
        public CarrerasAccesoDatos()
        {
            _conexion = new Conexion("localhost", "root", "", "escolar", 3306);
        }
        public void Eliminar(int noControl)
        {
            _conexion.EjecutarConsulta("delete from Carreras where idCarrera = '" + noControl + "'");
        }
        public void Guardar(Carreras carreras)
        {

            if (carreras.IdCarrera == 0)
            {
                string cadena = string.Format("insert into Carreras values (null, '{0}')", carreras.Nombre);
                _conexion.EjecutarConsulta(cadena);
            }
            else
            {
                string cadena = ("update Alumnos set nombre = '" + carreras.Nombre + "' where idCarrera = '" + carreras.IdCarrera + "'");
                _conexion.EjecutarConsulta(cadena);
            }
        }
        public List<Carreras> ObtenerLista()
        {
            var list = new List<Carreras>();
            try
            {
                var ds = _conexion.ObtenerDatos("select * from Carreras", "Carreras");
                var dt = ds.Tables[0];

                foreach (DataRow dr in dt.Rows)
                {
                    var carreras = new Carreras { IdCarrera = Convert.ToInt32(dr["idCarrera"].ToString()), Nombre = dr["nombre"].ToString() };

                    list.Add(carreras);
                }
            }
            catch (Exception ex)
            {
            }
            return list;
        }
    }
}
