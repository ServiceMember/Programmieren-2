namespace Fuhrpark___Prog_2_Lab;

class Program
{
    public static void Main(string[] args)
    {
        var contactManager = new ContactManager();
        StartContactManager(contactManager);
    }

    private static void StartContactManager(ContactManager contactManager)
    {
        bool running = true;

        while (running)
        {
            Console.WriteLine("Bitte wählen Sie eine Option:\n\t1. Kontakt erstellen\n\t2. Kontakt suchen\n\t3. Beenden");
            var selection = Console.ReadLine();
            switch (selection)
            {
                case "1":
                    contactManager.CreateContact();
                    break;
                case "2":
                    Console.WriteLine("Bitte geben Sie den Namen des Kontakts ein:");
                    var name = Console.ReadLine();
                    var contacts = contactManager.SearchContactByName(name);
                    if (contacts.Count == 0)
                    {
                        Console.WriteLine("Keine Kontakte gefunden.");
                    }else
                    {
                        Console.WriteLine("Gefundene Kontakte:");
                        Console.WriteLine(Contact.FieldList());
                        foreach (var contact in contacts)
                        {
                            Console.WriteLine(contact.ToTableString());
                        }
                    }
                    break;
                case "3":
                    running = false;
                    break;
                default:
                    Console.WriteLine("Ungültige Auswahl. Bitte versuchen Sie es erneut.");
                    break;
            }
            Console.WriteLine();
        }
    }
}