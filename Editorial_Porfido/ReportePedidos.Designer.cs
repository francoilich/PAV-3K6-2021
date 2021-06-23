
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.KioscoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DS_ListaRevistas = new Editorial_Porfido.Reportee.DS_ListaRevistas();
            this.ListaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.RevistaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TipoRubroBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.rv_kiosco = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btn_calcular = new System.Windows.Forms.Button();
            this.rb_KioscoAlfa = new System.Windows.Forms.RadioButton();
            this.rb_KioscoID = new System.Windows.Forms.RadioButton();
            this.rb_KioscoBarrio = new System.Windows.Forms.RadioButton();
            this.rb_KioscoBuscarID = new System.Windows.Forms.RadioButton();
            this.rb_KioscoLetra = new System.Windows.Forms.RadioButton();
            this.rb_KioscoTodos = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.mtxt_KioscoID = new Editorial_Porfido.Clasess.LabelMaskedTextBox();
            this.mtxt_KioscoBarrio = new Editorial_Porfido.Clasess.LabelMaskedTextBox();
            this.mtxt_KioscoLetra = new Editorial_Porfido.Clasess.LabelMaskedTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.rv_revistas = new Microsoft.Reporting.WinForms.ReportViewer();
            this.mtxt_edicionRevista = new Editorial_Porfido.Clasess.LabelMaskedTextBox();
            this.rb_precio = new System.Windows.Forms.RadioButton();
            this.rb_todos = new System.Windows.Forms.RadioButton();
            this.btn_consultar = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btn_calcularRubro = new System.Windows.Forms.Button();
            this.rv_rubro = new Microsoft.Reporting.WinForms.ReportViewer();
            this.Exp_nomRubro = new Editorial_Porfido.Clasess.Selector01();
            this.ListaTableAdapter = new Editorial_Porfido.Reportee.DS_ListaRevistasTableAdapters.ListaTableAdapter();
            this.rb_edicion = new System.Windows.Forms.RadioButton();
            this.mtxt_PrecioREvista = new Editorial_Porfido.Clasess.LabelMaskedTextBox();
            this.rb_ID = new System.Windows.Forms.RadioButton();
            this.mtxt_IDrevista = new Editorial_Porfido.Clasess.LabelMaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.KioscoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS_ListaRevistas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RevistaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TipoRubroBindingSource)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // KioscoBindingSource
            // 
            this.KioscoBindingSource.DataMember = "Kiosco";
            this.KioscoBindingSource.DataSource = this.DS_ListaRevistas;
            // 
            // DS_ListaRevistas
            // 
            this.DS_ListaRevistas.DataSetName = "DS_ListaRevistas";
            this.DS_ListaRevistas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ListaBindingSource
            // 
            this.ListaBindingSource.DataMember = "Lista";
            this.ListaBindingSource.DataSource = this.DS_ListaRevistas;
            // 
            // RevistaBindingSource
            // 
            this.RevistaBindingSource.DataMember = "Revista";
            this.RevistaBindingSource.DataSource = this.DS_ListaRevistas;
            // 
            // TipoRubroBindingSource
            // 
            this.TipoRubroBindingSource.DataMember = "TipoRubro";
            this.TipoRubroBindingSource.DataSource = this.DS_ListaRevistas;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.rv_kiosco);
            this.tabPage3.Controls.Add(this.btn_calcular);
            this.tabPage3.Controls.Add(this.rb_KioscoAlfa);
            this.tabPage3.Controls.Add(this.rb_KioscoID);
            this.tabPage3.Controls.Add(this.rb_KioscoBarrio);
            this.tabPage3.Controls.Add(this.rb_KioscoBuscarID);
            this.tabPage3.Controls.Add(this.rb_KioscoLetra);
            this.tabPage3.Controls.Add(this.rb_KioscoTodos);
            this.tabPage3.Controls.Add(this.groupBox1);
            this.tabPage3.Controls.Add(this.groupBox2);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(768, 400);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Listado de Kioscos";
            this.tabPage3.UseVisualStyleBackColor = true;
            this.tabPage3.Click += new System.EventHandler(this.tabPage3_Click);
            // 
            // rv_kiosco
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.KioscoBindingSource;
            this.rv_kiosco.LocalReport.DataSources.Add(reportDataSource1);
            this.rv_kiosco.LocalReport.ReportEmbeddedResource = "Editorial_Porfido.Reportee.ListadoKioscos.rdlc";
            this.rv_kiosco.Location = new System.Drawing.Point(6, 135);
            this.rv_kiosco.Name = "rv_kiosco";
            this.rv_kiosco.ServerReport.BearerToken = null;
            this.rv_kiosco.Size = new System.Drawing.Size(756, 259);
            this.rv_kiosco.TabIndex = 6;
            // 
            // btn_calcular
            // 
            this.btn_calcular.Location = new System.Drawing.Point(633, 65);
            this.btn_calcular.Name = "btn_calcular";
            this.btn_calcular.Size = new System.Drawing.Size(75, 23);
            this.btn_calcular.TabIndex = 5;
            this.btn_calcular.Text = "Calcular";
            this.btn_calcular.UseVisualStyleBackColor = true;
            this.btn_calcular.Click += new System.EventHandler(this.btn_calcular_Click);
            // 
            // rb_KioscoAlfa
            // 
            this.rb_KioscoAlfa.AutoSize = true;
            this.rb_KioscoAlfa.Location = new System.Drawing.Point(467, 79);
            this.rb_KioscoAlfa.Name = "rb_KioscoAlfa";
            this.rb_KioscoAlfa.Size = new System.Drawing.Size(72, 17);
            this.rb_KioscoAlfa.TabIndex = 1;
            this.rb_KioscoAlfa.Text = "Alfabetico";
            this.rb_KioscoAlfa.UseVisualStyleBackColor = true;
            // 
            // rb_KioscoID
            // 
            this.rb_KioscoID.AutoSize = true;
            this.rb_KioscoID.Location = new System.Drawing.Point(467, 56);
            this.rb_KioscoID.Name = "rb_KioscoID";
            this.rb_KioscoID.Size = new System.Drawing.Size(91, 17);
            this.rb_KioscoID.TabIndex = 1;
            this.rb_KioscoID.Text = "Numero de ID";
            this.rb_KioscoID.UseVisualStyleBackColor = true;
            // 
            // rb_KioscoBarrio
            // 
            this.rb_KioscoBarrio.AutoSize = true;
            this.rb_KioscoBarrio.Checked = true;
            this.rb_KioscoBarrio.Location = new System.Drawing.Point(251, 88);
            this.rb_KioscoBarrio.Name = "rb_KioscoBarrio";
            this.rb_KioscoBarrio.Size = new System.Drawing.Size(52, 17);
            this.rb_KioscoBarrio.TabIndex = 0;
            this.rb_KioscoBarrio.TabStop = true;
            this.rb_KioscoBarrio.Text = "Barrio";
            this.rb_KioscoBarrio.UseVisualStyleBackColor = true;
            // 
            // rb_KioscoBuscarID
            // 
            this.rb_KioscoBuscarID.AutoSize = true;
            this.rb_KioscoBuscarID.Location = new System.Drawing.Point(251, 65);
            this.rb_KioscoBuscarID.Name = "rb_KioscoBuscarID";
            this.rb_KioscoBuscarID.Size = new System.Drawing.Size(55, 17);
            this.rb_KioscoBuscarID.TabIndex = 0;
            this.rb_KioscoBuscarID.Text = "Por ID";
            this.rb_KioscoBuscarID.UseVisualStyleBackColor = true;
            // 
            // rb_KioscoLetra
            // 
            this.rb_KioscoLetra.AutoSize = true;
            this.rb_KioscoLetra.Location = new System.Drawing.Point(251, 42);
            this.rb_KioscoLetra.Name = "rb_KioscoLetra";
            this.rb_KioscoLetra.Size = new System.Drawing.Size(94, 17);
            this.rb_KioscoLetra.TabIndex = 0;
            this.rb_KioscoLetra.Text = "Inicia con letra";
            this.rb_KioscoLetra.UseVisualStyleBackColor = true;
            // 
            // rb_KioscoTodos
            // 
            this.rb_KioscoTodos.AutoSize = true;
            this.rb_KioscoTodos.Location = new System.Drawing.Point(251, 19);
            this.rb_KioscoTodos.Name = "rb_KioscoTodos";
            this.rb_KioscoTodos.Size = new System.Drawing.Size(55, 17);
            this.rb_KioscoTodos.TabIndex = 0;
            this.rb_KioscoTodos.Text = "Todos";
            this.rb_KioscoTodos.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.mtxt_KioscoID);
            this.groupBox1.Controls.Add(this.mtxt_KioscoBarrio);
            this.groupBox1.Controls.Add(this.mtxt_KioscoLetra);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(64, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(291, 123);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buscar por:";
            // 
            // mtxt_KioscoID
            // 
            this.mtxt_KioscoID.Location = new System.Drawing.Point(-12, 42);
            this.mtxt_KioscoID.Margin = new System.Windows.Forms.Padding(4);
            this.mtxt_KioscoID.Name = "mtxt_KioscoID";
            this.mtxt_KioscoID.Pp_Decimales = 0;
            this.mtxt_KioscoID.Pp_Etiqueta = "Rango ID";
            this.mtxt_KioscoID.Pp_Largo = 10;
            this.mtxt_KioscoID.Pp_MensajeError = null;
            this.mtxt_KioscoID.Pp_NombreCampo = null;
            this.mtxt_KioscoID.Pp_NombreTabla = null;
            this.mtxt_KioscoID.Pp_Text = "";
            this.mtxt_KioscoID.Pp_TipoDato = Editorial_Porfido.Clasess.LabelMaskedTextBox.TipoDato.texto;
            this.mtxt_KioscoID.Pp_Validable = false;
            this.mtxt_KioscoID.Size = new System.Drawing.Size(192, 36);
            this.mtxt_KioscoID.TabIndex = 3;
            // 
            // mtxt_KioscoBarrio
            // 
            this.mtxt_KioscoBarrio.Location = new System.Drawing.Point(-12, 72);
            this.mtxt_KioscoBarrio.Margin = new System.Windows.Forms.Padding(4);
            this.mtxt_KioscoBarrio.Name = "mtxt_KioscoBarrio";
            this.mtxt_KioscoBarrio.Pp_Decimales = 0;
            this.mtxt_KioscoBarrio.Pp_Etiqueta = "Barrio";
            this.mtxt_KioscoBarrio.Pp_Largo = 10;
            this.mtxt_KioscoBarrio.Pp_MensajeError = null;
            this.mtxt_KioscoBarrio.Pp_NombreCampo = null;
            this.mtxt_KioscoBarrio.Pp_NombreTabla = null;
            this.mtxt_KioscoBarrio.Pp_Text = "";
            this.mtxt_KioscoBarrio.Pp_TipoDato = Editorial_Porfido.Clasess.LabelMaskedTextBox.TipoDato.texto;
            this.mtxt_KioscoBarrio.Pp_Validable = false;
            this.mtxt_KioscoBarrio.Size = new System.Drawing.Size(192, 44);
            this.mtxt_KioscoBarrio.TabIndex = 2;
            // 
            // mtxt_KioscoLetra
            // 
            this.mtxt_KioscoLetra.Location = new System.Drawing.Point(-12, 13);
            this.mtxt_KioscoLetra.Margin = new System.Windows.Forms.Padding(4);
            this.mtxt_KioscoLetra.Name = "mtxt_KioscoLetra";
            this.mtxt_KioscoLetra.Pp_Decimales = 0;
            this.mtxt_KioscoLetra.Pp_Etiqueta = "Letra";
            this.mtxt_KioscoLetra.Pp_Largo = 10;
            this.mtxt_KioscoLetra.Pp_MensajeError = null;
            this.mtxt_KioscoLetra.Pp_NombreCampo = null;
            this.mtxt_KioscoLetra.Pp_NombreTabla = null;
            this.mtxt_KioscoLetra.Pp_Text = "";
            this.mtxt_KioscoLetra.Pp_TipoDato = Editorial_Porfido.Clasess.LabelMaskedTextBox.TipoDato.texto;
            this.mtxt_KioscoLetra.Pp_Validable = false;
            this.mtxt_KioscoLetra.Size = new System.Drawing.Size(192, 36);
            this.mtxt_KioscoLetra.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(408, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(177, 123);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Orden:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.rv_revistas);
            this.tabPage2.Controls.Add(this.mtxt_IDrevista);
            this.tabPage2.Controls.Add(this.mtxt_PrecioREvista);
            this.tabPage2.Controls.Add(this.mtxt_edicionRevista);
            this.tabPage2.Controls.Add(this.rb_ID);
            this.tabPage2.Controls.Add(this.rb_edicion);
            this.tabPage2.Controls.Add(this.rb_precio);
            this.tabPage2.Controls.Add(this.rb_todos);
            this.tabPage2.Controls.Add(this.btn_consultar);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(768, 400);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Listado de revistas";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // rv_revistas
            // 
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.ListaBindingSource;
            this.rv_revistas.LocalReport.DataSources.Add(reportDataSource2);
            this.rv_revistas.LocalReport.ReportEmbeddedResource = "Editorial_Porfido.Reportee.ListadoRevistas.rdlc";
            this.rv_revistas.Location = new System.Drawing.Point(6, 126);
            this.rv_revistas.Name = "rv_revistas";
            this.rv_revistas.ServerReport.BearerToken = null;
            this.rv_revistas.Size = new System.Drawing.Size(756, 268);
            this.rv_revistas.TabIndex = 6;
            // 
            // mtxt_edicionRevista
            // 
            this.mtxt_edicionRevista.Location = new System.Drawing.Point(42, 69);
            this.mtxt_edicionRevista.Name = "mtxt_edicionRevista";
            this.mtxt_edicionRevista.Pp_Decimales = 0;
            this.mtxt_edicionRevista.Pp_Etiqueta = "Rango";
            this.mtxt_edicionRevista.Pp_Largo = 10;
            this.mtxt_edicionRevista.Pp_MensajeError = null;
            this.mtxt_edicionRevista.Pp_NombreCampo = null;
            this.mtxt_edicionRevista.Pp_NombreTabla = null;
            this.mtxt_edicionRevista.Pp_Text = "";
            this.mtxt_edicionRevista.Pp_TipoDato = Editorial_Porfido.Clasess.LabelMaskedTextBox.TipoDato.numero;
            this.mtxt_edicionRevista.Pp_Validable = false;
            this.mtxt_edicionRevista.Size = new System.Drawing.Size(171, 36);
            this.mtxt_edicionRevista.TabIndex = 3;
            // 
            // rb_precio
            // 
            this.rb_precio.AutoSize = true;
            this.rb_precio.Location = new System.Drawing.Point(219, 36);
            this.rb_precio.Name = "rb_precio";
            this.rb_precio.Size = new System.Drawing.Size(104, 17);
            this.rb_precio.TabIndex = 2;
            this.rb_precio.TabStop = true;
            this.rb_precio.Text = "Rango de precio";
            this.rb_precio.UseVisualStyleBackColor = true;
            this.rb_precio.CheckedChanged += new System.EventHandler(this.radioButton5_CheckedChanged);
            // 
            // rb_todos
            // 
            this.rb_todos.AutoSize = true;
            this.rb_todos.Location = new System.Drawing.Point(515, 72);
            this.rb_todos.Name = "rb_todos";
            this.rb_todos.Size = new System.Drawing.Size(55, 17);
            this.rb_todos.TabIndex = 2;
            this.rb_todos.TabStop = true;
            this.rb_todos.Text = "Todos";
            this.rb_todos.UseVisualStyleBackColor = true;
            // 
            // btn_consultar
            // 
            this.btn_consultar.Location = new System.Drawing.Point(645, 69);
            this.btn_consultar.Name = "btn_consultar";
            this.btn_consultar.Size = new System.Drawing.Size(75, 23);
            this.btn_consultar.TabIndex = 1;
            this.btn_consultar.Text = "Consultar";
            this.btn_consultar.UseVisualStyleBackColor = true;
            this.btn_consultar.Click += new System.EventHandler(this.btn_consultar_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 426);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btn_calcularRubro);
            this.tabPage1.Controls.Add(this.rv_rubro);
            this.tabPage1.Controls.Add(this.Exp_nomRubro);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(768, 400);
            this.tabPage1.TabIndex = 3;
            this.tabPage1.Text = "Frecuencia de rubros";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btn_calcularRubro
            // 
            this.btn_calcularRubro.Location = new System.Drawing.Point(490, 34);
            this.btn_calcularRubro.Name = "btn_calcularRubro";
            this.btn_calcularRubro.Size = new System.Drawing.Size(79, 30);
            this.btn_calcularRubro.TabIndex = 2;
            this.btn_calcularRubro.Text = "Calcular";
            this.btn_calcularRubro.UseVisualStyleBackColor = true;
            // 
            // rv_rubro
            // 
            this.rv_rubro.Location = new System.Drawing.Point(6, 96);
            this.rv_rubro.Name = "rv_rubro";
            this.rv_rubro.ServerReport.BearerToken = null;
            this.rv_rubro.Size = new System.Drawing.Size(756, 298);
            this.rv_rubro.TabIndex = 1;
            // 
            // Exp_nomRubro
            // 
            this.Exp_nomRubro.Location = new System.Drawing.Point(85, 34);
            this.Exp_nomRubro.Name = "Exp_nomRubro";
            this.Exp_nomRubro.Pp_display = "nombre";
            this.Exp_nomRubro.Pp_Etiqueta = "Rubro";
            this.Exp_nomRubro.Pp_mensajeError = null;
            this.Exp_nomRubro.Pp_nombre_campo = null;
            this.Exp_nomRubro.Pp_nombre_tabla = null;
            this.Exp_nomRubro.Pp_tabla = "Tipo_Rubro";
            this.Exp_nomRubro.Pp_Text = "";
            this.Exp_nomRubro.Pp_validable = false;
            this.Exp_nomRubro.Pp_value = "id_tipo_rubro";
            this.Exp_nomRubro.Size = new System.Drawing.Size(342, 30);
            this.Exp_nomRubro.TabIndex = 0;
            // 
            // ListaTableAdapter
            // 
            this.ListaTableAdapter.ClearBeforeFill = true;
            // 
            // rb_edicion
            // 
            this.rb_edicion.AutoSize = true;
            this.rb_edicion.Location = new System.Drawing.Point(219, 75);
            this.rb_edicion.Name = "rb_edicion";
            this.rb_edicion.Size = new System.Drawing.Size(109, 17);
            this.rb_edicion.TabIndex = 2;
            this.rb_edicion.TabStop = true;
            this.rb_edicion.Text = "Rango de edicion";
            this.rb_edicion.UseVisualStyleBackColor = true;
            this.rb_edicion.CheckedChanged += new System.EventHandler(this.radioButton5_CheckedChanged);
            // 
            // mtxt_PrecioREvista
            // 
            this.mtxt_PrecioREvista.Location = new System.Drawing.Point(42, 27);
            this.mtxt_PrecioREvista.Name = "mtxt_PrecioREvista";
            this.mtxt_PrecioREvista.Pp_Decimales = 0;
            this.mtxt_PrecioREvista.Pp_Etiqueta = "Rango";
            this.mtxt_PrecioREvista.Pp_Largo = 10;
            this.mtxt_PrecioREvista.Pp_MensajeError = null;
            this.mtxt_PrecioREvista.Pp_NombreCampo = null;
            this.mtxt_PrecioREvista.Pp_NombreTabla = null;
            this.mtxt_PrecioREvista.Pp_Text = "";
            this.mtxt_PrecioREvista.Pp_TipoDato = Editorial_Porfido.Clasess.LabelMaskedTextBox.TipoDato.numero;
            this.mtxt_PrecioREvista.Pp_Validable = false;
            this.mtxt_PrecioREvista.Size = new System.Drawing.Size(171, 36);
            this.mtxt_PrecioREvista.TabIndex = 3;
            // 
            // rb_ID
            // 
            this.rb_ID.AutoSize = true;
            this.rb_ID.Location = new System.Drawing.Point(515, 36);
            this.rb_ID.Name = "rb_ID";
            this.rb_ID.Size = new System.Drawing.Size(86, 17);
            this.rb_ID.TabIndex = 2;
            this.rb_ID.TabStop = true;
            this.rb_ID.Text = "Rango de ID";
            this.rb_ID.UseVisualStyleBackColor = true;
            this.rb_ID.CheckedChanged += new System.EventHandler(this.radioButton5_CheckedChanged);
            // 
            // mtxt_IDrevista
            // 
            this.mtxt_IDrevista.Location = new System.Drawing.Point(329, 27);
            this.mtxt_IDrevista.Name = "mtxt_IDrevista";
            this.mtxt_IDrevista.Pp_Decimales = 0;
            this.mtxt_IDrevista.Pp_Etiqueta = "Rango";
            this.mtxt_IDrevista.Pp_Largo = 10;
            this.mtxt_IDrevista.Pp_MensajeError = null;
            this.mtxt_IDrevista.Pp_NombreCampo = null;
            this.mtxt_IDrevista.Pp_NombreTabla = null;
            this.mtxt_IDrevista.Pp_Text = "";
            this.mtxt_IDrevista.Pp_TipoDato = Editorial_Porfido.Clasess.LabelMaskedTextBox.TipoDato.numero;
            this.mtxt_IDrevista.Pp_Validable = false;
            this.mtxt_IDrevista.Size = new System.Drawing.Size(171, 36);
            this.mtxt_IDrevista.TabIndex = 3;
            // 
            // ReportePedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "ReportePedidos";
            this.Text = "Reportes y estadisticas";
            this.Load += new System.EventHandler(this.ReportePedidos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.KioscoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS_ListaRevistas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RevistaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TipoRubroBindingSource)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource RevistaBindingSource;
        private DS_ListaRevistas DS_ListaRevistas;
        private System.Windows.Forms.BindingSource TipoRubroBindingSource;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.RadioButton rb_KioscoAlfa;
        private System.Windows.Forms.RadioButton rb_KioscoID;
        private System.Windows.Forms.RadioButton rb_KioscoBarrio;
        private System.Windows.Forms.RadioButton rb_KioscoBuscarID;
        private System.Windows.Forms.RadioButton rb_KioscoLetra;
        private System.Windows.Forms.RadioButton rb_KioscoTodos;
        private System.Windows.Forms.GroupBox groupBox1;
        private Clasess.LabelMaskedTextBox mtxt_KioscoBarrio;
        private Clasess.LabelMaskedTextBox mtxt_KioscoLetra;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TabPage tabPage2;
        private Clasess.LabelMaskedTextBox mtxt_edicionRevista;
        private System.Windows.Forms.RadioButton rb_precio;
        private System.Windows.Forms.RadioButton rb_todos;
        private System.Windows.Forms.Button btn_consultar;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Button btn_calcular;
        private System.Windows.Forms.BindingSource KioscoBindingSource;
        private System.Windows.Forms.BindingSource ListaBindingSource;
        private DS_ListaRevistasTableAdapters.ListaTableAdapter ListaTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer rv_kiosco;
        private Clasess.LabelMaskedTextBox mtxt_KioscoID;
        private Microsoft.Reporting.WinForms.ReportViewer rv_revistas;
        private System.Windows.Forms.TabPage tabPage1;
        private Microsoft.Reporting.WinForms.ReportViewer rv_rubro;
        private Clasess.Selector01 Exp_nomRubro;
        private System.Windows.Forms.Button btn_calcularRubro;
        private Clasess.LabelMaskedTextBox mtxt_IDrevista;
        private Clasess.LabelMaskedTextBox mtxt_PrecioREvista;
        private System.Windows.Forms.RadioButton rb_ID;
        private System.Windows.Forms.RadioButton rb_edicion;
    }
}