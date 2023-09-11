using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperBank
{
    internal class BankAccount
    {
        public static int AccountNumberSeed = 12800782;
        public string Number { get; }
        public string Owner { get; set; }
        public decimal Balance { get
            {
                decimal balance = 0;
                foreach (var item in allTransactions)
                    balance += item.Amount;
                return balance;
            }; }

        private List<Transaction> allTransactions = new List<Transaction>();
        public BankAccount(string owner, decimal initialBalance)
        {
            this.Owner = owner;
            this.Number = AccountNumberSeed.ToString();
            AccountNumberSeed++;
            this.MakeDeposit(initialBalance, DateTime.Now, "Initial Balance");
        }

        public void MakeDeposit(decimal amount, DateTime date, string note)
        {
            if (amount <= 0)
                throw new ArgumentOutOfRangeException(nameof(amount), "Amount of deposit must be positive");
            var deposit = new Transaction(amount, date, note);
            allTransactions.Add(deposit);
        }

        public void MakeWithdrawal(decimal amount, DateTime date, string note)
        {
            if (amount <= 0)
                throw new ArgumentOutOfRangeException(nameof(amount), "Amount of withdrawal must be positive");
            if (amount > this.Balance)
                throw new InvalidOperationException("Insufficient funds for this withdrawal");
            var withdrawal = new Transaction(-amount, date, note); 
            allTransactions.Add(withdrawal);
        }
        
        public string GetTransactionHistory()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Date\tAmount\tNote");
            foreach (var item in allTransactions)
                sb.AppendLine($"{item.Date}\t{item.Amount}\t{item.Note}");
            return sb.ToString();
        }
    }
}
