using System.Text.Json;

namespace Generics;

public static class Program
{
    public static void Main()
    {
        var preCalculo = PreCalculo();

        Console.WriteLine(JsonSerializer.Serialize(preCalculo.Itens));
    }

    public static PreCalculo PreCalculo()
    {
        var elegivel = new Random().Next(1, 4);

        if (elegivel > 2)
        {
            var itensNovos = PreCalculoNovo();

            return new PreCalculo
            {
                Itens = itensNovos
            };
        }
        else
        {
            var itensAntigos = PreCalculoAntigo();

            return new PreCalculo
            {
                Itens = itensAntigos
            };
        }
    }

    public static List<ItemAntigo> PreCalculoAntigo()
    {
        return new List<ItemAntigo>()
        {
             new ItemAntigo() { Descricao = "Item Antigo" }
        };
    }

    public static List<ItemNovo> PreCalculoNovo()
    {
        return new List<ItemNovo>()
        {
             new ItemNovo() { Descricao = "Item Novo" }
        };
    }
}


public class PreCalculo
{
    public decimal ValorTotal { get; set; }
    public decimal ValorCredito { get; set; }
    public decimal ValorPagar { get; set; }
    public dynamic Itens { get; set; }
}


public class ItemAntigo
{
    public string Descricao { get; set; }
}

public class ItemNovo
{
    public string Descricao { get; set; }
}