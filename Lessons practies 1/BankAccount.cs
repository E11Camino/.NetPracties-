using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lessons_practies_1
{
    internal class BankAccount
    {
        public int Number { get; }
        public int BranchNumber { get; }
        public string IBAN { get; }

        public BankAccount()
        {
        }

        public BankAccount(int number, int branchNumber, string iban)
        {
            Number = number;
            BranchNumber = branchNumber;
            IBAN = iban;
        }

        public void PrintInfo()
        {
            Console.WriteLine("Bank Account number:{0}", Number);
            Console.WriteLine("Branch number:" + BranchNumber);
            Console.WriteLine($"IBAN number:{IBAN}");
        }
    }
}


