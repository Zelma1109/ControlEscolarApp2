using System;
using System.Collections.Generic;
using Entidades.ControlEscolarApp;
using AccesoDatos.ContolEscolarApp;
using System.Text.RegularExpressions;

namespace LogicaNegocio.ControlEscolarApp
{
    public class EscuelaManejador
    {
        private EscuelaAccesoDatos _escuelaAccesoDatos;

        public EscuelaManejador()
        {
            _escuelaAccesoDatos = new EscuelaAccesoDatos();
        }
        public void Eliminar(int Idesc)
        {
            _escuelaAccesoDatos.Eliminar(Idesc);
        }
        public void Guardar(Escuela escuela)
        {
            _escuelaAccesoDatos.Guardar(escuela);
        }

        public List<Escuela> ObtenerEscuela(string filtro)
        {
            var list = new List<Escuela>();
            list = _escuelaAccesoDatos.ObtenerLista(filtro);
            return list;
        }

        public int ObtenerIdesc(int Idesc)
        {
            return _escuelaAccesoDatos.ObtenerIdesc(Idesc);
        }

        //Validacion Escuela XD
        private bool EscuelaValida(string Escuelas)
        {
            var regex = new Regex(@"^[A-Za-zäÄëËïÏöÖüÜáéíóúáéíóúÁÉÍÓÚÂÊÎÔÛâêîôûàèìòùÀÈÌÒÙ]+( [A-Za-zäÄëËïÏöÖüÜáéíóúáéíóúÁÉÍÓÚÂÊÎÔÛâêîôûàèìòùÀÈÌÒÙ]+)*$");
            var match = regex.Match(Escuelas);

            if (match.Success)
            {
                return true;
            }
            return false;
        }

        //Aqui se comprueba el combre
        public Tuple<bool, string> ComprobarEscuela(Escuela escuela)
        {
            string mensaje = "";
            bool valido = true;
            if (escuela.Escuelas.Length == 0)
            {
                mensaje = "El nombre no es correcto, XD";
                valido = false;
            }
            else if (!EscuelaValida(escuela.Escuelas))
            {
                mensaje = "Por favor, Verifica el nombre";
                valido = false;
            }
            else if (escuela.Escuelas.Length > 100)
            {
                mensaje = "Se exede del tamaño ";
                valido = false;
            }
            return Tuple.Create(valido, mensaje);
        }


        private bool CorreoValido(string correo)
        {
            var regex = new Regex(@"^[a-zA-Z0-9.!#$%&'*+/=?^_`{|}~-]+@[A-Z0-9.-]+\.[A-Z]{2,}$");
            var match = regex.Match(correo);

            if (match.Success)
            {
                return true;
            }

            return false;
        }

        //Validacion para numero de Telefono
        private bool TelValido(string Telefono)
        {
            var regex = new Regex(@"^[0-9][10]");
            var match = regex.Match(Telefono);

            if (match.Success)
            {
                return true;
            }

            return false;
        }

        public Tuple<bool, string> ComprobarTelefono(Escuela escuela)
        {
            string mensaje = "";
            bool valido = true;

            if (escuela.Telefono.Length == 0)
            {
                mensaje = "Telefono Vacio XD";
                valido = false;
            }
            else if (!TelValido(escuela.Telefono))
            {
                mensaje = "Ingresa  correctamente el numero de telefono";
                valido = false;
            }
            else if (escuela.Telefono.Length > 10)
            {
                mensaje = "Se exedio la cantidad de numeros :3";
                valido = false;
            }
            return Tuple.Create(valido, mensaje);
        }

        public Tuple<bool, string> EsUnaEscuelaValido(Escuela escuela)
        {
            string mensaje = "";
            bool valido = true;

            if (escuela.Escuelas.Length == 0)
            {
                mensaje = "El nombre de la escuela es necesario";
                valido = false;
            }
            else if (!EscuelaValida(escuela.Escuelas))
            {
                mensaje = "Escribe un nombre valido";
                valido = false;
            }
            else if (escuela.Escuelas.Length > 15)
            {
                mensaje = "La longitud para nombre de usuario es máximo 15 carazteres";
                valido = false;
            }
            return Tuple.Create(valido, mensaje);
        }
    }
}
