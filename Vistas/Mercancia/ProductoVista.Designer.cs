namespace SimulacionTiendaElProfe.Vistas
{
    partial class ProductoVista
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductoVista));
            this.nombreProducto = new System.Windows.Forms.Label();
            this.precioProducto = new System.Windows.Forms.Label();
            this.bProducto = new System.Windows.Forms.Button();
            this.pictureProducto = new System.Windows.Forms.PictureBox();
            this.stock = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureProducto)).BeginInit();
            this.SuspendLayout();
            // 
            // nombreProducto
            // 
            this.nombreProducto.AutoSize = true;
            this.nombreProducto.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreProducto.Location = new System.Drawing.Point(14, 164);
            this.nombreProducto.Name = "nombreProducto";
            this.nombreProducto.Size = new System.Drawing.Size(139, 20);
            this.nombreProducto.TabIndex = 1;
            this.nombreProducto.Text = "Producto 1111";
            // 
            // precioProducto
            // 
            this.precioProducto.AutoSize = true;
            this.precioProducto.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.precioProducto.ForeColor = System.Drawing.Color.Red;
            this.precioProducto.Location = new System.Drawing.Point(14, 184);
            this.precioProducto.Name = "precioProducto";
            this.precioProducto.Size = new System.Drawing.Size(60, 20);
            this.precioProducto.TabIndex = 2;
            this.precioProducto.Text = "$89.0";
            // 
            // bProducto
            // 
            this.bProducto.Location = new System.Drawing.Point(114, 194);
            this.bProducto.Name = "bProducto";
            this.bProducto.Size = new System.Drawing.Size(72, 20);
            this.bProducto.TabIndex = 3;
            this.bProducto.Text = "Comprar";
            this.bProducto.UseVisualStyleBackColor = true;
            // 
            // pictureProducto
            // 
            this.pictureProducto.Image = ((System.Drawing.Image)(resources.GetObject("pictureProducto.Image")));
            this.pictureProducto.Location = new System.Drawing.Point(18, 18);
            this.pictureProducto.Name = "pictureProducto";
            this.pictureProducto.Size = new System.Drawing.Size(168, 143);
            this.pictureProducto.TabIndex = 0;
            this.pictureProducto.TabStop = false;
            // 
            // stock
            // 
            this.stock.AutoSize = true;
            this.stock.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stock.ForeColor = System.Drawing.Color.Blue;
            this.stock.Location = new System.Drawing.Point(14, 204);
            this.stock.Name = "stock";
            this.stock.Size = new System.Drawing.Size(20, 20);
            this.stock.TabIndex = 4;
            this.stock.Text = "0";
            // 
            // ProductoVista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.Controls.Add(this.stock);
            this.Controls.Add(this.bProducto);
            this.Controls.Add(this.precioProducto);
            this.Controls.Add(this.nombreProducto);
            this.Controls.Add(this.pictureProducto);
            this.Name = "ProductoVista";
            this.Size = new System.Drawing.Size(201, 232);
            ((System.ComponentModel.ISupportInitialize)(this.pictureProducto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button bProducto;
        public System.Windows.Forms.Label stock;
        public System.Windows.Forms.Label nombreProducto;
        public System.Windows.Forms.Label precioProducto;
        public System.Windows.Forms.PictureBox pictureProducto;
    }
}
