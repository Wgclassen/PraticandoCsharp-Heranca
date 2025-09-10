namespace EmployeeRegister;

internal class Interno(string nome, string cargo, decimal salario) : Funcionario(nome, cargo)
{
    public decimal Salario { get; } = salario;
}
