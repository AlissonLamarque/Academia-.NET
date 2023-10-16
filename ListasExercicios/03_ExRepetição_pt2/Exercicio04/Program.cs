/* 4. Em uma cidadezinha do interior há dois candidatos para prefeito (JOAO e ZECA). 
Você foi contratado para fazer um programa em VS que conte os votos dos candidatos. 
Cada vez que o usuário digitar JOAO, você deve somar um ao seu número de votos. O mesmo para ZECA. 
Você também pode aceitar votos em branco (palavra BRANCO). O programa em VS termina quando o usuário 
escrever FIM. Ao final devem ser mostradas as quantidades de votos para cada um dos candidatos e o número 
de votos em branco.  */

public class Exercicio04
{
    public static void Main(string[] args)
    {
        int joao = 0, zeca = 0, branco = 0;

        do
        {
            Console.WriteLine("Digite seu voto (JOAO/ZECA/BRANCO): ");
            string voto = Console.ReadLine();


            if (voto == "FIM")
            {
                Console.WriteLine("Saindo do sistema...");
                break;
            }
            if (voto == "JOAO")
            {
                joao++;
            }
            if (voto == "ZECA")
            {
                zeca++;
            }
            if (voto == "BRANCO")
            {
                branco++;
            }
            if(voto != "JOAO" && voto != "ZECA" && voto != "BRANCO")
            {
                Console.WriteLine("Voto inválido! Tente novamente.");
            }
        } while (true);

        Console.WriteLine($"TOTAL DE VOTOS: \n Joao: {joao} votos \n Zeca: {zeca} votos \n Branco: {branco} votos");

    }
}
