using System.Reflection.Metadata.Ecma335;
using System.Runtime;

namespace Banking.Logic;

public class CheckingAccount : Account
{
    public decimal MinValue = -10000;
    public decimal MaxValue = 10000000;
    public decimal MaxAmount = 10000;
    public override bool IsAllowed(Transaction t)
    {
        if (t.AccountNumber == AccountNumber && MaxValue > t.Amount + CurrentBalance && MinValue < t.Amount + CurrentBalance && t.Amount < MaxAmount) {return true;}
        else {return false;}
    }
}