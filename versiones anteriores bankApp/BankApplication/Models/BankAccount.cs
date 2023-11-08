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
    }

    public void MakeWithdrawal(decimal amount, DateTime date, string note) {
        if (amount <= 0) {
            throw new ArgumentOutOfRangeException(nameof(amount), "No puedes quitar un depósito negativo."); //por teclado: -100
        }

        if ((Balance - amount) < 0) {
            throw new InvalidOperationException("No puedes sacar dinero de donde no hay.");
        }
        var withdrawal = new Transaction(-amount, date, note);
        transactions.Add(withdrawal);
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

   public void GetTransactions() {
        decimal currentBalance = 0;
        foreach (var transaction in transactions) {
            currentBalance += transaction.Amount;
            Console.WriteLine($"{transaction.Date.ToShortDateString()}\t{transaction.Amount}\t{currentBalance}\t{transaction.Note}");
        }
    }

    public virtual void PerformMonthlyOperation() { }

    public override string ToString() {
        return Owner ?? "No Owner";
    }
}