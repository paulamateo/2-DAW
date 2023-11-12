using Spectre.Console;
namespace Models;

public class StyleCS {
    public static void PrintRed(string message) {
        AnsiConsole.MarkupLine("[red]{0}[/]", message);
    }

    public static void PrintGreen(string message) {
        AnsiConsole.MarkupLine("[green]{0}[/]", message);
    }

    public static Panel headerProgram() {
        var headerProgram = new Panel("Bienvenid@ al BANCO SAN VALERO!");
        headerProgram.Border = BoxBorder.Rounded;
        return headerProgram;
    }
    
}