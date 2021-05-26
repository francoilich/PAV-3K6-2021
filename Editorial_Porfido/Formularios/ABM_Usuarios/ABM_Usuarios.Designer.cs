namespace Editorial_Porfido.Formularios.ABM_Usuarios
{
    partial class ABM_Usuarios
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_Eliminar = new System.Windows.Forms.Button();
            this.btn_editar = new System.Windows.Forms.Button();
            this.grid_usuario = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_Guardar = new System.Windows.Forms.Button();
            this.btn_consultar = new System.Windows.Forms.Button();
            this.chk_todos = new System.Windows.Forms.CheckBox();
            this.txt_Nombre_usuario = new System.Windows.Forms.TextBox();
            this.lbl_Nombre_usu = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_usuario)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_Eliminar);
            this.groupBox1.Controls.Add(this.btn_editar);
            this.groupBox1.Controls.Add(this.grid_usuario);
            this.groupBox1.Controls.Add(this.btn_Guardar);
            this.groupBox1.Controls.Add(this.btn_consultar);
            this.groupBox1.Controls.Add(this.chk_todos);
            this.groupBox1.Controls.Add(this.txt_Nombre_usuario);
            this.groupBox1.Controls.Add(this.lbl_Nombre_usu);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(24, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(722, 340);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buscar";
            this.toolTip1.SetToolTip(this.groupBox1, "Limpiar");
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.Location = new System.Drawing.Point(607, 288);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Size = new System.Drawing.Size(99, 34);
            this.btn_Eliminar.TabIndex = 9;
            this.btn_Eliminar.Text = "Eliminar";
            this.btn_Eliminar.UseVisualStyleBackColor = true;
            this.btn_Eliminar.Click += new System.EventHandler(this.btn_Eliminar_Click);
            // 
            // btn_editar
            // 
            this.btn_editar.Location = new System.Drawing.Point(499, 288);
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Size = new System.Drawing.Size(102, 34);
            this.btn_editar.TabIndex = 8;
            this.btn_editar.Text = "Editar";
            this.btn_editar.UseVisualStyleBackColor = true;
            this.btn_editar.Click += new System.EventHandler(this.btn_editar_Click);
            // 
            // grid_usuario
            // 
            this.grid_usuario.AllowUserToAddRows = false;
            this.grid_usuario.AllowUserToDeleteRows = false;
            this.grid_usuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_usuario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Email});
            this.grid_usuario.Location = new System.Drawing.Point(6, 79);
            this.grid_usuario.Name = "grid_usuario";
            this.grid_usuario.ReadOnly = true;
            this.grid_usuario.Size = new System.Drawing.Size(700, 185);
            this.grid_usuario.TabIndex = 7;
            this.grid_usuario.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_usuario_CellClick);
            this.grid_usuario.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_rol_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Nombre Usuario";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column1.Width = 200;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Rol";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column2.Width = 200;
            // 
            // Email
            // 
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            this.Email.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Email.Width = 200;
            // 
            // btn_Guardar
            // 
            this.btn_Guardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Guardar.Location = new System.Drawing.Point(389, 288);
            this.btn_Guardar.Name = "btn_Guardar";
            this.btn_Guardar.Size = new System.Drawing.Size(104, 34);
            this.btn_Guardar.TabIndex = 6;
            this.btn_Guardar.Text = "Agregar";
            this.btn_Guardar.UseVisualStyleBackColor = true;
            this.btn_Guardar.Click += new System.EventHandler(this.btn_Guardar_Click);
            // 
            // btn_consultar
            // 
            this.btn_consultar.Location = new System.Drawing.Point(585, 24);
            this.btn_consultar.Name = "btn_consultar";
            this.btn_consultar.Size = new System.Drawing.Size(121, 35);
            this.btn_consultar.TabIndex = 5;
            this.btn_consultar.Text = "Consultar";
            this.btn_consultar.UseVisualStyleBackColor = true;
            this.btn_consultar.Click += new System.EventHandler(this.btn_consultar_Click);
            // 
            // chk_todos
            // 
            this.chk_todos.AutoSize = true;
            this.chk_todos.Location = new System.Drawing.Point(145, 52);
            this.chk_todos.Name = "chk_todos";
            this.chk_todos.Size = new System.Drawing.Size(67, 21);
            this.chk_todos.TabIndex = 4;
            this.chk_todos.Text = "Todos";
            this.chk_todos.UseVisualStyleBackColor = true;
            // 
            // txt_Nombre_usuario
            // 
            this.txt_Nombre_usuario.Location = new System.Drawing.Point(145, 23);
            this.txt_Nombre_usuario.Name = "txt_Nombre_usuario";
            this.txt_Nombre_usuario.Size = new System.Drawing.Size(232, 23);
            this.txt_Nombre_usuario.TabIndex = 2;
            this.toolTip1.SetToolTip(this.txt_Nombre_usuario, "Ingrese Nombre de Usuario");
            this.txt_Nombre_usuario.TextChanged += new System.EventHandler(this.txt_Nombre_usuario_TextChanged);
            // 
            // lbl_Nombre_usu
            // 
            this.lbl_Nombre_usu.AutoSize = true;
            this.lbl_Nombre_usu.Location = new System.Drawing.Point(19, 24);
            this.lbl_Nombre_usu.Name = "lbl_Nombre_usu";
            this.lbl_Nombre_usu.Size = new System.Drawing.Size(111, 17);
            this.lbl_Nombre_usu.TabIndex = 0;
            this.lbl_Nombre_usu.Text = "Nombre Usuario";
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            // 
            // ABM_Usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 365);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ABM_Usuarios";
            this.Text = "Usuario";
            this.Load += new System.EventHandler(this.ABM_Usuarios_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_usuario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl_Nombre_usu;
        private System.Windows.Forms.TextBox txt_Nombre_usuario;
        private System.Windows.Forms.Button btn_consultar;
        private System.Windows.Forms.CheckBox chk_todos;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btn_Guardar;
        private System.Windows.Forms.DataGridView grid_usuario;
        private System.Windows.Forms.Button btn_Eliminar;
        private System.Windows.Forms.Button btn_editar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
    }

}