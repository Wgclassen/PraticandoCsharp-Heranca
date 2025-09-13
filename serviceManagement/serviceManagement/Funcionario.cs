namespace serviceManagement;

internal class Funcionario(string nome, string departamento)
{
    public string Nome { get; set; } = nome;
    public string Departamento { get; set; } = departamento;
}
