using ScreenSound__API_LINQ.Modelos;
using System.Text.Json;
using ScreenSound__API_LINQ.Filtros;

using (HttpClient client = new HttpClient())
{
    try
    {
        string resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
        var musicas = JsonSerializer.Deserialize<List<Musica>>(resposta)!;
        //LinqFilter.FiltrarTodosOsGenerosMusicais(musicas);
        //LinqOrder.ExibirListaDeArtistasOrdenados(musicas);
        //LinqFilter.FiltrarArtistaPorGeneroMusical(musicas, "pop");
        //LinqFilter.FiltrarMusicasDeUmArtista(musicas, "U2");


        //var musicasPreferidasDoDudu = new MusicasPreferidas("Dudu");
        //musicasPreferidasDoDudu.AdicionarMusicasFavoritas(musicas[1]);
        //musicasPreferidasDoDudu.AdicionarMusicasFavoritas(musicas[377]);
        //musicasPreferidasDoDudu.AdicionarMusicasFavoritas(musicas[4]);
        //musicasPreferidasDoDudu.AdicionarMusicasFavoritas(musicas[6]);
        //musicasPreferidasDoDudu.AdicionarMusicasFavoritas(musicas[1467]);

        var musicasPreferidasDoGuilherme = new MusicasPreferidas("Guilherme");

        musicasPreferidasDoGuilherme.AdicionarMusicasFavoritas(musicas[500]);
        musicasPreferidasDoGuilherme.AdicionarMusicasFavoritas(musicas[17]);
        musicasPreferidasDoGuilherme.AdicionarMusicasFavoritas(musicas[578]);
        musicasPreferidasDoGuilherme.AdicionarMusicasFavoritas(musicas[134]);
        musicasPreferidasDoGuilherme.AdicionarMusicasFavoritas(musicas[1200]);

        musicasPreferidasDoGuilherme.ExibirMusicasFavoritas();

        musicasPreferidasDoGuilherme.GerarArquivoJson();
    }
    catch (Exception ex) 
    {
        Console.WriteLine($"Temos um problema : {ex.Message}");
    }
}