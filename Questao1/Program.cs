namespace Desafio_Capgemini.Questao1;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Digite a altura da sua escada com números de 1 até 9");
        var number = Console.ReadLine().Substring(0, 1);
        int height = int.Parse(number);
        Console.Clear();
        
        if(height==0)
             Console.WriteLine("A escada não pode ter altura zero");

        else {
            Console.WriteLine($"A sua escada tem altura {height}");
            Stairs(height);
        }

    }

    public static void Stairs(int height)
    {
        var list = new List<string>();

        for (int i = 1; i <= height; i++)
        {
            var gap = height - i;

            list.Add(string.Concat(Enumerable.Repeat<string>("", gap)) + string.Concat(Enumerable.Repeat<string>("*", i)));

        }

        foreach (var item in list)
            Console.WriteLine(item.ToString());

    }

}