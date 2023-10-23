namespace Models;

public class Transaction { //EN SINGULAR, NO TRANSACTIONS. las clases normalmente son en singular
    public decimal Amount {get;}
    public DateTime Date {get;}
    public string Note {get;} = "";

    public Transaction(decimal amount, DateTime date, string note) {
        Amount = amount;
        Date = date;
        Note = note;
    }
}