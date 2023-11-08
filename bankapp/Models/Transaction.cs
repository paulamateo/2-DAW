namespace Models;

public class Transaction {
    public decimal Amount { get; }
    public DateTime Date { get; }
    public string Note { get; }

    public Transaction(decimal amount, DateTime date, string note) {
        Amount = amount;
        Date = date;
        Note = note;
    }

    /*public static List<Transaction> LoadJson(string pathFile) {
        //loadjson
        var transactions = new List<Transaction>();
        return transactions;
    }

    public static List<Transaction> LoadTransactions() {
        //loadjson
        var transactions = UtilsJSON.LoadJson(pathJSON);
        return transactions;
    }*/

}