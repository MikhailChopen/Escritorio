using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Escritorio
{
    public partial class Form1 : Form
    {

        ServidorCS.Service1SoapClient ServerCS = new ServidorCS.Service1SoapClient();

        public Form1()
        {
            InitializeComponent();

            usuarios.Parent = null;
            pedidos.Parent = null;
            sesion_info.Parent = null;
            llenar_usuarios();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (usuario.Text != "" && password.Text != "")
            {
                

                List<string> Lista = new List<string>();

                Lista = ServerCS.Iniciar_Sesion(usuario.Text, Int32.Parse(password.Text));

                if (Lista[0] == "1")
                {

                    sesion.Parent = null;
                    sesion_info.Parent = tabControl1;
                    usuarios.Parent = tabControl1;
                    pedidos.Parent = tabControl1;

                    s_carnet.Text = Lista[1];
                    s_nombre.Text = Lista[2];
                    s_apellido.Text = Lista[3];


                }
                else
                {
                    mensaje.Text = "Los datos son incorrectos";
                }

            }
            else 
            {
                mensaje.Text = "Campos Vacios";
            }
            

        }

        private void Cerrar_Sesion_Click(object sender, EventArgs e)
        {
            mensaje.Text = "";
            usuario.Text = "";
            password.Text = "";

            usuarios.Parent = null;
            pedidos.Parent = null;
            sesion_info.Parent = null;
            sesion.Parent = tabControl1;
        }



        public void llenar_usuarios() 
        {


            List<string> Lista = ServerCS.Leer_Usuarios();
            tabla_usuario.ColumnCount = 3;
            tabla_usuario.Columns[0].Name = "Carnet";
            tabla_usuario.Columns[0].Width = 223;
            tabla_usuario.Columns[1].Name = "Nombre";
            tabla_usuario.Columns[1].Width = 223;
            tabla_usuario.Columns[2].Name = "Apellido";
            tabla_usuario.Columns[2].Width = 223;

            tabla_usuario.Rows.Clear();

            int cantidad = Lista.Count();
            int i=0;
            while(i<cantidad)
            {
                string[] row = new string[] { Lista[i], Lista[i+1], Lista[i+2] };
                tabla_usuario.Rows.Add(row);
                i = i+3;

            }

            tabla_usuario.Refresh();

        }

        
    }
}
