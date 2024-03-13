using System.Text;

namespace Classes;

public class BankAccount
{
    public string Number { get; }
    public string Owner { get; set; }
    public decimal Balance
    {
        get
        {
            decimal balance = 0;
            foreach (var item in allTransaction)
            {
                balance += item.Amount;
            }
            return balance;

        }
    }
    private static int accountNum = 43536622;
    private List<Transaction> allTransaction = new List<Transaction>();

    public BankAccount()
    {

    }

    public BankAccount(string name, decimal initialBalance)
    {
        this.Owner = name;
        //this.Balance = initialBalance;
        MakeDeposit(initialBalance, DateTime.Now, "Initial Balance");
        this.Number = accountNum.ToString();
        accountNum++;
    }

    public void MakeDeposit(decimal amount, DateTime date, string note)
    {
        if(amount<0)
        {
            throw new ArgumentOutOfRangeException(nameof(amount), "Amount of deposite must be greater than 0");

        }
        var deposit = new Transaction(amount,date,note);
        allTransaction.Add(deposit);
    }

    public void MakeWithdrawal(decimal amount, DateTime date, string note)
    {
        if(amount<=0)
        {
            throw new ArgumentOutOfRangeException(nameof(amount), "Amount of withdrawal must be positive");

        }
        if(Balance - amount<0)
        {
            throw new InvalidOperationException("no sufficient fund");
        }
        var withdrawal = new Transaction(-amount, date, note);
        allTransaction.Add(withdrawal);
    }
    public string GetAccountHistory()
    {
        var report = new StringBuilder();
        report.AppendLine("Date\t\t Amount\t\t Note");
        foreach(var item in allTransaction)
        {
            report.AppendLine($"{item.Date.ToShortDateString()}\t{item.Amount}\t{item.Notes}");
        }
        return report.ToString();
    }
}