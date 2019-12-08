using System;
using System.Collections.Generic;
using System.Data;
using ConexionBd;
using Entidades.ControlEscolarApp;

namespace AccesoDatos.ContolEscolarApp
{
    public class MunicipiosAccesoDatos
    {
        Conexion _conexion;

        public MunicipiosAccesoDatos()
        {
            _conexion = new Conexion("localhost", "root", "", "escolar", 3306);
        }

        public List<Municipios> ObtenerLista(string estado)
        {
            var list = new List<Municipios>();

            try
            {
                var ds = _conexion.ObtenerDatos("select * from Municipios where fkEstado ='" + estado + "' ", "Municipios");
                var dt = ds.Tables[0];

                foreach (DataRow dr in dt.Rows)
                {
                    //var estados = new Municipios { Codigo = dr["codigo"].ToString(), Nombre = dr["nombre"].ToString() };
                    var municipios = new Municipios { IdMunicipio = Convert.ToInt32(dr["idMunicipio"].ToString()), Nombre = dr["nombre"].ToString(), FkEstado = dr["fkEstado"].ToString() };
                    list.Add(municipios);
                }
            }
            catch (Exception)
            {

            }

            return list;
        }
    }
}
