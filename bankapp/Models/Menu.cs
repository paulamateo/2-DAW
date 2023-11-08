namespace Models;

public class Menu {

    public static void CreateNewAccount(List<BankAccount> accounts) {
        Console.WriteLine("Nombre del propietario/a: ");
        string owner = Console.ReadLine();
        Console.WriteLine("Depósito inicial: ");
        decimal initialDeposit = Convert.ToDecimal(Console.ReadLine());
        BankAccount newAccount = new BankAccount(owner, initialDeposit);
        accounts.Add(newAccount);
        Console.WriteLine($"Cuenta creada. {newAccount.GetBalance()}\n");
    }

    public static void AddMoney(List<BankAccount> accounts) {
        ListNumberAccounts(accounts);
        Console.WriteLine("Nº de cuenta: ");
        string accountNumber = Console.ReadLine();
        BankAccount account = GetAccountByNumber(accounts, accountNumber);
        if (account != null) {
            Console.WriteLine("Cantidad que quieres ingresar: ");
            decimal amount = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Descripción: ");
            string note = Console.ReadLine();
            DateTime date = DateTime.Now;
            account.MakeDeposit(amount, date, note);
            Console.WriteLine($"Ingreso realizado. {account.GetBalance()}\n");
        } else {
            Console.WriteLine("Esa cuenta no existe.");
        }
    }

    public static void RemoveMoney(List<BankAccount> accounts) {
        ListNumberAccounts(accounts);
        Console.WriteLine("Nº de cuenta: ");
        string accountNumber = Console.ReadLine();
        BankAccount account = GetAccountByNumber(accounts, accountNumber);
        if (account != null) {
            Console.WriteLine("Cantidad que quieres retirar: ");
            decimal amount = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Descripción: ");
            string note = Console.ReadLine();
            DateTime date = DateTime.Now;
            account.MakeWithdrawal(amount, date, note);
            Console.WriteLine($"Retiro realizado. {account.GetBalance()}\n");
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
        Console.WriteLine("Nº de cuenta: ");
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

    public static BankAccount GetAccountByNumber(List<BankAccount> accounts, string number) {
        return accounts.FirstOrDefault(acc => acc.Number == number);
    }

    public static void DisplayOptionsMenu(int option, List<BankAccount> accounts, ref bool accountCreated, ref bool exit) {
        switch(option) {
            case 1:
                CreateNewAccount(accounts);
                accountCreated = true;
                break;
            case 2:
                if (!accountCreated) {
                    Console.WriteLine("Debes crear una cuenta antes.");
                }else { 
                    AddMoney(accounts);
                }
                break;
            case 3:
                if (!accountCreated) {
                    Console.WriteLine("Debes crear una cuenta antes.");
                }else { 
                    RemoveMoney(accounts);
                }
                break;  
            case 4:
                if (!accountCreated) {
                    Console.WriteLine("Debes crear una cuenta antes.");
                }else { 
                    ListTransactions(accounts);
                }
                break;
            case 5:
                if (!accountCreated) {
                    Console.WriteLine("Debes crear una cuenta antes.");
                }else { 
                    ListAccounts(accounts);
                }
                break; 
            case 6:
                exit = true;
                break;
            default:
                Console.WriteLine($"La opción {option} no está en el menú.");
                break;
        }
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