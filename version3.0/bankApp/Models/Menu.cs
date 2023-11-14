using Spectre.Console;
namespace Models;

public class Menu {

    public static void CreateNewAccount(List<BankAccount> accounts) {
        StyleCS.Title("OPCIÓN 1 - CREACIÓN DE UNA CUENTA");
        Console.WriteLine("Nombre del propietario/a: ");
        string? owner = Console.ReadLine();
        Console.WriteLine("Depósito inicial: ");
        decimal initialDeposit = Convert.ToDecimal(Console.ReadLine());
        BankAccount newAccount = new BankAccount(owner, initialDeposit);
        accounts.Add(newAccount);
        StyleCS.PrintGreen($"Cuenta creada. {newAccount.GetBalance()}\n");
    }

    public static void AddMoney(List<BankAccount> accounts) {
        StyleCS.Title("OPCIÓN 2 - INGRESAR DINERO");
        ListNumberAccounts(accounts);
        StyleCS.PrintUnderlineBold("ELIGE Nº CUENTA:");
        string? accountNumber = Console.ReadLine();
        BankAccount account = GetAccountByNumber(accounts, accountNumber);
        if (account != null) {
            Console.WriteLine("Cantidad que quieres ingresar: ");
            decimal amount = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Descripción: ");
            string? note = Console.ReadLine();
            DateTime date = DateTime.Now;
            account.MakeDeposit(amount, date, note);
            StyleCS.PrintGreen($"Ingreso realizado. {account.GetBalance()}\n");
        } else {
            StyleCS.PrintRed($"La cuenta {accountNumber} no existe.\n");
        }
    }

    public static void RemoveMoney(List<BankAccount> accounts) {
        StyleCS.Title("OPCIÓN 3 - RETIRAR DINERO");
        ListNumberAccounts(accounts);
        StyleCS.PrintUnderlineBold("ELIGE Nº CUENTA:");
        string? accountNumber = Console.ReadLine();
        BankAccount account = GetAccountByNumber(accounts, accountNumber);
        if (account != null) {
            Console.WriteLine("Cantidad que quieres retirar: ");
            decimal amount = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Descripción: ");
            string? note = Console.ReadLine();
            DateTime date = DateTime.Now;
            account.MakeWithdrawal(amount, date, note);
            StyleCS.PrintGreen($"Retiro realizado. {account.GetBalance()}\n");
        } else {
            StyleCS.PrintRed($"La cuenta {accountNumber} no existe.\n");
        }
    }

    public static void ListTransactions(List<BankAccount> accounts) {
        StyleCS.Title("OPCIÓN 4 - LISTAR TRANSACCIONES");
        ListNumberAccounts(accounts);
        StyleCS.PrintUnderlineBold("ELIGE Nº CUENTA:");
        string? accNumber = Console.ReadLine();
        BankAccount acc = GetAccountByNumber(accounts, accNumber);
        if (acc != null) {
            var tableTransactions = new Table ()
                .AddColumn ("Date")
                .AddColumn ("Amount")
                .AddColumn ("Balance")
                .AddColumn("Note")
                .Title($"\nTransacciones realizadas por la cuenta {accNumber}")
            ;
            var transactionRows = acc.GetTransactions();
            foreach (var row in transactionRows) {
                tableTransactions.AddRow(row);
            }
            AnsiConsole.Write(tableTransactions);
            Console.WriteLine("");
        } else {
            StyleCS.PrintRed($"La cuenta {accNumber} no existe.\n");
        }
    }

    public static void ListNumberAccounts(List<BankAccount> accounts) {
        var tableAccounts = new Table()
            .AddColumn("Propietario")
            .AddColumn("Nº Cuenta")
            .Title("Cuentas disponibles")
        ;
        foreach (var account in accounts) {
            var accountNRows = account.GetNumberAccounts();
            foreach (var row in accountNRows) {
                tableAccounts.AddRow(row);
            }
        }
        AnsiConsole.Write(tableAccounts);
    }

    public static void ListAccounts(List<BankAccount> accounts) {
        StyleCS.Title("OPCIÓN 5 - LISTAR CUENTAS");
        var tableAllAccounts = new Table()
            .AddColumn("Propietario")
            .AddColumn("Saldo")
            .AddColumn("Nº cuenta")
            .Title("Cuentas creadas esta sesión")
        ;
        foreach (var account in accounts) {
            var accountRows = account.GetAllAccounts();
            foreach (var row in accountRows) {
                tableAllAccounts.AddRow(row);
            }
        }
        AnsiConsole.Write(tableAllAccounts);
        Console.WriteLine("");
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
                    StyleCS.PrintRed("Debes crear una cuenta antes.\n");
                }else { 
                    AddMoney(accounts);
                }
                break;
            case 3:
                if (!accountCreated) {
                    StyleCS.PrintRed("Debes crear una cuenta antes.\n");
                }else { 
                    RemoveMoney(accounts);
                }
                break;  
            case 4:
                if (!accountCreated) {
                    StyleCS.PrintRed("Debes crear una cuenta antes.\n");
                }else { 
                    ListTransactions(accounts);
                }
                break;
            case 5:
                if (!accountCreated) {
                    StyleCS.PrintRed("Debes crear una cuenta antes.\n");
                }else { 
                    ListAccounts(accounts);
                }
                break; 
            case 6:
                exit = true;
                break;
            default:
                StyleCS.PrintRed($"La opción {option} no está en el menú.\n");
                break;
        }
    }

}