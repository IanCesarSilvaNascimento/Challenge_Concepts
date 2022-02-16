namespace Desafio_Capgemini.Questao2;

public class Password
{
    private readonly string _password;
    public Password(string passwords)
    {
        _password = passwords;
    }
    public string Passwords { get; private set; }

    public bool ValidateNumberOfCharacters()
    {
        bool activate1 = false, activate2 = false, activate3 = false, activate4 = false, activate5 = false;

        var checkCharacter = _password.ToArray();

        if (checkCharacter.Length == 6)
        {
            foreach (var item in checkCharacter)
            {
                if (char.IsLetterOrDigit(item))
                    activate1 = true;

                if (char.IsUpper(item))
                    activate2 = true;

                if (char.IsLower(item))
                    activate3 = true;

                if (char.IsSymbol(item))
                    activate4 = true;


                if (activate1 == true && activate2 == true && activate3 == true && activate4 == true)
                    activate5 = true;

                if (activate5 == true)
                    return true;

            }



        }
        else
        {
            Console.WriteLine("A senha precisa conter 6 digitos");
            return false;
        }


        if (!activate1)
            Console.WriteLine("Digite Letra ou Número");


        if (!activate2)
            Console.WriteLine("Digite letra maiúscula");


        if (!activate3)
            Console.WriteLine("Digite letra minúscula");


        if (!activate4)
            Console.WriteLine("Digite caracter especial");


        return false;


    }


}