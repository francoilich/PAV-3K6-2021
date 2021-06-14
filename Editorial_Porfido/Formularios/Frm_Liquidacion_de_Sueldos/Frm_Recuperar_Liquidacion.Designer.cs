
namespace Editorial_Porfido.Formularios.Frm_Liquidacion_de_Sueldos
{
    partial class Frm_Recuperar_Liquidacion
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
            this.txt_id_usuario = new System.Windows.Forms.MaskedTextBox();
            this.txt_mes = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_anno = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.Grid01 = new Editorial_Porfido.Clasess.Grid01();
            this.btn_modificar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Grid01)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "id Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(57, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sueldos Liquidacion";
            // 
            // txt_id_usuario
            // 
            this.txt_id_usuario.Location = new System.Drawing.Point(99, 62);
            this.txt_id_usuario.Mask = "9999";
            this.txt_id_usuario.Name = "txt_id_usuario";
            this.txt_id_usuario.Size = new System.Drawing.Size(35, 20);
            this.txt_id_usuario.TabIndex = 2;
            // 
            // txt_mes
            // 
            this.txt_mes.Location = new System.Drawing.Point(182, 63);
            this.txt_mes.Mask = "99";
            this.txt_mes.Name = "txt_mes";
            this.txt_mes.Size = new System.Drawing.Size(35, 20);
            this.txt_mes.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(149, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Mes";
            // 
            // txt_anno
            // 
            this.txt_anno.Location = new System.Drawing.Point(265, 62);
            this.txt_anno.Mask = "9999";
            this.txt_anno.Name = "txt_anno";
            this.txt_anno.Size = new System.Drawing.Size(35, 20);
            this.txt_anno.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(233, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Año";
            // 
            // btn_buscar
            // 
            this.btn_buscar.Location = new System.Drawing.Point(325, 63);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(75, 23);
            this.btn_buscar.TabIndex = 7;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // Grid01
            // 
            this.Grid01.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid01.Location = new System.Drawing.Point(61, 119);
            this.Grid01.Name = "Grid01";
            this.Grid01.Size = new System.Drawing.Size(617, 235);
            this.Grid01.TabIndex = 8;
            // 
            // btn_modificar
            // 
            this.btn_modificar.Location = new System.Drawing.Point(59, 392);
            this.btn_modificar.Name = "btn_modificar";
            this.btn_modificar.Size = new System.Drawing.Size(75, 23);
            this.btn_modificar.TabIndex = 9;
            this.btn_modificar.Text = "Modificar";
            this.btn_modificar.UseVisualStyleBackColor = true;
            this.btn_modificar.Click += new System.EventHandler(this.btn_modificar_Click);
            // 
            // Frm_Recuperar_Liquidacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_modificar);
            this.Controls.Add(this.Grid01);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.txt_anno);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_mes);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_id_usuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Frm_Recuperar_Liquidacion";
            this.Text = "Recuperar Liquidacion";
            this.Load += new System.EventHandler(this.Frm_Recuperar_Liquidacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Grid01)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox txt_id_usuario;
        private System.Windows.Forms.MaskedTextBox txt_mes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox txt_anno;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_buscar;
        private Clasess.Grid01 Grid01;
        private System.Windows.Forms.Button btn_modificar;
    }
}