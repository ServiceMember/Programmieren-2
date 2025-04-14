namespace Assignment1;

public class VowelCounter
{
    private readonly char[] _vowels = [ 'a', 'e', 'i', 'o', 'u' ];

    public int CountVowels(string input)
    {
        int count = 0;
        
        foreach (var c in input)
        {
            foreach (var v in _vowels)
            {
                if (c == v) count++;
            }
        }

        return count;
    }
}