namespace ControlEstacionamiento
{
    partial class Inicio
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
            this.labelId = new System.Windows.Forms.Label();
            this.labelPwd = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.inputId = new System.Windows.Forms.TextBox();
            this.inputPwd = new System.Windows.Forms.TextBox();
            this.btnLog = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.errorDatos = new System.Windows.Forms.ErrorProvider(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Location = new System.Drawing.Point(106, 120);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(62, 31);
            this.labelId.TabIndex = 0;
            this.labelId.Text = "ID : ";
            // 
            // labelPwd
            // 
            this.labelPwd.AutoSize = true;
            this.labelPwd.Location = new System.Drawing.Point(6, 156);
            this.labelPwd.Name = "labelPwd";
            this.labelPwd.Size = new System.Drawing.Size(162, 31);
            this.labelPwd.TabIndex = 1;
            this.labelPwd.Text = "Contraseña : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Perpetua", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGreen;
            this.label1.Location = new System.Drawing.Point(98, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(391, 36);
            this.label1.TabIndex = 2;
            this.label1.Text = "Control de Estacionamiento";
            // 
            // inputId
            // 
            this.inputId.Location = new System.Drawing.Point(174, 113);
            this.inputId.Name = "inputId";
            this.inputId.Size = new System.Drawing.Size(165, 38);
            this.inputId.TabIndex = 4;
            this.inputId.TextChanged += new System.EventHandler(this.inputId_TextChanged);
            // 
            // inputPwd
            // 
            this.inputPwd.Location = new System.Drawing.Point(174, 157);
            this.inputPwd.Name = "inputPwd";
            this.inputPwd.PasswordChar = '*';
            this.inputPwd.Size = new System.Drawing.Size(165, 38);
            this.inputPwd.TabIndex = 5;
            // 
            // btnLog
            // 
            this.btnLog.Location = new System.Drawing.Point(375, 113);
            this.btnLog.Name = "btnLog";
            this.btnLog.Size = new System.Drawing.Size(129, 82);
            this.btnLog.TabIndex = 6;
            this.btnLog.Text = "Aceptar";
            this.btnLog.UseVisualStyleBackColor = true;
            this.btnLog.Click += new System.EventHandler(this.btnLog_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.OrangeRed;
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Location = new System.Drawing.Point(509, 113);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(129, 82);
            this.btnCerrar.TabIndex = 7;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // errorDatos
            // 
            this.errorDatos.ContainerControl = this;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ControlEstacionamiento.Properties.Resources.car_23964;
            this.pictureBox1.Location = new System.Drawing.Point(12, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(78, 80);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(650, 207);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnLog);
            this.Controls.Add(this.inputPwd);
            this.Controls.Add(this.inputId);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelPwd);
            this.Controls.Add(this.labelId);
            this.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.Font = new System.Drawing.Font("Perpetua", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.MaximizeBox = false;
            this.Name = "Inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Control de Estacionamiento";
            this.Load += new System.EventHandler(this.Inicio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.Label labelPwd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox inputId;
        private System.Windows.Forms.TextBox inputPwd;
        private System.Windows.Forms.Button btnLog;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.ErrorProvider errorDatos;
    }
}

