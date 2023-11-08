namespace Models;

public class Menu {

    public static void CreateNewAccount(List<BankAccount> accounts) {
        Console.Write("Nombre del propietario/a: ");
        string owner = Console.ReadLine();
        Console.Write("Depósito inicial: ");
        decimal initialDeposit = Convert.ToDecimal(Console.ReadLine());
        BankAccount newAccount = new BankAccount(owner, initialDeposit);
        accounts.Add(newAccount);
        Console.WriteLine($"\nCuenta creada. {newAccount.GetBalance()}");
    }

    public static void AddMoney(List<BankAccount> accounts) {
        ListNumberAccounts(accounts);
        Console.Write("Nº de cuenta: ");
        string accountNumber = Console.ReadLine();
        BankAccount account = GetAccountByNumber(accounts, accountNumber);
        if (account != null) {
            Console.Write("Cantidad que quieres ingresar: ");
            decimal amount = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Descripción: ");
            string note = Console.ReadLine();
            DateTime date = DateTime.Now;
            account.MakeDeposit(amount, date, note);
            Console.WriteLine($"\nIngreso realizado. {account.GetBalance()}");
        } else {
            Console.WriteLine("Esa cuenta no existe.");
        }
    }

    public static void RemoveMoney(List<BankAccount> accounts) {
        ListNumberAccounts(accounts);
        Console.Write("Nº de cuenta: ");
        string accountNumber = Console.ReadLine();
        BankAccount account = GetAccountByNumber(accounts, accountNumber);
        if (account != null) {
            Console.Write("Cantidad que quieres retirar: ");
            decimal amount = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Descripción: ");
            string note = Console.ReadLine();
            DateTime date = DateTime.Now;
            account.MakeWithdrawal(amount, date, note);
            Console.WriteLine($"\nRetiro realizado. {account.GetBalance()}");
        } else {
            Console.WriteLine("Esa cuenta no existe.");
        }
    }

    public static void ListAccounts(List<BankAccount> accounts) {
        Console.WriteLine("Propietario\tSaldo\tNúmero de cuenta");
        foreach (var account in accounts) {
            Console.WriteLine(account.GetAllAcounts());
        }
    }

    public static void ListTransactions(List<BankAccount> accounts) {
       ListNumberAccounts(accounts);
        Console.Write("Nº de cuenta: ");
        string accNumber = Console.ReadLine();
        BankAccount acc = GetAccountByNumber(accounts, accNumber);
        if (acc != null) {
            Console.WriteLine("Date\t\tAmount\tBalance\tNote");
            acc.GetTransactions();
        } else {
            Console.WriteLine("No se encontró la cuenta.");
        }
    }

    public static void ListNumberAccounts(List<BankAccount> accounts) {
        Console.WriteLine("----------------------------");
        Console.WriteLine("Propietario\tNº CUENTA");  
        foreach (var account in accounts) {
            Console.WriteLine(account.GetNumberAccount());
        }
        Console.WriteLine("----------------------------");
    }

    private static BankAccount GetAccountByNumber(List<BankAccount> accounts, string number) {
        return accounts.FirstOrDefault(acc => acc.Number == number);
    }

    public static void DisplayMenu() {
        Console.WriteLine(" ______________________________");
        Console.WriteLine("| 1 - Crear cuenta             |");
        Console.WriteLine("| 2 - Añadir dinero            |");
        Console.WriteLine("| 3 - Sacar dinero             |");
        Console.WriteLine("| 4 - Listar operaciones       |");
        Console.WriteLine("| 5 - Listar cuentas creadas   |");
        Console.WriteLine("| 6 - Salir                    |");
        Console.WriteLine("|______________________________|");
    }

}