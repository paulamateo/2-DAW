using Models;

List<BankAccount> accounts = new List<BankAccount>();

StyleCS.Title("BIENVENID@ AL BANCO SAN VALERO!");

bool exit = false;
bool accountCreated = false;

while(!exit) {
    StyleCS.DisplayMenu();
    StyleCS.PrintUnderlineBold("\nELIGE UNA OPCIÓN:");
    try {
        var option = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("");
        Menu.DisplayOptionsMenu(option, accounts, ref accountCreated, ref exit);
    }catch (FormatException) {
        StyleCS.PrintRed($"Error de formato. Debes introducir un carácter válido.\n");
    }
}