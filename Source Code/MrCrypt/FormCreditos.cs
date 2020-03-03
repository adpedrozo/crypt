using System;
using System.Windows.Forms;

namespace MrCrypt
{
    public partial class FormCreditos : Form
    {
        public FormCreditos()
        {
            InitializeComponent();
        }

        private void LinkAyuda_MouseClick(object sender, MouseEventArgs e)
        {

            MessageBox.Show("For RAM memory preserving reasons, " +
                            "encryption or decryption are not allowed " +
                            "in files with 512 MB size or more.", "Established Limits", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
