using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class QuantasJaFiz
    {
        public double Valor { get; set; }
        public string Descricao { get; set; }
        public bool Pago { get; set; }

        public override string ToString()
        {
            return Valor + "\t|" + Descricao + "\t|" + Pago;
        }
        public string Consultar()
        {
            byte var = 0;
            if (Pago)
                var = 1;

            return Valor + Descricao + var;
        }
    }
}
