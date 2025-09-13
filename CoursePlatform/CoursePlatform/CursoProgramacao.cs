namespace CoursePlatform;

internal class CursoProgramacao(string nomeCurso, Instrutor instrutor) : ICurso
{
    public string NomeCurso { get; } = nomeCurso;
    public Instrutor Instrutor { get; } = instrutor;

    public void PublicarCurso()
    {
        Console.WriteLine($"Curso publicado com sucesso: {NomeCurso} - Instrutora: {Instrutor.Nome} ({Instrutor.Especialidade})");
    }

    public void ValidarConteudo()
    {
        Console.WriteLine($"Validando conteúdo do curso de programação: {NomeCurso}");
    }
}
