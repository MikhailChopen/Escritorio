namespace Escritorio
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.usuarios = new System.Windows.Forms.TabPage();
            this.sesion = new System.Windows.Forms.TabPage();
            this.password = new System.Windows.Forms.TextBox();
            this.usuario = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.pedidos = new System.Windows.Forms.TabPage();
            this.sesion_info = new System.Windows.Forms.TabPage();
            this.Cerrar_Sesion = new System.Windows.Forms.Button();
            this.s_apellido = new System.Windows.Forms.Label();
            this.s_nombre = new System.Windows.Forms.Label();
            this.s_carnet = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.mensaje = new System.Windows.Forms.Label();
            this.u_carnet = new System.Windows.Forms.TextBox();
            this.u_nombre = new System.Windows.Forms.TextBox();
            this.u_apellido = new System.Windows.Forms.TextBox();
            this.u_crear = new System.Windows.Forms.Button();
            this.u_eliminar = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.u_actualizar = new System.Windows.Forms.Button();
            this.tabla_usuario = new System.Windows.Forms.DataGridView();
            this.p_id = new System.Windows.Forms.TextBox();
            this.p_pedido = new System.Windows.Forms.TextBox();
            this.p_cantidad = new System.Windows.Forms.TextBox();
            this.p_carnet = new System.Windows.Forms.TextBox();
            this.refrescar = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.p_crear = new System.Windows.Forms.Button();
            this.p_eliminar = new System.Windows.Forms.Button();
            this.p_actualizar = new System.Windows.Forms.Button();
            this.p_refrescar = new System.Windows.Forms.Button();
            this.tabla_pedidos = new System.Windows.Forms.DataGridView();
            this.usuarios.SuspendLayout();
            this.sesion.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.pedidos.SuspendLayout();
            this.sesion_info.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabla_usuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabla_pedidos)).BeginInit();
            this.SuspendLayout();
            // 
            // usuarios
            // 
            this.usuarios.Controls.Add(this.refrescar);
            this.usuarios.Controls.Add(this.tabla_usuario);
            this.usuarios.Controls.Add(this.u_actualizar);
            this.usuarios.Controls.Add(this.label11);
            this.usuarios.Controls.Add(this.label10);
            this.usuarios.Controls.Add(this.label9);
            this.usuarios.Controls.Add(this.u_eliminar);
            this.usuarios.Controls.Add(this.u_crear);
            this.usuarios.Controls.Add(this.u_apellido);
            this.usuarios.Controls.Add(this.u_nombre);
            this.usuarios.Controls.Add(this.u_carnet);
            this.usuarios.Location = new System.Drawing.Point(4, 22);
            this.usuarios.Name = "usuarios";
            this.usuarios.Padding = new System.Windows.Forms.Padding(3);
            this.usuarios.Size = new System.Drawing.Size(737, 382);
            this.usuarios.TabIndex = 3;
            this.usuarios.Text = "Usuarios";
            this.usuarios.UseVisualStyleBackColor = true;
            // 
            // sesion
            // 
            this.sesion.Controls.Add(this.mensaje);
            this.sesion.Controls.Add(this.password);
            this.sesion.Controls.Add(this.usuario);
            this.sesion.Controls.Add(this.label3);
            this.sesion.Controls.Add(this.label2);
            this.sesion.Controls.Add(this.button1);
            this.sesion.Controls.Add(this.label1);
            this.sesion.Location = new System.Drawing.Point(4, 22);
            this.sesion.Name = "sesion";
            this.sesion.Padding = new System.Windows.Forms.Padding(3);
            this.sesion.Size = new System.Drawing.Size(737, 382);
            this.sesion.TabIndex = 2;
            this.sesion.Text = "Iniciar Sesion";
            this.sesion.UseVisualStyleBackColor = true;
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(329, 158);
            this.password.Name = "password";
            this.password.PasswordChar = 'x';
            this.password.Size = new System.Drawing.Size(160, 20);
            this.password.TabIndex = 5;
            // 
            // usuario
            // 
            this.usuario.Location = new System.Drawing.Point(329, 124);
            this.usuario.Name = "usuario";
            this.usuario.Size = new System.Drawing.Size(160, 20);
            this.usuario.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(209, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(209, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Usuario";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(320, 222);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 40);
            this.button1.TabIndex = 1;
            this.button1.Text = "Iniciar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(280, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "INICIAR SESION";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.sesion);
            this.tabControl1.Controls.Add(this.usuarios);
            this.tabControl1.Controls.Add(this.pedidos);
            this.tabControl1.Controls.Add(this.sesion_info);
            this.tabControl1.Location = new System.Drawing.Point(1, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(745, 408);
            this.tabControl1.TabIndex = 0;
            // 
            // pedidos
            // 
            this.pedidos.Controls.Add(this.tabla_pedidos);
            this.pedidos.Controls.Add(this.p_refrescar);
            this.pedidos.Controls.Add(this.p_actualizar);
            this.pedidos.Controls.Add(this.p_eliminar);
            this.pedidos.Controls.Add(this.p_crear);
            this.pedidos.Controls.Add(this.label15);
            this.pedidos.Controls.Add(this.label14);
            this.pedidos.Controls.Add(this.label13);
            this.pedidos.Controls.Add(this.label12);
            this.pedidos.Controls.Add(this.p_carnet);
            this.pedidos.Controls.Add(this.p_cantidad);
            this.pedidos.Controls.Add(this.p_pedido);
            this.pedidos.Controls.Add(this.p_id);
            this.pedidos.Location = new System.Drawing.Point(4, 22);
            this.pedidos.Name = "pedidos";
            this.pedidos.Size = new System.Drawing.Size(737, 382);
            this.pedidos.TabIndex = 4;
            this.pedidos.Text = "Pedidos";
            this.pedidos.UseVisualStyleBackColor = true;
            // 
            // sesion_info
            // 
            this.sesion_info.Controls.Add(this.Cerrar_Sesion);
            this.sesion_info.Controls.Add(this.s_apellido);
            this.sesion_info.Controls.Add(this.s_nombre);
            this.sesion_info.Controls.Add(this.s_carnet);
            this.sesion_info.Controls.Add(this.label8);
            this.sesion_info.Controls.Add(this.label7);
            this.sesion_info.Controls.Add(this.label6);
            this.sesion_info.Controls.Add(this.label5);
            this.sesion_info.Controls.Add(this.label4);
            this.sesion_info.Location = new System.Drawing.Point(4, 22);
            this.sesion_info.Name = "sesion_info";
            this.sesion_info.Size = new System.Drawing.Size(737, 382);
            this.sesion_info.TabIndex = 5;
            this.sesion_info.Text = "Sesion";
            this.sesion_info.UseVisualStyleBackColor = true;
            // 
            // Cerrar_Sesion
            // 
            this.Cerrar_Sesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cerrar_Sesion.Location = new System.Drawing.Point(551, 340);
            this.Cerrar_Sesion.Name = "Cerrar_Sesion";
            this.Cerrar_Sesion.Size = new System.Drawing.Size(176, 34);
            this.Cerrar_Sesion.TabIndex = 8;
            this.Cerrar_Sesion.Text = "Cerrar_Sesion";
            this.Cerrar_Sesion.UseVisualStyleBackColor = true;
            this.Cerrar_Sesion.Click += new System.EventHandler(this.Cerrar_Sesion_Click);
            // 
            // s_apellido
            // 
            this.s_apellido.AutoSize = true;
            this.s_apellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.s_apellido.Location = new System.Drawing.Point(165, 190);
            this.s_apellido.Name = "s_apellido";
            this.s_apellido.Size = new System.Drawing.Size(87, 25);
            this.s_apellido.TabIndex = 7;
            this.s_apellido.Text = "apellido";
            // 
            // s_nombre
            // 
            this.s_nombre.AutoSize = true;
            this.s_nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.s_nombre.Location = new System.Drawing.Point(165, 154);
            this.s_nombre.Name = "s_nombre";
            this.s_nombre.Size = new System.Drawing.Size(84, 25);
            this.s_nombre.TabIndex = 6;
            this.s_nombre.Text = "nombre";
            // 
            // s_carnet
            // 
            this.s_carnet.AutoSize = true;
            this.s_carnet.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.s_carnet.Location = new System.Drawing.Point(165, 118);
            this.s_carnet.Name = "s_carnet";
            this.s_carnet.Size = new System.Drawing.Size(72, 25);
            this.s_carnet.TabIndex = 5;
            this.s_carnet.Text = "carnet";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(53, 118);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 25);
            this.label8.TabIndex = 4;
            this.label8.Text = "Carnet :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(53, 190);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 25);
            this.label7.TabIndex = 3;
            this.label7.Text = "Apellido :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(53, 154);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 25);
            this.label6.TabIndex = 2;
            this.label6.Text = "Nombre :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(31, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 25);
            this.label5.TabIndex = 1;
            this.label5.Text = "Usuario ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(266, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(225, 29);
            this.label4.TabIndex = 0;
            this.label4.Text = "SESION INICIADA";
            // 
            // mensaje
            // 
            this.mensaje.AutoSize = true;
            this.mensaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mensaje.ForeColor = System.Drawing.Color.Red;
            this.mensaje.Location = new System.Drawing.Point(7, 343);
            this.mensaje.Name = "mensaje";
            this.mensaje.Size = new System.Drawing.Size(0, 24);
            this.mensaje.TabIndex = 6;
            // 
            // u_carnet
            // 
            this.u_carnet.Location = new System.Drawing.Point(7, 33);
            this.u_carnet.Name = "u_carnet";
            this.u_carnet.Size = new System.Drawing.Size(157, 20);
            this.u_carnet.TabIndex = 0;
            // 
            // u_nombre
            // 
            this.u_nombre.Location = new System.Drawing.Point(170, 33);
            this.u_nombre.Name = "u_nombre";
            this.u_nombre.Size = new System.Drawing.Size(154, 20);
            this.u_nombre.TabIndex = 1;
            // 
            // u_apellido
            // 
            this.u_apellido.Location = new System.Drawing.Point(330, 32);
            this.u_apellido.Name = "u_apellido";
            this.u_apellido.Size = new System.Drawing.Size(146, 20);
            this.u_apellido.TabIndex = 2;
            // 
            // u_crear
            // 
            this.u_crear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.u_crear.Location = new System.Drawing.Point(482, 30);
            this.u_crear.Name = "u_crear";
            this.u_crear.Size = new System.Drawing.Size(75, 23);
            this.u_crear.TabIndex = 3;
            this.u_crear.Text = "Crear";
            this.u_crear.UseVisualStyleBackColor = true;
            this.u_crear.Click += new System.EventHandler(this.u_crear_Click);
            // 
            // u_eliminar
            // 
            this.u_eliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.u_eliminar.Location = new System.Drawing.Point(563, 29);
            this.u_eliminar.Name = "u_eliminar";
            this.u_eliminar.Size = new System.Drawing.Size(75, 23);
            this.u_eliminar.TabIndex = 4;
            this.u_eliminar.Text = "Eliminar";
            this.u_eliminar.UseVisualStyleBackColor = true;
            this.u_eliminar.Click += new System.EventHandler(this.u_eliminar_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(56, 6);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 20);
            this.label9.TabIndex = 5;
            this.label9.Text = "Carnet";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(211, 6);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 20);
            this.label10.TabIndex = 6;
            this.label10.Text = "Nombre";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(370, 6);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(73, 20);
            this.label11.TabIndex = 7;
            this.label11.Text = "Apellido";
            // 
            // u_actualizar
            // 
            this.u_actualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.u_actualizar.Location = new System.Drawing.Point(644, 29);
            this.u_actualizar.Name = "u_actualizar";
            this.u_actualizar.Size = new System.Drawing.Size(75, 23);
            this.u_actualizar.TabIndex = 8;
            this.u_actualizar.Text = "Actualizar";
            this.u_actualizar.UseVisualStyleBackColor = true;
            this.u_actualizar.Click += new System.EventHandler(this.u_actualizar_Click);
            // 
            // tabla_usuario
            // 
            this.tabla_usuario.AllowUserToAddRows = false;
            this.tabla_usuario.AllowUserToDeleteRows = false;
            this.tabla_usuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabla_usuario.Location = new System.Drawing.Point(7, 59);
            this.tabla_usuario.Name = "tabla_usuario";
            this.tabla_usuario.ReadOnly = true;
            this.tabla_usuario.Size = new System.Drawing.Size(712, 315);
            this.tabla_usuario.TabIndex = 9;
            // 
            // p_id
            // 
            this.p_id.Location = new System.Drawing.Point(7, 27);
            this.p_id.Name = "p_id";
            this.p_id.Size = new System.Drawing.Size(169, 20);
            this.p_id.TabIndex = 0;
            // 
            // p_pedido
            // 
            this.p_pedido.Location = new System.Drawing.Point(182, 27);
            this.p_pedido.Name = "p_pedido";
            this.p_pedido.Size = new System.Drawing.Size(186, 20);
            this.p_pedido.TabIndex = 1;
            // 
            // p_cantidad
            // 
            this.p_cantidad.Location = new System.Drawing.Point(374, 27);
            this.p_cantidad.Name = "p_cantidad";
            this.p_cantidad.Size = new System.Drawing.Size(178, 20);
            this.p_cantidad.TabIndex = 2;
            // 
            // p_carnet
            // 
            this.p_carnet.Location = new System.Drawing.Point(558, 27);
            this.p_carnet.Name = "p_carnet";
            this.p_carnet.Size = new System.Drawing.Size(169, 20);
            this.p_carnet.TabIndex = 3;
            // 
            // refrescar
            // 
            this.refrescar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refrescar.Location = new System.Drawing.Point(482, 3);
            this.refrescar.Name = "refrescar";
            this.refrescar.Size = new System.Drawing.Size(237, 23);
            this.refrescar.TabIndex = 10;
            this.refrescar.Text = "Actualizar Tabla De Usuarios";
            this.refrescar.UseVisualStyleBackColor = true;
            this.refrescar.Click += new System.EventHandler(this.refrescar_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(60, 4);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(85, 20);
            this.label12.TabIndex = 4;
            this.label12.Text = "Id Pedido";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(247, 4);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(64, 20);
            this.label13.TabIndex = 5;
            this.label13.Text = "Pedido";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(428, 4);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(81, 20);
            this.label14.TabIndex = 6;
            this.label14.Text = "Cantidad";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(612, 4);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(63, 20);
            this.label15.TabIndex = 7;
            this.label15.Text = "Carnet";
            // 
            // p_crear
            // 
            this.p_crear.Location = new System.Drawing.Point(8, 54);
            this.p_crear.Name = "p_crear";
            this.p_crear.Size = new System.Drawing.Size(168, 23);
            this.p_crear.TabIndex = 8;
            this.p_crear.Text = "Crear";
            this.p_crear.UseVisualStyleBackColor = true;
            this.p_crear.Click += new System.EventHandler(this.p_crear_Click);
            // 
            // p_eliminar
            // 
            this.p_eliminar.Location = new System.Drawing.Point(182, 54);
            this.p_eliminar.Name = "p_eliminar";
            this.p_eliminar.Size = new System.Drawing.Size(186, 23);
            this.p_eliminar.TabIndex = 9;
            this.p_eliminar.Text = "Eliminar";
            this.p_eliminar.UseVisualStyleBackColor = true;
            this.p_eliminar.Click += new System.EventHandler(this.p_eliminar_Click);
            // 
            // p_actualizar
            // 
            this.p_actualizar.Location = new System.Drawing.Point(374, 54);
            this.p_actualizar.Name = "p_actualizar";
            this.p_actualizar.Size = new System.Drawing.Size(178, 23);
            this.p_actualizar.TabIndex = 10;
            this.p_actualizar.Text = "Actualizar";
            this.p_actualizar.UseVisualStyleBackColor = true;
            this.p_actualizar.Click += new System.EventHandler(this.p_actualizar_Click);
            // 
            // p_refrescar
            // 
            this.p_refrescar.Location = new System.Drawing.Point(558, 54);
            this.p_refrescar.Name = "p_refrescar";
            this.p_refrescar.Size = new System.Drawing.Size(168, 23);
            this.p_refrescar.TabIndex = 11;
            this.p_refrescar.Text = "Actualizar Tabla De Pedidos";
            this.p_refrescar.UseVisualStyleBackColor = true;
            this.p_refrescar.Click += new System.EventHandler(this.p_refrescar_Click);
            // 
            // tabla_pedidos
            // 
            this.tabla_pedidos.AllowUserToAddRows = false;
            this.tabla_pedidos.AllowUserToDeleteRows = false;
            this.tabla_pedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabla_pedidos.Location = new System.Drawing.Point(8, 83);
            this.tabla_pedidos.Name = "tabla_pedidos";
            this.tabla_pedidos.ReadOnly = true;
            this.tabla_pedidos.Size = new System.Drawing.Size(718, 291);
            this.tabla_pedidos.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 409);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Aplicacion Escritorio";
            this.usuarios.ResumeLayout(false);
            this.usuarios.PerformLayout();
            this.sesion.ResumeLayout(false);
            this.sesion.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.pedidos.ResumeLayout(false);
            this.pedidos.PerformLayout();
            this.sesion_info.ResumeLayout(false);
            this.sesion_info.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabla_usuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabla_pedidos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage usuarios;
        private System.Windows.Forms.TabPage sesion;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.TextBox usuario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage pedidos;
        private System.Windows.Forms.TabPage sesion_info;
        private System.Windows.Forms.Button Cerrar_Sesion;
        private System.Windows.Forms.Label s_apellido;
        private System.Windows.Forms.Label s_nombre;
        private System.Windows.Forms.Label s_carnet;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label mensaje;
        private System.Windows.Forms.DataGridView tabla_usuario;
        private System.Windows.Forms.Button u_actualizar;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button u_eliminar;
        private System.Windows.Forms.Button u_crear;
        private System.Windows.Forms.TextBox u_apellido;
        private System.Windows.Forms.TextBox u_nombre;
        private System.Windows.Forms.TextBox u_carnet;
        private System.Windows.Forms.Button refrescar;
        private System.Windows.Forms.TextBox p_carnet;
        private System.Windows.Forms.TextBox p_cantidad;
        private System.Windows.Forms.TextBox p_pedido;
        private System.Windows.Forms.TextBox p_id;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView tabla_pedidos;
        private System.Windows.Forms.Button p_refrescar;
        private System.Windows.Forms.Button p_actualizar;
        private System.Windows.Forms.Button p_eliminar;
        private System.Windows.Forms.Button p_crear;

    }
}

