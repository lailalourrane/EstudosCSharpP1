using System;

public class Personagem
{
    private int HP;
    public string? Nome;

    public Personagem (string namePersona, int life)
    {
        Nome = namePersona;
        HP = life;
        Console.WriteLine($"O nome do personagem é {Nome} e tem {HP} de vida");
    }

    public void TomarDano(int dano)
    {
        Console.WriteLine($"O personagem está em batalha");

        HP -= dano;

        if (HP <= 0)
        {
            HP = 0;
        }
        else
        {
            
        }
    }
}

public class EscudoQA
{
    public void Executar()
    {
        Console.WriteLine("---Batalha---");
        Personagem personagem1 = new Personagem ("Prists", 240);
        const int DANO_NORMAL = 70;
        const int DANO_CRITICO = 100;

        personagem1.TomarDano(DANO_NORMAL);
        Console.WriteLine($"{personagem1.Nome} tomou {DANO_NORMAL} de dano normal.");
        personagem1.TomarDano(DANO_NORMAL);
        Console.WriteLine($"{personagem1.Nome} tomou {DANO_NORMAL} de dano normal.");
        personagem1.TomarDano(DANO_CRITICO);
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"[CRÍTICO] {personagem1.Nome} tomou {DANO_CRITICO} de dano e foi abatido!");
        Console.ResetColor();
    }
}

