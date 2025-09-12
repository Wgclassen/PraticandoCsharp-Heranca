namespace ItemCatalogue;

internal class Pergaminho(string titulo, string conteudoTextual) : ItemDigital(titulo)
{
    public string ConteudoTextual { get; } = conteudoTextual;

    public void MostrarDetalhes()
    {
        Console.WriteLine("Detalhes do Pergaminho:");
        Console.WriteLine($"Título: {Titulo}");
        Console.WriteLine($"Descrição: {ConteudoTextual}");
    }
}
