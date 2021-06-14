using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Editorial_Porfido.Clasess;

namespace Editorial_Porfido.Negocio
{
    class NE_SueldoPerfilHistorico
    {
        BE_Acceso_BD_T _BD = new BE_Acceso_BD_T();
        public string RecuerarUltimoSueldo(string id)
        {
            string sql = @"SELECT sph.sueldo
                           FROM SueldoPerfilHistorico sph
                           WHERE sph.id_perfil = " + id
                           + @" AND sph.fecha = (SELECT Max(sph2.fecha)  
                                   FROM SueldoPerfilHistorico sph2 
                                   WHERE sph2.id_perfil = " + id + ")";

            return _BD.EjecutarSelect(sql).Rows[0][0].ToString();
        }
    }
}
