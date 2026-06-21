using System;

public class Semaforo
{
    public void Executar()
    {
        Console.WriteLine("--------------");
        int municaoAtual = 3;
        int municaoMax = 5;
        if (municaoAtual > 0)
        {
            Console.WriteLine("ainda possui bala, tiro disparado");
            municaoAtual--;
        }
        else
        {
            Console.WriteLine("arma sem munição, recarregue");
        }
    }
}