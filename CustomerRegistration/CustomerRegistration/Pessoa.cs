namespace CustomerRegistration;

internal abstract class Pessoa(string nome, int idade)
{
    public string Nome { get; } = nome;
    public int Idade { get; } = idade;
}
