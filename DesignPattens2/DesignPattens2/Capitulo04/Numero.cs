using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattens2.Capitulo04
{
    class Numero : IExpressao
    {
        private int numero;

        public Numero(int num)
        {
            this.numero = num;            
        }

        public int Avalia()
        {
            return this.numero;
        }
    }
}
