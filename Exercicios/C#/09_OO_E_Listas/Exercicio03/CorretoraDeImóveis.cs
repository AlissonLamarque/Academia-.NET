using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio03
{
    internal class CorretoraDeImóveis
    {
        static List<CorretoraDeImóveis> ListaImoveis = new List<CorretoraDeImóveis> ();

        public string endereco;
        public double valor;
        public string tipo;

        public CorretoraDeImóveis(string end, string tipo, double valor)
        {
            this.endereco = end;
            this.tipo = tipo;
            this.valor = valor;
        }

        public void CadastrarImovel()
        {
            string endereco, tipo;
            double valor;

            Console.WriteLine("Endereço do imóvel: ");
            endereco = Console.ReadLine();
            Console.WriteLine("Tipo do imóvel: ");
            tipo = Console.ReadLine();
            Console.WriteLine("Valor do imóvel (R$): ");
            valor = double.Parse(Console.ReadLine());

            CorretoraDeImóveis imovel = new CorretoraDeImóveis(endereco, tipo, valor);

            ListaImoveis.Add(imovel);
        }

        public void AtualizarValor()
        {
            string end, tipo;
            double novoValor;
            bool imovelExiste = false;

            Console.WriteLine("Endereço do imóvel: ");
            end = Console.ReadLine();
            Console.WriteLine("Tipo do imóvel: ");
            tipo = Console.ReadLine();

            foreach (CorretoraDeImóveis imovel in ListaImoveis)
            {
                if (imovel.endereco == end && imovel.tipo == tipo)
                {
                    Console.WriteLine("Novo valor do imóvel (R$): ");
                    novoValor = double.Parse(Console.ReadLine());

                    if (novoValor < 0)
                        Console.WriteLine("Valor inválido! Cancelando processo...");
                    else
                        imovel.valor = novoValor;
                    
                    imovelExiste = true;
                }
            }
            if (!imovelExiste)
            {
                Console.WriteLine("Imóvel com a descrição fornecida não foi encontrado");
                Console.Write("Pressione ENTER para prosseguir");
                Console.Read();
            }
        }

        public void ListarImovel()
        {
            int cont = 0;
            double mediaPrecos = 0;

            foreach (CorretoraDeImóveis imovel in ListaImoveis)
            {
                Console.WriteLine ($"{imovel.tipo} (R${imovel.valor}) - {imovel.endereco}");
                mediaPrecos += imovel.valor;
                cont++;
            }
            
            mediaPrecos = mediaPrecos / cont;
            Console.WriteLine($"Media de valor dos imóveis: R${mediaPrecos:F2}");

            Console.Write("Pressione ENTER para prosseguir");
            Console.Read();
        }
    }
}
