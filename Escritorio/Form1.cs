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
            llenar_pedidos();
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

        private void u_crear_Click(object sender, EventArgs e)
        {
           ServerCS.Crear_Usuario(Int32.Parse(u_carnet.Text),u_nombre.Text,u_apellido.Text);
           llenar_usuarios();
           u_carnet.Text = "";
           u_nombre.Text = "";
           u_apellido.Text = "";

        }

        private void u_eliminar_Click(object sender, EventArgs e)
        {
            ServerCS.Eliminar_Usuario(Int32.Parse(u_carnet.Text));
            llenar_usuarios();
            u_carnet.Text = "";
            u_nombre.Text = "";
            u_apellido.Text = "";
        }

        private void u_actualizar_Click(object sender, EventArgs e)
        {
            ServerCS.Actualizar_Usuario(Int32.Parse(u_carnet.Text), u_nombre.Text, u_apellido.Text);
            llenar_usuarios();
            u_carnet.Text = "";
            u_nombre.Text = "";
            u_apellido.Text = "";
        }

        private void refrescar_Click(object sender, EventArgs e)
        {
            llenar_usuarios();
        }





        public void llenar_pedidos()
        {

            List<string> Lista = ServerCS.Leer_pedidos();
            tabla_pedidos.ColumnCount = 4;
            tabla_pedidos.Columns[0].Name = "Id Pedido";
            tabla_pedidos.Columns[0].Width = 168;
            tabla_pedidos.Columns[1].Name = "Pedido";
            tabla_pedidos.Columns[1].Width = 168;
            tabla_pedidos.Columns[2].Name = "Cantidad";
            tabla_pedidos.Columns[2].Width = 169;
            tabla_pedidos.Columns[3].Name = "Carnet";
            tabla_pedidos.Columns[3].Width = 170;

            tabla_pedidos.Rows.Clear();

            int cantidad = Lista.Count();
            int i = 0;
            while (i < cantidad)
            {
                string[] row = new string[] { Lista[i], Lista[i + 1], Lista[i + 2], Lista[i + 3] };
                tabla_pedidos.Rows.Add(row);
                i = i + 4;

            }

            tabla_pedidos.Refresh();

        }

        
        private void p_crear_Click(object sender, EventArgs e)
        {
            ServerCS.Crear_Pedido(p_pedido.Text, Int32.Parse(p_cantidad.Text), Int32.Parse(p_carnet.Text));
            llenar_pedidos();
            p_id.Text = "";
            p_pedido.Text = "";
            p_cantidad.Text = "";
            p_carnet.Text = "";
        }

        private void p_eliminar_Click(object sender, EventArgs e)
        {
            ServerCS.Eliminar_pedido(Int32.Parse(p_id.Text));
            llenar_pedidos();
            p_id.Text = "";
            p_pedido.Text = "";
            p_cantidad.Text = "";
            p_carnet.Text = "";
        }

        private void p_actualizar_Click(object sender, EventArgs e)
        {
            ServerCS.Actualizar_Pedido(Int32.Parse(p_id.Text),p_pedido.Text, Int32.Parse(p_cantidad.Text), Int32.Parse(p_carnet.Text));
            llenar_pedidos();
            p_id.Text = "";
            p_pedido.Text = "";
            p_cantidad.Text = "";
            p_carnet.Text = "";
        }

        private void p_refrescar_Click(object sender, EventArgs e)
        {
            llenar_pedidos();
        }




        



    }
}
