using Models;
using Spectre.Console;

List<BankAccount> accounts = new List<BankAccount>();

AnsiConsole.Write(StyleCS.headerProgram());

bool exit = false;
bool accountCreated = false;

while(!exit) {
    Menu.DisplayMenu();
    Console.Write("\nELIGE UNA OPCIÓN: ");
    try {
        var option = Convert.ToInt32(Console.ReadLine());
        Menu.DisplayOptionsMenu(option, accounts, ref accountCreated, ref exit);
    }catch (FormatException) {
        StyleCS.PrintRed($"Error de formato. Debes introducir un carácter válido.");
    }
}