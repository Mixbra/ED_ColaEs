using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana_5
{
    class Cola
    {
        public int dato { get; set; }
        public Cola siguiente { get; set; }

        public Cola(int dato)
        {
            this.dato = dato;
            this.siguiente = null;
        }
        public Cola()
        {
           
        }
    }
}
