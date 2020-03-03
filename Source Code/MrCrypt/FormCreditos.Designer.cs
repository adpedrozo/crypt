namespace MrCrypt
{
    partial class FormCreditos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCreditos));
            this.btnAceptar = new System.Windows.Forms.Button();
            this.imgCreditos = new System.Windows.Forms.PictureBox();
            this.labelCreditos = new System.Windows.Forms.Label();
            this.linkAyuda = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.imgCreditos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAceptar
            // 
            this.btnAceptar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAceptar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnAceptar.Location = new System.Drawing.Point(164, 348);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(110, 33);
            this.btnAceptar.TabIndex = 5;
            this.btnAceptar.Text = "OK";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.BtnAceptar_Click);
            // 
            // imgCreditos
            // 
            this.imgCreditos.Image = ((System.Drawing.Image)(resources.GetObject("imgCreditos.Image")));
            this.imgCreditos.Location = new System.Drawing.Point(159, 190);
            this.imgCreditos.Name = "imgCreditos";
            this.imgCreditos.Size = new System.Drawing.Size(120, 120);
            this.imgCreditos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgCreditos.TabIndex = 6;
            this.imgCreditos.TabStop = false;
            // 
            // labelCreditos
            // 
            this.labelCreditos.AutoSize = true;
            this.labelCreditos.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCreditos.ForeColor = System.Drawing.Color.White;
            this.labelCreditos.Location = new System.Drawing.Point(70, 34);
            this.labelCreditos.Name = "labelCreditos";
            this.labelCreditos.Size = new System.Drawing.Size(299, 80);
            this.labelCreditos.TabIndex = 7;
            this.labelCreditos.Text = "MrCrypt v2.1\r\n\r\nDeveloped in C# and .NET Framework 4.7 by\r\nAlejandro Pedrozo, Pro" +
    "gramming Technician\r\n©2019";
            this.labelCreditos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // linkAyuda
            // 
            this.linkAyuda.AutoSize = true;
            this.linkAyuda.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkAyuda.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(195)))), ((int)(((byte)(15)))));
            this.linkAyuda.Location = new System.Drawing.Point(158, 139);
            this.linkAyuda.Name = "linkAyuda";
            this.linkAyuda.Size = new System.Drawing.Size(122, 16);
            this.linkAyuda.TabIndex = 9;
            this.linkAyuda.TabStop = true;
            this.linkAyuda.Text = "Established Limits";
            this.linkAyuda.MouseClick += new System.Windows.Forms.MouseEventHandler(this.LinkAyuda_MouseClick);
            // 
            // FormCreditos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(439, 421);
            this.Controls.Add(this.linkAyuda);
            this.Controls.Add(this.labelCreditos);
            this.Controls.Add(this.imgCreditos);
            this.Controls.Add(this.btnAceptar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormCreditos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "About MrCrypt";
            ((System.ComponentModel.ISupportInitialize)(this.imgCreditos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.PictureBox imgCreditos;
        private System.Windows.Forms.Label labelCreditos;
        private System.Windows.Forms.LinkLabel linkAyuda;
    }
}