using System;
using System.Collections.Generic;

public class Receita
{
    public void Executar()
    {
        List<string> IngredientesBao = new List<string>();
        IngredientesBao.Add("Farinho de Trigo");
        IngredientesBao.Add("Água morna");
        IngredientesBao.Add("Fermento Biológico Seco");
        IngredientesBao.Add("Açúcar");
        IngredientesBao.Add("Óleo vegetal");
        IngredientesBao.Add("Sal");

        List<string> MolhoCurryCocoManga = new List<string>();
        MolhoCurryCocoManga.Add("Manga Madura");
        MolhoCurryCocoManga.Add("Leite de Coco");
        MolhoCurryCocoManga.Add("Óleo de Coco");
        MolhoCurryCocoManga.Add("Gengibre ralado");
        MolhoCurryCocoManga.Add("Alhos picados");
        MolhoCurryCocoManga.Add("Cebola picadas");
        MolhoCurryCocoManga.Add("Pasta de Curry");
        MolhoCurryCocoManga.Add("Cúrcuma");
        MolhoCurryCocoManga.Add("Sal");

        Console.WriteLine($"Para a receita de Bao falta os seguintes ingrediente: {IngredientesBao.Count}");
        Console.WriteLine($"E para curry falta os seguintes: {MolhoCurryCocoManga.Count}");

        MolhoCurryCocoManga.Remove("Manga Madura");
        IngredientesBao.Remove("Açúcar");

        IngredientesBao.Count();
        MolhoCurryCocoManga.Count();

        Console.WriteLine($"Agora para a receita de Bao falta os seguintes ingredientes: {IngredientesBao.Count}");
        Console.WriteLine($"E para o Curry falta: {MolhoCurryCocoManga.Count}");

    }
}