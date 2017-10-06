using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattens2.Capitulo04
{
    class RaizQuadrada : IExpressao
    {
        private IExpressao Numero { get; }        

        public RaizQuadrada(IExpressao numero)
        {
            this.Numero = numero;            
        }

        public int Avalia()
        {
            int numero = this.Numero.Avalia();            
            return Convert.ToInt32(Math.Sqrt(Convert.ToDouble(numero)));
        }
    }
}
