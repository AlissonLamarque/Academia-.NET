using OrientaçãoObjeto;

public class orientacaoObjeto
{
    public static void Main()
    {
        //Jogo rápido (1):
        
        Pessoa p1 = new Pessoa();
        p1.nome = "Joao";
        p1.idade = 15;

        Pessoa p2 = new Pessoa();
        p2.nome = "Maria";
        p2.idade = 29;

        Pessoa p3 = new Pessoa();
        p3.nome = "José";
        p3.idade = 30;

        Console.WriteLine($"O nome da pessoa 1 é {p1.nome} e tem {p1.idade} anos");
        Console.WriteLine($"O nome da pessoa 2 é {p2.nome} e tem {p2.idade} anos");
        Console.WriteLine($"O nome da pessoa 3 é {p3.nome} e tem {p3.idade} anos");

        //Jogo rápido (2):

        
        Professor p = new Professor();
        p.nome = "Ricardo";
        Laboratorio lab = new Laboratorio();
        lab.local = "Sala 108";

        Console.WriteLine($"O nome do professor é: {p.nome}");
        Console.WriteLine($"O local da aula é: {lab.local}");
        

        //Jogo rápido (3):

        
        Pessoa2 pp = new Pessoa2();

        Console.WriteLine("Digite o nome da pessoa: ");
        pp.nome = Console.ReadLine();
        Console.WriteLine("Digite a idade da pessoa: ");
        pp.idade = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite o genero da pessoa: ");
        pp.genero = Console.ReadLine();

        Console.WriteLine($"Nome: {pp.nome}\nIdade: {pp.idade}\nGenero: {pp.genero}");
        

        //Exercício 1

        
        Jogo j = new Jogo();

        Console.WriteLine("Digite o título do jogo: ");
        j.titulo = Console.ReadLine();
        Console.WriteLine("Digite o genero do jogo: ");
        j.genero = Console.ReadLine();
        Console.WriteLine("Digite a plataforma do jogo: ");
        j.plataforma = Console.ReadLine();
        Console.WriteLine("Digite o ano de lançamento do jogo: ");
        j.anoDeLancamento = int.Parse(Console.ReadLine());

        Console.WriteLine($"Título: {j.titulo}\nGênero: {j.genero}\nPlataforma: {j.plataforma}\nAno de lançamento: {j.anoDeLancamento}");
        

        //Exercício 2

        
        Estudio e = new Estudio();

        Console.WriteLine("Nome do estúdio: ");
        e.nome = Console.ReadLine();
        Console.WriteLine("Ano de fundação do estúdio: ");
        e.anoDeFundacao = int.Parse(Console.ReadLine());
        Console.WriteLine("País de origem do estúdio: ");
        e.paisDeOrigem = Console.ReadLine();
        Console.WriteLine("Número de jogos produzidos pelo estúdio: ");
        e.NrDeJogosProduzidos = int.Parse(Console.ReadLine());

        Console.WriteLine($"Nome: {e.nome}\nAno de fundação: {e.anoDeFundacao}\nPaís de origem: {e.paisDeOrigem}" +
            $"\nNúmero de Jogos produzidos: {e.NrDeJogosProduzidos}");
        

        //Exercício 3

        
        Carro c1 = new Carro();
        Carro c2 = new Carro();

        Console.WriteLine("Marca do carro: ");
        c1.marca = Console.ReadLine();
        Console.WriteLine("Modelo do carro: ");
        c1.modelo = Console.ReadLine();
        Console.WriteLine("Ano de fabricação do carro: ");
        c1.anoDeFabricacao = int.Parse(Console.ReadLine());

        Console.WriteLine("Marca do carro: ");
        c2.marca = Console.ReadLine();
        Console.WriteLine("Modelo do carro: ");
        c2.modelo = Console.ReadLine();
        Console.WriteLine("Ano de fabricação do carro: ");
        c2.anoDeFabricacao = int.Parse(Console.ReadLine());

        Console.WriteLine($"Carro 1\nMarca: {c1.marca}\nModelo: {c1.modelo}\nAno de fabricação: {c1.anoDeFabricacao}");
        Console.WriteLine($"Carro 2\nMarca: {c2.marca}\nModelo: {c2.modelo}\nAno de fabricação: {c2.anoDeFabricacao}");

        //Exercício 4

        Livro l1 = new Livro();
        Livro l2 = new Livro();
        Livro l3 = new Livro();

        l1.titulo = "LivroUm";
        l1.autor = "Alisson";
        l1.anoDePublicacao = 2021;
        l2.titulo = "LivroDois";
        l2.autor = "De Almeida";
        l2.anoDePublicacao = 2022;
        l3.titulo = "LivroTres";
        l3.autor = "Lamarque";
        l3.anoDePublicacao = 2023;

        Console.WriteLine($"Livro\nTitulo: {l1.titulo}\nAutor: {l1.autor}\nAno de publicação: {l1.anoDePublicacao}");
        Console.WriteLine($"Livro\nTitulo: {l2.titulo}\nAutor: {l2.autor}\nAno de publicação: {l2.anoDePublicacao}");
        Console.WriteLine($"Livro\nTitulo: {l3.titulo}\nAutor: {l3.autor}\nAno de publicação: {l3.anoDePublicacao}");
    }
}