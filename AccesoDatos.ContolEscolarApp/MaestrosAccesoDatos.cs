using System;
using System.Collections.Generic;
using System.Data;
using Entidades.ControlEscolarApp;
using ConexionBd;

namespace AccesoDatos.ContolEscolarApp
{
    public class MaestrosAccesoDatos
    {
        Conexion _conexion;
        public MaestrosAccesoDatos()
        {
            _conexion = new Conexion("localhost", "root", "", "escolar", 3306);
        }
        public void Eliminar(string noControlM)
        {
            _conexion.EjecutarConsulta("delete from Maestros where noControlM = '" + noControlM + "'");
        }

        public void Guardar(Maestros maestros)
        {
            //Store
            if (ObtenerNumControlM(maestros.NoControlM) == 0)
            {
                string cadena = string.Format("insert into maestros values ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}','{11}','{12}','{13}')",
                    maestros.NoControlM,
                    maestros.Nombre, 
                    maestros.ApellidoPaterno, 
                    maestros.ApellidoMaterno, 
                    maestros.Genero,
                    maestros.FechadeNacimiento,
                    maestros.CorreoElectronico, 
                    maestros.TelefonodeContacto, 
                    maestros.nocuenta, 
                    maestros.Estado,
                    maestros.Municipio, 
                    maestros.Licenciatura, 
                    maestros.Maestria, 
                    maestros.Doctorado
                    //maestros.Licenciaturadoc, 
                    //maestros.Maestriadoc, 
                    //maestros.Doctoradodoc
                    ); 
                _conexion.EjecutarConsulta(cadena);
            }
            else
            {
                string cadena = ("update Maestros set nombre = '" + maestros.Nombre + 
                    "', apellidoPaterno = '" + maestros.ApellidoPaterno + 
                    "', apellidoMaterno = '" + maestros.ApellidoMaterno + 
                    "', genero = '" + maestros.Genero + 
                    "', fechadeNacimiento = '" + maestros.FechadeNacimiento + 
                    "', correoElectronico = '" + maestros.CorreoElectronico + 
                    "', telefonodeContacto = '" + maestros.TelefonodeContacto + 
                    "', nocuenta = '" + maestros.nocuenta + 
                    "', estado = '" + maestros.Estado + 
                    "', municipio = '" + maestros.Municipio + 
                    "', licenciatura = '" + maestros.Licenciatura + 
                    "', maestria= '" + maestros.Maestria + 
                    "', doctorado = '" + maestros.Doctorado +
                     "' where noControlM = '" + maestros.NoControlM + "'");
                _conexion.EjecutarConsulta(cadena);
            }
        }

        public List<Maestros> ObtenerLista(string filtro)
        {
            var list = new List<Maestros>();
            try
            {
                var ds = _conexion.ObtenerDatos("select * from Maestros where noControlM like '%" + filtro + "%'", "Maestros");
                var dt = ds.Tables[0];

                foreach (DataRow dr in dt.Rows)
                {
                    var maestro = new Maestros { NoControlM = (dr["noControlM"].ToString()), 
                        Nombre = (dr["nombre"].ToString()), 
                        ApellidoPaterno = (dr["apellidoPaterno"].ToString()), 
                        ApellidoMaterno = (dr["apellidoMaterno"].ToString()),
                        Genero = (dr["genero"].ToString()), 
                        FechadeNacimiento = (dr["fechadeNacimiento"]).ToString(),
                        CorreoElectronico = (dr["correoElectronico"].ToString()),
                        TelefonodeContacto = (dr["telefonodecontacto"].ToString()),
                        nocuenta = (dr["nocuenta"].ToString()),
                        Estado = (dr["estado"].ToString()),
                        Municipio = Convert.ToInt32(dr["municipio"].ToString()),
                        Licenciatura = (dr["licenciatura"].ToString()),
                        Maestria = (dr["maestria"].ToString()),
                        Doctorado = (dr["doctorado"].ToString()),
                         };

                    list.Add(maestro);
                }
            }
            catch (Exception )
            {
            }
            return list;
        }
        public int ObtenerNumControlM(string noControlM)
        {
            var res = _conexion.Existencia("select count(*) from Maestros where noControlM = '" + noControlM + "'");
            return res;
        }
    }
}
