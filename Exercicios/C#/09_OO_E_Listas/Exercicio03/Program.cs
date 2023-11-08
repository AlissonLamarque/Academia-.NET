using Exercicio03;

public class Exercicio3
{
    public static void Main()
    {
        int op;
        bool opV;

        CorretoraDeImóveis imovel = new CorretoraDeImóveis("", "", 0);

        do
        {
            Console.Clear();
            Console.WriteLine("CORRETORA DE IMÓVEIS");
            Console.WriteLine("1 - Cadastrar imóvel\n2 - Atualizar valor\n3 - Listar imóveis\n4 - Sair");
            Console.Write("Sua opção: ");
            opV = int.TryParse(Console.ReadLine(), out op);

            switch (op)
            {
                case 1:
                    imovel.CadastrarImovel();
                    break;
                case 2:
                    imovel.AtualizarValor();
                    break;
                case 3:
                    imovel.ListarImovel();
                    break;
                case 4:
                    Console.WriteLine("Obrigado pela preferência! Saindo do sistema...");
                    break;
                default:
                    Console.WriteLine("Opção inválida! Tente novamente.");
                    break;
            }
        } while (op != 4);
    }
}
