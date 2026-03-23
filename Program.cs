using ScreenSound_APi.Modelos;
using System.Text.Json;
using ScreenSound_APi.Filtros;

using (HttpClient client = new HttpClient()) 
{ 
    try
    {
        string resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
        var musicas = JsonSerializer.Deserialize<List<Musica>>(resposta)!;
        //LinqFilter.FiltrarTodosOsGenerosMusicais(musicas);
        // LinqOrder.ExibirListaDeArtistasOrdernados(musicas);
        // LinqFilter.FiltrarArtistasPorGeneroMusical(musicas, "rock");
        //LinqFilter.FiltrarMusicasDeUmArtista(musicas, "21 Savage");
        //LinqFilter.FiltrarMusicasPorAno(musicas, "2017");


        var musicasPreferidasDoHiago = new MusicasPreferidas("Hiago");
        
        musicasPreferidasDoHiago.AdicionarMusicasFavoritas(musicas[1]); 
        musicasPreferidasDoHiago.AdicionarMusicasFavoritas(musicas[377]); 
        musicasPreferidasDoHiago.AdicionarMusicasFavoritas(musicas[4]); 
        musicasPreferidasDoHiago.AdicionarMusicasFavoritas(musicas[6]); 
        musicasPreferidasDoHiago.AdicionarMusicasFavoritas(musicas[1467]);

        musicasPreferidasDoHiago.ExibirMusicasFavoritas();

        var musicasPreferidasDaNath = new MusicasPreferidas("Nath");
        musicasPreferidasDaNath.AdicionarMusicasFavoritas(musicas[3]);
        musicasPreferidasDaNath.AdicionarMusicasFavoritas(musicas[23]);
        musicasPreferidasDaNath.AdicionarMusicasFavoritas(musicas[123]);
        musicasPreferidasDaNath.AdicionarMusicasFavoritas(musicas[555]);
        musicasPreferidasDaNath.AdicionarMusicasFavoritas(musicas[1000]);

        musicasPreferidasDaNath.ExibirMusicasFavoritas();

    }
    catch (Exception ex)
    {
        Console.WriteLine($"Temos um problema: {ex.Message}");
    }
}
