using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;
using LogicaNegocio.ControlEscolarApp;
using Entidades.ControlEscolarApp;
using System.IO;
using System.Drawing;

namespace ControlEscolarApp
{
    public partial class Escuela : Form
    {
        EstadosManejador _estadosManejador;
        Estados _estados;
        MunicipiosManejador _municipioManejador;
        Municipios _municipios;
        EscuelaManejador _escuelaManejador;
        Entidades.ControlEscolarApp.Escuela _escuela;


        private bool _isEnabledBinding = false;
        private bool XD = true;

        string nombreImagen;
        string Escuelas;
        string Dir;


        public Escuela()
        {
            InitializeComponent();
            _estados = new Estados();
            _estadosManejador = new EstadosManejador();
            _municipioManejador = new MunicipiosManejador();
            _municipios = new Municipios();
            _escuelaManejador = new EscuelaManejador();
            _escuela = new Entidades.ControlEscolarApp.Escuela();
            LlenarCombos();
            _isEnabledBinding = true;
            BindEscuela();
            Dir = @"C:\Escuela";
        }
        public Escuela(Entidades.ControlEscolarApp.Escuela escuela)
        {
            InitializeComponent();
            _estados = new Estados();
            _estadosManejador = new EstadosManejador();
            _municipioManejador = new MunicipiosManejador();
            _municipios = new Municipios();
            _escuelaManejador = new EscuelaManejador();
            _escuela = escuela;
            LlenarCombos();
            BindEscuelaTry2();
            _isEnabledBinding = true;
        }

        private void LlenarCombos()
        {
            cmbEstado.DataSource = _estadosManejador.ObtenerLista();
            cmbEstado.DisplayMember = "nombre";
            cmbEstado.ValueMember = "codigo";

            cmbMunicipio.DataSource = _municipioManejador.ObtenerLista(cmbEstado.SelectedValue.ToString());
            cmbMunicipio.DisplayMember = "nombre";
            cmbMunicipio.ValueMember = "idMunicipio";
        }

        private void Guardar()
        {
            _escuelaManejador.Guardar(_escuela);
        }

        private void BindEscuela()
        {
            if (_isEnabledBinding)
            {
                if (_escuela.Idesc == 0)
                {
                    _escuela.Idesc = 0;
                }
                _escuela.Escuelas = txtNombre.Text;
                _escuela.Domicilio = txtDomicilio.Text;
                _escuela.Noext = txtnoext.Text;
                _escuela.Estado = cmbEstado.Text;
                _escuela.Municipio = Convert.ToInt32(cmbMunicipio.SelectedValue);
                _escuela.Telefono = txtTelefono.Text;
                _escuela.PagWeb = TxtPasgWb.Text;
                _escuela.Correo = TxtEmail.Text;
                _escuela.Director = txtDirec.Text;
                _escuela.Imagen = pb_imagen.ImageLocation;
                _escuela.Rutaimagen = txtRutaImagen.Text;
            }
        }

        private void BindEscuelaTry2()
        {
            txtNombre.Text = _escuela.Escuelas;
            txtDomicilio.Text = _escuela.Domicilio;
            txtnoext.Text = _escuela.Noext;
            cmbEstado.SelectedValue = _escuela.Estado;
            cmbMunicipio.SelectedValue = Convert.ToString(_escuela.Municipio);
            txtTelefono.Text = _escuela.Telefono;
            TxtPasgWb.Text = _escuela.PagWeb;
            TxtEmail.Text = _escuela.Correo;
            txtDirec.Text = _escuela.Director;
            pb_imagen.ImageLocation = Convert.ToString(_escuela.Imagen);
            txtRutaImagen.Text = _escuela.Rutaimagen;
        }
        private void Escuela_Load(object sender, EventArgs e)
        { }

        private bool ValidarEscuela()
        {
            var res = _escuelaManejador.EsUnaEscuelaValido(_escuela);
            if (!res.Item1)
            {
                MessageBox.Show(res.Item2);
            }
            return res.Item1;
        }

