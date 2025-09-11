namespace JobCertificate;

internal class Certificado
{
    public Profissao Profissao { get; }
    public Certificado(Profissao prof)
    {
        Profissao = prof;
        Console.WriteLine("Certificado emitido para: " + prof.Titulo);
    }
}
