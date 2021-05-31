
namespace Editorial_Porfido.Formularios
{
    partial class Frm_agregar_suscripcion
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
            this.Aceptar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txt = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_suscripcion = new Editorial_Porfido.Clasess.TextBox01();
            this.txt_cod_revista = new Editorial_Porfido.Clasess.TextBox01();
            this.txt_fecha_inicio = new Editorial_Porfido.Clasess.TextBox01();
            this.txt_fecha_fin = new Editorial_Porfido.Clasess.TextBox01();
            this.cmb_forma_pago = new Editorial_Porfido.Clasess.ComboBox01();
            this.SuspendLayout();
            // 
            // Aceptar
            // 
            this.Aceptar.Location = new System.Drawing.Point(63, 253);
            this.Aceptar.Name = "Aceptar";
            this.Aceptar.Size = new System.Drawing.Size(75, 23);
            this.Aceptar.TabIndex = 0;
            this.Aceptar.Text = "Aceptar";
            this.Aceptar.UseVisualStyleBackColor = true;
            this.Aceptar.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(165, 253);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // txt
            // 
            this.txt.AutoSize = true;
            this.txt.Location = new System.Drawing.Point(36, 16);
            this.txt.Name = "txt";
            this.txt.Size = new System.Drawing.Size(98, 13);
            this.txt.TabIndex = 2;
            this.txt.Text = "Codigo Suscripcion";
            this.txt.Click += new System.EventHandler(this.txt_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Codigo Revista";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(74, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Fecha inicio";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(83, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Fecha fin";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 185);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Forma Pago";
            // 
            // txt_suscripcion
            // 
            this.txt_suscripcion.Location = new System.Drawing.Point(140, 13);
            this.txt_suscripcion.Name = "txt_suscripcion";
            this.txt_suscripcion.Pp_campo = null;
            this.txt_suscripcion.Pp_MensajeError = null;
            this.txt_suscripcion.Pp_tabla = null;
            this.txt_suscripcion.Pp_Validable = false;
            this.txt_suscripcion.Size = new System.Drawing.Size(122, 20);
            this.txt_suscripcion.TabIndex = 7;
            // 
            // txt_cod_revista
            // 
            this.txt_cod_revista.Location = new System.Drawing.Point(140, 54);
            this.txt_cod_revista.Name = "txt_cod_revista";
            this.txt_cod_revista.Pp_campo = null;
            this.txt_cod_revista.Pp_MensajeError = null;
            this.txt_cod_revista.Pp_tabla = null;
            this.txt_cod_revista.Pp_Validable = false;
            this.txt_cod_revista.Size = new System.Drawing.Size(122, 20);
            this.txt_cod_revista.TabIndex = 8;
            // 
            // txt_fecha_inicio
            // 
            this.txt_fecha_inicio.Location = new System.Drawing.Point(140, 98);
            this.txt_fecha_inicio.Name = "txt_fecha_inicio";
            this.txt_fecha_inicio.Pp_campo = null;
            this.txt_fecha_inicio.Pp_MensajeError = null;
            this.txt_fecha_inicio.Pp_tabla = null;
            this.txt_fecha_inicio.Pp_Validable = false;
            this.txt_fecha_inicio.Size = new System.Drawing.Size(122, 20);
            this.txt_fecha_inicio.TabIndex = 9;
            // 
            // txt_fecha_fin
            // 
            this.txt_fecha_fin.Location = new System.Drawing.Point(140, 141);
            this.txt_fecha_fin.Name = "txt_fecha_fin";
            this.txt_fecha_fin.Pp_campo = null;
            this.txt_fecha_fin.Pp_MensajeError = null;
            this.txt_fecha_fin.Pp_tabla = null;
            this.txt_fecha_fin.Pp_Validable = false;
            this.txt_fecha_fin.Size = new System.Drawing.Size(122, 20);
            this.txt_fecha_fin.TabIndex = 10;
            // 
            // cmb_forma_pago
            // 
            this.cmb_forma_pago.FormattingEnabled = true;
            this.cmb_forma_pago.Location = new System.Drawing.Point(141, 185);
            this.cmb_forma_pago.Name = "cmb_forma_pago";
            this.cmb_forma_pago.Pp_descripcion = "nombre";
            this.cmb_forma_pago.Pp_PK = "id_forma_pago";
            this.cmb_forma_pago.Pp_tabla = "Forma_pago";
            this.cmb_forma_pago.Size = new System.Drawing.Size(121, 21);
            this.cmb_forma_pago.TabIndex = 11;
            this.cmb_forma_pago.SelectedIndexChanged += new System.EventHandler(this.cmb_forma_pago_SelectedIndexChanged);
            // 
            // Frm_agregar_suscripcion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 288);
            this.Controls.Add(this.cmb_forma_pago);
            this.Controls.Add(this.txt_fecha_fin);
            this.Controls.Add(this.txt_fecha_inicio);
            this.Controls.Add(this.txt_cod_revista);
            this.Controls.Add(this.txt_suscripcion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Aceptar);
            this.Name = "Frm_agregar_suscripcion";
            this.Text = "Agregar Suscripcion";
            this.Load += new System.EventHandler(this.Frm_agregar_suscripcion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Aceptar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label txt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private Clasess.TextBox01 txt_suscripcion;
        private Clasess.TextBox01 txt_cod_revista;
        private Clasess.TextBox01 txt_fecha_inicio;
        private Clasess.TextBox01 txt_fecha_fin;
        private Clasess.ComboBox01 cmb_forma_pago;
    }
}