using System;

public class ComponenteBotao
{
    public string? CorHexadecimal;
    public string? Texto;
    public void Renderizar()
    {
        Console.WriteLine($"{CorHexadecimal}{Texto}");
    }
}

public class BotaoFrontEnd
{
    public void Executar()
    {
        Console.WriteLine("----------------");
        ComponenteBotao cor1 = new ComponenteBotao();
        cor1.CorHexadecimal = "#28a745";
        cor1.Texto = "Confirmar";
        ComponenteBotao cor2 = new ComponenteBotao();
        cor2.CorHexadecimal = "#dc3545";
        cor2.Texto = "Cancelar";

        cor1.Renderizar();
        cor2.Renderizar();
    }
}