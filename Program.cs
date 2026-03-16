using (HttpClient client = new HttpClient()) 
{
    try
    {
        string resposta = await client.GetStringAsync("https://guilhermeonrils.github.io/api-csharp-songs/songs.json");
        Console.WriteLine(resposta);
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Temos um problema: {ex.Message}");
    }
}
