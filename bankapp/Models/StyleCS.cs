using Spectre.Console;
namespace Models;

public class StyleCS {

    public static void PrintRed(string message) {
        AnsiConsole.MarkupLine("[red]{0}[/]", message);
    }

    public static void PrintGreen(string message) {
        AnsiConsole.MarkupLine("[green]{0}[/]", message);
    }

    public static void PrintUnderlineBold(string message) {
        AnsiConsole.MarkupLine($"[underline bold]{message}[/]");
    }

    public static void Title(string message) {
        var titleOption = new Panel("[blue]" + message + "[/]") 
        {
            Border = BoxBorder.Rounded,
            BorderStyle = new Style(Color.Blue)
        };
        AnsiConsole.Write(titleOption);
    }

    public static void DisplayMenu() {
        var panelMenu = new Panel("[bold]1 - Crear cuenta\n2 - Añadir dinero\n3 - Sacar dinero\n4 - Listar operaciones\n5 - Listar cuentas creadas\n6 - Salir[/]")
        {
            Border = BoxBorder.Heavy,
            Header = new PanelHeader("[bold]MENÚ[/]"),
            Padding = new Padding(3,1,3,1)
        };
        AnsiConsole.Write(panelMenu);
    }
    
}