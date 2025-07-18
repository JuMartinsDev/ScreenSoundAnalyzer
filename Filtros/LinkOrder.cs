using ScreenSound04.Modelos;

namespace ScreenSound04.Filtros
{
    internal class LinkOrder
    {
        // Método que exibe no console a lista de artistas ordenados e sem repetição
        public static void ExibirListaDeArtistasOrdenados(List<Musica> musicas)
        {
            // Ordena as músicas pelo nome do artista, seleciona artistas distintos e converte para lista
            var artistasOrdenados = musicas
                .OrderBy(musica => musica.Artista)
                .Select(musica => musica.Artista)
                .Distinct()
                .ToList();

            Console.WriteLine("Lista de artistas ordenados");
            // Exibe cada artista na lista ordenada
            foreach (var artista in artistasOrdenados)
            {
                Console.WriteLine($" - {artista}");
            }
            Console.WriteLine();

        }
    }
}
