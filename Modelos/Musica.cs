using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ScreenSound04.Modelos
{
    internal class Musica
    {
        // Array com as tonalidades musicais correspondentes ao índice Key
        private string[] tonalidades = { "C", "C#", "D", "Eb", "E", "F", "F#", "G", "Ab", "A", "Bb", "B" };

        // Nome da música, mapeado do JSON pelo atributo "song"
        [JsonPropertyName("song")]
        public string? Nome { get; set; }

        // Nome do artista, mapeado do JSON pelo atributo "artist"
        [JsonPropertyName("artist")]
        public string? Artista { get; set; }

        // Duração da música em milissegundos, mapeado do JSON "duration_ms"
        [JsonPropertyName("duration_ms")]
        public int? Duracao { get; set; }

        // Gênero musical da música, mapeado do JSON "genre"
        [JsonPropertyName("genre")]
        public string? Genero { get; set; }

        // Índice da tonalidade musical, mapeado do JSON "key"
        [JsonPropertyName("key")]
        public int Key { get; set; }

        // Propriedade que retorna a tonalidade em texto baseada no índice Key
        public string Tonalidade
        {
            get
            {
                return tonalidades[Key];
            }
        }

        // Exibe detalhes da música no console: artista, nome, duração em segundos, gênero e tonalidade
        public void ExibirDetalhesDaMusica()
        {
            Console.WriteLine($"Artista: {Artista}");
            Console.WriteLine($"Música: {Nome}");
            Console.WriteLine($"Duração em segundos: {Duracao / 1000}");
            Console.WriteLine($"Gênero musical: {Genero}");
            Console.WriteLine($"Tonalidade: {Tonalidade}");
        }
    }
}
