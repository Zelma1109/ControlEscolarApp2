using System;
using System.Collections.Generic;
using System.Data;
using Entidades.ControlEscolarApp;
using ConexionBd;

namespace AccesoDatos.ContolEscolarApp
{
    public class EstudiosAccesoDatos
    {
        Conexion _conexion;

        public EstudiosAccesoDatos()
        {
            _conexion = new Conexion("localhost", "root", "", "escolar", 3306);
        }
        public void Eliminar(string noControl)
        {
            _conexion.EjecutarConsulta("delete from MxE where fkEstudios = '" + noControl + "'");
            _conexion.EjecutarConsulta("delete from Estudios where idForm = '" + noControl + "'");
        }

        public void Guardar(Estudios estudios, Maestros maestros, int unionid, bool isNewElement)
        {
            if (isNewElement)
            {
                string cadenaEstudio = string.Format("insert into Estudios values ('{0}','{1}', '{2}', '{3}')", estudios.IdForm, estudios.Tipo, estudios.NombreArchivo, estudios.FechaRecibido);
                _conexion.EjecutarConsulta(cadenaEstudio);
                string cadenaUnion = string.Format("insert into MxE values ('{0}', '{1}', '{2}')", unionid, maestros.NoControlM, estudios.IdForm);
                _conexion.EjecutarConsulta(cadenaUnion);
            }
            else
            {
                string cadena = string.Format("update Estudios set tipo = '{0}', nombreArchivo = '{1}', fechaRecibio = '{2}' where idForm = '{3}'", estudios.Tipo, estudios.NombreArchivo, estudios.FechaRecibido, estudios.IdForm);
                _conexion.EjecutarConsulta(cadena);
            }
        }

        public List<Documentos> ObtenerLista(string noControl)
        {
            var list = new List<Documentos>();
            try
            {
                var ds = _conexion.ObtenerDatos("select * from mirarDocumentos where Clave_maestro = '" + noControl + "'", "mirarDocumentos");
                var dt = ds.Tables[0];
                Console.WriteLine("entre");

                foreach (DataRow dr in dt.Rows)
                {
                    var Docs = new Documentos { ClaveMaestro = (dr["Clave_maestro"].ToString()), Tipo = (dr["Tipo"].ToString()), Archivo = (dr["Archivo"].ToString()), Fecha = (dr["Fecha"].ToString()) };

                    list.Add(Docs);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return list;
        }


        public int ObtenerArchivoClave(int id)
        {
            var res = _conexion.Existencia("select count(*) from Estudios where idForm = '" + id + "'");

            return res;
        }

        public int ObtenerUnionclave(int id)
        {
            var res = _conexion.Existencia("select count(*) from MxE where id = '" + id + "'");

            return res;
        }

        public int ObtenerClaveExacta(string nArchivo)
        {
            var res = int.Parse(_conexion.ObtenerDatos("select idForm from Estudios where nombreArchivo = '" + nArchivo + "'", "Estudios").Tables[0].Rows[0][""].ToString());

            return res;
        }

    }
}
