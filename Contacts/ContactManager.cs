namespace Fuhrpark___Prog_2_Lab;

public class ContactManager
{
    private List<Contact> kontakteList = new List<Contact>();
    public void CreateContact()
    {
        Console.WriteLine("Bitte geben Sie den Nachnamen ein:");
        string? lastName = Console.ReadLine();
        
        Console.WriteLine("Bitte geben Sie den Vornamen ein:");
        var firstName = Console.ReadLine();
        
        Console.WriteLine("Bitte geben Sie die Telefonnummer ein:");
        var phoneNumber = Console.ReadLine();
        
        Console.WriteLine("Bitte geben Sie die E-Mail-Adresse ein:");
        var email = Console.ReadLine();

        var newContact = new Contact(lastName, firstName, phoneNumber, email);
        kontakteList.Add(newContact);
    }

    public List<Contact> SearchContactByName(string? name)
    {
        var results = new List<Contact>();
        Console.WriteLine();
        foreach (var contact in kontakteList)
        {
            if (contact.LastName.Equals(name, StringComparison.OrdinalIgnoreCase) || 
                contact.FirstName.Equals(name, StringComparison.OrdinalIgnoreCase))
            {
                results.Add(contact);
            }
        }
        return results;
    }
}