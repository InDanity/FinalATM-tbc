// See https://aka.ms/new-console-template for more information
public class User
{
    private string username { get; set; }
    private int pin { get; set; }
    private bool isAdmin { get; set; }

    public User(string username, int pin, bool isAdmin)
    {
        username = username;
        pin = pin;
        isAdmin = isAdmin;
    }
}

public class Account
{
    private int accountNumber { get; set; }
    private string holderName { get; set; }
    private decimal balance { get; set; }
    private bool isActive { get; set; }

    public Account(int accountNumber, string holderName, decimal balance, bool isActive)
    {
        accountNumber = accountNumber;
        holderName = holderName;
        balance = balance;
        isActive = isActive;
    }
}

public interface IATM
{
    void login();
    void customerMenu();
    void adminMenu();
    void deposit();
    void withdraw();
    void getBalance();
    void updateAcc();
    void deleteAcc();
    void addAcc();
}

public class ATM : IATM
{
    private DatabaseManager _databaseManager;

    public ATM(DatabaseManager databaseManager)
    {
        databaseManager = databaseManager;
    }

    public void addAcc()
    {
        throw new NotImplementedException();
    }

    public void adminMenu()
    {
        throw new NotImplementedException();
    }

    public void customerMenu()
    {
        throw new NotImplementedException();
    }

    public void deleteAcc()
    {
        throw new NotImplementedException();
    }

    public void deposit()
    {
        throw new NotImplementedException();
    }

    public void getBalance()
    {
        throw new NotImplementedException();
    }

    public void login()
    {
        throw new NotImplementedException();
    }

    public void updateAcc()
    {
        throw new NotImplementedException();
    }

    public void withdraw()
    {
        throw new NotImplementedException();
    }

}

public class DatabaseManager
{
    // Methods for database operations: connect, disconnect, executeQuery, executeUpdate, etc.
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World!");

        // Initialize dependencies
        DatabaseManager databaseManager = new DatabaseManager();
        ATM atm = new ATM(databaseManager);

        // Start ATM system
        // atm.start();

        Console.WriteLine("Hello World!");
    }
}
