namespace PaymentSystem;

internal class Pessoa(string nome, string email)
{
    public string Nome { get; } = nome;
    public string Email { get; } = email;
}
