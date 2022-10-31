namespace ControlEstacionamiento
{
    partial class Usuario
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Usuario));
            this.saludo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.estacionamiento = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.labelLibres = new System.Windows.Forms.Label();
            this.labelOcupados = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.libres = new System.Windows.Forms.Label();
            this.ocupados = new System.Windows.Forms.Label();
            this.auto0 = new System.Windows.Forms.PictureBox();
            this.auto2 = new System.Windows.Forms.PictureBox();
            this.auto1 = new System.Windows.Forms.PictureBox();
            this.auto3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.estacionamiento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.auto0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.auto2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.auto1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.auto3)).BeginInit();
            this.SuspendLayout();
            // 
            // saludo
            // 
            this.saludo.AutoSize = true;
            this.saludo.Font = new System.Drawing.Font("Perpetua", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saludo.ForeColor = System.Drawing.Color.DarkGreen;
            this.saludo.Location = new System.Drawing.Point(98, 48);
            this.saludo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.saludo.Name = "saludo";
            this.saludo.Size = new System.Drawing.Size(277, 42);
            this.saludo.TabIndex = 8;
            this.saludo.Text = "Bienvenido Usuario : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Perpetua", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGreen;
            this.label1.Location = new System.Drawing.Point(98, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(391, 36);
            this.label1.TabIndex = 7;
            this.label1.Text = "Control de Estacionamiento";
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.BackColor = System.Drawing.Color.DarkSalmon;
            this.btnCerrarSesion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCerrarSesion.Location = new System.Drawing.Point(14, 389);
            this.btnCerrarSesion.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(154, 32);
            this.btnCerrarSesion.TabIndex = 10;
            this.btnCerrarSesion.Text = "Cerrar Sesion ";
            this.btnCerrarSesion.UseVisualStyleBackColor = false;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // serialPort1
            // 
            this.serialPort1.PortName = "COM4";
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
            this.estacionamiento.TabIndex = 9;
            this.estacionamiento.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ControlEstacionamiento.Properties.Resources.car_23964;
            this.pictureBox2.Location = new System.Drawing.Point(12, 17);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(78, 80);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // labelLibres
            // 
            this.labelLibres.AutoSize = true;
            this.labelLibres.Font = new System.Drawing.Font("Lucida Console", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLibres.Location = new System.Drawing.Point(45, 150);
            this.labelLibres.Name = "labelLibres";
            this.labelLibres.Size = new System.Drawing.Size(108, 19);
            this.labelLibres.TabIndex = 11;
            this.labelLibres.Text = "Libres : ";
            // 
            // labelOcupados
            // 
            this.labelOcupados.AutoSize = true;
            this.labelOcupados.Font = new System.Drawing.Font("Lucida Console", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOcupados.Location = new System.Drawing.Point(23, 192);
            this.labelOcupados.Name = "labelOcupados";
            this.labelOcupados.Size = new System.Drawing.Size(130, 19);
            this.labelOcupados.TabIndex = 12;
            this.labelOcupados.Text = "Ocupados : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 11);
            this.label2.TabIndex = 13;
            this.label2.Text = "label2";
            // 
            // libres
            // 
            this.libres.AutoSize = true;
            this.libres.Font = new System.Drawing.Font("Lucida Console", 14.25F);
            this.libres.Location = new System.Drawing.Point(159, 150);
            this.libres.Name = "libres";
            this.libres.Size = new System.Drawing.Size(0, 19);
            this.libres.TabIndex = 14;
            // 
            // ocupados
            // 
            this.ocupados.AutoSize = true;
            this.ocupados.Font = new System.Drawing.Font("Lucida Console", 14.25F);
            this.ocupados.Location = new System.Drawing.Point(159, 192);
            this.ocupados.Name = "ocupados";
            this.ocupados.Size = new System.Drawing.Size(0, 19);
            this.ocupados.TabIndex = 15;
            // 
            // auto0
            // 
            this.auto0.BackColor = System.Drawing.Color.White;
            this.auto0.Image = global::ControlEstacionamiento.Properties.Resources.auto;
            this.auto0.Location = new System.Drawing.Point(339, 134);
            this.auto0.Name = "auto0";
            this.auto0.Size = new System.Drawing.Size(64, 108);
            this.auto0.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.auto0.TabIndex = 16;
            this.auto0.TabStop = false;
            // 
            // auto2
            // 
            this.auto2.BackColor = System.Drawing.Color.White;
            this.auto2.Image = global::ControlEstacionamiento.Properties.Resources.autoInvertido1;
            this.auto2.Location = new System.Drawing.Point(339, 268);
            this.auto2.Name = "auto2";
            this.auto2.Size = new System.Drawing.Size(64, 108);
            this.auto2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.auto2.TabIndex = 17;
            this.auto2.TabStop = false;
            // 
            // auto1
            // 
            this.auto1.BackColor = System.Drawing.Color.White;
            this.auto1.Image = global::ControlEstacionamiento.Properties.Resources.auto;
            this.auto1.Location = new System.Drawing.Point(434, 134);
            this.auto1.Name = "auto1";
            this.auto1.Size = new System.Drawing.Size(64, 108);
            this.auto1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.auto1.TabIndex = 18;
            this.auto1.TabStop = false;
            // 
            // auto3
            // 
            this.auto3.BackColor = System.Drawing.Color.White;
            this.auto3.Image = global::ControlEstacionamiento.Properties.Resources.autoInvertido1;
            this.auto3.Location = new System.Drawing.Point(434, 268);
            this.auto3.Name = "auto3";
            this.auto3.Size = new System.Drawing.Size(64, 108);
            this.auto3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.auto3.TabIndex = 19;
            this.auto3.TabStop = false;
            // 
            // Usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 11F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(861, 433);
            this.Controls.Add(this.auto3);
            this.Controls.Add(this.auto1);
            this.Controls.Add(this.auto2);
            this.Controls.Add(this.auto0);
            this.Controls.Add(this.ocupados);
            this.Controls.Add(this.libres);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelOcupados);
            this.Controls.Add(this.labelLibres);
            this.Controls.Add(this.btnCerrarSesion);
            this.Controls.Add(this.estacionamiento);
            this.Controls.Add(this.saludo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Font = new System.Drawing.Font("Lucida Console", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Usuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Usuario";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Usuario_FormClosed);
            this.Load += new System.EventHandler(this.Usuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.estacionamiento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.auto0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.auto2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.auto1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.auto3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label saludo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox estacionamiento;
        private System.Windows.Forms.Button btnCerrarSesion;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Label labelLibres;
        private System.Windows.Forms.Label labelOcupados;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label libres;
        private System.Windows.Forms.Label ocupados;
        private System.Windows.Forms.PictureBox auto0;
        private System.Windows.Forms.PictureBox auto2;
        private System.Windows.Forms.PictureBox auto1;
        private System.Windows.Forms.PictureBox auto3;
    }
}