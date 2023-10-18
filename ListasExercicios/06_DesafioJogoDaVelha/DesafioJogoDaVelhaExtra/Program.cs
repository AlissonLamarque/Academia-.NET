
public class DesafioJogoDaVelhaExtra
{
    public static void Main()
    {
        int op;

        do
        {
            Console.WriteLine("\r\n     ██╗ ██████╗  ██████╗  ██████╗     ██████╗  █████╗     ██╗   ██╗███████╗██╗     ██╗  ██╗ █████╗ \r\n     ██║██╔═══██╗██╔════╝ ██╔═══██╗    ██╔══██╗██╔══██╗    ██║   ██║██╔════╝██║     ██║  ██║██╔══██╗" +
                "\r\n     ██║██║   ██║██║  ███╗██║   ██║    ██║  ██║███████║    ██║   ██║█████╗  ██║     ███████║███████║\r\n██   ██║██║   ██║██║   ██║██║   ██║    ██║  ██║██╔══██║    ╚██╗ ██╔╝██╔══╝  ██║     ██╔══██║██╔══██║\r\n╚█████╔╝╚██████╔╝" +
                "╚██████╔╝╚██████╔╝    ██████╔╝██║  ██║     ╚████╔╝ ███████╗███████╗██║  ██║██║  ██║\r\n ╚════╝  ╚═════╝  ╚═════╝  ╚═════╝     ╚═════╝ ╚═╝  ╚═╝      ╚═══╝  ╚══════╝╚══════╝╚═╝  ╚═╝╚═╝  ╚═╝\r\n                                        " +
                "                                                            \r\n");

            Console.Write("Que modo deseja jogar?\n1 - P vs P\n2 - P vs PC\n3 - Sair\nSua opção: ");
            op = int.Parse(Console.ReadLine());

            switch (op)
            {
                case 1: 
                    Console.WriteLine("Você escolheu P vs P");
                    break;
                case 2: 
                    Console.WriteLine("Você escolheu P vs PC");
                    break;
                case 3:
                    Console.WriteLine("Obrigado por jogar! Saindo do sistema...");
                    break;
                default: 
                    Console.WriteLine("Opção inválida! Tente novamente.");
                    break;
            }
        } while (op != 3);
    }
}