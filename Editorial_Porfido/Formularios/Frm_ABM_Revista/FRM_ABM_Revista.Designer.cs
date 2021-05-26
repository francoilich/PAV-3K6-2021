namespace Editorial_Porfido.Formularios.Frm_ABM_Revista
{
    partial class FRM_ABM_Revista
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_salir = new System.Windows.Forms.Button();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.txt_id_numero_edi = new Editorial_Porfido.Clasess.TextBox01();
            this.txt_rubro = new Editorial_Porfido.Clasess.TextBox01();
            this.txt_frecuencia = new Editorial_Porfido.Clasess.TextBox01();
            this.txt_fecha = new Editorial_Porfido.Clasess.TextBox01();
            this.txt_nombre = new Editorial_Porfido.Clasess.TextBox01();
            this.lbl_num_edicion = new System.Windows.Forms.Label();
            this.lbl_rubro = new System.Windows.Forms.Label();
            this.lbl_frecuencia = new System.Windows.Forms.Label();
            this.lbl_fecha = new System.Windows.Forms.Label();
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.lbl_codigo = new System.Windows.Forms.Label();
            this.txt_codigo = new Editorial_Porfido.Clasess.TextBox01();
            this.btn_Eliminar = new System.Windows.Forms.Button();
            this.btn_editar = new System.Windows.Forms.Button();
            this.grid_revista = new System.Windows.Forms.DataGridView();
            this.btn_actualizar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_revista)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_actualizar);
            this.groupBox1.Controls.Add(this.btn_salir);
            this.groupBox1.Controls.Add(this.btn_guardar);
            this.groupBox1.Controls.Add(this.txt_id_numero_edi);
            this.groupBox1.Controls.Add(this.txt_rubro);
            this.groupBox1.Controls.Add(this.txt_frecuencia);
            this.groupBox1.Controls.Add(this.txt_fecha);
            this.groupBox1.Controls.Add(this.txt_nombre);
            this.groupBox1.Controls.Add(this.lbl_num_edicion);
            this.groupBox1.Controls.Add(this.lbl_rubro);
            this.groupBox1.Controls.Add(this.lbl_frecuencia);
            this.groupBox1.Controls.Add(this.lbl_fecha);
            this.groupBox1.Controls.Add(this.lbl_nombre);
            this.groupBox1.Controls.Add(this.lbl_codigo);
            this.groupBox1.Controls.Add(this.txt_codigo);
            this.groupBox1.Controls.Add(this.btn_Eliminar);
            this.groupBox1.Controls.Add(this.btn_editar);
            this.groupBox1.Controls.Add(this.grid_revista);
            this.groupBox1.Location = new System.Drawing.Point(26, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(746, 391);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Revista";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btn_salir
            // 
            this.btn_salir.Location = new System.Drawing.Point(526, 342);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(170, 43);
            this.btn_salir.TabIndex = 16;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // btn_guardar
            // 
            this.btn_guardar.Location = new System.Drawing.Point(479, 274);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(242, 32);
            this.btn_guardar.TabIndex = 15;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.UseVisualStyleBackColor = true;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // txt_id_numero_edi
            // 
            this.txt_id_numero_edi.Location = new System.Drawing.Point(595, 229);
            this.txt_id_numero_edi.Name = "txt_id_numero_edi";
            this.txt_id_numero_edi.Pp_campo = null;
            this.txt_id_numero_edi.Pp_MensajeError = "Falta Cargar Numero Edicion";
            this.txt_id_numero_edi.Pp_tabla = null;
            this.txt_id_numero_edi.Pp_Validable = false;
            this.txt_id_numero_edi.Size = new System.Drawing.Size(125, 20);
            this.txt_id_numero_edi.TabIndex = 14;
            // 
            // txt_rubro
            // 
            this.txt_rubro.Location = new System.Drawing.Point(595, 188);
            this.txt_rubro.Name = "txt_rubro";
            this.txt_rubro.Pp_campo = null;
            this.txt_rubro.Pp_MensajeError = "Falta Cargar Rubro";
            this.txt_rubro.Pp_tabla = null;
            this.txt_rubro.Pp_Validable = false;
            this.txt_rubro.Size = new System.Drawing.Size(125, 20);
            this.txt_rubro.TabIndex = 13;
            // 
            // txt_frecuencia
            // 
            this.txt_frecuencia.Location = new System.Drawing.Point(595, 143);
            this.txt_frecuencia.Name = "txt_frecuencia";
            this.txt_frecuencia.Pp_campo = null;
            this.txt_frecuencia.Pp_MensajeError = "Falta Cargar id Frecuencia";
            this.txt_frecuencia.Pp_tabla = null;
            this.txt_frecuencia.Pp_Validable = false;
            this.txt_frecuencia.Size = new System.Drawing.Size(125, 20);
            this.txt_frecuencia.TabIndex = 12;
            // 
            // txt_fecha
            // 
            this.txt_fecha.Location = new System.Drawing.Point(595, 102);
            this.txt_fecha.Name = "txt_fecha";
            this.txt_fecha.Pp_campo = null;
            this.txt_fecha.Pp_MensajeError = "Falta Cargar Fecha";
            this.txt_fecha.Pp_tabla = null;
            this.txt_fecha.Pp_Validable = false;
            this.txt_fecha.Size = new System.Drawing.Size(125, 20);
            this.txt_fecha.TabIndex = 11;
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(595, 69);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Pp_campo = null;
            this.txt_nombre.Pp_MensajeError = "Falta Cargar Nombre";
            this.txt_nombre.Pp_tabla = null;
            this.txt_nombre.Pp_Validable = false;
            this.txt_nombre.Size = new System.Drawing.Size(125, 20);
            this.txt_nombre.TabIndex = 10;
            // 
            // lbl_num_edicion
            // 
            this.lbl_num_edicion.AutoSize = true;
            this.lbl_num_edicion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_num_edicion.Location = new System.Drawing.Point(476, 229);
            this.lbl_num_edicion.Name = "lbl_num_edicion";
            this.lbl_num_edicion.Size = new System.Drawing.Size(118, 16);
            this.lbl_num_edicion.TabIndex = 9;
            this.lbl_num_edicion.Text = "Id Numero Edicion";
            // 
            // lbl_rubro
            // 
            this.lbl_rubro.AutoSize = true;
            this.lbl_rubro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_rubro.Location = new System.Drawing.Point(500, 193);
            this.lbl_rubro.Name = "lbl_rubro";
            this.lbl_rubro.Size = new System.Drawing.Size(59, 16);
            this.lbl_rubro.TabIndex = 8;
            this.lbl_rubro.Text = "Id Rubro";
            // 
            // lbl_frecuencia
            // 
            this.lbl_frecuencia.AutoSize = true;
            this.lbl_frecuencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_frecuencia.Location = new System.Drawing.Point(472, 148);
            this.lbl_frecuencia.Name = "lbl_frecuencia";
            this.lbl_frecuencia.Size = new System.Drawing.Size(117, 16);
            this.lbl_frecuencia.TabIndex = 7;
            this.lbl_frecuencia.Text = "Id_tipo_frecuencia";
            // 
            // lbl_fecha
            // 
            this.lbl_fecha.AutoSize = true;
            this.lbl_fecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fecha.Location = new System.Drawing.Point(463, 107);
            this.lbl_fecha.Name = "lbl_fecha";
            this.lbl_fecha.Size = new System.Drawing.Size(131, 16);
            this.lbl_fecha.TabIndex = 6;
            this.lbl_fecha.Text = "Fecha_inicio_sesion";
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nombre.Location = new System.Drawing.Point(490, 69);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(57, 16);
            this.lbl_nombre.TabIndex = 5;
            this.lbl_nombre.Text = "Nombre";
            // 
            // lbl_codigo
            // 
            this.lbl_codigo.AutoSize = true;
            this.lbl_codigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_codigo.Location = new System.Drawing.Point(490, 32);
            this.lbl_codigo.Name = "lbl_codigo";
            this.lbl_codigo.Size = new System.Drawing.Size(99, 16);
            this.lbl_codigo.TabIndex = 4;
            this.lbl_codigo.Text = "Codigo_interno";
            // 
            // txt_codigo
            // 
            this.txt_codigo.Location = new System.Drawing.Point(595, 31);
            this.txt_codigo.Name = "txt_codigo";
            this.txt_codigo.Pp_campo = null;
            this.txt_codigo.Pp_MensajeError = "Falta Cargar Codigo Interno";
            this.txt_codigo.Pp_tabla = null;
            this.txt_codigo.Pp_Validable = false;
            this.txt_codigo.Size = new System.Drawing.Size(125, 20);
            this.txt_codigo.TabIndex = 3;
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.Location = new System.Drawing.Point(179, 328);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Size = new System.Drawing.Size(106, 38);
            this.btn_Eliminar.TabIndex = 2;
            this.btn_Eliminar.Text = "Eliminar";
            this.btn_Eliminar.UseVisualStyleBackColor = true;
            this.btn_Eliminar.Click += new System.EventHandler(this.btn_Eliminar_Click);
            // 
            // btn_editar
            // 
            this.btn_editar.Location = new System.Drawing.Point(36, 328);
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Size = new System.Drawing.Size(105, 38);
            this.btn_editar.TabIndex = 1;
            this.btn_editar.Text = "Editar";
            this.btn_editar.UseVisualStyleBackColor = true;
            this.btn_editar.Click += new System.EventHandler(this.btn_editar_Click);
            // 
            // grid_revista
            // 
            this.grid_revista.AllowUserToAddRows = false;
            this.grid_revista.AllowUserToDeleteRows = false;
            this.grid_revista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_revista.Location = new System.Drawing.Point(19, 31);
            this.grid_revista.Name = "grid_revista";
            this.grid_revista.ReadOnly = true;
            this.grid_revista.Size = new System.Drawing.Size(438, 266);
            this.grid_revista.TabIndex = 0;
            this.grid_revista.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_revista_CellContentClick);
            // 
            // btn_actualizar
            // 
            this.btn_actualizar.Location = new System.Drawing.Point(324, 328);
            this.btn_actualizar.Name = "btn_actualizar";
            this.btn_actualizar.Size = new System.Drawing.Size(95, 38);
            this.btn_actualizar.TabIndex = 17;
            this.btn_actualizar.Text = "Actualizar";
            this.btn_actualizar.UseVisualStyleBackColor = true;
            this.btn_actualizar.Click += new System.EventHandler(this.btn_actualizar_Click);
            // 
            // FRM_ABM_Revista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 446);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FRM_ABM_Revista";
            this.Text = "FRM_ABM_Revista";
            this.Load += new System.EventHandler(this.FRM_ABM_Revista_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_revista)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_editar;
        private System.Windows.Forms.DataGridView grid_revista;
        private System.Windows.Forms.Button btn_Eliminar;
        private System.Windows.Forms.Label lbl_frecuencia;
        private System.Windows.Forms.Label lbl_fecha;
        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.Label lbl_codigo;
        private Clasess.TextBox01 txt_codigo;
        private Clasess.TextBox01 txt_fecha;
        private Clasess.TextBox01 txt_nombre;
        private System.Windows.Forms.Label lbl_num_edicion;
        private System.Windows.Forms.Label lbl_rubro;
        private Clasess.TextBox01 txt_id_numero_edi;
        private Clasess.TextBox01 txt_rubro;
        private Clasess.TextBox01 txt_frecuencia;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.Button btn_actualizar;
    }
}