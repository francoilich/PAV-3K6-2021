using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using Editorial_Porfido.Clasess;


namespace Editorial_Porfido.Clasess
{
    class ComboBox01: ComboBox
    {
        public string Pp_PK { get; set; }
        public string Pp_descripcion { get; set; }
        public string Pp_tabla { get; set; }

        /// <summary>
        /// Nombre de la tabla en la que actuará el dato ante un comando de insert
        /// </summary>
        public string Pp_NombreTabla { get; set; }
        /// <summary>
        /// Nombre del campo en el actuará el dato dentro de la tabla
        /// </summary>
        public string Pp_NombreCampo { get; set; }

        public bool Pp_Conseleccion { get; set; }
        public bool Pp_Validable { get; set; }
        public string Pp_MensajeError { get; set; }

        BE_Acceso_Datos_T _BD = new BE_Acceso_Datos_T();

        public void CargarCombo()
        {
            string sql = "SELECT " + Pp_PK + ", " + Pp_descripcion + " FROM " + Pp_tabla;
            this.DisplayMember = Pp_descripcion;
            this.ValueMember = Pp_PK;
            this.DataSource = _BD.EjecutarSelect(sql);
            if (this.Pp_Conseleccion== true)
            {
                this.SelectedIndex = 0;
            }
            else
            {
                this.SelectedIndex = -1;
            }
        }
        public void CargarCombo( EstructuraComboBox edc)
        {
            this.DisplayMember = edc.Display;
            this.ValueMember = edc.Value;
            this.DataSource = edc.Tabla;
        }
    }
}
