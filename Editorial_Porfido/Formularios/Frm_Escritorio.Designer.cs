namespace Editorial_Porfido
{
    partial class Frm_Escritorio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Escritorio));
            this.btn_usuario = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_tarjeta = new System.Windows.Forms.Button();
            this.btn_empresa_publicitaria = new System.Windows.Forms.Button();
            this.btn_suscripcion = new System.Windows.Forms.Button();
            this.btm_kiosco = new System.Windows.Forms.Button();
            this.btn_suscriptor = new System.Windows.Forms.Button();
            this.btn_pedido = new System.Windows.Forms.Button();
            this.btn_revista = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_usuario
            // 
            this.btn_usuario.Location = new System.Drawing.Point(15, 303);
            this.btn_usuario.Name = "btn_usuario";
            this.btn_usuario.Size = new System.Drawing.Size(177, 102);
            this.btn_usuario.TabIndex = 1;
            this.btn_usuario.Text = "Usuario";
            this.btn_usuario.UseVisualStyleBackColor = true;
            this.btn_usuario.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox1.BackgroundImage")));
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btn_tarjeta);
            this.groupBox1.Controls.Add(this.btn_empresa_publicitaria);
            this.groupBox1.Controls.Add(this.btn_suscripcion);
            this.groupBox1.Controls.Add(this.btm_kiosco);
            this.groupBox1.Controls.Add(this.btn_suscriptor);
            this.groupBox1.Controls.Add(this.btn_pedido);
            this.groupBox1.Controls.Add(this.btn_revista);
            this.groupBox1.Controls.Add(this.btn_usuario);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Location = new System.Drawing.Point(12, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(795, 430);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Editorial Porfido";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(251, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(317, 38);
            this.label1.TabIndex = 9;
            this.label1.Text = "Menu Editorial Porfido";
            // 
            // btn_tarjeta
            // 
            this.btn_tarjeta.Location = new System.Drawing.Point(603, 303);
            this.btn_tarjeta.Name = "btn_tarjeta";
            this.btn_tarjeta.Size = new System.Drawing.Size(177, 102);
            this.btn_tarjeta.TabIndex = 8;
            this.btn_tarjeta.Text = "Tarjeta";
            this.btn_tarjeta.UseVisualStyleBackColor = true;
            this.btn_tarjeta.Click += new System.EventHandler(this.btn_tarjeta_Click);
            // 
            // btn_empresa_publicitaria
            // 
            this.btn_empresa_publicitaria.Location = new System.Drawing.Point(603, 166);
            this.btn_empresa_publicitaria.Name = "btn_empresa_publicitaria";
            this.btn_empresa_publicitaria.Size = new System.Drawing.Size(177, 102);
            this.btn_empresa_publicitaria.TabIndex = 7;
            this.btn_empresa_publicitaria.Text = "Empresa publicitaria";
            this.btn_empresa_publicitaria.UseVisualStyleBackColor = true;
            this.btn_empresa_publicitaria.Click += new System.EventHandler(this.btn_empresa_publicitaria_Click);
            // 
            // btn_suscripcion
            // 
            this.btn_suscripcion.Location = new System.Drawing.Point(411, 303);
            this.btn_suscripcion.Name = "btn_suscripcion";
            this.btn_suscripcion.Size = new System.Drawing.Size(177, 102);
            this.btn_suscripcion.TabIndex = 6;
            this.btn_suscripcion.Text = "Suscripcion";
            this.btn_suscripcion.UseVisualStyleBackColor = true;
            // 
            // btm_kiosco
            // 
            this.btm_kiosco.Location = new System.Drawing.Point(603, 23);
            this.btm_kiosco.Name = "btm_kiosco";
            this.btm_kiosco.Size = new System.Drawing.Size(177, 102);
            this.btm_kiosco.TabIndex = 5;
            this.btm_kiosco.Text = "Kiosco";
            this.btm_kiosco.UseVisualStyleBackColor = true;
            // 
            // btn_suscriptor
            // 
            this.btn_suscriptor.Location = new System.Drawing.Point(212, 303);
            this.btn_suscriptor.Name = "btn_suscriptor";
            this.btn_suscriptor.Size = new System.Drawing.Size(177, 102);
            this.btn_suscriptor.TabIndex = 4;
            this.btn_suscriptor.Text = "Suscriptor";
            this.btn_suscriptor.UseVisualStyleBackColor = true;
            // 
            // btn_pedido
            // 
            this.btn_pedido.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_pedido.ForeColor = System.Drawing.Color.Black;
            this.btn_pedido.Location = new System.Drawing.Point(15, 23);
            this.btn_pedido.Name = "btn_pedido";
            this.btn_pedido.Size = new System.Drawing.Size(177, 102);
            this.btn_pedido.TabIndex = 3;
            this.btn_pedido.Text = "Pedido";
            this.btn_pedido.UseVisualStyleBackColor = true;
            this.btn_pedido.Click += new System.EventHandler(this.btn_pedido_Click);
            // 
            // btn_revista
            // 
            this.btn_revista.Location = new System.Drawing.Point(15, 166);
            this.btn_revista.Name = "btn_revista";
            this.btn_revista.Size = new System.Drawing.Size(177, 102);
            this.btn_revista.TabIndex = 2;
            this.btn_revista.Text = "Revista";
            this.btn_revista.UseVisualStyleBackColor = true;
            this.btn_revista.Click += new System.EventHandler(this.btn_revista_Click);
            // 
            // Frm_Escritorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(819, 450);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Escritorio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Frm_Escritorio_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_usuario;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_tarjeta;
        private System.Windows.Forms.Button btn_empresa_publicitaria;
        private System.Windows.Forms.Button btn_suscripcion;
        private System.Windows.Forms.Button btm_kiosco;
        private System.Windows.Forms.Button btn_suscriptor;
        private System.Windows.Forms.Button btn_pedido;
        private System.Windows.Forms.Button btn_revista;
    }
}

