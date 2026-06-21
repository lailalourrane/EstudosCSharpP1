using System;

public class Slots
{
    public void Executar()
    {
        string[] slot = new string[3];

        try
        {
            Console.WriteLine("Acessando os saves...");
            Console.WriteLine(slot[5]);
        }
        catch (Exception erro)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Arquivo inexistente ou corrompido");
            Console.ResetColor();
        }
    }
}