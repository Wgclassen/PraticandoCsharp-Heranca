namespace EmployeeRegister;

internal class Funcionario(string nome, string cargo)
{
    public string Nome { get; } = nome;
    public string Cargo { get; } = cargo;
}