using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana_5
{
    class Cola
    {
        public string dato { get; set; }
        public Cola siguiente { get; set; }

        public Cola(string dato)
        {
            this.dato = dato;
            this.siguiente = null;
        }
        public Cola()
        {
           
        }
    }
}
