using System.Text.Json;

namespace Models;

public class BankAccount {
    public string Number { get; }
    public string Owner { get; set; }
    private List<Transaction> transactions = new List<Transaction>();
    private static int accountNumber_seed = 1000;
    public decimal Balance {
        get {
            decimal balance = 0;
            foreach (Transaction item in transactions) {
                balance += item.Amount;
            }
            return balance;
        }
    }

    public BankAccount(string owner, decimal initialBalance) {
        Number = accountNumber_seed.ToString();
        Owner = owner;
        MakeDeposit(initialBalance, DateTime.Now, "First deposit");
        accountNumber_seed++;
    }

    public  void MakeDeposit(decimal amount, DateTime date, string note) {
        if (amount <= 0) {
            throw new ArgumentOutOfRangeException(nameof(amount), "El depósito debe ser positivo.");
        }
        var deposit = new Transaction(amount, date, note);
        transactions.Add(deposit);
        SaveTransactionsJson();
    }

    public void MakeWithdrawal(decimal amount, DateTime date, string note) {
        if (amount <= 0) {
            throw new ArgumentOutOfRangeException(nameof(amount), "No puedes quitar un depósito negativo."); 
        }

        if ((Balance - amount) < 0) {
            throw new InvalidOperationException("No puedes sacar dinero de donde no hay.");
        }
        var withdrawal = new Transaction(-amount, date, note);
        transactions.Add(withdrawal);
        SaveTransactionsJson();
    }

    public string GetBalance() {
        return $"Tienes {Balance}€ en tu cuenta, {Owner}.";
    }
     public string GetNumberAccount() {
        return $"{Owner}\t\t{Number}";
    }
    public string GetAllAcounts() {
        return $"{Owner}\t\t{Balance}€\t{Number}";
    }

    public virtual void PerformMonthlyOperation() { }

    public override string ToString() {
        return Owner ?? "No Owner";
    }


    //JSON
    public void SaveTransactionsJson() {
        UtilsJSON.SaveJson($"{Number}.json", transactions);
    }

    public bool LoadTransactionsJson() {
        List<Transaction> loadedTransactions = UtilsJSON.LoadJson($"{Number}.json");
        if (loadedTransactions.Count > 0) {
            transactions = loadedTransactions;
            return true;
        }
        return false;
    }

    public void GetTransactions() {
        if (LoadTransactionsJson()) {
            decimal currentBalance = 0;
            foreach (var transaction in transactions) {
                currentBalance += transaction.Amount;
                Console.WriteLine($"{transaction.Date.ToShortDateString()}\t{transaction.Amount}\t{currentBalance}\t{transaction.Note}");
            }
        }
    }

    /*LISTAR TRANSACCIONES SIN JSON  
    public void GetTransactions() {
        decimal currentBalance = 0;
        foreach (var transaction in transactions) {
            currentBalance += transaction.Amount;
            Console.WriteLine($"{transaction.Date.ToShortDateString()}\t{transaction.Amount}\t{currentBalance}\t{transaction.Note}");
        }
    }*/
    
}