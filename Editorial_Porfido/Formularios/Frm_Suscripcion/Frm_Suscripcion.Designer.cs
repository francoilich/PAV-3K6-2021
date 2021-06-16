
namespace Editorial_Porfido.Formularios.Frm_Suscripcion
{
    partial class Frm_Suscripcion
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_borrar = new System.Windows.Forms.Button();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.txt_cod_revista = new System.Windows.Forms.TextBox();
            this.txt_precio = new System.Windows.Forms.TextBox();
            this.date_fin = new System.Windows.Forms.DateTimePicker();
            this.date_inicio = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_consultar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_id_sus = new System.Windows.Forms.TextBox();
            this.txt_barrio = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_codigo_postal = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_apellido = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_dni = new System.Windows.Forms.TextBox();
            this.date_fin_susc = new System.Windows.Forms.DateTimePicker();
            this.date_inicio_susc = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_id_suscri = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txt_total = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.cmb_forma_pago = new Editorial_Porfido.Clasess.ComboBox01();
            this.grid_plan = new Editorial_Porfido.Clasess.Grid01();
            this.Fecha_Inicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha_Fin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Codigo_revista = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_plan)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.txt_total);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.cmb_forma_pago);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.txt_id_suscri);
            this.groupBox1.Controls.Add(this.date_fin_susc);
            this.groupBox1.Controls.Add(this.date_inicio_susc);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(869, 582);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Suscripcion";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_borrar);
            this.groupBox3.Controls.Add(this.btn_agregar);
            this.groupBox3.Controls.Add(this.txt_cod_revista);
            this.groupBox3.Controls.Add(this.grid_plan);
            this.groupBox3.Controls.Add(this.txt_precio);
            this.groupBox3.Controls.Add(this.date_fin);
            this.groupBox3.Controls.Add(this.date_inicio);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Location = new System.Drawing.Point(15, 245);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(433, 327);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Plan";
            // 
            // btn_borrar
            // 
            this.btn_borrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn_borrar.Location = new System.Drawing.Point(250, 98);
            this.btn_borrar.Name = "btn_borrar";
            this.btn_borrar.Size = new System.Drawing.Size(96, 42);
            this.btn_borrar.TabIndex = 14;
            this.btn_borrar.Text = "Borrar";
            this.btn_borrar.UseVisualStyleBackColor = true;
            // 
            // btn_agregar
            // 
            this.btn_agregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn_agregar.Location = new System.Drawing.Point(250, 35);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(96, 42);
            this.btn_agregar.TabIndex = 13;
            this.btn_agregar.Text = "Agregar";
            this.btn_agregar.UseVisualStyleBackColor = true;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // txt_cod_revista
            // 
            this.txt_cod_revista.Location = new System.Drawing.Point(116, 123);
            this.txt_cod_revista.Name = "txt_cod_revista";
            this.txt_cod_revista.Size = new System.Drawing.Size(100, 20);
            this.txt_cod_revista.TabIndex = 8;
            // 
            // txt_precio
            // 
            this.txt_precio.Location = new System.Drawing.Point(116, 91);
            this.txt_precio.Name = "txt_precio";
            this.txt_precio.Size = new System.Drawing.Size(100, 20);
            this.txt_precio.TabIndex = 6;
            // 
            // date_fin
            // 
            this.date_fin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_fin.Location = new System.Drawing.Point(116, 60);
            this.date_fin.Name = "date_fin";
            this.date_fin.Size = new System.Drawing.Size(100, 20);
            this.date_fin.TabIndex = 5;
            // 
            // date_inicio
            // 
            this.date_inicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_inicio.Location = new System.Drawing.Point(116, 33);
            this.date_inicio.Name = "date_inicio";
            this.date_inicio.Size = new System.Drawing.Size(100, 20);
            this.date_inicio.TabIndex = 4;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label10.Location = new System.Drawing.Point(12, 123);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(98, 17);
            this.label10.TabIndex = 3;
            this.label10.Text = "Codigo revista";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label9.Location = new System.Drawing.Point(62, 91);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 17);
            this.label9.TabIndex = 2;
            this.label9.Text = "Precio";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label8.Location = new System.Drawing.Point(44, 60);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 17);
            this.label8.TabIndex = 1;
            this.label8.Text = "Fecha fin";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label7.Location = new System.Drawing.Point(27, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "Fecha inicio";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_consultar);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txt_id_sus);
            this.groupBox2.Controls.Add(this.txt_barrio);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txt_codigo_postal);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txt_apellido);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txt_nombre);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txt_dni);
            this.groupBox2.Location = new System.Drawing.Point(454, 10);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(409, 233);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Suscriptor";
            // 
            // btn_consultar
            // 
            this.btn_consultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn_consultar.Location = new System.Drawing.Point(142, 179);
            this.btn_consultar.Name = "btn_consultar";
            this.btn_consultar.Size = new System.Drawing.Size(96, 42);
            this.btn_consultar.TabIndex = 12;
            this.btn_consultar.Text = "Consultar";
            this.btn_consultar.UseVisualStyleBackColor = true;
            this.btn_consultar.Click += new System.EventHandler(this.btn_consultar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label6.Location = new System.Drawing.Point(84, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "ID Suscriptor";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(125, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Barrio";
            // 
            // txt_id_sus
            // 
            this.txt_id_sus.Location = new System.Drawing.Point(177, 23);
            this.txt_id_sus.Name = "txt_id_sus";
            this.txt_id_sus.Size = new System.Drawing.Size(49, 20);
            this.txt_id_sus.TabIndex = 10;
            // 
            // txt_barrio
            // 
            this.txt_barrio.Location = new System.Drawing.Point(177, 153);
            this.txt_barrio.Name = "txt_barrio";
            this.txt_barrio.Size = new System.Drawing.Size(144, 20);
            this.txt_barrio.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(76, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Codigo Postal";
            // 
            // txt_codigo_postal
            // 
            this.txt_codigo_postal.Location = new System.Drawing.Point(177, 127);
            this.txt_codigo_postal.Name = "txt_codigo_postal";
            this.txt_codigo_postal.Size = new System.Drawing.Size(61, 20);
            this.txt_codigo_postal.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(113, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Apellido";
            // 
            // txt_apellido
            // 
            this.txt_apellido.Location = new System.Drawing.Point(177, 101);
            this.txt_apellido.Name = "txt_apellido";
            this.txt_apellido.Size = new System.Drawing.Size(121, 20);
            this.txt_apellido.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(113, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nombre";
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(177, 75);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(121, 20);
            this.txt_nombre.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(142, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "DNI";
            // 
            // txt_dni
            // 
            this.txt_dni.Location = new System.Drawing.Point(177, 49);
            this.txt_dni.Name = "txt_dni";
            this.txt_dni.Size = new System.Drawing.Size(121, 20);
            this.txt_dni.TabIndex = 0;
            // 
            // date_fin_susc
            // 
            this.date_fin_susc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_fin_susc.Location = new System.Drawing.Point(116, 89);
            this.date_fin_susc.Name = "date_fin_susc";
            this.date_fin_susc.Size = new System.Drawing.Size(121, 20);
            this.date_fin_susc.TabIndex = 9;
            // 
            // date_inicio_susc
            // 
            this.date_inicio_susc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_inicio_susc.Location = new System.Drawing.Point(116, 62);
            this.date_inicio_susc.Name = "date_inicio_susc";
            this.date_inicio_susc.Size = new System.Drawing.Size(121, 20);
            this.date_inicio_susc.TabIndex = 8;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label11.Location = new System.Drawing.Point(44, 89);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(66, 17);
            this.label11.TabIndex = 7;
            this.label11.Text = "Fecha fin";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label12.Location = new System.Drawing.Point(27, 62);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(83, 17);
            this.label12.TabIndex = 6;
            this.label12.Text = "Fecha inicio";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label13.Location = new System.Drawing.Point(12, 33);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(98, 17);
            this.label13.TabIndex = 13;
            this.label13.Text = "ID Suscripcion";
            // 
            // txt_id_suscri
            // 
            this.txt_id_suscri.Location = new System.Drawing.Point(116, 31);
            this.txt_id_suscri.Name = "txt_id_suscri";
            this.txt_id_suscri.Size = new System.Drawing.Size(49, 20);
            this.txt_id_suscri.TabIndex = 12;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label14.Location = new System.Drawing.Point(8, 126);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(104, 17);
            this.label14.TabIndex = 15;
            this.label14.Text = "Forma de pago";
            // 
            // txt_total
            // 
            this.txt_total.Enabled = false;
            this.txt_total.Location = new System.Drawing.Point(115, 162);
            this.txt_total.Name = "txt_total";
            this.txt_total.Size = new System.Drawing.Size(121, 20);
            this.txt_total.TabIndex = 17;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label15.Location = new System.Drawing.Point(30, 163);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(82, 17);
            this.label15.TabIndex = 16;
            this.label15.Text = "Monto total ";
            // 
            // groupBox4
            // 
            this.groupBox4.Location = new System.Drawing.Point(454, 245);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(408, 326);
            this.groupBox4.TabIndex = 18;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Regalo";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button1.Location = new System.Drawing.Point(176, 189);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 42);
            this.button1.TabIndex = 19;
            this.button1.Text = "Generar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // cmb_forma_pago
            // 
            this.cmb_forma_pago.FormattingEnabled = true;
            this.cmb_forma_pago.Location = new System.Drawing.Point(116, 125);
            this.cmb_forma_pago.Name = "cmb_forma_pago";
            this.cmb_forma_pago.Pp_Conseleccion = false;
            this.cmb_forma_pago.Pp_descripcion = "nombre";
            this.cmb_forma_pago.Pp_MensajeError = null;
            this.cmb_forma_pago.Pp_NombreCampo = null;
            this.cmb_forma_pago.Pp_NombreTabla = null;
            this.cmb_forma_pago.Pp_PK = "id_forma_pago";
            this.cmb_forma_pago.Pp_tabla = "Forma_Pago";
            this.cmb_forma_pago.Pp_Validable = false;
            this.cmb_forma_pago.Size = new System.Drawing.Size(121, 21);
            this.cmb_forma_pago.TabIndex = 14;
            // 
            // grid_plan
            // 
            this.grid_plan.AllowUserToAddRows = false;
            this.grid_plan.AllowUserToDeleteRows = false;
            this.grid_plan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_plan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Fecha_Inicio,
            this.Fecha_Fin,
            this.Precio,
            this.Codigo_revista});
            this.grid_plan.Location = new System.Drawing.Point(6, 154);
            this.grid_plan.Name = "grid_plan";
            this.grid_plan.ReadOnly = true;
            this.grid_plan.Size = new System.Drawing.Size(397, 167);
            this.grid_plan.TabIndex = 7;
            // 
            // Fecha_Inicio
            // 
            this.Fecha_Inicio.HeaderText = "Fecha Inicio";
            this.Fecha_Inicio.Name = "Fecha_Inicio";
            this.Fecha_Inicio.ReadOnly = true;
            this.Fecha_Inicio.Width = 85;
            // 
            // Fecha_Fin
            // 
            this.Fecha_Fin.HeaderText = "Fecha Fin";
            this.Fecha_Fin.Name = "Fecha_Fin";
            this.Fecha_Fin.ReadOnly = true;
            this.Fecha_Fin.Width = 85;
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            this.Precio.Width = 65;
            // 
            // Codigo_revista
            // 
            this.Codigo_revista.HeaderText = "Codigo revista";
            this.Codigo_revista.Name = "Codigo_revista";
            this.Codigo_revista.ReadOnly = true;
            this.Codigo_revista.Width = 80;
            // 
            // Frm_Suscripcion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 596);
            this.Controls.Add(this.groupBox1);
            this.Name = "Frm_Suscripcion";
            this.Text = "Frm_Suscripcion";
            this.Load += new System.EventHandler(this.Frm_Suscripcion_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_plan)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_id_sus;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_barrio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_codigo_postal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_apellido;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_dni;
        private System.Windows.Forms.Button btn_consultar;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.TextBox txt_cod_revista;
        private Clasess.Grid01 grid_plan;
        private System.Windows.Forms.TextBox txt_precio;
        private System.Windows.Forms.DateTimePicker date_fin;
        private System.Windows.Forms.DateTimePicker date_inicio;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_borrar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha_Inicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha_Fin;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo_revista;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txt_total;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private Clasess.ComboBox01 cmb_forma_pago;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txt_id_suscri;
        private System.Windows.Forms.DateTimePicker date_fin_susc;
        private System.Windows.Forms.DateTimePicker date_inicio_susc;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
    }
}