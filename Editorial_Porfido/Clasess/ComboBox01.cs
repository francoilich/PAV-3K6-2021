using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

namespace Editorial_Porfido.Clasess
{
    class ComboBox01:ComboBox
    {
        public string Pp_PK { get; set; }
        public string Pp_descripcion { get; set;}
        public string Pp_tabla { get; set; }
        BE_Acceso_BD _BD = new BE_Acceso_BD();

        public void CargarCombo()
        {
            string sql = " Select " + Pp_PK + " ," + Pp_descripcion + " From " + Pp_tabla;
            this.DisplayMember = Pp_descripcion;
            this.ValueMember = Pp_PK;
            this.DataSource = _BD.Ejecutar_Select(sql);
        }
    }
}
