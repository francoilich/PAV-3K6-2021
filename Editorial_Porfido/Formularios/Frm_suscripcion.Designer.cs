
namespace Editorial_Porfido.Formularios
{
    partial class Frm_suscripcion
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_suscripcion = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.grid_suscripcion = new System.Windows.Forms.DataGridView();
            this.id_suscriptor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodRevista = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaInicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaFin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chkTodos = new System.Windows.Forms.CheckBox();
            this.btn_aceptar = new System.Windows.Forms.Button();
            this.btn_modificar = new System.Windows.Forms.Button();
            this.btn_eliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grid_suscripcion)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Suscripcion:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txt_suscripcion
            // 
            this.txt_suscripcion.Location = new System.Drawing.Point(124, 17);
            this.txt_suscripcion.Name = "txt_suscripcion";
            this.txt_suscripcion.Size = new System.Drawing.Size(218, 23);
            this.txt_suscripcion.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(369, 17);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 28);
            this.button1.TabIndex = 6;
            this.button1.Text = "Consultar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // grid_suscripcion
            // 
            this.grid_suscripcion.AllowUserToAddRows = false;
            this.grid_suscripcion.AllowUserToDeleteRows = false;
            this.grid_suscripcion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_suscripcion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_suscriptor,
            this.CodRevista,
            this.FechaInicio,
            this.FechaFin});
            this.grid_suscripcion.Location = new System.Drawing.Point(40, 74);
            this.grid_suscripcion.Name = "grid_suscripcion";
            this.grid_suscripcion.ReadOnly = true;
            this.grid_suscripcion.Size = new System.Drawing.Size(713, 232);
            this.grid_suscripcion.TabIndex = 7;
            this.grid_suscripcion.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_suscripcion_CellContentClick);
            // 
            // id_suscriptor
            // 
            this.id_suscriptor.HeaderText = "Id suscriptor";
            this.id_suscriptor.Name = "id_suscriptor";
            this.id_suscriptor.ReadOnly = true;
            this.id_suscriptor.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // CodRevista
            // 
            this.CodRevista.HeaderText = "Codigo Revista";
            this.CodRevista.Name = "CodRevista";
            this.CodRevista.ReadOnly = true;
            this.CodRevista.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // FechaInicio
            // 
            this.FechaInicio.HeaderText = "Fecha Inicio";
            this.FechaInicio.Name = "FechaInicio";
            this.FechaInicio.ReadOnly = true;
            this.FechaInicio.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.FechaInicio.Width = 200;
            // 
            // FechaFin
            // 
            this.FechaFin.HeaderText = "Fecha Fin";
            this.FechaFin.Name = "FechaFin";
            this.FechaFin.ReadOnly = true;
            this.FechaFin.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.FechaFin.Width = 200;
            // 
            // chkTodos
            // 
            this.chkTodos.AutoSize = true;
            this.chkTodos.Location = new System.Drawing.Point(124, 47);
            this.chkTodos.Name = "chkTodos";
            this.chkTodos.Size = new System.Drawing.Size(67, 21);
            this.chkTodos.TabIndex = 8;
            this.chkTodos.Text = "Todos";
            this.chkTodos.UseVisualStyleBackColor = true;
            // 
            // btn_aceptar
            // 
            this.btn_aceptar.Location = new System.Drawing.Point(428, 323);
            this.btn_aceptar.Name = "btn_aceptar";
            this.btn_aceptar.Size = new System.Drawing.Size(96, 34);
            this.btn_aceptar.TabIndex = 9;
            this.btn_aceptar.Text = "Guardar";
            this.btn_aceptar.UseVisualStyleBackColor = true;
            this.btn_aceptar.Click += new System.EventHandler(this.btn_aceptar_Click);
            // 
            // btn_modificar
            // 
            this.btn_modificar.Location = new System.Drawing.Point(543, 324);
            this.btn_modificar.Name = "btn_modificar";
            this.btn_modificar.Size = new System.Drawing.Size(96, 33);
            this.btn_modificar.TabIndex = 10;
            this.btn_modificar.Text = "Modificar";
            this.btn_modificar.UseVisualStyleBackColor = true;
            this.btn_modificar.Click += new System.EventHandler(this.btn_modificar_Click);
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.Location = new System.Drawing.Point(657, 324);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(96, 34);
            this.btn_eliminar.TabIndex = 11;
            this.btn_eliminar.Text = "Eliminar";
            this.btn_eliminar.UseVisualStyleBackColor = true;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // Frm_suscripcion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 366);
            this.Controls.Add(this.btn_eliminar);
            this.Controls.Add(this.btn_modificar);
            this.Controls.Add(this.btn_aceptar);
            this.Controls.Add(this.chkTodos);
            this.Controls.Add(this.grid_suscripcion);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_suscripcion);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Frm_suscripcion";
            this.Text = "Suscripcion";
            this.Load += new System.EventHandler(this.Frm_suscripcion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid_suscripcion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_suscripcion;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView grid_suscripcion;
        private System.Windows.Forms.CheckBox chkTodos;
        private System.Windows.Forms.Button btn_aceptar;
        private System.Windows.Forms.Button btn_modificar;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_suscriptor;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodRevista;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaInicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaFin;
    }
}