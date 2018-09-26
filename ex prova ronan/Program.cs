using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_prova_ronan
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                String nomeProduto;
                int quantidade;
                double valorProduto, valorTotal;

                Console.Write("Informe o nome do produto: ");
                nomeProduto = Console.ReadLine();

                Console.Write("Informe a quantidade do produto: ");
                quantidade = Convert.ToInt32(Console.ReadLine());

                Console.Write("Informe o valor produto: ");
                valorProduto = Convert.ToDouble(Console.ReadLine());

                valorTotal = quantidade * valorProduto;

                Console.Clear();
                Console.WriteLine(" ****** Venda de Produtos ****** ");
                Console.WriteLine("Produto: " + nomeProduto);
                Console.WriteLine("Qtde: " + quantidade + " x Valor Unitário: " + valorProduto.ToString("C"));
                // .ToString() -> converte o numero para Texto, o "C" -> Formata para moeda.
                Console.WriteLine("Total da Venda: " + valorTotal.ToString("C"));
            }
            catch (Exception)
            {
                Console.Clear();
                Console.WriteLine("Dados digitados inválidos!!!");

            }
            Console.ReadKey();
        }
    }
}
