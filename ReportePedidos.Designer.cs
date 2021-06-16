
namespace Editorial_Porfido.Reportee
{
    partial class ReportePedidos
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.rb_nombre = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.rb_todas = new System.Windows.Forms.RadioButton();
            this.rb_precios = new System.Windows.Forms.RadioButton();
            this.rb_fechas = new System.Windows.Forms.RadioButton();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Location = new System.Drawing.Point(22, 169);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(759, 259);
            this.reportViewer1.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 426);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.radioButton3);
            this.tabPage1.Controls.Add(this.radioButton2);
            this.tabPage1.Controls.Add(this.rb_fechas);
            this.tabPage1.Controls.Add(this.rb_precios);
            this.tabPage1.Controls.Add(this.rb_todas);
            this.tabPage1.Controls.Add(this.rb_nombre);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.btn_buscar);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(768, 400);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = " Listado de Pedidos";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(295, 37);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(65, 20);
            this.textBox1.TabIndex = 2;
            // 
            // btn_buscar
            // 
            this.btn_buscar.Location = new System.Drawing.Point(609, 78);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(75, 23);
            this.btn_buscar.TabIndex = 1;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(245, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(768, 400);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // rb_nombre
            // 
            this.rb_nombre.AutoSize = true;
            this.rb_nombre.Location = new System.Drawing.Point(428, 38);
            this.rb_nombre.Name = "rb_nombre";
            this.rb_nombre.Size = new System.Drawing.Size(122, 17);
            this.rb_nombre.TabIndex = 3;
            this.rb_nombre.TabStop = true;
            this.rb_nombre.Text = "Nombre de la revista";
            this.rb_nombre.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(323, 192);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(122, 17);
            this.radioButton2.TabIndex = 4;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Nombre de la revista";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(331, 200);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(122, 17);
            this.radioButton3.TabIndex = 5;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Nombre de la revista";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // rb_todas
            // 
            this.rb_todas.AutoSize = true;
            this.rb_todas.Location = new System.Drawing.Point(428, 61);
            this.rb_todas.Name = "rb_todas";
            this.rb_todas.Size = new System.Drawing.Size(55, 17);
            this.rb_todas.TabIndex = 3;
            this.rb_todas.TabStop = true;
            this.rb_todas.Text = "Todas";
            this.rb_todas.UseVisualStyleBackColor = true;
            // 
            // rb_precios
            // 
            this.rb_precios.AutoSize = true;
            this.rb_precios.Location = new System.Drawing.Point(428, 84);
            this.rb_precios.Name = "rb_precios";
            this.rb_precios.Size = new System.Drawing.Size(109, 17);
            this.rb_precios.TabIndex = 3;
            this.rb_precios.TabStop = true;
            this.rb_precios.Text = "Rango de precios";
            this.rb_precios.UseVisualStyleBackColor = true;
            // 
            // rb_fechas
            // 
            this.rb_fechas.AutoSize = true;
            this.rb_fechas.Location = new System.Drawing.Point(428, 107);
            this.rb_fechas.Name = "rb_fechas";
            this.rb_fechas.Size = new System.Drawing.Size(107, 17);
            this.rb_fechas.TabIndex = 3;
            this.rb_fechas.TabStop = true;
            this.rb_fechas.Text = "Rango de fechas";
            this.rb_fechas.UseVisualStyleBackColor = true;
            // 
            // ReporteDistribucion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.tabControl1);
            this.Name = "ReporteDistribucion";
            this.Text = "ReporteDistribucion";
            this.Load += new System.EventHandler(this.ReportePedidos_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton rb_fechas;
        private System.Windows.Forms.RadioButton rb_precios;
        private System.Windows.Forms.RadioButton rb_todas;
        private System.Windows.Forms.RadioButton rb_nombre;
    }
}