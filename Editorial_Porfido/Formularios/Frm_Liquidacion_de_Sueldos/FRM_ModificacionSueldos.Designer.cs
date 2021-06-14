
namespace Editorial_Porfido.Formularios.Frm_Liquidacion_de_Sueldos
{
    partial class FRM_ModificacionSueldos
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_valor_asignaciones = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_valor_descuentos = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_cantidad_asigna = new System.Windows.Forms.MaskedTextBox();
            this.btn_agregar_asigna = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_cantidad_descu = new System.Windows.Forms.MaskedTextBox();
            this.btn_agregar_descu = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_perfil = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_cuil = new System.Windows.Forms.MaskedTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_apellido = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_nombre_usuario = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_usuario_id = new System.Windows.Forms.MaskedTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_fecha = new System.Windows.Forms.Button();
            this.txt_Fecha = new System.Windows.Forms.MaskedTextBox();
            this.txt_sueldo_neto = new System.Windows.Forms.MaskedTextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txt_sueldo_bruto = new System.Windows.Forms.MaskedTextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txt_año = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txt_mes = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btn_grabar = new System.Windows.Forms.Button();
            this.cmb_descuento = new Editorial_Porfido.Clasess.ComboBox01();
            this.cmb_asignaciones = new Editorial_Porfido.Clasess.ComboBox01();
            this.grid_descuento = new Editorial_Porfido.Clasess.Grid01();
            this.grid_asignaciones = new Editorial_Porfido.Clasess.Grid01();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_descuento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_asignaciones)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(236, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Modificacion Sueldo Mensual";
            // 
            // txt_valor_asignaciones
            // 
            this.txt_valor_asignaciones.Location = new System.Drawing.Point(448, 50);
            this.txt_valor_asignaciones.Mask = "999999,99";
            this.txt_valor_asignaciones.Name = "txt_valor_asignaciones";
            this.txt_valor_asignaciones.Size = new System.Drawing.Size(65, 20);
            this.txt_valor_asignaciones.TabIndex = 8;
            this.txt_valor_asignaciones.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(541, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Asignaciones";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(552, 223);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Descuento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(411, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Valor";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(411, 250);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Valor";
            // 
            // txt_valor_descuentos
            // 
            this.txt_valor_descuentos.Location = new System.Drawing.Point(448, 250);
            this.txt_valor_descuentos.Mask = "999999,99";
            this.txt_valor_descuentos.Name = "txt_valor_descuentos";
            this.txt_valor_descuentos.Size = new System.Drawing.Size(65, 20);
            this.txt_valor_descuentos.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(541, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Cantidad";
            // 
            // txt_cantidad_asigna
            // 
            this.txt_cantidad_asigna.Location = new System.Drawing.Point(606, 50);
            this.txt_cantidad_asigna.Mask = "99";
            this.txt_cantidad_asigna.Name = "txt_cantidad_asigna";
            this.txt_cantidad_asigna.Size = new System.Drawing.Size(27, 20);
            this.txt_cantidad_asigna.TabIndex = 10;
            // 
            // btn_agregar_asigna
            // 
            this.btn_agregar_asigna.Location = new System.Drawing.Point(668, 48);
            this.btn_agregar_asigna.Name = "btn_agregar_asigna";
            this.btn_agregar_asigna.Size = new System.Drawing.Size(75, 24);
            this.btn_agregar_asigna.TabIndex = 11;
            this.btn_agregar_asigna.Text = "Agregar";
            this.btn_agregar_asigna.UseVisualStyleBackColor = true;
            this.btn_agregar_asigna.Click += new System.EventHandler(this.btn_agregar_asigna_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(541, 253);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Cantidad";
            // 
            // txt_cantidad_descu
            // 
            this.txt_cantidad_descu.Location = new System.Drawing.Point(596, 250);
            this.txt_cantidad_descu.Mask = "99";
            this.txt_cantidad_descu.Name = "txt_cantidad_descu";
            this.txt_cantidad_descu.Size = new System.Drawing.Size(27, 20);
            this.txt_cantidad_descu.TabIndex = 16;
            // 
            // btn_agregar_descu
            // 
            this.btn_agregar_descu.Location = new System.Drawing.Point(657, 250);
            this.btn_agregar_descu.Name = "btn_agregar_descu";
            this.btn_agregar_descu.Size = new System.Drawing.Size(75, 23);
            this.btn_agregar_descu.TabIndex = 17;
            this.btn_agregar_descu.Text = "Agregar";
            this.btn_agregar_descu.UseVisualStyleBackColor = true;
            this.btn_agregar_descu.Click += new System.EventHandler(this.btn_agregar_descu_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_perfil);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.txt_cuil);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.txt_apellido);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txt_nombre);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txt_nombre_usuario);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txt_usuario_id);
            this.groupBox1.Location = new System.Drawing.Point(15, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(356, 145);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Usuario";
            // 
            // txt_perfil
            // 
            this.txt_perfil.Location = new System.Drawing.Point(224, 108);
            this.txt_perfil.Name = "txt_perfil";
            this.txt_perfil.Size = new System.Drawing.Size(100, 20);
            this.txt_perfil.TabIndex = 11;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(177, 111);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(30, 13);
            this.label13.TabIndex = 10;
            this.label13.Text = "Perfil";
            // 
            // txt_cuil
            // 
            this.txt_cuil.Location = new System.Drawing.Point(53, 111);
            this.txt_cuil.Mask = "99-99999999-9";
            this.txt_cuil.Name = "txt_cuil";
            this.txt_cuil.Size = new System.Drawing.Size(85, 20);
            this.txt_cuil.TabIndex = 9;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(15, 111);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(24, 13);
            this.label12.TabIndex = 8;
            this.label12.Text = "Cuil";
            // 
            // txt_apellido
            // 
            this.txt_apellido.Location = new System.Drawing.Point(224, 65);
            this.txt_apellido.Name = "txt_apellido";
            this.txt_apellido.Size = new System.Drawing.Size(100, 20);
            this.txt_apellido.TabIndex = 7;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(174, 68);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 13);
            this.label11.TabIndex = 7;
            this.label11.Text = "Apellido";
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(53, 65);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(100, 20);
            this.txt_nombre.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 65);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 13);
            this.label10.TabIndex = 4;
            this.label10.Text = "Nombre";
            // 
            // txt_nombre_usuario
            // 
            this.txt_nombre_usuario.Location = new System.Drawing.Point(224, 25);
            this.txt_nombre_usuario.Name = "txt_nombre_usuario";
            this.txt_nombre_usuario.Size = new System.Drawing.Size(100, 20);
            this.txt_nombre_usuario.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(135, 28);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 13);
            this.label9.TabIndex = 5;
            this.label9.Text = "Nombre Usuario";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(50, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(18, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "ID";
            // 
            // txt_usuario_id
            // 
            this.txt_usuario_id.Location = new System.Drawing.Point(74, 21);
            this.txt_usuario_id.Mask = "9999";
            this.txt_usuario_id.Name = "txt_usuario_id";
            this.txt_usuario_id.Size = new System.Drawing.Size(28, 20);
            this.txt_usuario_id.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_fecha);
            this.groupBox2.Controls.Add(this.txt_Fecha);
            this.groupBox2.Controls.Add(this.txt_sueldo_neto);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.txt_sueldo_bruto);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Location = new System.Drawing.Point(15, 250);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(356, 121);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos Liquidacion";
            // 
            // btn_fecha
            // 
            this.btn_fecha.Location = new System.Drawing.Point(253, 35);
            this.btn_fecha.Name = "btn_fecha";
            this.btn_fecha.Size = new System.Drawing.Size(75, 23);
            this.btn_fecha.TabIndex = 5;
            this.btn_fecha.Text = "Fecha";
            this.btn_fecha.UseVisualStyleBackColor = true;
            this.btn_fecha.Click += new System.EventHandler(this.btn_fecha_Click);
            // 
            // txt_Fecha
            // 
            this.txt_Fecha.Location = new System.Drawing.Point(253, 64);
            this.txt_Fecha.Mask = "00/00/0000";
            this.txt_Fecha.Name = "txt_Fecha";
            this.txt_Fecha.Size = new System.Drawing.Size(70, 20);
            this.txt_Fecha.TabIndex = 4;
            this.txt_Fecha.ValidatingType = typeof(System.DateTime);
            // 
            // txt_sueldo_neto
            // 
            this.txt_sueldo_neto.Enabled = false;
            this.txt_sueldo_neto.Location = new System.Drawing.Point(84, 85);
            this.txt_sueldo_neto.Mask = "99999999.99";
            this.txt_sueldo_neto.Name = "txt_sueldo_neto";
            this.txt_sueldo_neto.Size = new System.Drawing.Size(70, 20);
            this.txt_sueldo_neto.TabIndex = 3;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(9, 85);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(66, 13);
            this.label17.TabIndex = 2;
            this.label17.Text = "Sueldo Neto";
            // 
            // txt_sueldo_bruto
            // 
            this.txt_sueldo_bruto.Enabled = false;
            this.txt_sueldo_bruto.Location = new System.Drawing.Point(83, 32);
            this.txt_sueldo_bruto.Mask = "99999999.99";
            this.txt_sueldo_bruto.Name = "txt_sueldo_bruto";
            this.txt_sueldo_bruto.Size = new System.Drawing.Size(70, 20);
            this.txt_sueldo_bruto.TabIndex = 1;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(9, 35);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(68, 13);
            this.label14.TabIndex = 0;
            this.label14.Text = "Sueldo Bruto";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txt_año);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.txt_mes);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Location = new System.Drawing.Point(15, 185);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(356, 51);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Periodo Remuneracion";
            // 
            // txt_año
            // 
            this.txt_año.Location = new System.Drawing.Point(224, 23);
            this.txt_año.Name = "txt_año";
            this.txt_año.Size = new System.Drawing.Size(44, 20);
            this.txt_año.TabIndex = 3;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(192, 26);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(26, 13);
            this.label16.TabIndex = 2;
            this.label16.Text = "Año";
            // 
            // txt_mes
            // 
            this.txt_mes.Location = new System.Drawing.Point(157, 23);
            this.txt_mes.Name = "txt_mes";
            this.txt_mes.Size = new System.Drawing.Size(19, 20);
            this.txt_mes.TabIndex = 1;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(126, 26);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(27, 13);
            this.label15.TabIndex = 0;
            this.label15.Text = "Mes";
            // 
            // btn_buscar
            // 
            this.btn_buscar.Location = new System.Drawing.Point(277, 387);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(75, 35);
            this.btn_buscar.TabIndex = 6;
            this.btn_buscar.Text = "Buscar";
            this.toolTip1.SetToolTip(this.btn_buscar, "Oprima para buscar Usuario a Liquidar");
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // btn_grabar
            // 
            this.btn_grabar.Location = new System.Drawing.Point(172, 388);
            this.btn_grabar.Name = "btn_grabar";
            this.btn_grabar.Size = new System.Drawing.Size(75, 34);
            this.btn_grabar.TabIndex = 5;
            this.btn_grabar.Text = "Grabar";
            this.toolTip1.SetToolTip(this.btn_grabar, "Grabar Liquidacion");
            this.btn_grabar.UseVisualStyleBackColor = true;
            this.btn_grabar.Click += new System.EventHandler(this.btn_grabar_Click);
            // 
            // cmb_descuento
            // 
            this.cmb_descuento.FormattingEnabled = true;
            this.cmb_descuento.Location = new System.Drawing.Point(617, 220);
            this.cmb_descuento.Name = "cmb_descuento";
            this.cmb_descuento.Pp_descripcion = null;
            this.cmb_descuento.Pp_PK = null;
            this.cmb_descuento.Pp_tabla = null;
            this.cmb_descuento.Size = new System.Drawing.Size(126, 21);
            this.cmb_descuento.TabIndex = 12;
            this.cmb_descuento.SelectionChangeCommitted += new System.EventHandler(this.cmb_descuento_SelectionChangeCommitted);
            // 
            // cmb_asignaciones
            // 
            this.cmb_asignaciones.FormattingEnabled = true;
            this.cmb_asignaciones.Location = new System.Drawing.Point(617, 13);
            this.cmb_asignaciones.Name = "cmb_asignaciones";
            this.cmb_asignaciones.Pp_descripcion = null;
            this.cmb_asignaciones.Pp_PK = null;
            this.cmb_asignaciones.Pp_tabla = null;
            this.cmb_asignaciones.Size = new System.Drawing.Size(126, 21);
            this.cmb_asignaciones.TabIndex = 7;
            this.cmb_asignaciones.SelectionChangeCommitted += new System.EventHandler(this.cmb_asignaciones_SelectionChangeCommitted);
            // 
            // grid_descuento
            // 
            this.grid_descuento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_descuento.Location = new System.Drawing.Point(391, 276);
            this.grid_descuento.Name = "grid_descuento";
            this.grid_descuento.Size = new System.Drawing.Size(352, 121);
            this.grid_descuento.TabIndex = 2;
            this.grid_descuento.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.grid_descuento_CellMouseDoubleClick);
            // 
            // grid_asignaciones
            // 
            this.grid_asignaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_asignaciones.Location = new System.Drawing.Point(391, 86);
            this.grid_asignaciones.Name = "grid_asignaciones";
            this.grid_asignaciones.Size = new System.Drawing.Size(352, 116);
            this.grid_asignaciones.TabIndex = 0;
            this.grid_asignaciones.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.grid_asignaciones_CellMouseDoubleClick);
            // 
            // FRM_ModificacionSueldos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_grabar);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_agregar_descu);
            this.Controls.Add(this.txt_cantidad_descu);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btn_agregar_asigna);
            this.Controls.Add(this.txt_cantidad_asigna);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_valor_descuentos);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_valor_asignaciones);
            this.Controls.Add(this.cmb_descuento);
            this.Controls.Add(this.cmb_asignaciones);
            this.Controls.Add(this.grid_descuento);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grid_asignaciones);
            this.Name = "FRM_ModificacionSueldos";
            this.Text = "Modificacion De Sueldos";
            this.Load += new System.EventHandler(this.FRM_LiquidacionSueldos_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_descuento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_asignaciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Clasess.Grid01 grid_asignaciones;
        private System.Windows.Forms.Label label1;
        private Clasess.Grid01 grid_descuento;
        private Clasess.ComboBox01 cmb_asignaciones;
        private Clasess.ComboBox01 cmb_descuento;
        private System.Windows.Forms.MaskedTextBox txt_valor_asignaciones;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox txt_valor_descuentos;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox txt_cantidad_asigna;
        private System.Windows.Forms.Button btn_agregar_asigna;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox txt_cantidad_descu;
        private System.Windows.Forms.Button btn_agregar_descu;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_apellido;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_nombre_usuario;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MaskedTextBox txt_usuario_id;
        private System.Windows.Forms.MaskedTextBox txt_cuil;
        private System.Windows.Forms.TextBox txt_perfil;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.MaskedTextBox txt_sueldo_bruto;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btn_grabar;
        private System.Windows.Forms.TextBox txt_año;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txt_mes;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.MaskedTextBox txt_sueldo_neto;
        private System.Windows.Forms.MaskedTextBox txt_Fecha;
        private System.Windows.Forms.Button btn_fecha;
    }
}