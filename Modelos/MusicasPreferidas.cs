namespace ScreenSound_APi.Modelos;

internal class MusicasPreferidas
{
    public string? Nome { get; set; }
    public List<Musica> ListaDeMusicasFavoritas { get; }

    public MusicasPreferidas(string nome) 
    {
        Nome = nome;
        ListaDeMusicasFavoritas = new List<Musica>();
    }
}
