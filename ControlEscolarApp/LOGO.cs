using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades.ControlEscolarApp;
using LogicaNegocio.ControlEscolarApp;
using Extentions.ControlEscolarApp;


namespace ControlEscolarApp
{
    public partial class LOGO : Form
    {
        private OpenFileDialog _dialogCargarLogo;
        private bool _isEnableBinding = false;
        private bool _isImagineClear = false;
        private EscuelapruebaManejador _escuelapruebaManejador;
        private Escuelaprueba _escuela;
        private RutasManager _rutasManager;


        public LOGO()
        {
            InitializeComponent();
            _dialogCargarLogo = new OpenFileDialog();
            _rutasManager = new RutasManager(Application.StartupPath);
            _escuelapruebaManejador = new EscuelapruebaManejador(_rutasManager);
            _escuela = new Escuelaprueba();

            _escuela = _escuelapruebaManejador.GetEscuela();

            if (!string.IsNullOrEmpty(_escuela.Idesc.ToString()))
            {

            }
        }

        private void LoadEntity()
        {
            TxtNombre.Text = _escuela.Nombre;
            txtDirector.Text = _escuela.Director;
            picLogo.ImageLocation = null;

            if (!string.IsNullOrEmpty(_escuela.Logo) && string.IsNullOrEmpty(_dialogCargarLogo.FileName))
            {
                picLogo.ImageLocation = _rutasManager.RutaLogoEscuela(_escuela);
            }
        }

        private void TxtNombre_TextChanged(object sender, EventArgs e)
        {
            BindEntity();
        }

        private void txtDirector_TextChanged(object sender, EventArgs e)
        {
            BindEntity();
        }

        private void BindEntity()
        {
            _escuela.Nombre = TxtNombre.Text;
            _escuela.Director = txtDirector.Text;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Save();
            BindEntity();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelara_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Estas seguro de salir sin guardar cambios", "salir", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            CargarLogo();
        }

        private void CargarLogo()
        {
            _dialogCargarLogo.Filter = "imagen tipo (*.png)|*.png |(*.jpg)|*.jpg";
            _dialogCargarLogo.Title = "Cargar un archivo de imagen";
            _dialogCargarLogo.ShowDialog();

            if (_dialogCargarLogo.FileName != "")
            {
                if (_escuelapruebaManejador.CargarLogo(_dialogCargarLogo.FileName))
                {
                    picLogo.ImageLocation = _dialogCargarLogo.FileName;
                    _isImagineClear = false;
                }
                else
                {
                    MessageBox.Show("No son admitidas imagenes mayores a 5MB");
                }
            }
        }

        private void btnEliminarLago_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Estas seguro de eliminar logo. Los cambios se guardaran en esta edicion", "Eliminar", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                EliminarLogo();
            }
        }

        private void EliminarLogo()
        {
            picLogo.ImageLocation = null;
            _isImagineClear = true;
        }

        private void Save()
        {
            if (picLogo.Image != null)
            {
                if (!string.IsNullOrEmpty(_dialogCargarLogo.FileName))
                {
                    _escuela.Logo = _escuelapruebaManejador.GetNombreLogo(_dialogCargarLogo.FileName);

                    if (!string.IsNullOrEmpty(_escuela.Logo))
                    {
                        _escuelapruebaManejador.GuardarLogo(_dialogCargarLogo.FileName, 1);
                        _dialogCargarLogo.Dispose();
                    }
                }
            }
            else
            {
                _escuela.Logo = string.Empty;//Empty = ""; como dejarlo vacio
            }

            if (_isImagineClear)
            {
                _escuelapruebaManejador.LimpiarDocumento(1, "png");
                _escuelapruebaManejador.LimpiarDocumento(1, "jpg");
            }
            _escuelapruebaManejador.Guardar(_escuela);
        }
    }
}
