namespace Desafio_Capgemini.Questao3;

public class Anagram
{
    private readonly string _anagram;
    public Anagram(string anagrams)
    {
        _anagram = anagrams;
    }

    public string Anagrams { get; private set; }

    public bool Validate()
    {
        var checkAnagram = _anagram.ToArray();
        var item = checkAnagram.Reverse().ToArray();
        var item2 = item.Reverse().ToArray();



        if (checkAnagram.ToString().Equals(item2.ToString()))

            return true;


        return false;

    }


}