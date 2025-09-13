namespace ComputerAssembly;

internal class Computador(Processador processador, PlacaMae placaMae)
{
    public Processador Processador { get; } = processador;
    public PlacaMae PlacaMae { get; } = placaMae;

    public void ExibirConfiguracao()
    {
        Console.WriteLine($"Computador configurado com:\r\nProcessador: {Processador.Marca} - {Processador.Modelo}\r\nPlaca-mãe: {PlacaMae.Fabricante} - {PlacaMae.Socket}");
    }
}
