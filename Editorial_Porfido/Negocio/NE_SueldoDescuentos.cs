using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Editorial_Porfido.Clasess;
using System.Data;

namespace Editorial_Porfido.Negocio
{
    class NE_SueldoDescuentos
    {
        BE_Acceso_BD_T _BD = new BE_Acceso_BD_T();

        public DataTable RecuperarDescuentos(string id_usuario, string mes, string anno)
        {
            string SqlSelect = @" SELECT sa.id_descuento, a.n_descuento, sa.cantidad, sa.monto
                                 FROM SueldosDescuentos sa JOIN Descuentos a 
                                                  ON sa.id_descuento = a.id_descuento
                                 WHERE id_usuario = " + id_usuario
                                 + " AND mes = " + mes
                                 + " AND anno = " + anno;
            return _BD.EjecutarSelect(SqlSelect);
        }
    }
}
