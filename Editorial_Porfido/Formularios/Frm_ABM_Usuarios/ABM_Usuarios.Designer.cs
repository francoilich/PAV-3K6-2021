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
            this.grid_rol = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_limpiar = new System.Windows.Forms.Button();
            this.btn_consultar = new System.Windows.Forms.Button();
            this.chk_todos = new System.Windows.Forms.CheckBox();
            this.cmb_Roles = new Editorial_Porfido.Clasess.ComboBox01();
            this.txt_Nombre_usuario = new System.Windows.Forms.TextBox();
            this.lbl_Rol = new System.Windows.Forms.Label();
            this.lbl_Nombre_usu = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_rol)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.grid_rol);
            this.groupBox1.Controls.Add(this.btn_limpiar);
            this.groupBox1.Controls.Add(this.btn_consultar);
            this.groupBox1.Controls.Add(this.chk_todos);
            this.groupBox1.Controls.Add(this.cmb_Roles);
            this.groupBox1.Controls.Add(this.txt_Nombre_usuario);
            this.groupBox1.Controls.Add(this.lbl_Rol);
            this.groupBox1.Controls.Add(this.lbl_Nombre_usu);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(24, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(737, 400);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buscar";
            this.toolTip1.SetToolTip(this.groupBox1, "Limpiar");
            // 
            // grid_rol
            // 
            this.grid_rol.AllowUserToAddRows = false;
            this.grid_rol.AllowUserToDeleteRows = false;
            this.grid_rol.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_rol.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.grid_rol.Location = new System.Drawing.Point(27, 209);
            this.grid_rol.Name = "grid_rol";
            this.grid_rol.ReadOnly = true;
            this.grid_rol.Size = new System.Drawing.Size(677, 185);
            this.grid_rol.TabIndex = 7;
            this.grid_rol.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_rol_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Nombre Usuario";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 200;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Rol";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 200;
            // 
            // btn_limpiar
            // 
            this.btn_limpiar.BackgroundImage = global::Editorial_Porfido.Properties.Resources._9ZeIKce;
            this.btn_limpiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_limpiar.Location = new System.Drawing.Point(394, 90);
            this.btn_limpiar.Name = "btn_limpiar";
            this.btn_limpiar.Size = new System.Drawing.Size(82, 65);
            this.btn_limpiar.TabIndex = 6;
            this.btn_limpiar.UseVisualStyleBackColor = true;
            this.btn_limpiar.Click += new System.EventHandler(this.btn_limpiar_Click);
            // 
            // btn_consultar
            // 
            this.btn_consultar.Location = new System.Drawing.Point(583, 109);
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
            this.chk_todos.Location = new System.Drawing.Point(156, 149);
            this.chk_todos.Name = "chk_todos";
            this.chk_todos.Size = new System.Drawing.Size(115, 21);
            this.chk_todos.TabIndex = 4;
            this.chk_todos.Text = "Marcar Todos";
            this.chk_todos.UseVisualStyleBackColor = true;
            // 
            // cmb_Roles
            // 
            this.cmb_Roles.FormattingEnabled = true;
            this.cmb_Roles.Location = new System.Drawing.Point(156, 109);
            this.cmb_Roles.Name = "cmb_Roles";
            this.cmb_Roles.Pp_descripcion = "userRoleName";
            this.cmb_Roles.Pp_PK = "userRoleId";
            this.cmb_Roles.Pp_tabla = "dbo.RolUsuario";
            this.cmb_Roles.Size = new System.Drawing.Size(232, 24);
            this.cmb_Roles.TabIndex = 3;
            this.toolTip1.SetToolTip(this.cmb_Roles, "Selecione un Perfil");
            // 
            // txt_Nombre_usuario
            // 
            this.txt_Nombre_usuario.Location = new System.Drawing.Point(156, 59);
            this.txt_Nombre_usuario.Name = "txt_Nombre_usuario";
            this.txt_Nombre_usuario.Size = new System.Drawing.Size(232, 23);
            this.txt_Nombre_usuario.TabIndex = 2;
            this.toolTip1.SetToolTip(this.txt_Nombre_usuario, "Ingrese Nombre de Usuario");
            // 
            // lbl_Rol
            // 
            this.lbl_Rol.AutoSize = true;
            this.lbl_Rol.Location = new System.Drawing.Point(33, 109);
            this.lbl_Rol.Name = "lbl_Rol";
            this.lbl_Rol.Size = new System.Drawing.Size(82, 17);
            this.lbl_Rol.TabIndex = 1;
            this.lbl_Rol.Text = "Rol Usuario";
            // 
            // lbl_Nombre_usu
            // 
            this.lbl_Nombre_usu.AutoSize = true;
            this.lbl_Nombre_usu.Location = new System.Drawing.Point(24, 59);
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
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "ABM_Usuarios";
            this.Text = "ABM_Usuarios";
            this.Load += new System.EventHandler(this.ABM_Usuarios_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_rol)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl_Rol;
        private System.Windows.Forms.Label lbl_Nombre_usu;
        private System.Windows.Forms.TextBox txt_Nombre_usuario;
        private Clasess.ComboBox01 cmb_Roles;
        private System.Windows.Forms.Button btn_consultar;
        private System.Windows.Forms.CheckBox chk_todos;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btn_limpiar;
        private System.Windows.Forms.DataGridView grid_rol;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}