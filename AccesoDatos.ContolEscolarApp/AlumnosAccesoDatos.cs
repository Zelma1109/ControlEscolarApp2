using System;
using System.Collections.Generic;
using System.Data;
using Entidades.ControlEscolarApp;
using ConexionBd;

namespace AccesoDatos.ContolEscolarApp
{
    public class AlumnosAccesoDatos
    {
        Conexion _conexion;
        public AlumnosAccesoDatos()
        {
            _conexion = new Conexion("localhost", "root", "", "escolar", 3306);
        }
        public void Eliminar(string noControl)
        {
            //var cadena = string.Format("delete from usuario where idUsuario = {0}", idUsuario);
            _conexion.EjecutarConsulta("delete from Alumnos where noControl = '" + noControl + "'");
        }

        public void Guardar(Alumnos alumnos)
        {
            //Store
            if (ObtenerNumControl(alumnos.NoControl) == 0)
            {
                string cadena = string.Format("insert into Alumnos values ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}')", alumnos.NoControl, alumnos.Nombre, alumnos.ApellidoPaterno, alumnos.ApellidoMaterno, alumnos.Genero, alumnos.FechadeNacimiento, alumnos.CorreoElectronico, alumnos.TelefonodeContacto, alumnos.Estado, alumnos.Municipio, alumnos.Domicilio); ;
                _conexion.EjecutarConsulta(cadena);
            }
            else
            {
                //string cadena = string.Format("update Alumnos set Nombre = '{1}', apellidoPaterno = '{2}', apellidoMaterno = '{3}', genero = '{4}', fechadeNacimiento = '{5}', correoElectronico = '{6}', telefonodeContacto = '{7}', estado = '{8}', municipio = '{9}', domicilio = '{10}' where noControl = '{1}'", alumnos.NoControl, alumnos.Nombre, alumnos.ApellidoPaterno, alumnos.ApellidoMaterno, alumnos.Genero, alumnos.FechadeNacimiento, alumnos.CorreoElectronico, alumnos.TelefonodeContacto, alumnos.Estado, alumnos.Municipio, alumnos.Domicilio);
                string cadena = ("update Alumnos set nombre = '" + alumnos.Nombre + "', apellidoPaterno = '" + alumnos.ApellidoPaterno + "', apellidoMaterno = '" + alumnos.ApellidoMaterno + "', genero = '" + alumnos.Genero + "', fechadeNacimiento = '" + alumnos.FechadeNacimiento + "', correoElectronico = '" + alumnos.CorreoElectronico + "', telefonodeContacto = '" + alumnos.TelefonodeContacto + "', estado = '" + alumnos.Estado + "', municipio = '" + alumnos.Municipio + "', domicilio = '" + alumnos.Domicilio + "' where noControl = '" + alumnos.NoControl + "'");
                _conexion.EjecutarConsulta(cadena);
            }
        }

        public List<Alumnos> ObtenerLista(string filtro)
        {
            var list = new List<Alumnos>();
            try
            {
                var ds = _conexion.ObtenerDatos("select * from Alumnos where noControl like '%" + filtro + "%'", "Alumnos");
                //var ds = _conexion.ObtenerDatos("select * from Alumnos", "Alumnos");
                var dt = ds.Tables[0];

                foreach (DataRow dr in dt.Rows)
                {
                    var alumno = new Alumnos { NoControl = (dr["noControl"].ToString()), Nombre = (dr["nombre"].ToString()), ApellidoPaterno = (dr["apellidoPaterno"].ToString()), ApellidoMaterno = (dr["apellidoMaterno"].ToString()), Genero = (dr["genero"].ToString()), FechadeNacimiento = (dr["fechadeNacimiento"]).ToString(), CorreoElectronico = (dr["correoElectronico"].ToString()), TelefonodeContacto = (dr["telefonodeContacto"].ToString()), Estado = (dr["estado"].ToString()), Municipio = Convert.ToInt32(dr["municipio"].ToString()), Domicilio = (dr["domicilio"].ToString()) };

                    list.Add(alumno);
                }
            }
            catch (Exception )
            {
            }
            return list;
        }
        public int ObtenerNumControl(string noControl)
        {
            var res = _conexion.Existencia("select count(*) from Alumnos where noControl = '" + noControl + "'");

            return res;
        }
    }
}
