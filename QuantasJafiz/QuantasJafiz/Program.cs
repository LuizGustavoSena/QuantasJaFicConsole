using System;
using System.Collections.Generic;
using System.Linq;
using Model;
using System.Text;
using System.Threading.Tasks;

namespace QuantasJafiz
{
    class Program
    {
        static void Main(string[] args)
        {
            QuantasJaFiz quantasJaFiz;
            List<QuantasJaFiz> lista = new List<QuantasJaFiz>();

            do
            {

            } while (true);
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

            Console.Write("Qual a descrição: ");
            descricao = Console.ReadLine();

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
