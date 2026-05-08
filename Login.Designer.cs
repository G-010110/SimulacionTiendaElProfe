namespace LoginMejorado
{
    partial class Login
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.linkLabelCrearUsuario = new System.Windows.Forms.LinkLabel();
            this.label4 = new System.Windows.Forms.Label();
            this.bEntrar = new System.Windows.Forms.Button();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbCorreo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.linkLabelCrearUsuario);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.bEntrar);
            this.panel1.Controls.Add(this.tbPassword);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.tbCorreo);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(306, 450);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gray;
            this.panel2.Location = new System.Drawing.Point(36, 73);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(230, 91);
            this.panel2.TabIndex = 8;
            // 
            // linkLabelCrearUsuario
            // 
            this.linkLabelCrearUsuario.AutoSize = true;
            this.linkLabelCrearUsuario.Font = new System.Drawing.Font("Swis721 BlkCn BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelCrearUsuario.Location = new System.Drawing.Point(188, 422);
            this.linkLabelCrearUsuario.Name = "linkLabelCrearUsuario";
            this.linkLabelCrearUsuario.Size = new System.Drawing.Size(37, 19);
            this.linkLabelCrearUsuario.TabIndex = 7;
            this.linkLabelCrearUsuario.TabStop = true;
            this.linkLabelCrearUsuario.Text = "aquí";
            this.linkLabelCrearUsuario.Visible = false;
            this.linkLabelCrearUsuario.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelCrearUsuario_LinkClicked);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Swis721 BlkCn BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 422);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(189, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "No tienes cuenta, crea una ";
            this.label4.Visible = false;
            // 
            // bEntrar
            // 
            this.bEntrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.bEntrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bEntrar.Location = new System.Drawing.Point(87, 350);
            this.bEntrar.Name = "bEntrar";
            this.bEntrar.Size = new System.Drawing.Size(122, 36);
            this.bEntrar.TabIndex = 5;
            this.bEntrar.Text = "Entrar";
            this.bEntrar.UseVisualStyleBackColor = false;
            this.bEntrar.Click += new System.EventHandler(this.bEntrar_Click);
            // 
            // tbPassword
            // 
            this.tbPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.tbPassword.Location = new System.Drawing.Point(50, 296);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(205, 35);
            this.tbPassword.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("News706 BT", 18F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(45, 264);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 29);
            this.label3.TabIndex = 3;
            this.label3.Text = "Contraseña:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("News706 BT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(45, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Alias:";
            // 
            // tbCorreo
            // 
            this.tbCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.tbCorreo.Location = new System.Drawing.Point(50, 226);
            this.tbCorreo.Name = "tbCorreo";
            this.tbCorreo.Size = new System.Drawing.Size(205, 35);
            this.tbCorreo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Felix Titling", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Inicio de Sesión";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 450);
            this.Controls.Add(this.panel1);
            this.Name = "Login";
            this.Text = "Acceder";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbCorreo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkLabelCrearUsuario;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button bEntrar;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Panel panel1;
    }
}

