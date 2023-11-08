namespace Models;

public class CreditCardAccount: BankAccount {
    private decimal interestRate = 0.05M;
    public CreditCardAccount(string name, decimal initialBalance): base(name, initialBalance) {

    }
    
    
    /*public override void PerformMonthlyOperation() {
        Decimal interestEarned = Balance*interestRate;
        MakeDeposit(interestEarned, DateTime.Now.AddDays(30), "Monthly Earnings");
    }

    public override void MakeWithdrawal(decimal amount, DateTime date, string note) {
        if ((Balance - amount) < 0) { //si saca más dinero del que hay
            decimal negativeBalance = System.Math.Abs(Balance - amount);
            decimal monthlyInterest = interestRate*negativeBalance;
            Console.WriteLine("INTERESES: " +monthlyInterest+ " €");
        }
    }*/

}