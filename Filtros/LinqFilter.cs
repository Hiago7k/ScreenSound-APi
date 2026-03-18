using ScreenSound_APi.Modelos;
using System.Linq;
namespace ScreenSound_APi.Filtros;

internal class LinqFilter
{
    public static void FiltrarTodosOsGenerosMusicais(List<Musica> musicas) 
    {
        var todosOsGenerosMusicais = musicas.Select(generos => generos.Genero).Distinct().ToList();
        foreach (var genero in todosOsGenerosMusicais) 
        {
            Console.WriteLine($"- {genero}");
        }
    }

    public static void FiltrarArtistasPorGeneroMusical(List<Musica> musicas, string genero) 
    {
        var artistasPorGeneroMusical = musicas.Where(musica => musica.Genero.Contains(genero)).Select(musica => musica.Artista).ToList().Distinct();
        Console.WriteLine($"Exibindo os artistas por genero musical: {genero}");

        foreach (var artista in artistasPorGeneroMusical) 
        {
            Console.WriteLine($"- {artista}");
        }
    }
}
