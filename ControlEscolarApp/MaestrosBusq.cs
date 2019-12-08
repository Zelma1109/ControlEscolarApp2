using System;
using System.Windows.Forms;
using LogicaNegocio.ControlEscolarApp;

namespace ControlEscolarApp
{
    public partial class MaestrosBusq : Form
    {
        MaestroManejador _maestroManejador;
        Entidades.ControlEscolarApp.Maestros _Maestros;
        public MaestrosBusq()
        {
            InitializeComponent();
            _maestroManejador = new MaestroManejador();
            _Maestros = new Entidades.ControlEscolarApp.Maestros();
            BuscarMaestros("");
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            MaestrosModal maestrosModal = new MaestrosModal();
            maestrosModal.ShowDialog();
            BuscarMaestros("");
        }

        private void dgvMaestros_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvMaestros_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            BindMaestros();
            MaestrosModal maestrosModal = new MaestrosModal();
            maestrosModal.ShowDialog();
            BuscarMaestros("");
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            BuscarMaestros(txtBuscar.Text);
        }

        private void BuscarMaestros(string filtro)
        {
            dgvMaestros.DataSource = _maestroManejador.ObtenerAlumnos(filtro);
        }
        private void BindMaestros()
        {
            _Maestros.NoControlM = ((dgvMaestros.CurrentRow.Cells["noControlM"].Value).ToString());
            _Maestros.Nombre = ((dgvMaestros.CurrentRow.Cells["nombre"].Value).ToString());
            _Maestros.ApellidoPaterno = ((dgvMaestros.CurrentRow.Cells["apellidoPaterno"].Value).ToString());
            _Maestros.ApellidoMaterno = ((dgvMaestros.CurrentRow.Cells["apellidoMaterno"].Value).ToString());
            _Maestros.Genero = ((dgvMaestros.CurrentRow.Cells["genero"].Value).ToString());
            _Maestros.FechadeNacimiento = (dgvMaestros.CurrentRow.Cells["fechadeNacimiento"].Value).ToString();
            _Maestros.CorreoElectronico = ((dgvMaestros.CurrentRow.Cells["correoElectronico"].Value).ToString());
            _Maestros.TelefonodeContacto = (dgvMaestros.CurrentRow.Cells["telefonodeContacto"].Value).ToString();
            _Maestros.nocuenta = (dgvMaestros.CurrentRow.Cells["nocuenta"].Value).ToString();
            _Maestros.Estado = ((dgvMaestros.CurrentRow.Cells["estado"].Value).ToString());
            _Maestros.Municipio = Convert.ToInt32((dgvMaestros.CurrentRow.Cells["municipio"].Value).ToString());
            _Maestros.Licenciatura = ((dgvMaestros.CurrentRow.Cells["licenciatura"].Value).ToString());
            _Maestros.Maestria = ((dgvMaestros.CurrentRow.Cells["maestria"].Value).ToString());
            _Maestros.Doctorado = ((dgvMaestros.CurrentRow.Cells["doctorado"].Value).ToString());
        }
        private void Eliminar()
        {
            string nControlM = (dgvMaestros.CurrentRow.Cells["noControlM"].Value).ToString();
            _maestroManejador.Eliminar(nControlM);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Favor de confirmar", "Eliminar registro", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    Eliminar();
                    BuscarMaestros("");
                }
                catch (Exception)
                {
                    MessageBox.Show("No eliminado");
                }
            }
        }

        private void MaestrosBusq_Load(object sender, EventArgs e)
        {

        }
    }
}
