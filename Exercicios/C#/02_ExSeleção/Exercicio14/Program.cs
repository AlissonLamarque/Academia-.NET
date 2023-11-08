/* 14 - Faça um programa que peça o tamanho de um arquivo para download (em MB) e a velocidade de um 
link de Internet (em Mbps). Em seguida, calcule e informe o tempo aproximado de download 
do arquivo usando este link (em minutos). */

public class Exercicio14
{
    public static void Main()
    {
        int mb, mbps, tempoDownload;

        Console.WriteLine("Tamanho do arquivo (MB): ");
        mb = int.Parse(Console.ReadLine());
        Console.WriteLine("Tamanho do arquivo (Mbps): ");
        mbps = int.Parse(Console.ReadLine());

        tempoDownload = (mb * 8192) / mbps;

        Console.WriteLine($"Tempo aproximado de download: {tempoDownload} minutos");
    }
}