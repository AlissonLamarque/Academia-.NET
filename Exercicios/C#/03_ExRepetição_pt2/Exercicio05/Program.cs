/*
5. Modifique o programa em VS anterior para aceitar votos nulos 
(qualquer nome diferente de FIM, JOAO, ZECA e BRANCO). 
Ao final, informe o nome do candidato vencedor, o número de votos nulos 
e o número de pessoas que votaram.
 */

public class Exercicio05
{
    public static void Main()
    {
        int joao = 0, zeca = 0, branco = 0, nulo = 0, cont = 0;

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
                cont++;
            }
            if (voto == "ZECA")
            {
                zeca++;
                cont++;
            }
            if (voto == "BRANCO")
            {
                branco++;
                cont++;
            }
            if (voto != "JOAO" && voto != "ZECA" && voto != "BRANCO")
            {
                nulo++;
                cont++;
            }
        } while (true);

        if (joao > zeca)
        {
            Console.WriteLine($"Vencedor: João\nNr votos nulos: {nulo}\nNr eleitores: {cont}");
        }

    }
}