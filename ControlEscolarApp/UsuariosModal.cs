using System;
using System.Windows.Forms;
using LogicaNegocio.ControlEscolarApp;
using Entidades.ControlEscolarApp;

namespace ControlEscolarApp
{
    public partial class UsuariosModal : Form
    {
        private UsuarioManejador _usuarioManejador;
        private Usuarios _usuario;
        private bool _isEnablebinging = false;
        public UsuariosModal()
        {
            InitializeComponent();
            _usuarioManejador = new UsuarioManejador();
            _usuario = new Usuarios();
            _isEnablebinging = true;
            BindingUsuario();
        }
        public UsuariosModal(Usuarios usuario)
        {
            InitializeComponent();
            _usuarioManejador = new UsuarioManejador();
            _usuario = new Usuarios();
            _usuario = usuario;


            BindingUsuarioReload();

            _isEnablebinging = true;
        }

        private void BindingUsuarioReload()
        {
            TxtNombre.Text = _usuario.Nombre;
            TxtApellidoPaterno.Text = _usuario.ApellidoPaterno;
            TxtApellidoMaterno.Text = _usuario.ApellidoMaterno;
        }

        private void UsuariosModal_Load(object sender, EventArgs e)
        {

        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            BindingUsuario();

            if (ValidarUsuario())
            {
                Guardar();
                this.Close();
            }
        }
        private void Guardar()
        {
            _usuarioManejador.Guardar(_usuario);
        }

        private bool ValidarUsuario()
        {
            var res = _usuarioManejador.EsUsuarioValido(_usuario);
            if (!res.Item1)
            {
                MessageBox.Show(res.Item2);
            }
            return res.Item1;
        }
        private void BindingUsuario()
        {
            if (_isEnablebinging)
            {
                if (_usuario.IdUsuario == 0)
                {
                    _usuario.IdUsuario = 0;
                }

                _usuario.Nombre = TxtNombre.Text;
                _usuario.ApellidoPaterno = TxtApellidoPaterno.Text;
                _usuario.ApellidoMaterno = TxtApellidoMaterno.Text;
            }
        }

            private void TxtNombre_TextChanged(object sender, EventArgs e)
            {
                BindingUsuario();
            }

            private void TxtApellidoPaterno_TextChanged(object sender, EventArgs e)
            {
                BindingUsuario();
            }

            private void TxtApellidoMaterno_TextChanged(object sender, EventArgs e)
            {
                BindingUsuario();
            }

            private void BtnCancelar_Click(object sender, EventArgs e)
            {
                this.Close();
            }
    }
}
