using System;
using System.Collections.Generic;
using Entidades.ControlEscolarApp;
using AccesoDatos.ContolEscolarApp;

namespace LogicaNegocio.ControlEscolarApp
{
    public class MateriasManejador
    {
        private MateriasAccesoDatos _materiasAccesoDatos;
        public MateriasManejador()
        {
            _materiasAccesoDatos = new MateriasAccesoDatos();
        }

        public void Eliminar(string nControl)
        {
            _materiasAccesoDatos.Eliminar(nControl);
        }

        public void Guardar(Materias alumnos)
        {
            _materiasAccesoDatos.Guardar(alumnos);
        }

        public List<Materias> ObtenerAlumnos(int filtro)
        {
            var list = new List<Materias>();
            list = _materiasAccesoDatos.ObtenerLista(filtro);
            return list;
        }

        public List<Materias> ObtenerAlumnos(string filtro)
        {
            var list = new List<Materias>();
            list = _materiasAccesoDatos.ObtenerLista(filtro);
            return list;
        }
    }
}