        private void cmbEstado_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            cmbMunicipio.DataSource = _municipioManejador.ObtenerLista(cmbEstado.SelectedValue.ToString());
            cmbMunicipio.DisplayMember = "nombre";
            cmbMunicipio.ValueMember = "idMunicipio";
        }

        private void Btn_cargar_Click(object sender, EventArgs e)
        {
            pb_imagen.SizeMode = PictureBoxSizeMode.StretchImage;
            OpenFileDialog getImage = new OpenFileDialog();
             getImage.InitialDirectory = "C:\\";
            getImage.Filter = "Archivos de Imagen(*.jpg)(*.jpeg)|*.jpg;*.jpge";

            if (getImage.ShowDialog() == DialogResult.OK)
            {
                FileStream z = File.OpenRead(getImage.FileName);
                if (z.Length <= 5120000)
                {

                    pb_imagen.Image = new Bitmap(getImage.FileName);
                    nombreImagen = Path.GetFileName(getImage.FileName);
                }
                else
                {
                    MessageBox.Show("Lo siento, la imagen no debe pasar de 5MB");
                }
            }
            else
            {
                MessageBox.Show("No se ha seleccionado la imagen", "Sin seleccion",
                                   MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void Btn_Cancelar_Click(object sender, EventArgs e)
        {
            txtDirec.Text = null;
            txtDomicilio.Text = null;
            TxtEmail.Text = null;
            txtnoext.Text = null;
            txtNombre.Text = null;
            TxtPasgWb.Text = null;
            txtRutaImagen.Text = null;
            txtTelefono.Text = null;

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            pb_imagen.Image = null;
        }

        private void Btn_guardar_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            string ruta = "";
            ruta = (@"/Esc/" + txtNombre.Text.Trim());
            bool exist;

            exist = (Directory.Exists(ruta));
            if (!exist)
            {
                Directory.CreateDirectory(ruta);
                MessageBox.Show("se ha Creado ");
            }
            else
            {
                MessageBox.Show("No se ha creado, sorry :C");
            }

            if (txtNombre != null)
                Dir = Path.Combine(Dir, txtNombre.Text);

            if (pb_imagen != null)
            {
                try
                {
                    pb_imagen.Image.Save(Path.Combine(Dir, nombreImagen), System.Drawing.Imaging.ImageFormat.Jpeg);
                    BindEscuela();
                    Guardar();
                    this.Close();
                }
                catch (Exception)
                {

                    //File.Delete(Path.Combine(Dir, txtNombre.Text));
                }
            }

            try
            {
                BindEscuela();

                if (ValidarEscuela())
                {
                    _escuelaManejador.Guardar(_escuela);
                    this.Close();
                }
            }
            catch (Exception)
            {

            }
        }

        /* SaveFileDialog saveFileDialog = new SaveFileDialog();
         string ruta = "";
         ruta = (@"/Escuela/Escuelas/" + txtNombre.Text.Trim());
         bool exist;

         exist = (Directory.Exists(ruta));
         if (!exist)
         {
             Directory.CreateDirectory(ruta);
             MessageBox.Show("se ha Creado ");
         }
         else
         {
             MessageBox.Show("No se ha creado, sorry :C");
         }

         if (txtNombre != null)
             Dir = Path.Combine(Dir, txtNombre.Text);

         if (pb_imagen != null)
         {
              try
              {
                  pb_imagen.Image.Save(Path.Combine(Dir, nombreImagen), System.Drawing.Imaging.ImageFormat.Jpeg);
                  BindEscuela();
                  Guardar();
                  this.Close();
              }
              catch (Exception)
              {

                  //File.Delete(Path.Combine(Dir, txtNombre.Text));
              }
         }

         try
         {
             BindEscuela();

             if (ValidarEscuela())
             {
                 _escuelaManejador.Guardar(_escuela);
                 this.Close();
             }
         }
         catch (Exception)
         {

         }
     }*/

    }
}
