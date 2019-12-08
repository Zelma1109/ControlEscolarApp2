using System;
using System.Collections.Generic;
using System.Data;
using Entidades.ControlEscolarApp;
using ConexionBd;

namespace AccesoDatos.ContolEscolarApp
{
    public class MateriasAccesoDatos
    {
        Conexion _conexion;

        public MateriasAccesoDatos()
        {
            _conexion = new Conexion("localhost", "root", "", "escolar", 3306);
        }
        public void Eliminar(string noControl)
        {
            _conexion.EjecutarConsulta("delete from Materias where matMateria = '" + noControl + "'");
        }

        public void Guardar(Materias materias)
        {
            #region Inserts
            if (ObtenerMatricula(materias.MatMateria) == 0 && materias.FkAntecesor == null && materias.FkPredecesor != null)
            {
                string cadena = string.Format("insert into Materias values('{0}', '{1}', '{2}', '{3}', '{4}', {5}, null)", materias.MatMateria, materias.Nombre, materias.Horas, materias.Creditos, materias.FkCarrera, materias.FkPredecesor);
                _conexion.EjecutarConsulta(cadena);
            }
            else if (ObtenerMatricula(materias.MatMateria) == 0 && materias.FkPredecesor == null && materias.FkAntecesor != null)
            {
                string cadena = string.Format("insert into Materias values('{0}', '{1}', '{2}', '{3}', '{4}', null, {5})", materias.MatMateria, materias.Nombre, materias.Horas, materias.Creditos, materias.FkCarrera, materias.FkAntecesor);
                _conexion.EjecutarConsulta(cadena);
            }
            else if (ObtenerMatricula(materias.MatMateria) == 0 && materias.FkAntecesor == null && materias.FkAntecesor == null)
            {
                string cadena = string.Format("insert into Materias values('{0}', '{1}', '{2}', '{3}', '{4}', null, null)", materias.MatMateria, materias.Nombre, materias.Horas, materias.Creditos, materias.FkCarrera);
                _conexion.EjecutarConsulta(cadena);
            }
            else if (ObtenerMatricula(materias.MatMateria) == 0)
            {
                string cadena = string.Format("insert into Materias values('{0}', '{1}', '{2}', '{3}', '{4}', {5}, {6})", materias.MatMateria, materias.Nombre, materias.Horas, materias.Creditos, materias.FkCarrera, materias.FkPredecesor, materias.FkAntecesor);
                _conexion.EjecutarConsulta(cadena);
            }
            #endregion
            #region Updates
            else if (ObtenerMatricula(materias.MatMateria) == 1 && materias.FkAntecesor == null)
            {
                string cadena = string.Format("update Materias set nombre = '{1}', horas = '{2}', creditos = '{3}', fkCarrera = '{4}', fkAntecesor = '{5}', fkPredecesor = null where matMateria = '{0}'", materias.MatMateria, materias.Nombre, materias.Horas, materias.Creditos, materias.FkCarrera, materias.FkPredecesor);
                _conexion.EjecutarConsulta(cadena);
            }
            else if (ObtenerMatricula(materias.MatMateria) == 1 && materias.FkPredecesor == null)
            {
                string cadena = string.Format("update Materias set nombre = '{1}', horas = '{2}', creditos = '{3}', fkCarrera = '{4}', fkAntecesor = null, fkPredecesor = '{5}' where matMateria = '{0}'", materias.MatMateria, materias.Nombre, materias.Horas, materias.Creditos, materias.FkCarrera, materias.FkAntecesor);
                _conexion.EjecutarConsulta(cadena);
            }
            else if (ObtenerMatricula(materias.MatMateria) == 1 && materias.FkAntecesor == null && materias.FkAntecesor == null)
            {
                string cadena = string.Format("update Materias set nombre = '{1}', horas = '{2}', creditos = '{3}', fkCarrera = '{4}', fkAntecesor = null, fkPredecesor = null where matMateria = '{0}'", materias.MatMateria, materias.Nombre, materias.Horas, materias.Creditos, materias.FkCarrera);
                _conexion.EjecutarConsulta(cadena);
            }
            else
            {
                string cadena = string.Format("update Materias set nombre = '{1}', horas = '{2}', creditos = '{3}', fkCarrera = '{4}', fkAntecesor = '{5}', fkPredecesor = '{6}' where matMateria = '{0}'", materias.MatMateria, materias.Nombre, materias.Horas, materias.Creditos, materias.FkCarrera, materias.FkPredecesor, materias.FkAntecesor);
                _conexion.EjecutarConsulta(cadena);
            }
            #endregion
        }

        public List<Materias> ObtenerLista(int filtro)
        {
            var list = new List<Materias>();
            try
            {
                var ds = _conexion.ObtenerDatos("select * from Materias where fkCarrera = '" + filtro + "'", "Materias");
                //var ds = _conexion.ObtenerDatos("select * from Alumnos", "Alumnos");
                var dt = ds.Tables[0];

                foreach (DataRow dr in dt.Rows)
                {
                    var materias = new Materias { MatMateria = (dr["matMateria"].ToString()), Nombre = (dr["nombre"].ToString()), Horas = Convert.ToInt32(dr["horas"].ToString()), Creditos = Convert.ToInt32(dr["creditos"].ToString()), FkCarrera = Convert.ToInt32(dr["fkCarrera"].ToString()), FkPredecesor = (dr["fkPredecesor"].ToString()), FkAntecesor = (dr["fkAntecesor"].ToString()) };

                    list.Add(materias);
                }
            }
            catch (Exception ex)
            {
            }
            return list;
        }

        public List<Materias> ObtenerLista(string filtro)
        {
            var list = new List<Materias>();
            try
            {
                var ds = _conexion.ObtenerDatos("select * from Materias where matMateria like '%" + filtro + "%'", "Materias");
                //var ds = _conexion.ObtenerDatos("select * from Alumnos", "Alumnos");
                var dt = ds.Tables[0];

                foreach (DataRow dr in dt.Rows)
                {
                    var materias = new Materias { MatMateria = (dr["matMateria"].ToString()), Nombre = (dr["nombre"].ToString()), Horas = Convert.ToInt32(dr["horas"].ToString()), Creditos = Convert.ToInt32(dr["creditos"].ToString()), FkCarrera = Convert.ToInt32(dr["fkCarrera"].ToString()), FkPredecesor = (dr["fkPredecesor"].ToString()), FkAntecesor = (dr["fkAntecesor"].ToString()) };

                    list.Add(materias);
                }
            }
            catch (Exception ex)
            {
            }
            return list;
        }

        public int ObtenerMatricula(string noControl)
        {
            var res = _conexion.Existencia("select count(*) from Materias where matMateria = '" + noControl + "'");

            return res;
        }
    }
}
