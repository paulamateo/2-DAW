using System.Text.Json;
using Spectre.Console;

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

    public virtual void PerformMonthlyOperation() { }

    public override string ToString() {
        return Owner ?? "No Owner";
    }

    public List<string[]> GetTransactions() {
        List<string[]> transactionRows = new List<string[]>();
        if (LoadTransactionsJson()) {
            decimal currentBalance = 0;
            foreach (var transaction in transactions) {
                currentBalance += transaction.Amount;
                string[] row = {
                    transaction.Date.ToShortDateString(),
                    transaction.Amount.ToString(),
                    currentBalance.ToString(),
                    transaction.Note
                };
                transactionRows.Add(row);
            }
        }
        return transactionRows;
    }

    public List<string[]> GetNumberAccounts() {
        List<string[]> numberAccountsRows = new List<string[]>();
        string[] row = {Owner, Number};
        numberAccountsRows.Add(row);
        return numberAccountsRows;
    }

    public List<string[]> GetAllAccounts() {
        List<string[]> accountsRows = new List<string[]>();
        string[] row = {Owner, Balance.ToString(), Number};
        accountsRows.Add(row);
        return accountsRows;
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

}