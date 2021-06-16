using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Editorial_Porfido.Clasess;

namespace Editorial_Porfido.Negocio
{
    class NE_Facturacion
    {
        public string Id_usuario { get; set; }

        BE_Acceso_BD_Transacciones _BD = new BE_Acceso_BD_Transacciones();
    }
}
