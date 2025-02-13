using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    public class BankAccount
    {
        private int balance;
        private int overdraftLimit = -500;

        public BankAccount(int balance = 0)
        {
            this.balance = balance;
        }

        public void Deposit(int amount)
        {
            this.balance += amount;
            Console.WriteLine($"Deposited amount ${amount}, balance is now ${balance}");
        }

        public bool Withdraw(int amount)
        {
            if (balance - amount >= overdraftLimit)
            {
                this.balance -= amount;
                Console.WriteLine($"Withdrew ${amount}, balance is now ${balance}");
                return true;
            }
            return false;
        }

        public override string ToString()
        {
            return $"{nameof(balance)}: {balance}";
        }
    }
}
