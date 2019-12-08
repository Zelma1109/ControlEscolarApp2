using System;
using System.Collections.Generic;
using Entidades.ControlEscolarApp;
using AccesoDatos.ContolEscolarApp;
using System.Text.RegularExpressions;

namespace LogicaNegocio.ControlEscolarApp
{
    public class UsuarioManejador
    {
        private UsuariosAccesoDatos _usuariosAccesoDatos;
        public UsuarioManejador()
        {
            _usuariosAccesoDatos = new UsuariosAccesoDatos();
        }
        public void Eliminar(int idUsuario)
        {
            _usuariosAccesoDatos.Eliminar(idUsuario);
        }

        public void Guardar(Usuarios usuario)
        {
            _usuariosAccesoDatos.Guardar(usuario);
        }

        private bool NombreValido(string nombre)
        {
            var regex = new Regex(@"^[A-Za-z]+( [A-Za-z]+)*$");
            var match = regex.Match(nombre);

            if (match.Success)
            {
                return true;
            }
            return false;
        }

        public List<Usuarios> ObtenerLista(string filtro)
        {
            var list = new List<Usuarios>();
            list = _usuariosAccesoDatos.ObtenerLista(filtro);
            return list;
        }
        public Tuple<bool, string> EsUsuarioValido(Usuarios usuario)
        {
            string mensaje = "";
            bool valido = true;

            if (usuario.Nombre.Length == 0)
            {
                mensaje = "El nombre de usuario es necesario";
                valido = false;
            }
            else if(!NombreValido(usuario.Nombre))
            {
                mensaje = "Escribe un nombre valido";
                valido = false;
            }
            else if (usuario.Nombre.Length > 15)
            {
                mensaje = "La longitud para nombre de usuario es máximo 15 carazteres";
                valido = false;
            }
            return Tuple.Create(valido, mensaje);
        }
    }
}

