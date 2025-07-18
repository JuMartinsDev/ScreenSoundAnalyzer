using ScreenSound04.Modelos;
using System.Net.Http.Json;
using System.Text.Json;
using System.Xml;
using ScreenSound04.Filtros;

// Cria um cliente HTTP para consumir a API
using (HttpClient client = new HttpClient())
{
    try
    {
        // Faz a requisição para a URL da API de músicas
        string resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");

        // Desserializa a string JSON em uma lista de objetos Musica
        var musicas = JsonSerializer.Deserialize<List<Musica>>(resposta)!;

        // Aplicação de filtros (exemplos comentados):
        LinkFilter.FiltrarTodosOsGenerosMusicais(musicas);
        LinkOrder.ExibirListaDeArtistasOrdenados(musicas);
        LinkFilter.FiltrarArtistasPorGeneroMusical(musicas, "rock");
        LinkFilter.FiltrarMusicasDeUmArtista(musicas, "Taylor");

        // Filtra músicas que mencionam "C#"
        LinkFilter.FiltrarMusicasEmCSharp(musicas);

        // Cria uma lista de músicas favoritas para o usuário "Julia"
        var musicasPreferidasDaJulia = new MusicasPreferidas("Julia");
        musicasPreferidasDaJulia.AdicionarMusicasFavoritas(musicas[4]);
        musicasPreferidasDaJulia.AdicionarMusicasFavoritas(musicas[5]);
        musicasPreferidasDaJulia.AdicionarMusicasFavoritas(musicas[777]);
        musicasPreferidasDaJulia.AdicionarMusicasFavoritas(musicas[6]);
        musicasPreferidasDaJulia.AdicionarMusicasFavoritas(musicas[1433]);

        // Exibir ou salvar a lista de músicas favoritas (opcional):
        musicasPreferidasDaJulia.ExibirMusicasFavoritas();
        musicasPreferidasDaJulia.GerarArquivoJson();
    }
    catch (Exception ex)
    {
        // Captura erros e exibe uma mensagem amigável
        Console.WriteLine($"Temos um problema: {ex.Message}");
    }
}
