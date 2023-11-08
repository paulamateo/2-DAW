using Models;
public class Program {
    public static List<BankAccount> accounts = new List<BankAccount>();
    public static void Main(string[] args) {
        Console.WriteLine("Bienvenid@ a BANCO SAN VALERO");
        bool exit = false;
        bool accountCreated = false;

        while(!exit) {
            Menu.DisplayMenu();
            Console.Write("\nELIGE UNA OPCIÓN: ");
            try {
                var option = Convert.ToInt32(Console.ReadLine());
                switch(option) {
                case 1:
                    Menu.CreateNewAccount(accounts);
                    accountCreated = true;
                    break;
                case 2:
                    if (!accountCreated) {
                        Console.WriteLine("Debes crear una cuenta antes.");
                    }else { 
                        Menu.AddMoney(accounts);
                    }
                    break;
                case 3:
                    if (!accountCreated) {
                        Console.WriteLine("Debes crear una cuenta antes.");
                    }else { 
                        Menu.RemoveMoney(accounts);
                    }
                    break;  
                case 4:
                    if (!accountCreated) {
                        Console.WriteLine("Debes crear una cuenta antes.");
                    }else { 
                        Menu.ListTransactions(accounts);
                    }
                    break;
                case 5:
                    if (!accountCreated) {
                        Console.WriteLine("Debes crear una cuenta antes.");
                    }else { 
                        Menu.ListAccounts(accounts);
                    }
                    break; 
                case 6:
                    exit = true;
                    break;
                default:
                    Console.WriteLine($"La opción {option} no está en el menú.");
                    break;
                }
            }catch (FormatException) {
                Console.WriteLine($"Error de formato. Debes introducir un carácter válido.");
            }
        }
    }
}

