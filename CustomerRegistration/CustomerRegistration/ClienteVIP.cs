namespace CustomerRegistration;

internal class ClienteVIP(string nome, int idade, string fidelidade, string codigoVIP) : Pessoa(nome, idade)
{
    public string Fidelidade { get; } = fidelidade;
    public string CodigoVIP { get; } = codigoVIP;
}
