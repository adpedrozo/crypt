namespace MrCrypt
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.btnEncriptar = new System.Windows.Forms.Button();
            this.btnDesencriptar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnCreditos = new System.Windows.Forms.Button();
            this.pictureBoxFondo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFondo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEncriptar
            // 
            this.btnEncriptar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEncriptar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEncriptar.Location = new System.Drawing.Point(122, 34);
            this.btnEncriptar.Name = "btnEncriptar";
            this.btnEncriptar.Size = new System.Drawing.Size(140, 33);
            this.btnEncriptar.TabIndex = 0;
            this.btnEncriptar.Text = "Encrypt";
            this.btnEncriptar.UseVisualStyleBackColor = true;
            this.btnEncriptar.Click += new System.EventHandler(this.BtnEncriptar_Click);
            // 
            // btnDesencriptar
            // 
            this.btnDesencriptar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDesencriptar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.btnDesencriptar.Location = new System.Drawing.Point(122, 80);
            this.btnDesencriptar.Name = "btnDesencriptar";
            this.btnDesencriptar.Size = new System.Drawing.Size(140, 33);
            this.btnDesencriptar.TabIndex = 1;
            this.btnDesencriptar.Text = "Decrypt";
            this.btnDesencriptar.UseVisualStyleBackColor = true;
            this.btnDesencriptar.Click += new System.EventHandler(this.BtnDesencriptar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.btnSalir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnSalir.Location = new System.Drawing.Point(137, 201);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(110, 33);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "Exit";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // btnCreditos
            // 
            this.btnCreditos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreditos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreditos.Location = new System.Drawing.Point(180, 249);
            this.btnCreditos.Name = "btnCreditos";
            this.btnCreditos.Size = new System.Drawing.Size(25, 20);
            this.btnCreditos.TabIndex = 3;
            this.btnCreditos.Text = "?";
            this.btnCreditos.UseVisualStyleBackColor = true;
            this.btnCreditos.Click += new System.EventHandler(this.BtnCreditos_Click);
            // 
            // pictureBoxFondo
            // 
            this.pictureBoxFondo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxFondo.Image")));
            this.pictureBoxFondo.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxFondo.Name = "pictureBoxFondo";
            this.pictureBoxFondo.Size = new System.Drawing.Size(360, 270);
            this.pictureBoxFondo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxFondo.TabIndex = 4;
            this.pictureBoxFondo.TabStop = false;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(384, 294);
            this.Controls.Add(this.btnCreditos);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnDesencriptar);
            this.Controls.Add(this.btnEncriptar);
            this.Controls.Add(this.pictureBoxFondo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MrCrypt";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFondo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEncriptar;
        private System.Windows.Forms.Button btnDesencriptar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnCreditos;
        private System.Windows.Forms.PictureBox pictureBoxFondo;
    }
}

