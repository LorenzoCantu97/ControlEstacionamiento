using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlEstacionamiento
{
    public partial class Admin : Form
    {
        bool cerrado = false;
        string idUsuario;
        public Admin(string id)
        {
            InitializeComponent();
            idUsuario = id;
            serialPort1 = new SerialPort();
            serialPort1.PortName = "COM4";
            serialPort1.BaudRate = 9600;
            serialPort1.ReadTimeout = 1500;
            try
            {
                serialPort1.Open();
            } 
            catch
            {
                MessageBox.Show("Arduino no conectado");
            }
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            saludo.Text += idUsuario;
            auto0.Hide();
            auto1.Hide();
            auto2.Hide();
            auto3.Hide();
            Thread hilo = new Thread(escucharSerial);
            hilo.Start();
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            Program.Inicio.showInicio();
            this.Close();
        }

        private void escucharSerial()
        {
            while (!cerrado)
            {
                try
                {
                    string cadena = serialPort1.ReadLine();
                    contarCarros(cadena);
                }
                catch (Exception exc)
                {
                    //MessageBox.Show(exc.ToString());
                }
            }
        }

        private void contarCarros(string carros)
        {
            int ocupado = 0;
            int libre = -1;
            
            for (int i = 0; i < carros.Length; i++)
            {
                string actual = carros.Substring(i, 1);
                if (actual == "0")
                {
                    dibujarCarro(i);
                    ocupado++;
                } else
                {
                    borrarCarro(i);
                    libre++;
                }
            }            
            libres.Invoke(new MethodInvoker(
                delegate
                {
                    libres.Text = libre.ToString();
                }));
            ocupados.Invoke(new MethodInvoker(
                delegate
                {
                    ocupados.Text = ocupado.ToString();
                }));            
        }

        private void dibujarCarro(int posicion)
        {
            switch (posicion)
            {
                case 0:
                    auto0.Invoke(new MethodInvoker(
                        delegate
                        {
                            auto0.Show();
                        }));
                    break;
                case 1:
                    auto1.Invoke(new MethodInvoker(
                        delegate
                        {
                            auto1.Show();
                        })); break;
                case 2:
                    auto2.Invoke(new MethodInvoker(
                        delegate
                        {
                            auto2.Show();
                        })); 
                    break;
                case 3:
                    auto3.Invoke(new MethodInvoker(
                        delegate
                        {
                            auto3.Show();
                        })); 
                    break;
            }
        }

        private void borrarCarro(int posicion)
        {
            switch (posicion)
            {
                case 0:
                    auto0.Invoke(new MethodInvoker(
                        delegate
                        {
                            auto0.Hide();
                        }));
                    break;
                case 1:
                    auto1.Invoke(new MethodInvoker(
                        delegate
                        {
                            auto1.Hide();
                        })); break;
                case 2:
                    auto2.Invoke(new MethodInvoker(
                        delegate
                        {
                            auto2.Hide();
                        }));
                    break;
                case 3:
                    auto3.Invoke(new MethodInvoker(
                        delegate
                        {
                            auto3.Hide();
                        }));
                    break;
            }
        }

        private void Admin_FormClosed(object sender, FormClosedEventArgs e)
        {
            cerrado = true;
            if (serialPort1.IsOpen)
            {
                serialPort1.Close();
            }
        }
    }
}
