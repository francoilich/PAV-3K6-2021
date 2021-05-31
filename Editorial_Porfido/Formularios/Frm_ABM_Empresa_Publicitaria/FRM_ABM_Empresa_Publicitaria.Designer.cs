
namespace Editorial_Porfido.Formularios.Frm_ABM_Empresa_Publicitaria
{
    partial class FRM_ABM_Empresa_Publicitaria
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
            this.components = new System.ComponentModel.Container();
            this.grid_empresa_publicitaria = new System.Windows.Forms.DataGridView();
            this.dataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_salir = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.txt_cuit_buscar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_numero_calle = new System.Windows.Forms.TextBox();
            this.lbl_numero_calle = new System.Windows.Forms.Label();
            this.txt_calle = new System.Windows.Forms.TextBox();
            this.txt_ciudad = new System.Windows.Forms.TextBox();
            this.txt_fecha_inicio = new System.Windows.Forms.TextBox();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.txt_cuit = new System.Windows.Forms.TextBox();
            this.lbl_calle = new System.Windows.Forms.Label();
            this.lbl_id_ciudad = new System.Windows.Forms.Label();
            this.lbl_fecha_inicio = new System.Windows.Forms.Label();
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.lbl_cuit_empresa = new System.Windows.Forms.Label();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.btn_actualizar = new System.Windows.Forms.Button();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.btn_editar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grid_empresa_publicitaria)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grid_empresa_publicitaria
            // 
            this.grid_empresa_publicitaria.AllowUserToAddRows = false;
            this.grid_empresa_publicitaria.AllowUserToDeleteRows = false;
            this.grid_empresa_publicitaria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_empresa_publicitaria.Location = new System.Drawing.Point(27, 108);
            this.grid_empresa_publicitaria.Name = "grid_empresa_publicitaria";
            this.grid_empresa_publicitaria.ReadOnly = true;
            this.grid_empresa_publicitaria.RowHeadersWidth = 62;
            this.grid_empresa_publicitaria.RowTemplate.Height = 28;
            this.grid_empresa_publicitaria.Size = new System.Drawing.Size(633, 297);
            this.grid_empresa_publicitaria.TabIndex = 0;
            this.grid_empresa_publicitaria.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_salir);
            this.groupBox1.Controls.Add(this.btn_cancelar);
            this.groupBox1.Controls.Add(this.btn_buscar);
            this.groupBox1.Controls.Add(this.txt_cuit_buscar);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_numero_calle);
            this.groupBox1.Controls.Add(this.lbl_numero_calle);
            this.groupBox1.Controls.Add(this.txt_calle);
            this.groupBox1.Controls.Add(this.txt_ciudad);
            this.groupBox1.Controls.Add(this.txt_fecha_inicio);
            this.groupBox1.Controls.Add(this.txt_nombre);
            this.groupBox1.Controls.Add(this.txt_cuit);
            this.groupBox1.Controls.Add(this.lbl_calle);
            this.groupBox1.Controls.Add(this.lbl_id_ciudad);
            this.groupBox1.Controls.Add(this.lbl_fecha_inicio);
            this.groupBox1.Controls.Add(this.lbl_nombre);
            this.groupBox1.Controls.Add(this.lbl_cuit_empresa);
            this.groupBox1.Controls.Add(this.btn_guardar);
            this.groupBox1.Controls.Add(this.btn_actualizar);
            this.groupBox1.Controls.Add(this.btn_eliminar);
            this.groupBox1.Controls.Add(this.btn_editar);
            this.groupBox1.Controls.Add(this.grid_empresa_publicitaria);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1066, 517);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Empresa publicitaria";
            // 
            // btn_salir
            // 
            this.btn_salir.Location = new System.Drawing.Point(868, 426);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(165, 63);
            this.btn_salir.TabIndex = 23;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(406, 68);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(122, 34);
            this.btn_cancelar.TabIndex = 22;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_buscar
            // 
            this.btn_buscar.Location = new System.Drawing.Point(406, 28);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(122, 34);
            this.btn_buscar.TabIndex = 21;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // txt_cuit_buscar
            // 
            this.txt_cuit_buscar.Location = new System.Drawing.Point(182, 52);
            this.txt_cuit_buscar.Name = "txt_cuit_buscar";
            this.txt_cuit_buscar.Size = new System.Drawing.Size(204, 26);
            this.txt_cuit_buscar.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 20);
            this.label1.TabIndex = 19;
            this.label1.Text = "Buscar por cuit";
            // 
            // txt_numero_calle
            // 
            this.txt_numero_calle.Location = new System.Drawing.Point(830, 295);
            this.txt_numero_calle.Name = "txt_numero_calle";
            this.txt_numero_calle.Size = new System.Drawing.Size(178, 26);
            this.txt_numero_calle.TabIndex = 18;
            // 
            // lbl_numero_calle
            // 
            this.lbl_numero_calle.AutoSize = true;
            this.lbl_numero_calle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lbl_numero_calle.Location = new System.Drawing.Point(682, 295);
            this.lbl_numero_calle.Name = "lbl_numero_calle";
            this.lbl_numero_calle.Size = new System.Drawing.Size(131, 25);
            this.lbl_numero_calle.TabIndex = 17;
            this.lbl_numero_calle.Text = "Numero Calle";
            // 
            // txt_calle
            // 
            this.txt_calle.Location = new System.Drawing.Point(830, 257);
            this.txt_calle.Name = "txt_calle";
            this.txt_calle.Size = new System.Drawing.Size(178, 26);
            this.txt_calle.TabIndex = 16;
            // 
            // txt_ciudad
            // 
            this.txt_ciudad.Location = new System.Drawing.Point(830, 211);
            this.txt_ciudad.Name = "txt_ciudad";
            this.txt_ciudad.Size = new System.Drawing.Size(178, 26);
            this.txt_ciudad.TabIndex = 15;
            // 
            // txt_fecha_inicio
            // 
            this.txt_fecha_inicio.Location = new System.Drawing.Point(830, 165);
            this.txt_fecha_inicio.Name = "txt_fecha_inicio";
            this.txt_fecha_inicio.Size = new System.Drawing.Size(178, 26);
            this.txt_fecha_inicio.TabIndex = 13;
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(830, 117);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(178, 26);
            this.txt_nombre.TabIndex = 12;
            // 
            // txt_cuit
            // 
            this.txt_cuit.Location = new System.Drawing.Point(830, 68);
            this.txt_cuit.Name = "txt_cuit";
            this.txt_cuit.Size = new System.Drawing.Size(178, 26);
            this.txt_cuit.TabIndex = 11;
            // 
            // lbl_calle
            // 
            this.lbl_calle.AutoSize = true;
            this.lbl_calle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lbl_calle.Location = new System.Drawing.Point(682, 258);
            this.lbl_calle.Name = "lbl_calle";
            this.lbl_calle.Size = new System.Drawing.Size(57, 25);
            this.lbl_calle.TabIndex = 10;
            this.lbl_calle.Text = "Calle";
            // 
            // lbl_id_ciudad
            // 
            this.lbl_id_ciudad.AutoSize = true;
            this.lbl_id_ciudad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lbl_id_ciudad.Location = new System.Drawing.Point(682, 211);
            this.lbl_id_ciudad.Name = "lbl_id_ciudad";
            this.lbl_id_ciudad.Size = new System.Drawing.Size(96, 25);
            this.lbl_id_ciudad.TabIndex = 9;
            this.lbl_id_ciudad.Text = "Id Ciudad";
            // 
            // lbl_fecha_inicio
            // 
            this.lbl_fecha_inicio.AutoSize = true;
            this.lbl_fecha_inicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lbl_fecha_inicio.Location = new System.Drawing.Point(682, 165);
            this.lbl_fecha_inicio.Name = "lbl_fecha_inicio";
            this.lbl_fecha_inicio.Size = new System.Drawing.Size(117, 25);
            this.lbl_fecha_inicio.TabIndex = 7;
            this.lbl_fecha_inicio.Text = "Fecha Inicio";
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lbl_nombre.Location = new System.Drawing.Point(682, 117);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(81, 25);
            this.lbl_nombre.TabIndex = 6;
            this.lbl_nombre.Text = "Nombre";
            // 
            // lbl_cuit_empresa
            // 
            this.lbl_cuit_empresa.AutoSize = true;
            this.lbl_cuit_empresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lbl_cuit_empresa.Location = new System.Drawing.Point(682, 68);
            this.lbl_cuit_empresa.Name = "lbl_cuit_empresa";
            this.lbl_cuit_empresa.Size = new System.Drawing.Size(47, 25);
            this.lbl_cuit_empresa.TabIndex = 5;
            this.lbl_cuit_empresa.Text = "Cuit";
            // 
            // btn_guardar
            // 
            this.btn_guardar.Location = new System.Drawing.Point(680, 426);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(165, 63);
            this.btn_guardar.TabIndex = 4;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.UseVisualStyleBackColor = true;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // btn_actualizar
            // 
            this.btn_actualizar.Location = new System.Drawing.Point(406, 426);
            this.btn_actualizar.Name = "btn_actualizar";
            this.btn_actualizar.Size = new System.Drawing.Size(165, 63);
            this.btn_actualizar.TabIndex = 3;
            this.btn_actualizar.Text = "Actualizar";
            this.btn_actualizar.UseVisualStyleBackColor = true;
            this.btn_actualizar.Click += new System.EventHandler(this.btn_actualizar_Click);
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.Location = new System.Drawing.Point(220, 426);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(165, 63);
            this.btn_eliminar.TabIndex = 2;
            this.btn_eliminar.Text = "Eliminar";
            this.btn_eliminar.UseVisualStyleBackColor = true;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // btn_editar
            // 
            this.btn_editar.Location = new System.Drawing.Point(27, 426);
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Size = new System.Drawing.Size(165, 63);
            this.btn_editar.TabIndex = 1;
            this.btn_editar.Text = "Editar";
            this.btn_editar.UseVisualStyleBackColor = true;
            this.btn_editar.Click += new System.EventHandler(this.btn_editar_Click);
            // 
            // FRM_ABM_Empresa_Publicitaria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1101, 580);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FRM_ABM_Empresa_Publicitaria";
            this.Text = "FRM_ABM_Empresa_Publicitaria";
            this.Load += new System.EventHandler(this.FRM_ABM_Empresa_Publicitaria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid_empresa_publicitaria)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grid_empresa_publicitaria;
        private System.Windows.Forms.BindingSource dataSet1BindingSource;
       
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_actualizar;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.Button btn_editar;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.Label lbl_cuit_empresa;
        private System.Windows.Forms.Label lbl_calle;
        private System.Windows.Forms.Label lbl_id_ciudad;
        private System.Windows.Forms.Label lbl_fecha_inicio;
        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.TextBox txt_cuit;
        private System.Windows.Forms.TextBox txt_calle;
        private System.Windows.Forms.TextBox txt_ciudad;
        private System.Windows.Forms.TextBox txt_fecha_inicio;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.TextBox txt_numero_calle;
        private System.Windows.Forms.Label lbl_numero_calle;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.TextBox txt_cuit_buscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_salir;
    }
}