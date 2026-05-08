namespace SimulacionTiendaElProfe.Vistas.Administrador
{
    partial class Usuarios
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataPersonal = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tClave = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tAlias = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.bAgregarU = new System.Windows.Forms.Button();
            this.comboTurno = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.comboTusuario = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.comboSexo = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tEdad = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tAM = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tAP = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tFfin = new System.Windows.Forms.TextBox();
            this.tFinicio = new System.Windows.Forms.TextBox();
            this.dataTurnos = new System.Windows.Forms.DataGridView();
            this.bAgregarTurno = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.tNombreTurno = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataPersonal)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataTurnos)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataPersonal);
            this.groupBox1.Font = new System.Drawing.Font("Schadow BT", 12F);
            this.groupBox1.Location = new System.Drawing.Point(378, 67);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(284, 391);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Personal";
            // 
            // dataPersonal
            // 
            this.dataPersonal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataPersonal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataPersonal.Location = new System.Drawing.Point(3, 23);
            this.dataPersonal.Name = "dataPersonal";
            this.dataPersonal.Size = new System.Drawing.Size(278, 365);
            this.dataPersonal.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Usuarios";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.groupBox2.Controls.Add(this.tClave);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.tAlias);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.bAgregarU);
            this.groupBox2.Controls.Add(this.comboTurno);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.comboTusuario);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.comboSexo);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.tEdad);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.tAM);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.tAP);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.tNombre);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Font = new System.Drawing.Font("Schadow BT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(9, 47);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(363, 225);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Agregar Usuarios";
            // 
            // tClave
            // 
            this.tClave.Font = new System.Drawing.Font("Square721 BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tClave.Location = new System.Drawing.Point(256, 98);
            this.tClave.Name = "tClave";
            this.tClave.Size = new System.Drawing.Size(101, 27);
            this.tClave.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Schadow BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(183, 102);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 19);
            this.label9.TabIndex = 17;
            this.label9.Text = "Clave:";
            // 
            // tAlias
            // 
            this.tAlias.Font = new System.Drawing.Font("Square721 BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tAlias.Location = new System.Drawing.Point(79, 98);
            this.tAlias.Name = "tAlias";
            this.tAlias.Size = new System.Drawing.Size(101, 27);
            this.tAlias.TabIndex = 16;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Schadow BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(6, 102);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 19);
            this.label10.TabIndex = 15;
            this.label10.Text = "Alias:";
            // 
            // bAgregarU
            // 
            this.bAgregarU.Location = new System.Drawing.Point(6, 188);
            this.bAgregarU.Name = "bAgregarU";
            this.bAgregarU.Size = new System.Drawing.Size(127, 28);
            this.bAgregarU.TabIndex = 14;
            this.bAgregarU.Text = "Agregar";
            this.bAgregarU.UseVisualStyleBackColor = true;
            this.bAgregarU.Click += new System.EventHandler(this.bAgregarU_Click);
            // 
            // comboTurno
            // 
            this.comboTurno.FormattingEnabled = true;
            this.comboTurno.Location = new System.Drawing.Point(256, 163);
            this.comboTurno.Name = "comboTurno";
            this.comboTurno.Size = new System.Drawing.Size(101, 27);
            this.comboTurno.TabIndex = 13;
            this.comboTurno.SelectedIndexChanged += new System.EventHandler(this.comboTurno_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Schadow BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(183, 167);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 19);
            this.label8.TabIndex = 12;
            this.label8.Text = "Turno:";
            // 
            // comboTusuario
            // 
            this.comboTusuario.FormattingEnabled = true;
            this.comboTusuario.Items.AddRange(new object[] {
            "root",
            "user",
            "visitor"});
            this.comboTusuario.Location = new System.Drawing.Point(256, 130);
            this.comboTusuario.Name = "comboTusuario";
            this.comboTusuario.Size = new System.Drawing.Size(101, 27);
            this.comboTusuario.TabIndex = 11;
            this.comboTusuario.SelectedIndexChanged += new System.EventHandler(this.comboTusuario_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Schadow BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(183, 134);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 19);
            this.label7.TabIndex = 10;
            this.label7.Text = "Tipo U:";
            // 
            // comboSexo
            // 
            this.comboSexo.FormattingEnabled = true;
            this.comboSexo.Items.AddRange(new object[] {
            "Masculino",
            "Femenino"});
            this.comboSexo.Location = new System.Drawing.Point(79, 131);
            this.comboSexo.Name = "comboSexo";
            this.comboSexo.Size = new System.Drawing.Size(101, 27);
            this.comboSexo.TabIndex = 9;
            this.comboSexo.SelectedIndexChanged += new System.EventHandler(this.comboSexo_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Schadow BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 134);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 19);
            this.label6.TabIndex = 8;
            this.label6.Text = "Sexo:";
            // 
            // tEdad
            // 
            this.tEdad.Font = new System.Drawing.Font("Square721 BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tEdad.Location = new System.Drawing.Point(256, 65);
            this.tEdad.Name = "tEdad";
            this.tEdad.Size = new System.Drawing.Size(101, 27);
            this.tEdad.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Schadow BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(183, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 19);
            this.label5.TabIndex = 6;
            this.label5.Text = "Edad:";
            // 
            // tAM
            // 
            this.tAM.Font = new System.Drawing.Font("Square721 BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tAM.Location = new System.Drawing.Point(79, 65);
            this.tAM.Name = "tAM";
            this.tAM.Size = new System.Drawing.Size(101, 27);
            this.tAM.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Schadow BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 19);
            this.label4.TabIndex = 4;
            this.label4.Text = "Apell. M:";
            // 
            // tAP
            // 
            this.tAP.Font = new System.Drawing.Font("Square721 BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tAP.Location = new System.Drawing.Point(256, 32);
            this.tAP.Name = "tAP";
            this.tAP.Size = new System.Drawing.Size(101, 27);
            this.tAP.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Schadow BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(183, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Apell. P:";
            // 
            // tNombre
            // 
            this.tNombre.Font = new System.Drawing.Font("Square721 BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tNombre.Location = new System.Drawing.Point(79, 32);
            this.tNombre.Name = "tNombre";
            this.tNombre.Size = new System.Drawing.Size(101, 27);
            this.tNombre.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Schadow BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nombre:";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBox3.Controls.Add(this.tFfin);
            this.groupBox3.Controls.Add(this.tFinicio);
            this.groupBox3.Controls.Add(this.dataTurnos);
            this.groupBox3.Controls.Add(this.bAgregarTurno);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.label18);
            this.groupBox3.Controls.Add(this.tNombreTurno);
            this.groupBox3.Controls.Add(this.label19);
            this.groupBox3.Font = new System.Drawing.Font("Schadow BT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(9, 278);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(363, 177);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Agregar Turno";
            // 
            // tFfin
            // 
            this.tFfin.Font = new System.Drawing.Font("Square721 BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tFfin.Location = new System.Drawing.Point(256, 61);
            this.tFfin.Name = "tFfin";
            this.tFfin.Size = new System.Drawing.Size(101, 27);
            this.tFfin.TabIndex = 19;
            // 
            // tFinicio
            // 
            this.tFinicio.Font = new System.Drawing.Font("Square721 BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tFinicio.Location = new System.Drawing.Point(256, 28);
            this.tFinicio.Name = "tFinicio";
            this.tFinicio.Size = new System.Drawing.Size(101, 27);
            this.tFinicio.TabIndex = 18;
            // 
            // dataTurnos
            // 
            this.dataTurnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataTurnos.Location = new System.Drawing.Point(6, 99);
            this.dataTurnos.Name = "dataTurnos";
            this.dataTurnos.Size = new System.Drawing.Size(351, 72);
            this.dataTurnos.TabIndex = 17;
            // 
            // bAgregarTurno
            // 
            this.bAgregarTurno.Location = new System.Drawing.Point(6, 62);
            this.bAgregarTurno.Name = "bAgregarTurno";
            this.bAgregarTurno.Size = new System.Drawing.Size(127, 30);
            this.bAgregarTurno.TabIndex = 14;
            this.bAgregarTurno.Text = "Agregar";
            this.bAgregarTurno.UseVisualStyleBackColor = true;
            this.bAgregarTurno.Click += new System.EventHandler(this.bAgregarTurno_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Schadow BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(183, 69);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(47, 19);
            this.label16.TabIndex = 6;
            this.label16.Text = "F. fin:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Schadow BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(183, 36);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(66, 19);
            this.label18.TabIndex = 2;
            this.label18.Text = "F. inicio:";
            // 
            // tNombreTurno
            // 
            this.tNombreTurno.Font = new System.Drawing.Font("Square721 BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tNombreTurno.Location = new System.Drawing.Point(79, 32);
            this.tNombreTurno.Name = "tNombreTurno";
            this.tNombreTurno.Size = new System.Drawing.Size(101, 27);
            this.tNombreTurno.TabIndex = 1;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Schadow BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(6, 36);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(67, 19);
            this.label19.TabIndex = 0;
            this.label19.Text = "Nombre:";
            // 
            // Usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Usuarios";
            this.Size = new System.Drawing.Size(665, 461);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataPersonal)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataTurnos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataPersonal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tEdad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tAM;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tAP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bAgregarU;
        private System.Windows.Forms.ComboBox comboTurno;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboTusuario;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboSexo;
        private System.Windows.Forms.TextBox tClave;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tAlias;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button bAgregarTurno;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox tNombreTurno;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.DataGridView dataTurnos;
        private System.Windows.Forms.TextBox tFfin;
        private System.Windows.Forms.TextBox tFinicio;
    }
}
