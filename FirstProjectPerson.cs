using System.Threading.Channels;

namespace FirstProject;

public class Person
{
    public string Firstname;
    public string Lastname;

    private DateTime dateOfBirth;
    private string contactNumber;
    public static int Count = 0;

    public string ContactNumber
    {
        get { return contactNumber;  }
        set
        {
            if (value.Length < 9)
            {
                Console.WriteLine("invalid contact number");
            }
            else
            {
                contactNumber = value;    
            }

            
        }
    }
    
    // public string ContactNumber { get; set; }

    public Person(string firstname, string lastname)
    {
        Count++;
        Console.WriteLine("constr 1");
        Firstname = firstname;
        Lastname = lastname;
    }

    public Person(string firstname, string lastname, DateTime dateOfBirth) : this(firstname,lastname)
    {
        Console.WriteLine("constr 2");
        SetDateOfBirth(dateOfBirth);
    }

    public void SetDateOfBirth(DateTime date)
    {
        if (date > DateTime.Now)
        {
            Console.WriteLine("Invalid date");
        }
        else{
            dateOfBirth = date;
        }
    }

    public DateTime GetDateOBirth() => dateOfBirth; //expresion body - instead that body from lower part 
//     {
//         return dateOfBirth;
//     }
    public void SayHi()
    {
        Console.WriteLine($"Hi, I'm {Firstname}, {Lastname}, {GetDateOBirth()}, catch me at {ContactNumber}");
    }
}