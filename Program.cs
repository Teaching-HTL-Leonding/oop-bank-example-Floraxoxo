using Banking.Logic;

Account myAccount;
Transaction myTransaction = new();

Console.Write("Type of account ([c]hecking, [b]usiness, [s]avings): ");
var accountType = Console.ReadLine()!;

switch(accountType)
{
    case "c": myAccount = new CheckingAccount(); break;
    case "b": myAccount = new BusinessAccount(); break;
    case "s": myAccount = new SavingsAccount(); break;
    default: return;
}

Console.Write("Account number: ");
myAccount.AccountNumber = Console.ReadLine()!;
Console.Write("Account holder: ");
myAccount.AccountHolder = Console.ReadLine()!;
Console.Write("Current balance: ");
myAccount.CurrentBalance = decimal.Parse(Console.ReadLine()!);

Console.Write("Transaction account number: ");
myTransaction.AccountNumber = Console.ReadLine()!;
Console.Write("Transaction description: ");
myTransaction.AccountNumber = Console.ReadLine()!;
Console.Write("Transaction amount: ");
myTransaction.Amount = decimal.Parse(Console.ReadLine()!);
Console.Write("Transaction timestamp: ");
myTransaction.Timestamp = DateTime.Parse(Console.ReadLine()!);

if (myAccount.TryExecute(myTransaction)) {Console.WriteLine($"Transaction executed successfully. The new current balance is {myAccount.CurrentBalance}€.");}
else {Console.WriteLine("Transaction not allowed");}





