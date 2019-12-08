using System;
using System.Collections.Generic;
using System.Data;
using Entidades.ControlEscolarApp;
using ConexionBd;

namespace AccesoDatos.ContolEscolarApp
{
    public class GruposAccesoDatos
    {
        Conexion _conexion;
        public GruposAccesoDatos()
        {
            _conexion = new Conexion("localhost", "root", "", "escolar", 3306);
        }
        public void Eliminar(int noControl)
        {
            _conexion.EjecutarConsulta("delete from Grupos where idGrupo = '" + noControl + "'");
        }

        public void Guardar(Grupos grupos)
        {
            if (grupos.IdGrupo == 0)
            {
                string cadena = string.Format("insert into Grupos values(null, '{0}', '{1}', '{2}')", grupos.Semestre, grupos.Ciclo, grupos.FkCarrera);
                _conexion.EjecutarConsulta(cadena);
            }
            else
            {               
                string cadena = string.Format("update Grupos set semestre = '{1}', generacion = '{2}', fkCarrera = '{3}' where idGrupo = '{0}'", grupos.IdGrupo, grupos.Semestre, grupos.Ciclo, grupos.FkCarrera);
                _conexion.EjecutarConsulta(cadena);
            }
        }
        public List<Grupos> ObtenerLista()
        {
            var list = new List<Grupos>();
            try
            {
                var ds = _conexion.ObtenerDatos("select * from Grupos", "Grupos");
                var dt = ds.Tables[0];

                foreach (DataRow dr in dt.Rows)
                {
                    var grupos = new Grupos { IdGrupo = Convert.ToInt32(dr["idGrupo"].ToString()), Semestre = (dr["semestre"].ToString()), Ciclo = (dr["generacion"].ToString()), FkCarrera = Convert.ToInt32(dr["fkCarrera"].ToString()) };

                    list.Add(grupos);
                }
            }
            catch (Exception ex)
            {
            }
            return list;
        }
    }
}
