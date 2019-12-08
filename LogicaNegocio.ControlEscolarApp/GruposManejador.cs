using System;
using System.Collections.Generic;
using Entidades.ControlEscolarApp;
using AccesoDatos.ContolEscolarApp;

namespace LogicaNegocio.ControlEscolarApp
{
    public class GruposManejador
    {
        private GruposAccesoDatos _gruposAccesoDatos;

        public GruposManejador()
        {
            _gruposAccesoDatos = new GruposAccesoDatos();
        }
        public void Eliminar(int nControl)
        {
            _gruposAccesoDatos.Eliminar(nControl);
        }

        public void Guardar(Grupos alumnos)
        {
            _gruposAccesoDatos.Guardar(alumnos);
        }

        public List<Grupos> ObtenerAlumnos()
        {
            var list = new List<Grupos>();
            list = _gruposAccesoDatos.ObtenerLista();
            return list;
        }
    }
}
