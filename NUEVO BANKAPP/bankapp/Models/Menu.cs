namespace Models;

public class Menu {

    public static void Program() {

        var option = 0;

        do {
            MainMenu(); // Mostrar el menú
            option = int.Parse(Console.ReadLine()); // Leer la opción y convertirla a un entero

            switch(option) {
                case 1:
                    CreateAccount();
                    break;
                case 2:
                    MakeADeposit();
                    break;
                case 3:
                    WithdrawFunds();
                    break;
                case 4:
                    ListActivities();
                    break;
                case 5:
                    ListAccounts();
                    break;
            }

        }while (option != 6);


        //     case 4:
        //         //Console.WriteLine(bankaccPaula.GetAccountHistory());
        //         break;
        // }

        // var option = Console.ReadLine();
        // int optionNumber;
        // if (int.TryParse(option, out optionNumber)) {
        //     if (optionNumber < 0 && optionNumber > 3) return;
        //     Console.WriteLine($"Converted '{option}' to {optionNumber}");
        // }else {

        // }
    }

    public static void MainMenu() {
        Console.WriteLine("TU BANCO DE CONFIANZA");
        Console.WriteLine("----------------------");
        Console.WriteLine("1 - CREAR CUENTA");
        Console.WriteLine("2 - AÑADIR DINERO");
        Console.WriteLine("3 - SACAR DINERO");
        Console.WriteLine("4 - LISTAR OPERACIONES");
        Console.WriteLine("5 - LISTAR CUENTAS");
        Console.WriteLine("6 - SALIR");
        Console.WriteLine("----------------------");
        Console.WriteLine("Elige una opción: ");
    }

    public static void CreateAccount() {
        Console.WriteLine("RELLENA LOS DATOS");
        Console.WriteLine("Propietario de la cuenta:");
        string ownerName = Console.ReadLine();
        Console.WriteLine("Saldo inicial:");
        decimal balance = Console.Read();
        BankAccount bAccount = new BankAccount(ownerName, balance); //DICCIONARIO, MIRAR!!!!!!!!!!

            
        //BankAccount account1 = new BankAccount("Paula", 100);
    }

    public static void MakeADeposit() {
        Console.WriteLine("RELLENA LOS DATOS");
        Console.WriteLine("Cantidad que quieres ingresar:");
        decimal moneyDeposited = Console.Read();
        Console.WriteLine("Concepto:");
        string noteMoneyDeposited = Console.ReadLine();

        // bAccount.MakeDeposit(moneyDeposited, DateTime.Now, noteMoneyDeposited);
    }

    public static void WithdrawFunds() {
        Console.WriteLine("RELLENA LOS DATOS");
        Console.WriteLine("Cantidad que quieres retirar:");
        decimal moneyWithdrawn = Console.Read();
        Console.WriteLine("Concepto:");
        string noteMoneyWithdrawn = Console.ReadLine();

        //account1.MakeWithdrawal(100, DateTime.Now, "Regalo");
    }

    public static void ListActivities() {
        //Console.WriteLine(bankaccPaula.GetAccountHistory());
    }

    public static void ListAccounts() {
        //diccionario
    }




}