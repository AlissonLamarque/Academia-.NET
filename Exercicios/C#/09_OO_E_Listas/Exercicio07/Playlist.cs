using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio07
{
    internal class Playlist
    {
        static List<Musica> playlist = new List<Musica>();
        private Random random = new Random();

        public string donoPlaylist {  get; set; }

        public void adicionarMusicas(Musica musica)
        {
            playlist.Add(musica);
        }

        public void escutarMusicas()
        {
            List<Musica> musicasNaoTocadas = new List<Musica>(playlist);

            while (musicasNaoTocadas.Count > 0)
            {
                int nrAleatorio = random.Next(0, musicasNaoTocadas.Count);
                Musica musicaAtual = musicasNaoTocadas[nrAleatorio];

                Console.WriteLine($"Tocando '{musicaAtual.nome}'");
                Thread.Sleep(1500);

                musicasNaoTocadas.Remove(musicaAtual);
            }
        }

        public void listarMusicas()
        {
            foreach (Musica musica in playlist)
            {
                Console.WriteLine($"Nome: {musica.nome} - Autor: {musica.autor} - Gravadora: {musica.gravadora}");
            }
        }
    }
}
