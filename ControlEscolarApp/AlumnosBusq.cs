using LogicaNegocio.ControlEscolarApp;
using System;
using System.Windows.Forms;

namespace ControlEscolarApp
{
    public partial class AlumnosBusq : Form
    {
        AlumnoManejador _alumnoManejador;
        Entidades.ControlEscolarApp.Alumnos _alumnos;
        public AlumnosBusq()
        {
            InitializeComponent();
            _alumnoManejador = new AlumnoManejador();
            _alumnos = new Entidades.ControlEscolarApp.Alumnos();
            BuscarAlumno("");
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            Alumnos alumnos = new Alumnos();
            alumnos.ShowDialog();
            BuscarAlumno("");
        }
        private void Eliminar()
        {
            string nControl = (dgvAlumnos.CurrentRow.Cells["noControl"].Value).ToString();
            _alumnoManejador.Eliminar(nControl);
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
             if (MessageBox.Show("Favor de confirmar", "Eliminar registro", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    Eliminar();
                    BuscarAlumno("");
                }
                catch (Exception)
                {
                    MessageBox.Show("No eliminado");
                }
            }
        }

       private void DgvAlumnos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DgvAlumnos_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            BindAlumno();
            Alumnos alumnos = new Alumnos(_alumnos);
            alumnos.ShowDialog();
            BuscarAlumno("");
        }

        private void TxtBuscar_TextChanged(object sender, EventArgs e)
        {
            BuscarAlumno(txtBuscar.Text);
        }

        private void AlumnosBusq_Load(object sender, EventArgs e)
        {

        }
        private void BuscarAlumno(string filtro)
        {
            dgvAlumnos.DataSource = _alumnoManejador.ObtenerAlumnos(filtro);
        }
        private void BindAlumno()
        {
            _alumnos.NoControl = ((dgvAlumnos.CurrentRow.Cells["noControl"].Value).ToString());
            _alumnos.Nombre = ((dgvAlumnos.CurrentRow.Cells["nombre"].Value).ToString());
            _alumnos.ApellidoPaterno = ((dgvAlumnos.CurrentRow.Cells["apellidoPaterno"].Value).ToString());
            _alumnos.ApellidoMaterno = ((dgvAlumnos.CurrentRow.Cells["apellidoMaterno"].Value).ToString());
            _alumnos.Genero = ((dgvAlumnos.CurrentRow.Cells["genero"].Value).ToString());
            _alumnos.FechadeNacimiento = (dgvAlumnos.CurrentRow.Cells["fechadeNacimiento"].Value).ToString();
            _alumnos.CorreoElectronico = ((dgvAlumnos.CurrentRow.Cells["correoElectronico"].Value).ToString());
            _alumnos.TelefonodeContacto = (dgvAlumnos.CurrentRow.Cells["telefonodeContacto"].Value).ToString();
            _alumnos.Estado = ((dgvAlumnos.CurrentRow.Cells["estado"].Value).ToString());
            _alumnos.Municipio = Convert.ToInt32((dgvAlumnos.CurrentRow.Cells["municipio"].Value).ToString());
            _alumnos.Domicilio = ((dgvAlumnos.CurrentRow.Cells["domicilio"].Value).ToString());
        }
    }
}
