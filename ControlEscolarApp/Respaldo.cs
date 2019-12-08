using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades.ControlEscolarApp;
using LogicaNegocio.ControlEscolarApp;
using Microsoft.WindowsAPICodePack.Dialogs;

namespace ControlEscolarApp
{
    public partial class Respaldo : Form
    {
        private RespaldoManejador _backupManejador;
        private CommonOpenFileDialog cofd;
        private string trackFile;
        public Respaldo()
        {
            InitializeComponent();
            _backupManejador = new RespaldoManejador();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(trackFile))
            {
                if (MessageBox.Show("¿Quieres guardar el respaldo en esta hubicación?", "¿Preparado?", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (MessageBox.Show("La operación esta por empezar.", "Please wait", MessageBoxButtons.OK) == DialogResult.OK)
                    {
                        _backupManejador.CrearBackup(trackFile);
                    }
                    label2.Visible = true;
                }
                else
                {
                    if (cofd.ShowDialog() == CommonFileDialogResult.Ok && !string.IsNullOrEmpty(cofd.FileName))
                    {
                        trackFile = cofd.FileName;
                    }
                }
            }
        }

        private void txtruta_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtruta_Click(object sender, EventArgs e)
        {
            cofd = new CommonOpenFileDialog();
            cofd.InitialDirectory = @"C:\";
            cofd.IsFolderPicker = true;
            if (cofd.ShowDialog() == CommonFileDialogResult.Ok && !string.IsNullOrEmpty(cofd.FileName))
            {
                trackFile = cofd.FileName;
                txtruta.Text = Path.GetFileName(cofd.FileName);
                Respaldo bc = new Respaldo();
                bc.Focus();
            }
        }
    }
}
