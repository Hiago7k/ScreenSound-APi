using System.Text.Json.Serialization;

namespace ScreenSound_APi.Modelos;
internal class Musica
{
   
    [JsonPropertyName("song")]
    public string Nome { get; set; }
}
