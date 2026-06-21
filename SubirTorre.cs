using System;

public class SubirTorre
{
    public void Executar()
    {
        int andar = 1;
        while (andar <= 70)
        {
            Console.WriteLine($"Subindo para o andar {andar}");

            if (andar == 70)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("O ceifador chegou");
                Console.ResetColor();
                break;
            }
            else
            {
              Console.ForegroundColor = ConsoleColor.Green;
              Console.WriteLine("Andar livre do ceifador");
              Console.ResetColor();  
            }
            andar++;
        }
    }
}