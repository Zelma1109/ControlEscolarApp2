using System;
using System.Collections.Generic;
using Entidades.ControlEscolarApp;
using ConexionBd;
using System.Data;

namespace AccesoDatos.ContolEscolarApp
{
    public class EstadosAccesoDatos
    {
        Conexion _conexion;

        public EstadosAccesoDatos()
        {
            _conexion = new Conexion("localhost", "root", "", "escolar", 3306);
        }

        public List<Estados> ObtenerLista()
        {
            var list = new List<Estados>();

            try
            {
                var ds = _conexion.ObtenerDatos("select * from Estados", "Estados");
                var dt = ds.Tables[0];

                foreach (DataRow dr in dt.Rows)
                {
                    var estados = new Estados { Codigo = dr["codigo"].ToString(), Nombre = dr["nombre"].ToString() };
                    list.Add(estados);
                }
            }
            catch (Exception)
            {

            }

            return list;
        }
    }
}
