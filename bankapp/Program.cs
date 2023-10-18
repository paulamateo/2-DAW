// See https://aka.ms/new-console-template for more information
using Models;

Console.WriteLine("Hello, World!");

BankAccount account = new BankAccount("Paula", 100);
var stringifyAccount = account.ToString();
Console.WriteLine(stringifyAccount);

BankAccount account2 = new BankAccount("Paula2");

Console.WriteLine("Bye, World!");
