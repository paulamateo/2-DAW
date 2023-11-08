// using Newtonsoft.Json;
using System.Text.Json;
namespace Models;

public class UtilsJSON {

    private static readonly string folderName = "ACCOUNTS_CREATED";

    public static void SaveJson(string fileName, List<Transaction> transactions) { 
        try {
            string fullPath = Path.Combine(folderName, fileName);
            Directory.CreateDirectory(folderName);
            var options = new JsonSerializerOptions { WriteIndented = true };
            string json = JsonSerializer.Serialize(transactions, options);
            File.WriteAllText(fullPath, json);
        }catch (Exception e) {
            Console.WriteLine($"Error: {e.Message}");
        }
    } 

    public static List<Transaction> LoadJson(string fileName) {
        try {
            string fullPath = Path.Combine(folderName, fileName);
            string json = File.ReadAllText(fullPath);
            List<Transaction>? loadedTransactions = JsonSerializer.Deserialize<List<Transaction>>(json);
            return loadedTransactions;
        } catch (FileNotFoundException) {
            Console.WriteLine($"El archivo {fileName} no existe.");
        } catch (Exception e) {
            Console.WriteLine($"Error al cargar las transacciones: {e.Message}");
        }
        return new List<Transaction>();
    }
    
}