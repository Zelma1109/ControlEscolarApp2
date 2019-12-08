using System;
using System.Collections.Generic;
using Entidades.ControlEscolarApp;
using AccesoDatos.ContolEscolarApp;

namespace LogicaNegocio.ControlEscolarApp
{
    public class UnionesManejador
    {
        private UnionesAccesoDatos _unionesAccesoDatos;

        public UnionesManejador()
        {
            _unionesAccesoDatos = new UnionesAccesoDatos();
        }

        public void EliminarGA(int nControl)
        {
            _unionesAccesoDatos.EliminarGA(nControl);
        }

        public void EliminarGM(int nControl)
        {
            _unionesAccesoDatos.EliminarGM(nControl);
        }
        public void GuardarGA(Unionga alumnos)
        {
            _unionesAccesoDatos.GuardarGA(alumnos);
        }

        public void GuardarGM(Uniongm alumnos)
        {
            _unionesAccesoDatos.GuardarGM(alumnos);
        }

        public List<Unionga> CargarGA(string filtro)
        {
            var list = new List<Unionga>();
            list = _unionesAccesoDatos.ObtenerListaGA(filtro);
            return list;
        }

        public List<Uniongm> CargarGM(string filtro)
        {
            var list = new List<Uniongm>();
            list = _unionesAccesoDatos.ObtenerListaGM(filtro);
            return list;
        }
    }
}
