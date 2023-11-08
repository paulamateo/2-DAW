using Models;

List<BankAccount> accounts = new List<BankAccount>();

Console.WriteLine("Bienvenid@ a BANCO SAN VALERO");
bool exit = false;
bool accountCreated = false;

while(!exit) {
    Menu.DisplayMenu();
    Console.Write("\nELIGE UNA OPCIÓN: ");
    try {
        var option = Convert.ToInt32(Console.ReadLine());
        Menu.DisplayOptionsMenu(option, accounts, ref accountCreated, ref exit);
    }catch (FormatException) {
        Console.WriteLine($"Error de formato. Debes introducir un carácter válido.");
    }
}