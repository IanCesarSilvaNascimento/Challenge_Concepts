namespace Desafio_Capgemini.Questao2;

public class Program
{
    public static void Main(string[] args)
    {

        Console.WriteLine("Digite uma senha forte");
        var item = Console.ReadLine();

        var password = new Password(item);

        Console.Clear();

        if (password.ValidateNumberOfCharacters() == true)

            Console.WriteLine("Senha cadastrada com sucesso");

        else Console.Write("Falha ao cadastrar a senha. Atenção, observe os requisitos da senha!!");


    }



}

