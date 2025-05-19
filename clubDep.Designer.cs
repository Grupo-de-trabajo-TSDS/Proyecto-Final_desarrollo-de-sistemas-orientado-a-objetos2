
using System.Net;
namespace clubd
{
    
    partial class clubdep
    {
        

        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>


        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            ingresoSis = new Panel();
            label3 = new Label();
            label2 = new Label();
            label4 = new Label();
            txtPassword = new TextBox();
            label1 = new Label();
            txtMainUser = new TextBox();
            InicioAdmin = new Panel();
            cmdListMorosos = new Button();
            txtDni = new TextBox();
            label6 = new Label();
            label5 = new Label();
            inscCliente = new Panel();
            cmdVolver1 = new Button();
            cmdLimpiar = new Button();
            chkSocio = new CheckBox();
            cmdConfirma = new Button();
            txtFichamed = new TextBox();
            txtConturgencia = new TextBox();
            txtTelefono = new TextBox();
            txtEmail = new TextBox();
            txtDireccion = new TextBox();
            txtFechanac = new TextBox();
            txtApellido = new TextBox();
            txtNombre = new TextBox();
            txtNuevoDni = new TextBox();
            label7 = new Label();
            toolTip1 = new ToolTip(components);
            toolTip2 = new ToolTip(components);
            actSocio = new Panel();
            cmdVolver2 = new Button();
            cmdCarnet = new Button();
            cmdPagoCS = new Button();
            label10 = new Label();
            txtDniSel = new TextBox();
            label8 = new Label();
            actNoSocio = new Panel();
            label9 = new Label();
            label11 = new Label();
            txtDniSel2 = new TextBox();
            cmdInsAct = new Button();
            cmdVolver3 = new Button();
            toolTip3 = new ToolTip(components);
            toolTip4 = new ToolTip(components);
            toolTip5 = new ToolTip(components);
            button1 = new Button();
            ingresoSis.SuspendLayout();
            InicioAdmin.SuspendLayout();
            inscCliente.SuspendLayout();
            actSocio.SuspendLayout();
            actNoSocio.SuspendLayout();
            SuspendLayout();
            // 
            // ingresoSis
            // 
            ingresoSis.Controls.Add(button1);
            ingresoSis.Controls.Add(label3);
            ingresoSis.Controls.Add(label2);
            ingresoSis.Controls.Add(label4);
            ingresoSis.Controls.Add(txtPassword);
            ingresoSis.Controls.Add(label1);
            ingresoSis.Controls.Add(txtMainUser);
            ingresoSis.Location = new Point(0, -3);
            ingresoSis.Name = "ingresoSis";
            ingresoSis.Size = new Size(802, 451);
            ingresoSis.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(254, 269);
            label3.Name = "label3";
            label3.Size = new Size(77, 17);
            label3.TabIndex = 3;
            label3.Text = "Contraseña:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(287, 105);
            label2.Name = "label2";
            label2.Size = new Size(229, 37);
            label2.TabIndex = 1;
            label2.Text = "Ingreso al sistema";
            label2.Click += label2_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(217, 26);
            label4.Name = "label4";
            label4.Size = new Size(368, 45);
            label4.TabIndex = 0;
            label4.Text = "Club deportivo Grupo5";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(337, 269);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(192, 25);
            txtPassword.TabIndex = 4;
            toolTip2.SetToolTip(txtPassword, "Ingrese su clave de acceso y oprima ENTER");
            txtPassword.TextChanged += password_TextChanged;
            txtPassword.KeyDown += password_KeyDown;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(273, 201);
            label1.Name = "label1";
            label1.Size = new Size(58, 20);
            label1.TabIndex = 0;
            label1.Text = "Usuario:";
            label1.Click += label1_Click;
            // 
            // txtMainUser
            // 
            txtMainUser.Location = new Point(337, 201);
            txtMainUser.Name = "txtMainUser";
            txtMainUser.Size = new Size(192, 25);
            txtMainUser.TabIndex = 2;
            toolTip1.SetToolTip(txtMainUser, "Ingrese su nombre de usuario");
            txtMainUser.TextChanged += mainUser_TextChanged;
            // 
            // InicioAdmin
            // 
            InicioAdmin.BackColor = SystemColors.Control;
            InicioAdmin.BackgroundImageLayout = ImageLayout.None;
            InicioAdmin.Controls.Add(cmdListMorosos);
            InicioAdmin.Controls.Add(txtDni);
            InicioAdmin.Controls.Add(label6);
            InicioAdmin.Controls.Add(label5);
            InicioAdmin.Location = new Point(0, 0);
            InicioAdmin.Name = "InicioAdmin";
            InicioAdmin.Size = new Size(802, 451);
            InicioAdmin.TabIndex = 0;
            // 
            // cmdListMorosos
            // 
            cmdListMorosos.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmdListMorosos.Location = new Point(315, 262);
            cmdListMorosos.Name = "cmdListMorosos";
            cmdListMorosos.Size = new Size(172, 29);
            cmdListMorosos.TabIndex = 3;
            cmdListMorosos.Text = "Listado de morosos";
            toolTip4.SetToolTip(cmdListMorosos, "Emite listado de socios con cuotas atrasadas");
            cmdListMorosos.UseVisualStyleBackColor = true;
            cmdListMorosos.Click += button1_Click;
            // 
            // txtDni
            // 
            txtDni.Location = new Point(401, 151);
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(100, 25);
            txtDni.TabIndex = 2;
            toolTip3.SetToolTip(txtDni, "Ingrese DNI de la persona");
            txtDni.TextChanged += dni_TextChanged;
            txtDni.KeyDown += dni_KeyDown;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(301, 154);
            label6.Name = "label6";
            label6.Size = new Size(94, 17);
            label6.TabIndex = 1;
            label6.Text = "Ingrese el DNI:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(320, 47);
            label5.Name = "label5";
            label5.Size = new Size(163, 30);
            label5.TabIndex = 0;
            label5.Text = "Administración";
            // 
            // inscCliente
            // 
            inscCliente.Controls.Add(cmdVolver1);
            inscCliente.Controls.Add(cmdLimpiar);
            inscCliente.Controls.Add(chkSocio);
            inscCliente.Controls.Add(cmdConfirma);
            inscCliente.Controls.Add(txtFichamed);
            inscCliente.Controls.Add(txtConturgencia);
            inscCliente.Controls.Add(txtTelefono);
            inscCliente.Controls.Add(txtEmail);
            inscCliente.Controls.Add(txtDireccion);
            inscCliente.Controls.Add(txtFechanac);
            inscCliente.Controls.Add(txtApellido);
            inscCliente.Controls.Add(txtNombre);
            inscCliente.Controls.Add(txtNuevoDni);
            inscCliente.Controls.Add(label7);
            inscCliente.Location = new Point(0, 0);
            inscCliente.Name = "inscCliente";
            inscCliente.Size = new Size(802, 451);
            inscCliente.TabIndex = 0;
            // 
            // cmdVolver1
            // 
            cmdVolver1.Location = new Point(515, 387);
            cmdVolver1.Name = "cmdVolver1";
            cmdVolver1.Size = new Size(75, 23);
            cmdVolver1.TabIndex = 14;
            cmdVolver1.Text = "Volver";
            cmdVolver1.UseVisualStyleBackColor = true;
            cmdVolver1.Click += cmdVolver2_Click;
            // 
            // cmdLimpiar
            // 
            cmdLimpiar.Location = new Point(213, 387);
            cmdLimpiar.Name = "cmdLimpiar";
            cmdLimpiar.Size = new Size(75, 23);
            cmdLimpiar.TabIndex = 13;
            cmdLimpiar.Text = "Limpiar";
            cmdLimpiar.UseVisualStyleBackColor = true;
            cmdLimpiar.Click += button1_Click_1;
            // 
            // chkSocio
            // 
            chkSocio.AutoSize = true;
            chkSocio.Location = new Point(372, 332);
            chkSocio.Name = "chkSocio";
            chkSocio.Size = new Size(59, 21);
            chkSocio.TabIndex = 12;
            chkSocio.Text = "Socio";
            toolTip5.SetToolTip(chkSocio, "Al seleccionar Socio, debe cobrar la primera cuota societaria");
            chkSocio.UseVisualStyleBackColor = true;
            // 
            // cmdConfirma
            // 
            cmdConfirma.FlatStyle = FlatStyle.Popup;
            cmdConfirma.Location = new Point(329, 387);
            cmdConfirma.Name = "cmdConfirma";
            cmdConfirma.Size = new Size(145, 23);
            cmdConfirma.TabIndex = 11;
            cmdConfirma.Text = "Confirma inscripcion";
            cmdConfirma.UseVisualStyleBackColor = true;
            cmdConfirma.Click += confirma_Click;
            // 
            // txtFichamed
            // 
            txtFichamed.Location = new Point(546, 261);
            txtFichamed.Name = "txtFichamed";
            txtFichamed.PlaceholderText = "Nº de ficha médica";
            txtFichamed.Size = new Size(187, 25);
            txtFichamed.TabIndex = 9;
            // 
            // txtConturgencia
            // 
            txtConturgencia.Location = new Point(271, 259);
            txtConturgencia.Name = "txtConturgencia";
            txtConturgencia.PlaceholderText = "Tel del contacto de urgencia";
            txtConturgencia.Size = new Size(172, 25);
            txtConturgencia.TabIndex = 8;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(68, 261);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.PlaceholderText = "Ingrese el Teléfono";
            txtTelefono.Size = new Size(100, 25);
            txtTelefono.TabIndex = 7;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(540, 193);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "Ingrese el Email";
            txtEmail.Size = new Size(193, 25);
            txtEmail.TabIndex = 6;
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(273, 193);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.PlaceholderText = "Ingrese la Dirección";
            txtDireccion.Size = new Size(170, 25);
            txtDireccion.TabIndex = 5;
            // 
            // txtFechanac
            // 
            txtFechanac.Location = new Point(69, 193);
            txtFechanac.Name = "txtFechanac";
            txtFechanac.PlaceholderText = "Fecha Nacimiento dd/mm/AAAA";
            txtFechanac.Size = new Size(109, 25);
            txtFechanac.TabIndex = 4;
            txtFechanac.TextChanged += fechanac_TextChanged;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(540, 134);
            txtApellido.Name = "txtApellido";
            txtApellido.PlaceholderText = "Ingrese el Apellido";
            txtApellido.Size = new Size(193, 25);
            txtApellido.TabIndex = 3;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(268, 134);
            txtNombre.Name = "txtNombre";
            txtNombre.PlaceholderText = "Ingrese el Nombre";
            txtNombre.Size = new Size(174, 25);
            txtNombre.TabIndex = 2;
            // 
            // txtNuevoDni
            // 
            txtNuevoDni.Location = new Point(69, 134);
            txtNuevoDni.Name = "txtNuevoDni";
            txtNuevoDni.ReadOnly = true;
            txtNuevoDni.Size = new Size(109, 25);
            txtNuevoDni.TabIndex = 1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(294, 38);
            label7.Name = "label7";
            label7.Size = new Size(214, 30);
            label7.TabIndex = 0;
            label7.Text = "Inscripción del cliente";
            // 
            // toolTip1
            // 
            toolTip1.AutoPopDelay = 1000;
            toolTip1.InitialDelay = 100;
            toolTip1.IsBalloon = true;
            toolTip1.ReshowDelay = 100;
            toolTip1.Popup += toolTip1_Popup;
            // 
            // toolTip2
            // 
            toolTip2.AutoPopDelay = 1000;
            toolTip2.InitialDelay = 100;
            toolTip2.IsBalloon = true;
            toolTip2.ReshowDelay = 100;
            // 
            // actSocio
            // 
            actSocio.Controls.Add(cmdVolver2);
            actSocio.Controls.Add(cmdCarnet);
            actSocio.Controls.Add(cmdPagoCS);
            actSocio.Controls.Add(label10);
            actSocio.Controls.Add(txtDniSel);
            actSocio.Controls.Add(label8);
            actSocio.Location = new Point(0, 0);
            actSocio.Name = "actSocio";
            actSocio.Size = new Size(799, 451);
            actSocio.TabIndex = 5;
            actSocio.Paint += actSocio_Paint;
            // 
            // cmdVolver2
            // 
            cmdVolver2.Location = new Point(362, 391);
            cmdVolver2.Name = "cmdVolver2";
            cmdVolver2.Size = new Size(75, 23);
            cmdVolver2.TabIndex = 5;
            cmdVolver2.Text = "Inicio";
            cmdVolver2.UseVisualStyleBackColor = true;
            cmdVolver2.Click += cmdVolver2_Click;
            // 
            // cmdCarnet
            // 
            cmdCarnet.Location = new Point(432, 253);
            cmdCarnet.Name = "cmdCarnet";
            cmdCarnet.Size = new Size(92, 43);
            cmdCarnet.TabIndex = 4;
            cmdCarnet.Text = "Emitir Carnet";
            cmdCarnet.UseVisualStyleBackColor = true;
            cmdCarnet.Click += button2_Click;
            // 
            // cmdPagoCS
            // 
            cmdPagoCS.Location = new Point(274, 254);
            cmdPagoCS.Name = "cmdPagoCS";
            cmdPagoCS.Size = new Size(117, 43);
            cmdPagoCS.TabIndex = 3;
            cmdPagoCS.Text = "Pago de cuota Social";
            cmdPagoCS.UseVisualStyleBackColor = true;
            cmdPagoCS.Click += button1_Click_2;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(260, 146);
            label10.Name = "label10";
            label10.Size = new Size(114, 17);
            label10.TabIndex = 2;
            label10.Text = "DNI Seleccionado:";
            // 
            // txtDniSel
            // 
            txtDniSel.Location = new Point(380, 143);
            txtDniSel.Name = "txtDniSel";
            txtDniSel.ReadOnly = true;
            txtDniSel.Size = new Size(100, 25);
            txtDniSel.TabIndex = 1;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(285, 9);
            label8.Name = "label8";
            label8.Size = new Size(238, 45);
            label8.TabIndex = 0;
            label8.Text = "Panel de Socio";
            // 
            // actNoSocio
            // 
            actNoSocio.Controls.Add(label9);
            actNoSocio.Controls.Add(label11);
            actNoSocio.Controls.Add(txtDniSel2);
            actNoSocio.Controls.Add(cmdInsAct);
            actNoSocio.Controls.Add(cmdVolver3);
            actNoSocio.Location = new Point(-1, 0);
            actNoSocio.Name = "actNoSocio";
            actNoSocio.Size = new Size(802, 451);
            actNoSocio.TabIndex = 0;
            actNoSocio.Paint += panel5_Paint;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(193, 29);
            label9.Name = "label9";
            label9.Size = new Size(393, 37);
            label9.TabIndex = 0;
            label9.Text = "Panel Inscriptos no asociados";
            label9.Click += label9_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(287, 129);
            label11.Name = "label11";
            label11.Size = new Size(114, 17);
            label11.TabIndex = 8;
            label11.Text = "DNI Seleccionado:";
            // 
            // txtDniSel2
            // 
            txtDniSel2.Location = new Point(416, 126);
            txtDniSel2.Name = "txtDniSel2";
            txtDniSel2.ReadOnly = true;
            txtDniSel2.Size = new Size(100, 25);
            txtDniSel2.TabIndex = 9;
            // 
            // cmdInsAct
            // 
            cmdInsAct.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmdInsAct.Location = new Point(314, 205);
            cmdInsAct.Name = "cmdInsAct";
            cmdInsAct.Size = new Size(174, 64);
            cmdInsAct.TabIndex = 7;
            cmdInsAct.Text = "Inscripcion en actividad";
            cmdInsAct.UseVisualStyleBackColor = true;
            // 
            // cmdVolver3
            // 
            cmdVolver3.Location = new Point(364, 387);
            cmdVolver3.Name = "cmdVolver3";
            cmdVolver3.Size = new Size(75, 23);
            cmdVolver3.TabIndex = 6;
            cmdVolver3.Text = "Inicio";
            cmdVolver3.UseVisualStyleBackColor = true;
            cmdVolver3.Click += cmdVolver2_Click;
            // 
            // toolTip4
            // 
            toolTip4.Popup += toolTip4_Popup;
            // 
            // button1
            // 
            button1.Location = new Point(368, 374);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 5;
            button1.Text = "Probar conexion DB";
            button1.UseVisualStyleBackColor = true;
            button1.Click += ProbarConexion_Click;
            // 
            // clubdep
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ingresoSis);
            Controls.Add(InicioAdmin);
            Controls.Add(inscCliente);
            Controls.Add(actSocio);
            Controls.Add(actNoSocio);
            Name = "clubdep";
            Text = "Club Deportivo - G5";
            ingresoSis.ResumeLayout(false);
            ingresoSis.PerformLayout();
            InicioAdmin.ResumeLayout(false);
            InicioAdmin.PerformLayout();
            inscCliente.ResumeLayout(false);
            inscCliente.PerformLayout();
            actSocio.ResumeLayout(false);
            actSocio.PerformLayout();
            actNoSocio.ResumeLayout(false);
            actNoSocio.PerformLayout();
            ResumeLayout(false);
        }



        /*private void textBox2_TextChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }*/

        private void password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                VerificarCredenciales();
                e.SuppressKeyPress = true;
            }
        }

        private void dni_KeyDown(object sender, KeyEventArgs e)
        {
            var repo = new UsuarioRepo(servidor: "mysql-gttsds.alwaysdata.net",
                    baseDatos: "gttsds_g5",
                    usuario: "gttsds_usuario",
                    clave: "grab&&71");
            var dni = txtDni.Text.Trim();
            if (e.KeyCode == Keys.Enter)
            {
                if (dni.Length != 8)
                {
                    MessageBox.Show("Ingrese un DNI válido de 8 dígitos.");
                    return;
                }

                dniIngresado = txtDni.Text.Trim();

                var resultado = repo.BuscarPersonaPorDni(dni);
                if (resultado.Existe)
                {
                    string tipo = resultado.EsSocio ? "Socio" : "No Socio";
                    //MessageBox.Show($"DNI ya registrado como: {tipo}");
                    if (tipo == "Socio")
                    {
                        // Mostrar panel de socio
                        txtDniSel.Text = dni;
                        MostrarPaso(4);
                    }
                    else
                    {
                        // Mostrar panel de no socio
                        txtDniSel2.Text = dni;
                        MostrarPaso(5);
                    }
                }
                else
                {                     // DNI no registrado, mostrar panel de inscripción
                    txtNuevoDni.Text = dni;
                    MostrarPaso(3);
                }
            }
            
               
        }
        
        private void VerificarCredenciales()
        {
            string usuario = txtMainUser.Text.Trim();
            string contraseña = txtPassword.Text;

            // Datos "válidos" (pueden venir de una base de datos en el futuro)
            string userCorrecto = "admin";
            string passCorrecta = "1234";

            if (usuario == userCorrecto && contraseña == passCorrecta)
            {
                MostrarPaso(2); // pasar al panel siguiente
            }
            else
            {
                MessageBox.Show("Usuario y/o contraseña incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword.Clear(); // opcional: limpiar
                txtPassword.Focus();
            }
        }

        private void MostrarPaso(int paso)
        {
            ingresoSis.Visible = (paso == 1);
            InicioAdmin.Visible = (paso == 2);
            inscCliente.Visible = (paso == 3);
            actSocio.Visible = (paso == 4);
            actNoSocio.Visible = (paso == 5);
            // Agregar más pasos según sea necesario

        }
        private void ConfirmaVolver_Click()
        {
            // Mensaje de confirmación
                
                MostrarPaso(2);
            txtDni.Text = "";
            txtDni.Focus(); // para que el cursor quede listo para escribir


        }


        private void confirma_Click(object sender, EventArgs e)
        {
            // Determinar si es socio o no
            string tipoCliente = chkSocio.Checked ? "socio" : "no socio";
            string mensaje = "";
            // Mensaje personalizado
            if (tipoCliente == "socio")
            {
                mensaje = $"Está por confirmar que el cliente se registra como {tipoCliente} y ha pagado el monto correcto.\n¿Desea continuar?";   
            }
            else
            {
                mensaje = $"Está por confirmar que el cliente se registra como {tipoCliente}.\n¿Desea continuar?";
            }
            

            // Mostrar mensaje de confirmación
            DialogResult resultado = MessageBox.Show(mensaje,
                "Confirmar",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (resultado == DialogResult.Yes )
            {
                person nueva = new person
                {
                    Dni = txtNuevoDni.Text.Trim(),
                    Apellido = txtApellido.Text.Trim(),
                    Nombre = txtNombre.Text.Trim(),
                    Fechanac = txtFechanac.Text.Trim(),          // asegurate del formato
                    Fechainscrip = DateTime.Now.ToString("dd-MM-yyyy"),
                    Direccion = txtDireccion.Text.Trim(),
                    Email = txtEmail.Text.Trim(),
                    Telefono = txtTelefono.Text.Trim(),
                    Conturgencia = txtConturgencia.Text.Trim(),
                    Fichamed = txtFichamed.Text.Trim(),
                    Socio = chkSocio.Checked,
                    Estado = "activo"
                };

                var repo = new UsuarioRepo("mysql-gttsds.alwaysdata.net","gttsds_g5","gttsds_usuario","grab&&71");

                if (repo.InsertarPersona(nueva))
                {
                    MessageBox.Show("Registro guardado correctamente");
                    inscCliente.Visible = false;
                    actSocio.Visible = true;
                }
                else
                {
                    MessageBox.Show("Error al guardar los datos");
                }
                if (tipoCliente == "socio")
                {
                    // Confirmado: avanzar a panel 4
                    txtDniSel.Text = dniIngresado;
                    MostrarPaso(4);
                }
                else
                {
                    // Confirmado: avanzar a panel 5
                    txtDniSel2.Text = dniIngresado;
                    MostrarPaso(5);
                }
                
            }
            else
            {
                // Cancelado: no hacer nada
                return; // o puedes mostrar un mensaje de cancelación si lo deseas
            }
            // Si cancela, no hace nada
        }

        private void ProbarConexion_Click(object sender, EventArgs e)
        {
            try
            {
                var repo = new UsuarioRepo(
                    servidor: "mysql-gttsds.alwaysdata.net",
                    baseDatos: "gttsds_g5",
                    usuario: "gttsds_usuario",
                    clave: "grab&&71");

                /*if (repo.CredencialesValidas("juan", "secreta"))
                    MessageBox.Show("Credenciales OK");
                else
                    MessageBox.Show("Usuario / clave incorrectos");*/
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }





        #endregion

        private Panel ingresoSis;
        private Panel InicioAdmin;
        private Panel inscCliente;
        private Label label1;
        private Label label2;
        private TextBox txtPassword;
        private Label label3;
        private TextBox txtMainUser;
        private ToolTip toolTip1;
        private ToolTip toolTip2;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtDni;
        private TextBox txtNuevoDni;
        private Label label7;
        private TextBox txtNombre;
        private TextBox txtFechanac;
        private TextBox txtApellido;
        private TextBox txtTelefono;
        private TextBox txtEmail;
        private TextBox txtDireccion;
        private TextBox txtFichamed;
        private TextBox txtConturgencia;
        private Panel actSocio;
        private Label label8;
        private Panel actNoSocio;
        private Label label9;
        private Button cmdConfirma;
        private CheckBox chkSocio;
        private Button cmdListMorosos;
        private ToolTip toolTip3;
        private ToolTip toolTip4;
        private Button cmdVolver1;
        private Button cmdLimpiar;
        private ToolTip toolTip5;
        private Button cmdCarnet;
        private Button cmdPagoCS;
        private Label label10;
        private TextBox txtDniSel;
        private Button cmdVolver2;
        private Button cmdInsAct;
        private Button cmdVolver3;
        private Label label11;
        private TextBox txtDniSel2;
        private Button button1;
    }
}
