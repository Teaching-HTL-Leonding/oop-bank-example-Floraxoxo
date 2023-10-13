namespace Banking.Logic;

public class BusinessAccount : Account
{ 
    public decimal MinValue = -1000000;
    public decimal MaxValue = 100000000;
    public decimal MaxAmount = 100000;
    public override bool IsAllowed(Transaction t)
    {
        if (t.AccountNumber == AccountNumber && MaxValue > CurrentBalance + t.Amount && MinValue < CurrentBalance + t.Amount && t.Amount > MaxAmount) {return true;}
        else {return false;}
    }
    
}

