namespace ControlEstacionamiento
{
    partial class Admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin));
            this.label1 = new System.Windows.Forms.Label();
            this.saludo = new System.Windows.Forms.Label();
            this.estacionamiento = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.libres = new System.Windows.Forms.Label();
            this.ocupados = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.estacionamiento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Perpetua", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGreen;
            this.label1.Location = new System.Drawing.Point(112, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(391, 36);
            this.label1.TabIndex = 5;
            this.label1.Text = "Control de Estacionamiento";
            // 
            // saludo
            // 
            this.saludo.AutoSize = true;
            this.saludo.Font = new System.Drawing.Font("Perpetua", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saludo.ForeColor = System.Drawing.Color.DarkGreen;
            this.saludo.Location = new System.Drawing.Point(112, 45);
            this.saludo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.saludo.Name = "saludo";
            this.saludo.Size = new System.Drawing.Size(277, 42);
            this.saludo.TabIndex = 6;
            this.saludo.Text = "Bienvenido Usuario : ";
            // 
            // estacionamiento
            // 
            this.estacionamiento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.estacionamiento.Image = global::ControlEstacionamiento.Properties.Resources.estacionamiento;
            this.estacionamiento.Location = new System.Drawing.Point(273, 90);
            this.estacionamiento.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.estacionamiento.Name = "estacionamiento";
            this.estacionamiento.Size = new System.Drawing.Size(575, 331);
            this.estacionamiento.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.estacionamiento.TabIndex = 7;
            this.estacionamiento.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ControlEstacionamiento.Properties.Resources.car_23964;
            this.pictureBox2.Location = new System.Drawing.Point(13, 14);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(78, 75);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.BackColor = System.Drawing.Color.DarkSalmon;
            this.btnCerrarSesion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCerrarSesion.Location = new System.Drawing.Point(14, 389);
            this.btnCerrarSesion.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(154, 32);
            this.btnCerrarSesion.TabIndex = 8;
            this.btnCerrarSesion.Text = "Cerrar Sesion ";
            this.btnCerrarSesion.UseVisualStyleBackColor = false;
            // 
            // libres
            // 
            this.libres.AutoSize = true;
            this.libres.Font = new System.Drawing.Font("Lucida Console", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.libres.Location = new System.Drawing.Point(45, 150);
            this.libres.Name = "libres";
            this.libres.Size = new System.Drawing.Size(108, 19);
            this.libres.TabIndex = 9;
            this.libres.Text = "Libres : ";
            this.libres.Click += new System.EventHandler(this.label2_Click);
            // 
            // ocupados
            // 
            this.ocupados.AutoSize = true;
            this.ocupados.Font = new System.Drawing.Font("Lucida Console", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ocupados.Location = new System.Drawing.Point(23, 192);
            this.ocupados.Name = "ocupados";
            this.ocupados.Size = new System.Drawing.Size(130, 19);
            this.ocupados.TabIndex = 10;
            this.ocupados.Text = "Ocupados : ";
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 11F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(861, 433);
            this.Controls.Add(this.ocupados);
            this.Controls.Add(this.libres);
            this.Controls.Add(this.btnCerrarSesion);
            this.Controls.Add(this.estacionamiento);
            this.Controls.Add(this.saludo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.Admin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.estacionamiento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label saludo;
        private System.Windows.Forms.PictureBox estacionamiento;
        private System.Windows.Forms.Button btnCerrarSesion;
        private System.Windows.Forms.Label libres;
        private System.Windows.Forms.Label ocupados;
    }
}