using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace Controller
{
    public class File
    {
        public static void Write(List<QuantasJaFiz> lista)
        {
            using(StreamWriter file = new StreamWriter(@"C:\Users\Luiz Sena\source\repos\LuizGustavoSena\QuantasJafiz\QuantasJafiz\Entregas.dat"))
            {
                foreach (QuantasJaFiz i in lista)
                    file.WriteLine(i.Consultar());
            }
        }

        public static void Read(List<QuantasJaFiz> lista)
        {
            if (File.Exists(@"C:\Users\Luiz Sena\source\repos\LuizGustavoSena\QuantasJafiz\QuantasJafiz\Entregas.dat"))
            {
                using (StreamReader file = new StreamReader(@"C:\Users\Luiz Sena\source\repos\LuizGustavoSena\QuantasJafiz\QuantasJafiz\Entregas.dat"))
                {
                    while (!file.EndOfStream)
                    {
                        string line = file.ReadLine();
                        int valor;
                        string descricao;
                        byte var;
                        bool pago = false;

                        valor = int.Parse(line.Substring(0, 1));

                        descricao = line.Substring(1, 15).Trim();

                        var = byte.Parse(line.Substring(15, 1));

                        if (var == 1)
                            pago = true;

                        lista.Add(new QuantasJaFiz { Valor = valor, Descricao = descricao, Pago = pago });
                    }
                }
            }
        }
    }
}
