namespace PassengerData;

internal class Passageiro(string nome, int idade, int quantidadeBilhetes) : Pessoa(nome, idade)
{
    public int QuantidadeBilhetes { get; set; } = quantidadeBilhetes;

    public void ImprimirDados()
    {
        Console.WriteLine($"Passageiro: {Nome} - Idade: {Idade} - Bilhetes: {QuantidadeBilhetes}");
    }
}
