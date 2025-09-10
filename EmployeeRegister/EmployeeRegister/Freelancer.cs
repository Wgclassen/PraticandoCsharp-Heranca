namespace EmployeeRegister;

internal class Freelancer(string nome, string cargo, decimal valorProjeto) : Funcionario(nome, cargo)
{
    public decimal ValorProjeto { get; } = valorProjeto;
}
