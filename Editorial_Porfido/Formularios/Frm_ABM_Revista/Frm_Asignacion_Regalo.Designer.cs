
namespace Editorial_Porfido.Formularios.Frm_ABM_Revista
{
    partial class Frm_Asignacion_Regalo
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
            this.label2 = new System.Windows.Forms.Label();
            this.btn_consultar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_Regalo = new Editorial_Porfido.Clasess.TextBox01();
            this.txt_nombre = new Editorial_Porfido.Clasess.TextBox01();
            this.txt_descripcion = new Editorial_Porfido.Clasess.TextBox01();
            this.txt_plan = new Editorial_Porfido.Clasess.TextBox01();
            this.txt_id_regalo = new Editorial_Porfido.Clasess.TextBox01();
            this.grid_plan = new Editorial_Porfido.Clasess.Grid01();
            this.grid_asignacion_regalo = new Editorial_Porfido.Clasess.Grid01();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.btn_modificar = new System.Windows.Forms.Button();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_plan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_asignacion_regalo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label1.Location = new System.Drawing.Point(9, 270);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Regalos:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Plan:";
            // 
            // btn_consultar
            // 
            this.btn_consultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_consultar.Location = new System.Drawing.Point(98, 9);
            this.btn_consultar.Name = "btn_consultar";
            this.btn_consultar.Size = new System.Drawing.Size(88, 32);
            this.btn_consultar.TabIndex = 6;
            this.btn_consultar.Text = "Consultar";
            this.btn_consultar.UseVisualStyleBackColor = true;
            this.btn_consultar.Click += new System.EventHandler(this.btn_consultar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.btn_eliminar);
            this.groupBox1.Controls.Add(this.btn_modificar);
            this.groupBox1.Controls.Add(this.btn_guardar);
            this.groupBox1.Controls.Add(this.txt_Regalo);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txt_nombre);
            this.groupBox1.Controls.Add(this.txt_descripcion);
            this.groupBox1.Controls.Add(this.txt_plan);
            this.groupBox1.Controls.Add(this.txt_id_regalo);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(512, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(377, 425);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Regalo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(66, 282);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 18);
            this.label6.TabIndex = 3;
            this.label6.Text = "Plan";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(66, 240);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 18);
            this.label5.TabIndex = 2;
            this.label5.Text = "Descripcion";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(66, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 18);
            this.label4.TabIndex = 1;
            this.label4.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(66, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "Id Regalo:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(66, 318);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 18);
            this.label7.TabIndex = 8;
            this.label7.Text = "Regalo:";
            // 
            // txt_Regalo
            // 
            this.txt_Regalo.Location = new System.Drawing.Point(131, 319);
            this.txt_Regalo.Name = "txt_Regalo";
            this.txt_Regalo.Pp_campo = null;
            this.txt_Regalo.Pp_MensajeError = null;
            this.txt_Regalo.Pp_tabla = null;
            this.txt_Regalo.Pp_Validable = false;
            this.txt_Regalo.Size = new System.Drawing.Size(128, 20);
            this.txt_Regalo.TabIndex = 9;
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(146, 199);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Pp_campo = null;
            this.txt_nombre.Pp_MensajeError = null;
            this.txt_nombre.Pp_tabla = null;
            this.txt_nombre.Pp_Validable = false;
            this.txt_nombre.Size = new System.Drawing.Size(100, 20);
            this.txt_nombre.TabIndex = 7;
            // 
            // txt_descripcion
            // 
            this.txt_descripcion.Location = new System.Drawing.Point(159, 241);
            this.txt_descripcion.Name = "txt_descripcion";
            this.txt_descripcion.Pp_campo = null;
            this.txt_descripcion.Pp_MensajeError = null;
            this.txt_descripcion.Pp_tabla = null;
            this.txt_descripcion.Pp_Validable = false;
            this.txt_descripcion.Size = new System.Drawing.Size(100, 20);
            this.txt_descripcion.TabIndex = 6;
            // 
            // txt_plan
            // 
            this.txt_plan.Location = new System.Drawing.Point(109, 283);
            this.txt_plan.Name = "txt_plan";
            this.txt_plan.Pp_campo = null;
            this.txt_plan.Pp_MensajeError = null;
            this.txt_plan.Pp_tabla = null;
            this.txt_plan.Pp_Validable = false;
            this.txt_plan.Size = new System.Drawing.Size(100, 20);
            this.txt_plan.TabIndex = 5;
            // 
            // txt_id_regalo
            // 
            this.txt_id_regalo.Location = new System.Drawing.Point(146, 165);
            this.txt_id_regalo.Name = "txt_id_regalo";
            this.txt_id_regalo.Pp_campo = null;
            this.txt_id_regalo.Pp_MensajeError = null;
            this.txt_id_regalo.Pp_tabla = null;
            this.txt_id_regalo.Pp_Validable = false;
            this.txt_id_regalo.Size = new System.Drawing.Size(100, 20);
            this.txt_id_regalo.TabIndex = 4;
            // 
            // grid_plan
            // 
            this.grid_plan.AllowUserToAddRows = false;
            this.grid_plan.AllowUserToDeleteRows = false;
            this.grid_plan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_plan.Location = new System.Drawing.Point(12, 48);
            this.grid_plan.Name = "grid_plan";
            this.grid_plan.ReadOnly = true;
            this.grid_plan.Size = new System.Drawing.Size(485, 209);
            this.grid_plan.TabIndex = 5;
            this.grid_plan.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_plan_CellContentClick);
            // 
            // grid_asignacion_regalo
            // 
            this.grid_asignacion_regalo.AllowUserToAddRows = false;
            this.grid_asignacion_regalo.AllowUserToDeleteRows = false;
            this.grid_asignacion_regalo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_asignacion_regalo.Location = new System.Drawing.Point(12, 302);
            this.grid_asignacion_regalo.Name = "grid_asignacion_regalo";
            this.grid_asignacion_regalo.ReadOnly = true;
            this.grid_asignacion_regalo.Size = new System.Drawing.Size(421, 136);
            this.grid_asignacion_regalo.TabIndex = 2;
            this.grid_asignacion_regalo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_asignacion_regalo_CellContentClick_1);
            // 
            // btn_guardar
            // 
            this.btn_guardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_guardar.Location = new System.Drawing.Point(69, 376);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(88, 32);
            this.btn_guardar.TabIndex = 10;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.UseVisualStyleBackColor = true;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // btn_modificar
            // 
            this.btn_modificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_modificar.Location = new System.Drawing.Point(177, 376);
            this.btn_modificar.Name = "btn_modificar";
            this.btn_modificar.Size = new System.Drawing.Size(88, 32);
            this.btn_modificar.TabIndex = 11;
            this.btn_modificar.Text = "Modificar";
            this.btn_modificar.UseVisualStyleBackColor = true;
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_eliminar.Location = new System.Drawing.Point(282, 376);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(88, 32);
            this.btn_eliminar.TabIndex = 12;
            this.btn_eliminar.Text = "Eliminar";
            this.btn_eliminar.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Editorial_Porfido.Properties.Resources.png_transparent_gift_boxes_gift_boxes_gifts_gift;
            this.pictureBox1.Location = new System.Drawing.Point(118, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(177, 130);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // Frm_Asignacion_Regalo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_consultar);
            this.Controls.Add(this.grid_plan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.grid_asignacion_regalo);
            this.Controls.Add(this.label1);
            this.Name = "Frm_Asignacion_Regalo";
            this.Text = "Regalo por revista";
            this.Load += new System.EventHandler(this.Frm_Asignacion_Regalo_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_plan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_asignacion_regalo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private Clasess.Grid01 grid_asignacion_regalo;
        private System.Windows.Forms.Label label2;
        private Clasess.Grid01 grid_plan;
        private System.Windows.Forms.Button btn_consultar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private Clasess.TextBox01 txt_nombre;
        private Clasess.TextBox01 txt_descripcion;
        private Clasess.TextBox01 txt_plan;
        private Clasess.TextBox01 txt_id_regalo;
        private Clasess.TextBox01 txt_Regalo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.Button btn_modificar;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}