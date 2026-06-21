using System;
using System.Security.Cryptography.X509Certificates;

public interface IAcessivel
{
    bool ValidarConstrate();
}

public class TemaMinimalista : IAcessivel
{
    public bool ValidarConstrate()
    {
        return true;
    }
}

public class Auditoria
{
    public void Executar()
    {
        TemaMinimalista meuTema = new TemaMinimalista();
        Console.WriteLine($"O tema passou no teste de contraste? {meuTema.ValidarConstrate()}");
    }
}