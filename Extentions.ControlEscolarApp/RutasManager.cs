using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Entidades.ControlEscolarApp;


namespace Extentions.ControlEscolarApp
{
    public class RutasManager
    {
        //TODO ESTO ES PARA CREAR RUTAS SOLO PARA LOS LOGOS


        //CONSTANTES SIEMPRE EN MAYUSCULAS ejemplo: LOGOS
        private string _appPath;
        private const string LOGOS = "logos";

        public RutasManager(string appPath)
        {
            _appPath = appPath;
        }

        public string RutasRepositoritoriosLogos
        {
            get { return Path.Combine(_appPath, LOGOS); }
        }

        public void CrearRepositoriosLogos()
        {
            if (!Directory.Exists(RutasRepositoritoriosLogos))
            {
                Directory.CreateDirectory(RutasRepositoritoriosLogos);

            }
        }

        public void CrearRepositorioLogosEscuela(int escuelaId)
        {
            string ruta = Path.Combine(RutasRepositoritoriosLogos, escuelaId.ToString());
            if (!Directory.Exists(ruta))
            {
                Directory.CreateDirectory(ruta);

            }
        }

        public string RutaLogoEscuela(Escuelaprueba escuela)
        {
            return Path.Combine(RutasRepositoritoriosLogos, escuela.Idesc.ToString(), escuela.Logo);
        }

    }
}
