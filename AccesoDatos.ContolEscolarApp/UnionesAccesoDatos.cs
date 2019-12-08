using System;
using System.Collections.Generic;
using System.Data;
using Entidades.ControlEscolarApp;
using ConexionBd;

namespace AccesoDatos.ContolEscolarApp
{
    public class UnionesAccesoDatos
    {
        Conexion _conexion;

        public UnionesAccesoDatos()
        {
            _conexion = new Conexion("localhost", "root", "", "escolar", 3306);
        }
        public void EliminarGA(int noControl)
        {
            _conexion.EjecutarConsulta("delete from GruposxAlumnos where idUnion = '" + noControl + "'");
        }

        public void EliminarGM(int noControl)
        {
            _conexion.EjecutarConsulta("delete from GruposxMaterias where idUnion = '" + noControl + "'");
        }

        public void GuardarGA(Unionga union)
        {
            //Store
            if (union.IdUnion == 0)
            {
                string cadena = string.Format("insert into GruposxAlumnos values(null, '{0}', '{1}')", union.FkGrupo, union.FkAlumno);
                _conexion.EjecutarConsulta(cadena);
            }
            else
            {
              
                string cadena = string.Format("update GruposxAlumnos set fkAlumno = '{1} where idUnion = '{0}'", union.FkAlumno, union.IdUnion);
                _conexion.EjecutarConsulta(cadena);
            }
        }

        public void GuardarGM(Uniongm union)
        {
            if (union.IdUnion == 0)
            {
                string cadena = string.Format("insert into GruposxMaterias values (null, '{0}', '{1}')", union.FkGrupo, union.FkMateria);
                _conexion.EjecutarConsulta(cadena);
            }
            else
            {
               
                string cadena = string.Format("update GruposxMaterias set fkAlumno = '{1} where idUnion = '{0}'", union.FkMateria, union.IdUnion);
                _conexion.EjecutarConsulta(cadena);
            }
        }
        public List<Unionga> ObtenerListaGA(string filtro)
        {
            var list = new List<Unionga>();
            try
            {
                var ds = _conexion.ObtenerDatos("select * from vistaUnionGA where semestre = '" + filtro + "'", "vistaUnionGA");
                var dt = ds.Tables[0];

                foreach (DataRow dr in dt.Rows)
                {
                    var union = new Unionga { IdUnion = Convert.ToInt32(dr["idUnion"].ToString()), Semestre = (dr["semestre"].ToString()), Nombre = (dr["nombre"].ToString()), ApellidoPaterno = (dr["apellidoPaterno"].ToString()), ApellidoMaterno = (dr["apellidoMaterno"].ToString()) };

                    list.Add(union);
                }
            }
            catch (Exception ex)
            {
            }
            return list;
        }

        public List<Uniongm> ObtenerListaGM(string filtro)
        {
            var list = new List<Uniongm>();
            try
            {
                var ds = _conexion.ObtenerDatos("select * from vistaUnionGM where semestre = '" + filtro + "'", "vistaUnionGM");
                var dt = ds.Tables[0];

                foreach (DataRow dr in dt.Rows)
                {
                    var union = new Uniongm { IdUnion = Convert.ToInt32(dr["idUnionGM"].ToString()), Semestre = (dr["semestre"].ToString()), Nombre = (dr["nombre"].ToString()) };

                    list.Add(union);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return list;
        }
    }
}
