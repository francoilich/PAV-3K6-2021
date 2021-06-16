using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Editorial_Porfido.Clasess;

namespace Editorial_Porfido.Negocio
{
    class NE_Regalo
    {
        public string Pp_id_regalo { get; set; }
        public string Pp_nombre { get; set; }
        public string Pp_descripcion { get; set; }
        public string Pp_plan { get; set; }
        public string Pp_tipo_regalo { get; set; }

        BE_Acceso_Datos_T BD = new BE_Acceso_Datos_T();
        public EstructuraComboBox DatosCombo()
        {
            EstructuraComboBox edc = new EstructuraComboBox();
            edc.Value = "id_tipo_regalo";
            edc.Display = "nombre";
            edc.Sql = "SELECT * FROM TipoRegalo";
            edc.Tabla = BD.EjecutarSelect(edc.Sql);
            return edc;
        }

        public DataTable RecuperarTodo()
        {
            string sql = @"Select * from Plan_Revista";
            return BD.EjecutarSelect(sql);

        }
        public DataTable RecuperarTodoTipoRegalo()
        {
            string sql = @"SELECT * FROM TipoRegalo";
            return BD.EjecutarSelect(sql);

        }
        public void insertar()
        {
            string sql = @"insert regalo (id_regalo, nombre, descripcion, id_tipo_regalo, id_plan)"
                        + "values(" + Pp_id_regalo
                        + ",'" + Pp_nombre + "'"
                        + ",'" + Pp_descripcion + "'"
                        + "," + Pp_tipo_regalo
                        + "," + Pp_plan + ")";
            BD.Insertar(sql);
        }
    }
}
