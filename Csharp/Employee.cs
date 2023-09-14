using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company
{
    internal class Employee
    {
        //private string _empName;
        //private int _empId;
        //private float _currPay;
        //private EmpPayType _payType;
        public enum EmpPayType { Hourly, Salaried, Commission }
        private static int EmpIDSeed = 12300;
        public string EmpName { get; set; }
        public int EmpID { get; set; }
        public float CurrPay { get; set; }
        public EmpPayType PayType { get; set; }
        public string SocialSecurityNumber { get; set; }
        public Employee(string empName) : this(empName, 0, EmpPayType.Salaried, "null") { }
        public Employee(string empName, string socialSecurityNumber) : this(empName, 0, EmpPayType.Salaried, socialSecurityNumber) { }
        public Employee(string empName, float currPay) : this(empName, currPay, EmpPayType.Salaried, "null") { }
        public Employee(string empName, float currPay, EmpPayType payType) : this(empName, currPay, payType, "null") { }
        public Employee(string empName, float currPay, EmpPayType payType, string socialSecurityNumber)
        {
            this.EmpName = empName;
            this.EmpID = EmpIDSeed;
            this.CurrPay = currPay;
            this.PayType = payType;
            this.SocialSecurityNumber = socialSecurityNumber;
            EmpIDSeed++;
        }
        public void DisplayStats()
        {
            Console.WriteLine($"Emmployee name: {this.EmpName} ");
            Console.WriteLine($"Employee id: {this.EmpID}");
            Console.WriteLine($"Current paid amount: {this.CurrPay}");
            Console.WriteLine($"Paid type: {this.PayType}");
            Console.WriteLine($"Social security Number (SSN): {this.SocialSecurityNumber}");
        }

        public void GiveBonus(float amount)
        {
            switch (PayType)
            {
                case EmpPayType.Commission:
                    CurrPay += .10F * amount;
                    break;
                case EmpPayType.Salaried:
                    CurrPay += amount;
                    break;
                case EmpPayType.Hourly:
                    CurrPay += 40F * amount / 2080F;
                    break;
            }
        }
    }
}
