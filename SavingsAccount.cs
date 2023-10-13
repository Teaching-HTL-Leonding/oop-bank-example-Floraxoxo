namespace Banking.Logic;

public class SavingsAccount : Account
{
    public decimal MinValue = -1000000;
    public decimal MaxValue = 10000000;
    public decimal MaxAmount = 0;
    public override bool IsAllowed(Transaction t)
    {
        if (t.AccountNumber == AccountNumber && MaxValue > CurrentBalance + t.Amount && MinValue < CurrentBalance + t.Amount && t.Amount > MaxAmount) {return true;}
        else {return false;}
    }
}

