using System;
using System.Collections.Generic;

public class Carta
{
    public int PoderAtaque;
}

public class calculoDanos
{
    public void Executar()
    {
        Carta carta1 = new Carta();
        Carta carta2 = new Carta();
        Carta carta3 = new Carta();
        carta1.PoderAtaque = 30;
        carta2.PoderAtaque = 50;
        carta3.PoderAtaque = 80;

        List<Carta> mao = new List<Carta>();
        mao.Add(carta1);
        mao.Add(carta2);
        mao.Add(carta3);

        int total = 0;

        foreach (Carta c in mao)
        {
            total =+ c.PoderAtaque;
        }

        Console.WriteLine($"Total de poder de ataque: {total}");
    }
}