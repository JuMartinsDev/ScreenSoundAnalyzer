using ScreenSound04.Modelos;
using System.Linq;

namespace ScreenSound04.Filtros
{
    internal class LinkFilter
    {
        // Exibe todos os gêneros musicais distintos presentes na lista de músicas
        public static void FiltrarTodosOsGenerosMusicais(List<Musica> musicas)
        {
            var todosOsGenerosMusicias = musicas.Select(generos => generos.Genero).Distinct().ToList();

            Console.WriteLine("Todos os generos musicais: ");
            foreach (var genero in todosOsGenerosMusicias)
            {
                Console.WriteLine($" - {genero}");
            }
            Console.WriteLine();
        }

        // Exibe os artistas que pertencem a um gênero musical específico
        public static void FiltrarArtistasPorGeneroMusical(List<Musica> musicas, string genero)
        {
            var artistasPorGeneroMusical = musicas
                .Where(musica => musica.Genero.Contains(genero))
                .Select(musica => musica.Artista)
                .Distinct()
                .ToList();

            Console.WriteLine($"Exibindo os artistas por gênero musical >> {genero}");

            foreach (var artista in artistasPorGeneroMusical)
            {
                Console.WriteLine($" - {artista}");
            }
            Console.WriteLine();

        }

        // Exibe as músicas de um artista específico
        public static void FiltrarMusicasDeUmArtista(List<Musica> musicas, string nomeDoArtista)
        {
            var musicasDoArtista = musicas
                .Where(musica => musica.Artista!.Equals(nomeDoArtista))
                .Distinct()
                .ToList();

            Console.WriteLine(nomeDoArtista);

            foreach (var musica in musicasDoArtista)
            {
                Console.WriteLine($"- {musica.Nome}");
            }
            Console.WriteLine();

        }

        // Exibe as músicas que estão na tonalidade "C#"
        public static void FiltrarMusicasEmCSharp(List<Musica> musicas)
        {
            var musicasComCSharp = musicas
                .Where(musica => musica.Tonalidade.Equals("C#"))
                .Select(musica => musica.Nome)
                .ToList();

            Console.WriteLine("Músicas em C#: ");
            foreach (var musica in musicasComCSharp)
            {
                Console.WriteLine($"- {musica}");
            }
            Console.WriteLine();

        }
    }
}
