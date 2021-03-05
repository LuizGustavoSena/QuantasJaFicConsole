using System;
using System.Collections.Generic;
using System.Linq;
using Model;
using System.Text;
using System.Threading.Tasks;
using Controller;

namespace QuantasJafiz
{
    class Program
    {
        static void Main(string[] args)
        {
            QuantasJaFiz quantasJaFiz;
            List<QuantasJaFiz> lista = new List<QuantasJaFiz>();
            byte op;
            do
            {
                op = Menu();

                Console.Clear();

                switch (op)
                {
                    case 1: // INSERIR ENTREGA 

                        lista.Add(lerEntrega());

                        File.Write(lista);

                        break;
                    case 2: // IMPRIMIR ENTREGAS
                        Console.WriteLine("Valor\t|Descrição \t|Pago");
                        lista.ForEach(x => Console.WriteLine(x.ToString()));
                        break;
                    case 3: // EDITAR ENTREGA
                        break;
                }
                

            } while (op != 0);
        }

        static byte Menu()
        {
            byte op;
            string opcao;
            Console.WriteLine(">>> MENU <<<" +
                              "\n1 - Inserir nova entrega" +
                              "\n2 - Imprimir entregas" +
                              "\n3 - Editar entrega" +
                              "\n0 - Sair");
            opcao = Console.ReadLine();

            if (byte.TryParse(opcao, out op))
                return op;

            Console.WriteLine("Informação inválida");
            return Menu();
        }

        static QuantasJaFiz lerEntrega()
        {
            string valor, descricao, pago;
            double var;
            bool pag = false;

            Console.Write("Qual o valor: ");
            valor = Console.ReadLine();

            do
            {
                Console.Write("Qual a descrição (Campo Máximo 15 Caracteres: ");
                descricao = Console.ReadLine();
            } while (descricao.Length > 15);

            descricao = descricao.PadRight(15, ' ');

            Console.Write(@"Está paga 1 - Sim \ 0 - Não: ");
            pago = Console.ReadLine();
            if (pago == "1")
                pag = true;

            if (double.TryParse(valor, out var))
                return new QuantasJaFiz()
                {
                    Descricao = descricao,
                    Valor = var,
                    Pago = pag
                };

            return lerEntrega();
        }
    }
}
