namespace Fuhrpark___Prog_2_Lab;

public class Contact()
{
    string lastName;
    string firstName;
    string phoneNumber;
    string email;

    public Contact(string lastName = null, string firstName = null, string phoneNumber = null, string email = null) : this()
    {
        this.lastName = lastName;
        this.firstName = firstName;
        this.phoneNumber = phoneNumber;
        this.email = email;
    }
    
    public string? LastName
    {
        get => lastName;
        set
        {
            if (value == null)
            {
                lastName = "";
            }

            if (value != null) lastName = value;
        }
    }

    public string? FirstName
    {
        get => firstName;
        set
        {
            if (value == null)
            {
                firstName = "";
            }

            if (value != null) firstName = value;
        }
    }

    public string? PhoneNumber
    { 
        get => phoneNumber;
        set
        {
            if (value == null)
            {
                phoneNumber = "";
            }

            if (value != null) phoneNumber = value;
        }
    }

    public string? Email
    {
        get => email;
        set
        {
            if (value == null)
            {
                email = "";
            }

            if (value != null) email = value;
        }
    }
    
    public string ToTableString()
    {
        return $"{LastName,-20}| {FirstName,-20}| {PhoneNumber,-20}| {Email,-40}";
    }
    public static string FieldList()
    {
    return $"{"LastName",-20}| {"FirstName",-20}| {"PhoneNumber",-20}| {"Email",-40}\n{new string('-', 100)}";
    }
}