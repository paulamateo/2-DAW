// See https://aka.ms/new-console-template for more information
using Models;

// User userAdmin = new User {
//     Name = "Paula",
//     Lastname = "Mateo",
//     NIF = "XXXXXXG"
// };

// User userNull = new User{};

// Console.WriteLine(userAdmin.ToString());
// Console.WriteLine(userNull.ToString());

// var usersDict = new Dictionary<int, User>(){
//     { 100, userAdmin}, {101, userNull}, {102, new User {
//         Name = "Pipo",
//         Lastname = "Pipez",
//         NIF = "usado"
//     }}
// };

// Console.WriteLine(usersDict.ToString());

// Console.WriteLine(usersDict[102].Name);

// try {
//     usersDict.Add(103, userAdmin);
//     // usersDict.Add(102, user);
// }catch {

// }


// foreach (var index in Enumerable.Range(100,3)) {
//     Console.WriteLine(usersDict[index].Name);
// }

// BankAccount account = new BankAccount("Paula", 100);
// account.MakeDeposit(5000, DateTime.Now, "Colacao");
// account.MakeDeposit(2000, DateTime.Now, "Churros");

// var history = account.GetAccountHistory();
// Console.WriteLine(history);

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

// var balance = account.Balance;
// var stringifyAccount = account.ToString();
// Console.WriteLine(stringifyAccount);

// BankAccount account2 = new BankAccount("Paula2", 200);

// Console.WriteLine("Bye, World!");




// BankAccount bankaccMarcos = new InterestEarningAccount("Marcos", 1000);
// bankaccMarcos.MakeDeposit(1000, DateTime.Now, "Cumpleaños");
// bankaccMarcos.PerformMonthlyOperation(); //monthly operation simulation

// Console.WriteLine(bankaccMarcos.GetAccountHistory());


//CREDITCARDACCOUNT
BankAccount bankaccP = new CreditCardAccount("Paula", 2000);
bankaccP.MakeWithdrawal(-3000, DateTime.Now, "Luz");
Console.WriteLine(bankaccP.GetAccountHistory()); 

