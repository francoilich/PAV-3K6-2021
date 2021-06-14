using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Editorial_Porfido.Clasess
{
    class TextBox01:TextBox
    {
        public string Pp_tabla { get; set; }
        public string Pp_campo { get; set; }
        public bool Pp_Validable { get; set; }
        public string Pp_MensajeError { get; set; }

    }
}
