namespace Models;

public class BankAccount {
    public string? Number {get;}
    public string Owner {get;set;}
    public decimal Balance {get;}

    private static int accountNumber_seed = 1000;

    public void MakeDeposit(decimal amount, DateTime date, string note) {

    }

    public void MakeWithdrawal(decimal amount, DateTime date, string note) {
        
    }

    public override string ToString() {
        return Owner ?? "No Owner"; //SIGNIFICADO: si esto es nulo, devuelvo "No Owner"
    }

    public BankAccount(string name) {
        Owner = name;
        Number = accountNumber_seed.ToString();
        accountNumber_seed++;
        Balance = 0;
    }

    public BankAccount(string name, decimal initialBalance) {
        Owner = name;
        this.Balance = initialBalance;
        Number = "1";
        accountNumber_seed++;
    }

}