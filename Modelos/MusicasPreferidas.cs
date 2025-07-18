using System.Globalization;
using System.Text.Json;

namespace ScreenSound04.Modelos
{
    internal class MusicasPreferidas
    {
        // Nome do usuário dono da lista de músicas favoritas
        public string? Nome { get; set; }

        // Lista das músicas favoritas
        public List<Musica> ListaDeMusicasFavoritas { get; }

        // Construtor que recebe o nome do usuário e inicializa a lista
        public MusicasPreferidas(string nome)
        {
            Nome = nome;
            ListaDeMusicasFavoritas = new List<Musica>();
        }

        // Adiciona uma música à lista de favoritas
        public void AdicionarMusicasFavoritas(Musica musica)
        {
            ListaDeMusicasFavoritas.Add(musica);
        }

        // Exibe no console as músicas favoritas com nome e artista
        public void ExibirMusicasFavoritas()
        {
            Console.WriteLine($"Essas são as músicas favoritas -> {Nome} ");

            foreach (var musica in ListaDeMusicasFavoritas)
            {
                Console.WriteLine($"- {musica.Nome} de {musica.Artista}");
            }
            Console.WriteLine();
        }

        // Gera um arquivo JSON com as músicas favoritas e salva no disco
        public void GerarArquivoJson()
        {
            string json = JsonSerializer.Serialize(new
            {
                Nome = Nome,
                musicas = ListaDeMusicasFavoritas
            });

            string nomeDoArquivo = $"musicas-favoritas-{Nome}.json";

            File.WriteAllText(nomeDoArquivo, json);
            Console.WriteLine($"O arquvio json foi criado com sucesso! {Path.GetFullPath(nomeDoArquivo)}");
            Console.WriteLine();

        }
    }
}
