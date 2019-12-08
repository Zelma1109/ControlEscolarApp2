using System;
using System.IO;
using System.IO.Compression;
namespace LogicaNegocio.ControlEscolarApp
{
    public class RespaldoManejador
    {
        private string dato;
        public void CrearBackup(string RutaObjetivo)
        {
            if (!string.IsNullOrEmpty(RutaObjetivo))
            {
                //SplitHeads(DateTime.Now.ToString());
                dato = DateTime.Now.ToString("dd_MM_yyyy_hh_mm_ss");
                string xno = "CONTROLESCOLAR_" + dato + ".zip";
                ZipFile.CreateFromDirectory(@"C:\Escuela", Path.Combine(RutaObjetivo, xno), CompressionLevel.Optimal, true);
            }
        }

        private void SplitHeads(string str)
        {
            string[] stringList = str.Split(new[] { "/", "p. m.", "a. m.", ":" }, StringSplitOptions.None);
            foreach (string s in stringList)
            {
                dato += s;
            }
        }
    }
}
