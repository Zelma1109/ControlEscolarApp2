using System;
using System.Collections.Generic;
using Entidades.ControlEscolarApp;
using AccesoDatos.ContolEscolarApp;
using System.Text.RegularExpressions;

namespace LogicaNegocio.ControlEscolarApp
{
    public class EstudiosManejador
    {
        private EstudiosAccesoDatos _estudiosAccesoDatos;

        public EstudiosManejador()
        {
            _estudiosAccesoDatos = new EstudiosAccesoDatos();
        }

        public void Eliminar(string nControl)
        {
            _estudiosAccesoDatos.Eliminar(nControl);
        }

        public void Guardar(Estudios estudios, Maestros maestros, int unionid, bool isNewElement)
        {
            _estudiosAccesoDatos.Guardar(estudios, maestros, unionid, isNewElement); ;
        }

        public List<Documentos> ObtenerMaestros(string noControl)
        {
            var list = new List<Documentos>();
            list = _estudiosAccesoDatos.ObtenerLista(noControl);
            foreach (var item in list)
            {
                Console.WriteLine(item + "lel");
            }


            return list;
        }

        public int ObtenerArchivoClave(int noControl)
        {
            return _estudiosAccesoDatos.ObtenerArchivoClave(noControl);
        }

        public int ObtenerUnionclave(int noControl)
        {
            return _estudiosAccesoDatos.ObtenerUnionclave(noControl);
        }

        public int ObtenerClaveExacta(string nArchivo)
        {
            return _estudiosAccesoDatos.ObtenerClaveExacta(nArchivo);
        }
    }
}
