/***  MrCrypt      ***/
/***  Encriptador - English Version  ***/

using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Diagnostics;

namespace MrCrypt
{
    public partial class FormOperation1 : Form
    {
        BackgroundWorker elWorker;
        byte[] matriz;
        uint card;

        public FormOperation1()
        {
            InitializeComponent();
            elWorker = new BackgroundWorker();
            elWorker.DoWork += new DoWorkEventHandler(elWorker_DoWork);
            elWorker.ProgressChanged += new ProgressChangedEventHandler(elWorker_ProgressChanged);
            elWorker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(elWorker_RunWorkerCompleted);
            elWorker.WorkerReportsProgress = true;
            elWorker.WorkerSupportsCancellation = true;

            imgFiles1.Visible = false;
            progressBar.Visible = false;

            txtboxEntrada.Enabled = false;
            txtboxSalida.Enabled = false;
            txtboxEntrada.BackColor = Color.FromArgb(255, 180, 180, 180);
            txtboxSalida.BackColor = Color.FromArgb(255, 180, 180, 180);

            btnGris.Enabled = false;
            btnAceptar.Enabled = false;
            btnAceptar.Visible = false;
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            labelBytes.Text = "";
            btnAceptar.Enabled = false;

            elWorker.RunWorkerAsync();
        }

        private void elWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            matriz = File.ReadAllBytes(txtboxEntrada.Text);
            card = Convert.ToUInt32(matriz.GetLength(0));

            if (card > 536870912)
            {
                e.Cancel = true;  /*** cancel de seguridad para archivos de entrada > 512 MB ***/
            }
            else
            {
                uint i = 0;
                foreach (byte b in matriz)
                {
                    if (b == 255) { matriz[i] = 0; }
                    else
                    {
                        matriz[i] = Convert.ToByte(b + 1);
                    }
                    i++;
                    if (i < 75) { elWorker.ReportProgress(Convert.ToInt32(i)); }
                    if (i == card * 0.75) { elWorker.ReportProgress(75); }
                    if (i == card * 0.90) { elWorker.ReportProgress(90); }
                }
                File.WriteAllBytes(txtboxSalida.Text, matriz);
                elWorker.ReportProgress(100);
            }
        }

        private void elWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                progressBar.Visible = false;
                MessageBox.Show("Input file exceeds the 512 MB size limit.", "Rejected Order", MessageBoxButtons.OK,MessageBoxIcon.Error);
                this.Close();
            }
            else if (e.Error != null) { MessageBox.Show("Process Error. Try again.", "Rejected Order", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            else
            {
                labelBytes.Text = card + " Encrypted Bytes";

                if ( MessageBox.Show("*** File Properly Encrypted ***\nDo you want to open the location of the Encrypted file?",
                    "Successful Operation", MessageBoxButtons.YesNo,MessageBoxIcon.Information) == DialogResult.Yes )
                {
                    string pathAux = Path.GetDirectoryName(guardarDialog.FileName);

                    ProcessStartInfo abrirExplorer = new ProcessStartInfo
                    {
                        Arguments = pathAux,
                        FileName = "explorer.exe"
                    };

                    Process.Start(abrirExplorer);
                }
                
                this.Close();
            }
        }

        private void elWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar.Visible = true;
            imgFiles1.Visible = true;
            progressBar.Value = e.ProgressPercentage;
            if (progressBar.Value == 75) { labelBytes.Text = "Encrypting File..."; }
        }

        private void TxtboxEntrada_TextChanged(object sender, EventArgs e)
        {
            if (txtboxEntrada.Text != "")
            {
                txtboxEntrada.BackColor = Color.White;
                btnGuardar.Focus();
                if (txtboxSalida.Text != "")
                {
                    btnGris.Visible = false;
                    btnAceptar.Enabled = true;
                    btnAceptar.Visible = true;
                    btnAceptar.Focus();
                }
            }
            else
            {
                txtboxEntrada.BackColor = Color.FromArgb(255, 180, 180, 180);
                btnGris.Visible = true;
                btnAceptar.Enabled = false;
                btnAceptar.Visible = false;
            }
        }

        private void TxtboxSalida_TextChanged(object sender, EventArgs e)
        {
            if (txtboxSalida.Text != "")
            {
                txtboxSalida.BackColor = Color.White;
            }
            if (txtboxEntrada.Text != "")
            {
                btnGris.Visible = false;
                btnAceptar.Enabled = true;
                btnAceptar.Visible = true;
                btnAceptar.Focus();
            }
        }

        private void BtnAbrir_Click(object sender, EventArgs e)
        {
            if ( DialogResult.OK == abrirDialog.ShowDialog() )
            {
                FileInfo fInfo = new FileInfo(abrirDialog.FileName);
                long fileSize = fInfo.Length;

                if ( fileSize > 536870912 )
                {
                    txtboxEntrada.Text = "";
                    MessageBox.Show("Input File size is "
                    + fileSize/1048576 + " MB and exceeds the 512 MB size limit.", "Rejected Order", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    txtboxEntrada.Text = abrirDialog.FileName;
                    txtboxEntrada.Select(txtboxEntrada.Text.Length, 0);
                }
            }
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            guardarDialog.ShowDialog();
            txtboxSalida.Text = guardarDialog.FileName;
            txtboxSalida.Select(txtboxSalida.Text.Length, 0);
        }
    }
}
