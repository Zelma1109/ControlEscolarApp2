using System;
using System.Collections.Generic;
using Entidades.ControlEscolarApp;
using AccesoDatos.ContolEscolarApp;

namespace LogicaNegocio.ControlEscolarApp
{
    public class CarrerasManejador
    {
        private CarrerasAccesoDatos _carrerasAccesoDatos;

        public CarrerasManejador()
        {
            _carrerasAccesoDatos = new CarrerasAccesoDatos();
        }

        public void Eliminar(int nControl)
        {
            _carrerasAccesoDatos.Eliminar(nControl);
        }

        public void Guardar(Carreras carreras)
        {
            _carrerasAccesoDatos.Guardar(carreras);
        }

        public List<Carreras> ObtenerAlumnos()
        {
            var list = new List<Carreras>();
            list = _carrerasAccesoDatos.ObtenerLista();
            return list;
        }
    }
}



