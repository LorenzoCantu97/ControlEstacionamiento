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
    public partial class Usuario : Form
    {
        //"cerrado" se utiliza como señalador si está abierto o cerrado éste forms
        bool cerrado = false;
        string idUsuario;

        //Al inicializar la clase es necesario abrir la comunicación serial con sus propiedades
        public Usuario(string id)
        {
            InitializeComponent();
            idUsuario = id;
            serialPort1 = new SerialPort();
            serialPort1.PortName = "COM4";
            serialPort1.BaudRate = 9600;
            serialPort1.ReadTimeout = 500;
            try
            {
                serialPort1.Open();
            }
            catch
            {
                MessageBox.Show("Arduino no conectado");
            }
        }

        //Al cargar el forms, oculta los carros, recibe el id e inicia la comunicación serial
        private void Usuario_Load(object sender, EventArgs e)
        {
            saludo.Text += idUsuario;
            auto0.Hide();
            auto1.Hide();
            auto2.Hide();
            auto3.Hide();
            Thread hilo = new Thread(escucharSerial);
            hilo.Start();
        }

        //Cierra el forms y abre "Inicio.cs"
        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            Program.Inicio.showInicio();
            this.Close();
        }

        //Función utilizada en thread para comunicación serial. Manda a llamar "contarCarros()"
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

        //Hace el cálculo de los carros existentes y los muestra en pantalla
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
                }
                else
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

        //Muestra el carro según los parametros recibidos
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

        //Borra el carro según los parametros recibidos
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

        //Cierra el puerto serial y cambia el valor de la variable "cerrado", que a su vez termina la comunicación serial
        private void Usuario_FormClosed(object sender, FormClosedEventArgs e)
        {
            cerrado = true;
            if (serialPort1.IsOpen)
            {
                serialPort1.Close();
            }
        }
    }
}
