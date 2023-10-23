// See https://aka.ms/new-console-template for more information
using Models;

BankAccount account = new BankAccount("Paula", 100);
account.MakeDeposit(5000, DateTime.Now, "Colacao");
account.MakeDeposit(2000, DateTime.Now, "Churros");

var history = account.GetAccountHistory();
Console.WriteLine(history);

// try {
//     account.MakeDeposit(-2000, DateTime.Now, "bus");
// } catch (ArgumentOutOfRangeException e) {
//     Console.WriteLine("Exception " +e.ToString());
// } catch (Exception e) {
//     Console.WriteLine("Exception " +e.ToString());
// }


// try {
//     account.MakeWithdrawal(-200, DateTime.Now, "bus");
// } catch (ArgumentOutOfRangeException e) {
//     Console.WriteLine("Exception " +e.ToString());
// } catch (Exception e) {
//     Console.WriteLine("Exception " +e.ToString());
// }


// try {
//     account.MakeWithdrawal(1000000, DateTime.Now, "hipoteca");
// } catch (ArgumentOutOfRangeException e) {
//     Console.WriteLine("Exception " +e.ToString());
// } catch (Exception e) {
//     Console.WriteLine("Exception " +e.ToString());
// }

var balance = account.Balance;
var stringifyAccount = account.ToString();
Console.WriteLine(stringifyAccount);

BankAccount account2 = new BankAccount("Paula2", 200);

Console.WriteLine("Bye, World!");
