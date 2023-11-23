using POO0611;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Olá, estamos no teste de animais");

        Cachorro cachorro = new Cachorro("Caramelo");
        //cachorro.Nome = "Caramelo";
        //cachorro.Especie = "SRD";
        //cachorro.Idade = 10;
        cachorro.EmitirSom();

        Gato gato = new Gato("Apollo", 7);
        //gato.Nome = "Apollo";
        //gato.Especie = "Siamês";
        //gato.Idade = 8;
        gato.EmitirSom();
        gato.Ronronar();

        cachorro.Movimentar();
    }
}