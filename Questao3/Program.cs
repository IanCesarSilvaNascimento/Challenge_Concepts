namespace Desafio_Capgemini.Questao3;

public class Program
{
    public static void Main(string[] args)
    {

        Console.WriteLine("Digite uma palavra");
        var item = Console.ReadLine();

        var anagram = new Anagram(item);

        Console.Clear();

        
        
        Console.WriteLine(anagram.Validate());





    }



}

