using System;
using System.Collections.Generic;
using System.Data;
using Entidades.ControlEscolarApp;
using ConexionBd;

namespace AccesoDatos.ContolEscolarApp
{
    public class EscuelaAccesoDatos
    {
        Conexion _conexion;
        public EscuelaAccesoDatos()
        {
            _conexion = new Conexion("localhost", "root", "", "escolar", 3306);
        }
        public void Eliminar(int Idesc)
        {
            _conexion.EjecutarConsulta("delete from escuela where idesc = '" + Idesc + "'");
        }
        public void Guardar(Escuela escuela)
        {
            //Store
            if (ObtenerIdesc(escuela.Idesc) == 0)
            {
                string cadena = string.Format("insert into escuela values ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}', '{11}')",
                    escuela.Idesc,
                    escuela.Escuelas,
                    escuela.Domicilio,
                    escuela.Noext,
                    escuela.Estado,
                    escuela.Municipio,
                    escuela.Telefono,
                    escuela.PagWeb,
                    escuela.Correo,
                    escuela.Director,
                    escuela.Imagen,
                    escuela.Rutaimagen); ;
                _conexion.EjecutarConsulta(cadena);
            }
            else
            {
                string cadena = ("update escuela set escuela = " + "'" + escuela.Escuelas +
                   "', direccion = '" + escuela.Domicilio +
                   "', noext = '" + escuela.Noext +
                   "', estado = '" + escuela.Estado +
                   "', municipio = '" + escuela.Municipio +
                   "', telefono = '" + escuela.Telefono +
                   "', pagweb = '" + escuela.PagWeb +
                   "', correo = '" + escuela.Correo +
                   "', director = '" + escuela.Director +
                   "', imagen = '" + escuela.Imagen +
                   "', rutaimagen ='" + escuela.Rutaimagen +
                   "' where idesc = '" + escuela.Idesc + "'");
                _conexion.EjecutarConsulta(cadena);
            }
        }
        public List<Escuela> ObtenerLista(string filtro)
        {
            var list = new List<Escuela>();
            try
            {
                var ds = _conexion.ObtenerDatos("select * from escuela where idesc like '%" + filtro + "%'", "escuela");
                var dt = ds.Tables[0];

                foreach (DataRow dr in dt.Rows)
                {
                    var escuela = new Escuela { Idesc = Convert.ToInt32(dr["idesc"].ToString()),
                        Escuelas = (dr["escuela"].ToString()),
                        Domicilio = (dr["domicilio"].ToString()), 
                        Noext = (dr["noext"].ToString()),
                        Estado = (dr["estado"].ToString()),
                        Municipio = Convert.ToInt32(dr["municipio"].ToString()),
                        Telefono = (dr["telefono"]).ToString(),
                        PagWeb = (dr["pagweb"].ToString()), 
                        Correo = (dr["correo"].ToString()), 
                        Director = (dr["director"].ToString()),
                        Imagen = (dr["imagen"].ToString()),
                        Rutaimagen = (dr["rutaimagen"].ToString())
                    };

                    list.Add(escuela);
                }
            }
            catch (Exception )
            {
            }
            return list;
        }
        public int ObtenerIdesc(int Idesc)
        {
            var res = _conexion.Existencia("select count(*) from escuela where idesc = '" + Idesc + "'");

            return res;
        }
    }
}
