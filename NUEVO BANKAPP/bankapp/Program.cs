using Models;

Menu.Program();

//CREACION CUENTA. Hacer un deposito + hacer un retiro (manejo excepciones)
// BankAccount account1 = new BankAccount("Paula", 100);
// try {
//     account1.MakeDeposit(2000, DateTime.Now, "Bus");
//     account1.MakeWithdrawal(100, DateTime.Now, "Regalo");
//     string history = account1.GetAccountHistory();
//     Console.WriteLine(history);
// } catch (ArgumentOutOfRangeException e) {
//     Console.WriteLine("Exception " +e.ToString());
// } catch (InvalidOperationException e) {
//     Console.WriteLine("Exception " +e.ToString());
// }

// var balance = account1.Balance;
// var stringifyAccount = account1.ToString();
// Console.WriteLine(stringifyAccount);




//INTERESES
// BankAccount bankaccPaula = new InterestEarningAccount("Paula", 1000);
// bankaccPaula.MakeDeposit(1000, DateTime.Now, "Cumpleaños");
// bankaccPaula.PerformMonthlyOperation();
// Console.WriteLine(bankaccPaula.GetAccountHistory());





//CREACION USUARIO
// User userAdmin = new User {
//     Name = "Paula",
//     Lastname = "Mateo",
//     NIF = "XXXXXXXXG"
// };

// User userNull = new User{};
// Console.WriteLine(userAdmin.ToString());
// Console.WriteLine(userNull.ToString());

// var usersDict = new Dictionary<int, User>() {
//     {100, userAdmin}, {101, userNull}, {102, new User {
//         Name = "Pipo",
//         Lastname = "Pipez",
//         NIF = "usado"
//     }} 
// };

// Console.WriteLine(usersDict.ToString());
// Console.WriteLine(usersDict[102].Name);

// try {
//     usersDict.Add(103, userAdmin);
// }catch {

// }

// foreach (var index in Enumerable.Range(100,3)) {
//     Console.WriteLine(usersDict[index].Name);
// }