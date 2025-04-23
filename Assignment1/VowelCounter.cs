namespace Assignment1;

public class VowelCounter
{
    private static readonly char[] Vowels = [ 'a', 'e', 'i', 'o', 'u' ];

    public static int CountVowels(string input)
    {
        int count = 0;
        
        foreach (var c in input)
        {
            foreach (var v in Vowels)
            {
                if (c == v) count++;
            }
        }

        return count;
    }
}