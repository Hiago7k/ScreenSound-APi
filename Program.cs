// Chamando bibilioteca http, para conseguir trabalhar com API
// Obs nao colocamos ; no final pois vamos usar somente dentro do using
// using aqui entra, como gerenciando um recurso que vai ser usado ate a chave fechar }

using (HttpClient client = new HttpClient()) 
{
    // Nossa api tudo e string
    // Entao nossa primeira resposta e do tipo STRING
    // entao vamos usar a seguinte variavel
    // utilizamos o get, para pegar string e o Async e por que nao sabemos
    // a quantidade de musicas ou qual tamanho desse recurso que estamos recebendo
    // e nos queremos garantir que vamos conseguir receber. todos esses recursos
    // Se nao utilizar o Async ele vai receber uma parte, e ja vai passar para a proxima instrucao
    string resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
    // o uso do async e await aqui, e o seguinte ele fala espera essa tarefa ser concluia e ai sim voce pega o resultado da tarefa
    Console.WriteLine(resposta);
}
