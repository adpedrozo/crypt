using System;
using System.Windows.Forms;

namespace MrCrypt
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
            btnCreditos.Select();
        }

        private void BtnEncriptar_Click(object sender, EventArgs e)
        {
            FormOperation1 FO1 = new FormOperation1();
            FO1.Show();

            btnCreditos.Select();
        }

        private void BtnDesencriptar_Click(object sender, EventArgs e)
        {
            FormOperation2 FO2 = new FormOperation2();
            FO2.Show();

            btnCreditos.Select();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnCreditos_Click(object sender, EventArgs e)
        {
            FormCreditos FC = new FormCreditos();
            FC.Show();
            btnCreditos.Select();
        }
    }
}
