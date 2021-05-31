
namespace Editorial_Porfido.Formularios
{
    partial class Frm_borrar_suscripcion
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
            this.btn_salir = new System.Windows.Forms.Button();
            this.btn_borrar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_cod_suscripcion = new System.Windows.Forms.Label();
            this.txt_forma_pago = new System.Windows.Forms.TextBox();
            this.txt_fecha_fin = new System.Windows.Forms.TextBox();
            this.txt_fecha_inicio = new System.Windows.Forms.TextBox();
            this.txt_cod_revista = new System.Windows.Forms.TextBox();
            this.txt_id_suscripcion = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_salir
            // 
            this.btn_salir.Location = new System.Drawing.Point(203, 260);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(89, 32);
            this.btn_salir.TabIndex = 5;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // btn_borrar
            // 
            this.btn_borrar.Location = new System.Drawing.Point(78, 260);
            this.btn_borrar.Name = "btn_borrar";
            this.btn_borrar.Size = new System.Drawing.Size(90, 32);
            this.btn_borrar.TabIndex = 4;
            this.btn_borrar.Text = "Borrar";
            this.btn_borrar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btn_borrar.UseVisualStyleBackColor = true;
            this.btn_borrar.Click += new System.EventHandler(this.btn_borrar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_cod_suscripcion);
            this.groupBox1.Controls.Add(this.txt_forma_pago);
            this.groupBox1.Controls.Add(this.txt_fecha_fin);
            this.groupBox1.Controls.Add(this.txt_fecha_inicio);
            this.groupBox1.Controls.Add(this.txt_cod_revista);
            this.groupBox1.Controls.Add(this.txt_id_suscripcion);
            this.groupBox1.Location = new System.Drawing.Point(5, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(355, 244);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(79, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Forma de pago:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(106, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Fecha fin:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(93, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Fecha inicio:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(83, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Codigo revista:";
            // 
            // txt_cod_suscripcion
            // 
            this.txt_cod_suscripcion.AutoSize = true;
            this.txt_cod_suscripcion.Location = new System.Drawing.Point(59, 52);
            this.txt_cod_suscripcion.Name = "txt_cod_suscripcion";
            this.txt_cod_suscripcion.Size = new System.Drawing.Size(101, 13);
            this.txt_cod_suscripcion.TabIndex = 7;
            this.txt_cod_suscripcion.Text = "Codigo Suscripcion:";
            // 
            // txt_forma_pago
            // 
            this.txt_forma_pago.Location = new System.Drawing.Point(166, 190);
            this.txt_forma_pago.Name = "txt_forma_pago";
            this.txt_forma_pago.Size = new System.Drawing.Size(100, 20);
            this.txt_forma_pago.TabIndex = 4;
            // 
            // txt_fecha_fin
            // 
            this.txt_fecha_fin.Location = new System.Drawing.Point(166, 157);
            this.txt_fecha_fin.Name = "txt_fecha_fin";
            this.txt_fecha_fin.Size = new System.Drawing.Size(100, 20);
            this.txt_fecha_fin.TabIndex = 3;
            // 
            // txt_fecha_inicio
            // 
            this.txt_fecha_inicio.Location = new System.Drawing.Point(166, 122);
            this.txt_fecha_inicio.Name = "txt_fecha_inicio";
            this.txt_fecha_inicio.Size = new System.Drawing.Size(100, 20);
            this.txt_fecha_inicio.TabIndex = 2;
            // 
            // txt_cod_revista
            // 
            this.txt_cod_revista.Location = new System.Drawing.Point(166, 87);
            this.txt_cod_revista.Name = "txt_cod_revista";
            this.txt_cod_revista.Size = new System.Drawing.Size(100, 20);
            this.txt_cod_revista.TabIndex = 1;
            // 
            // txt_id_suscripcion
            // 
            this.txt_id_suscripcion.Enabled = false;
            this.txt_id_suscripcion.Location = new System.Drawing.Point(166, 49);
            this.txt_id_suscripcion.Name = "txt_id_suscripcion";
            this.txt_id_suscripcion.Size = new System.Drawing.Size(100, 20);
            this.txt_id_suscripcion.TabIndex = 0;
            // 
            // Frm_borrar_suscripcion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 306);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.btn_borrar);
            this.Controls.Add(this.groupBox1);
            this.Name = "Frm_borrar_suscripcion";
            this.Text = "Borrar Suscripcion";
            this.Load += new System.EventHandler(this.Frm_borrar_suscripcion_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.Button btn_borrar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label txt_cod_suscripcion;
        private System.Windows.Forms.TextBox txt_forma_pago;
        private System.Windows.Forms.TextBox txt_fecha_fin;
        private System.Windows.Forms.TextBox txt_fecha_inicio;
        private System.Windows.Forms.TextBox txt_cod_revista;
        private System.Windows.Forms.TextBox txt_id_suscripcion;
    }
}