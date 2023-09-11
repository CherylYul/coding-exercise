using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp
{
    internal class BankAccount
    {
        public static int AccountNumberSeed = 12800782;
        public string Number { get; }
        public string Owner { get; set; }
        public decimal Balance { get; }
        public BankAccount(string owner,decimal balance)
        {
            this.Owner = owner;
            this.Balance = balance;
            this.Number = AccountNumberSeed.ToString();
        }
    }
}
