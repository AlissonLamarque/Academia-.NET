using Exercicio07;

public class Program
{
    public static void Main()
    {
        string nome, autor, gravadora, dono;
        int op;
        Playlist playlist = new Playlist();
            
        Console.WriteLine("Seu nome: ");
        dono = Console.ReadLine();

        do
        {
            Console.Clear();
            Console.WriteLine($"--- Playlist de {dono} ---");
            Console.WriteLine("1 - Adicionar música\n2 - Tocar músicas\n3 - Listar músicas\n4 - Sair");
            Console.Write("--- Sua opção: ");
            op = int.Parse(Console.ReadLine());

            switch (op)
            {
                case 1:
                    Console.WriteLine("Nome: ");
                    nome = Console.ReadLine();
                    Console.WriteLine("Autor: ");
                    autor = Console.ReadLine();
                    Console.WriteLine("Gravadora: ");
                    gravadora = Console.ReadLine();

                    Musica musica = new Musica(nome, autor, gravadora);
                    playlist.adicionarMusicas(musica);
                    break;
                case 2:
                    playlist.escutarMusicas();
                    break;
                case 3:
                    playlist.listarMusicas();
                    Console.Write("Pressione ENTER para continuar");
                    Console.ReadKey();
                    break;
                case 4:
                    Console.WriteLine("Obrigado pela preferência! Saindo do sistema...");
                    break;
            }
        } while (op != 4);
    }
}