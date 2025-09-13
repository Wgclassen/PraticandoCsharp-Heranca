namespace serviceManagement;

internal class Consultoria(string descricao, Funcionario funcionario) : IServico
{
    public string Descricao { get; } = descricao;
    public Funcionario Funcionario { get; } = funcionario;

    public void ExecutarServico()
    {
        Console.WriteLine($"Executando serviço de consultoria: {Descricao}\r\nResponsável: {Funcionario.Nome} - Departamento: {Funcionario.Departamento}");
    }
}
