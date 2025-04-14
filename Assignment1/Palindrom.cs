namespace Assignment1;

public class Palindrom(string? palindrom)
{
    public string? PalindromCandidate { get; set; } = palindrom;

    private bool IsPalindrom()
    {

        for (int i = 0; i < PalindromCandidate.Length / 2; i++)
        {
            if (PalindromCandidate[i] != PalindromCandidate[PalindromCandidate.Length - 1 - i])
            {
                return false;
            }
        }
        return true;
    }

    public void PrintPalindrom()
    {
        Console.WriteLine(IsPalindrom()
            ? $"Der eingegebene String '{PalindromCandidate}' ist ein Palindrom."
            : $"Der eingegebene String {PalindromCandidate}' ist kein Palindrom.");
    }
    
}