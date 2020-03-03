namespace MrCrypt
{
    partial class FormOperation1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOperation1));
            this.txtboxEntrada = new System.Windows.Forms.TextBox();
            this.txtboxSalida = new System.Windows.Forms.TextBox();
            this.labelEntrada = new System.Windows.Forms.Label();
            this.labelSalida = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnGris = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.labelBytes = new System.Windows.Forms.Label();
            this.imgFiles1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxFondo = new System.Windows.Forms.PictureBox();
            this.btnAbrir = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.abrirDialog = new System.Windows.Forms.OpenFileDialog();
            this.guardarDialog = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.imgFiles1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFondo)).BeginInit();
            this.SuspendLayout();
            // 
            // txtboxEntrada
            // 
            this.txtboxEntrada.Location = new System.Drawing.Point(223, 51);
            this.txtboxEntrada.Name = "txtboxEntrada";
            this.txtboxEntrada.Size = new System.Drawing.Size(284, 22);
            this.txtboxEntrada.TabIndex = 0;
            this.txtboxEntrada.TextChanged += new System.EventHandler(this.TxtboxEntrada_TextChanged);
            // 
            // txtboxSalida
            // 
            this.txtboxSalida.Location = new System.Drawing.Point(223, 100);
            this.txtboxSalida.Name = "txtboxSalida";
            this.txtboxSalida.Size = new System.Drawing.Size(284, 22);
            this.txtboxSalida.TabIndex = 1;
            this.txtboxSalida.TextChanged += new System.EventHandler(this.TxtboxSalida_TextChanged);
            // 
            // labelEntrada
            // 
            this.labelEntrada.AutoSize = true;
            this.labelEntrada.BackColor = System.Drawing.Color.Transparent;
            this.labelEntrada.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEntrada.ForeColor = System.Drawing.Color.White;
            this.labelEntrada.Location = new System.Drawing.Point(136, 55);
            this.labelEntrada.Name = "labelEntrada";
            this.labelEntrada.Size = new System.Drawing.Size(84, 14);
            this.labelEntrada.TabIndex = 2;
            this.labelEntrada.Text = "Input File:";
            // 
            // labelSalida
            // 
            this.labelSalida.AutoSize = true;
            this.labelSalida.BackColor = System.Drawing.Color.Transparent;
            this.labelSalida.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSalida.ForeColor = System.Drawing.Color.White;
            this.labelSalida.Location = new System.Drawing.Point(129, 104);
            this.labelSalida.Name = "labelSalida";
            this.labelSalida.Size = new System.Drawing.Size(91, 14);
            this.labelSalida.TabIndex = 3;
            this.labelSalida.Text = "Output File:";
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.DarkGreen;
            this.btnAceptar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.ForeColor = System.Drawing.Color.White;
            this.btnAceptar.Location = new System.Drawing.Point(287, 185);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(110, 33);
            this.btnAceptar.TabIndex = 4;
            this.btnAceptar.Text = "Start";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.BtnAceptar_Click);
            // 
            // btnGris
            // 
            this.btnGris.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.btnGris.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGris.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGris.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGris.ForeColor = System.Drawing.Color.White;
            this.btnGris.Location = new System.Drawing.Point(287, 185);
            this.btnGris.Name = "btnGris";
            this.btnGris.Size = new System.Drawing.Size(110, 33);
            this.btnGris.TabIndex = 5;
            this.btnGris.Text = "...";
            this.btnGris.UseVisualStyleBackColor = false;
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(237, 263);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(210, 23);
            this.progressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar.TabIndex = 6;
            // 
            // labelBytes
            // 
            this.labelBytes.BackColor = System.Drawing.Color.Transparent;
            this.labelBytes.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.labelBytes.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBytes.ForeColor = System.Drawing.Color.White;
            this.labelBytes.Location = new System.Drawing.Point(0, 299);
            this.labelBytes.Name = "labelBytes";
            this.labelBytes.Size = new System.Drawing.Size(684, 32);
            this.labelBytes.TabIndex = 7;
            this.labelBytes.Text = "Waiting Files...";
            this.labelBytes.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // imgFiles1
            // 
            this.imgFiles1.BackColor = System.Drawing.Color.Transparent;
            this.imgFiles1.Image = ((System.Drawing.Image)(resources.GetObject("imgFiles1.Image")));
            this.imgFiles1.Location = new System.Drawing.Point(116, 199);
            this.imgFiles1.Name = "imgFiles1";
            this.imgFiles1.Size = new System.Drawing.Size(453, 101);
            this.imgFiles1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.imgFiles1.TabIndex = 8;
            this.imgFiles1.TabStop = false;
            // 
            // pictureBoxFondo
            // 
            this.pictureBoxFondo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxFondo.Image")));
            this.pictureBoxFondo.Location = new System.Drawing.Point(525, -88);
            this.pictureBoxFondo.Name = "pictureBoxFondo";
            this.pictureBoxFondo.Size = new System.Drawing.Size(280, 280);
            this.pictureBoxFondo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxFondo.TabIndex = 9;
            this.pictureBoxFondo.TabStop = false;
            // 
            // btnAbrir
            // 
            this.btnAbrir.Location = new System.Drawing.Point(512, 51);
            this.btnAbrir.Name = "btnAbrir";
            this.btnAbrir.Size = new System.Drawing.Size(40, 22);
            this.btnAbrir.TabIndex = 10;
            this.btnAbrir.Text = "...";
            this.btnAbrir.UseVisualStyleBackColor = true;
            this.btnAbrir.Click += new System.EventHandler(this.BtnAbrir_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(512, 100);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(40, 22);
            this.btnGuardar.TabIndex = 11;
            this.btnGuardar.Text = "...";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // abrirDialog
            // 
            this.abrirDialog.RestoreDirectory = true;
            this.abrirDialog.Title = "Search file to encrypt...";
            // 
            // guardarDialog
            // 
            this.guardarDialog.RestoreDirectory = true;
            this.guardarDialog.Title = "Save encrypted file...";
            // 
            // FormOperation1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(684, 331);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnAbrir);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.btnGris);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.labelSalida);
            this.Controls.Add(this.labelEntrada);
            this.Controls.Add(this.txtboxSalida);
            this.Controls.Add(this.txtboxEntrada);
            this.Controls.Add(this.labelBytes);
            this.Controls.Add(this.imgFiles1);
            this.Controls.Add(this.pictureBoxFondo);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormOperation1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MrCrypt - Encrypt File";
            ((System.ComponentModel.ISupportInitialize)(this.imgFiles1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFondo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtboxEntrada;
        private System.Windows.Forms.TextBox txtboxSalida;
        private System.Windows.Forms.Label labelEntrada;
        private System.Windows.Forms.Label labelSalida;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnGris;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label labelBytes;
        private System.Windows.Forms.PictureBox imgFiles1;
        private System.Windows.Forms.PictureBox pictureBoxFondo;
        private System.Windows.Forms.Button btnAbrir;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.OpenFileDialog abrirDialog;
        private System.Windows.Forms.SaveFileDialog guardarDialog;
    }
}