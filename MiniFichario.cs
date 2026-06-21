using System;
using System.Runtime.CompilerServices;

public interface IColecionaveis
{
    void GuardarCarta();
}

public class CartaIdent
{
    protected int idCarta;
}

public class CartaKalos : CartaIdent, IColecionaveis
{
    public string? NomeCarta;

    public CartaKalos(string nome, int identificacao)
    {
        NomeCarta = nome;
        idCarta = identificacao;
        Console.WriteLine($"Carta {NomeCarta} com o ID {idCarta} foi adicionada");
    }

    public void GuardarCarta()
    {
        Console.WriteLine("Carta guardada!");
    }
}

public class MiniFichario
{
    public void Executar()
    {
        CartaKalos[] fichario = new CartaKalos[2];
        try
        {
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"\n Tentando guardar a carta no sleeve {i}...");
                CartaKalos novoCard = new CartaKalos("Pokemons de Kalos", i);
                fichario[i] = novoCard;
                fichario[i].GuardarCarta();
            }
        } catch (Exception erro)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n Aletra, fichário cheio, não há espaço para mais cartas!");
            Console.WriteLine($"Log técnico para QA: {erro.Message}");
            Console.ResetColor();
        }
    }
}