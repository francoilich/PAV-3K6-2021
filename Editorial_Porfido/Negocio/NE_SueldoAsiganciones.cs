using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Editorial_Porfido.Clasess;
using System.Data;
namespace Editorial_Porfido.Negocio
{
    class NE_SueldoAsiganciones
    {
        BE_Acceso_BD_T _BD = new BE_Acceso_BD_T();

        public DataTable RecuperarAsignaciones(string id_usuario, string mes, string anno)
        {
            string SqlSelect = @"SELECT sa.id_asignacion, a.n_asignacion, sa.cantidad, sa.monto
                                 FROM SueldosAsignaciones sa JOIN asignaciones a 
                                                  ON sa.id_asignacion = a.id_asignacion
                                 WHERE id_usuario = " + id_usuario
                                 + " AND mes = " + mes
                                 + " AND anno = " + anno;
            return _BD.EjecutarSelect(SqlSelect);
        }
    }
}

