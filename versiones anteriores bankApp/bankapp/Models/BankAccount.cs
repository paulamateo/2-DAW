namespace Models;

public class BankAccount {
    public string? Number {get;}
    public string Owner {get;set;}
    public decimal Balance {
        get {
            decimal balance = 0;
            foreach (Transaction item in transactions) {
                balance += item.Amount;
            }
            return balance;
        }
    }

    private static int accountNumber_seed = 1000;

    public /*private*/ List<Transaction> transactions = new List<Transaction>();

    public void MakeDeposit(decimal amount, DateTime date, string note) {
        // if (amount <= 0) return;
        if (amount <= 0) {
            throw new ArgumentOutOfRangeException(nameof(amount), "No puede añadirse un depósito negativo");
        }
        // DateTime trimmedDate = new DateTime(2023, 10, 23, 18, 26, 0);
        if (date > DateTime.Now) {
            throw new InvalidOperationException("La fecha no puede ser posterior a la actual");
        }
        var deposit = new Transaction(amount, date, note);
        transactions.Add(deposit);
    }

    public virtual /*sin virtual*/ void MakeWithdrawal(decimal amount, DateTime date, string note) {
       if (amount <= 0) {
            throw new ArgumentOutOfRangeException(nameof(amount), "No puede quitar un depósito negativo");
        }
        if ((Balance - amount) < 0) {
            throw new InvalidOperationException("No puedes sacar dinero de donde no hay");
        }
        var withdrawal = new Transaction(-amount, date, note);
        transactions.Add(withdrawal);
    }

    public BankAccount(string name) {
        Owner = name;
        Number = accountNumber_seed.ToString();
        accountNumber_seed++;
        // Balance = 0;
    }

    public BankAccount(string name, decimal initialBalance = 0) {
        Owner = name;
        // this.Balance = initialBalance;
        Number = accountNumber_seed.ToString();
        MakeDeposit(initialBalance, DateTime.Now, "First deposit");
        accountNumber_seed++;
    }

    public override string ToString() {
        return Owner ?? "No Owner"; //SIGNIFICADO: si esto es nulo, devuelvo "No Owner"
    }

    public string GetAccountHistory() {
        var history = new System.Text.StringBuilder();
        decimal balance = 0;
        history.AppendLine("Date\tAmount\tBalance\tNote");
        foreach (var item in transactions) {
            balance += item.Amount;
            history.AppendLine($"{item.Date.ToShortDateString()}\t{item.Amount}\t{balance}\t{item.Note}");
        }
        return history.ToString();
    }

    public virtual void PerformMonthlyOperation() { } //VIRTUAL ES PARA SOBREESCRIBIR, PARA HACER OVERRIDE

}