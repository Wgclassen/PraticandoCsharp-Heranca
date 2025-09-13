namespace PaymentSystem;

internal class PagamentoBoleto(string nome, string email) : Pessoa(nome, email), IPagamento
{
    public void ProcessarPagamento()
    {
        Console.WriteLine($"Processando pagamento via boleto para {Nome} - {Email}");
    }
}
