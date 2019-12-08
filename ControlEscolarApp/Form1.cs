using System;
using System.Windows.Forms;
using LogicaNegocio.ControlEscolarApp;
using Entidades.ControlEscolarApp;

namespace ControlEscolarApp
{
    public partial class FrmUsuarios : Form
    {
        UsuarioManejador _usuarioManejador;
        Usuarios _usuario;
        public FrmUsuarios()
        {
            InitializeComponent();
            _usuarioManejador = new UsuarioManejador();
            _usuario = new Usuarios();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BuscarUsuarios("");
        }
        private void BuscarUsuarios(string filtro)
        {
            dgvUsuarios.DataSource = _usuarioManejador.ObtenerLista(filtro);
        }

        private void Txt_buscar_TextChanged(object sender, EventArgs e)
        {
            BuscarUsuarios(Txt_buscar.Text);
        }

        private void Btn_eliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seguro de eliminar ese registro","Eliminar Registro",MessageBoxButtons.YesNo)==DialogResult.Yes)
            {
                try
                {
                    Eliminar();
                    BuscarUsuarios("");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        } 
        private void Eliminar()
        {
            int id =Convert.ToInt32(dgvUsuarios.CurrentRow.Cells["idusuario"].Value);
            _usuarioManejador.Eliminar(id);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UsuariosModal usuariosModal = new UsuariosModal();
            usuariosModal.ShowDialog();
            BuscarUsuarios("");
        }

        private void dgvUsuarios_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            BindingUsuario();
            UsuariosModal usuariosModal = new UsuariosModal(_usuario);
            usuariosModal.ShowDialog();
            BuscarUsuarios("");
        }
        private void BindingUsuario()
        {
            _usuario.IdUsuario = Convert.ToInt32(dgvUsuarios.CurrentRow.Cells["idusuario"].Value);
            _usuario.Nombre = dgvUsuarios.CurrentRow.Cells["nombre"].Value.ToString();
            _usuario.ApellidoPaterno = dgvUsuarios.CurrentRow.Cells["apellidopaterno"].Value.ToString();
            _usuario.ApellidoMaterno = dgvUsuarios.CurrentRow.Cells["apellidomaterno"].Value.ToString();
        }

        private void dgvUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
