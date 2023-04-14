using System;
using System.Runtime.InteropServices;

namespace AccountApp
{
    public class Account
    {
        public int Id;
        public string _name;
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if (value.Length > 15)
                    Console.WriteLine("The name is too big");
                _name = value;
            }
        }
        private decimal _balance;

        public decimal Balance
        {
            get
            {
                return _balance;
            }
            
        }


        public void createaccount(int id, string name, decimal balance)
        {
            Id = id;
            _name = name;
            _balance = balance;
        }

        public void displayinfo()
        {
            Console.WriteLine(" Account Information");
            Console.WriteLine("Account Id:" + Id);
            Console.WriteLine("Name:" + _name);
            Console.WriteLine("Opening Balance:" + _balance);
        }


        public void Deposit(decimal amount)
        {
            _balance += amount;
            Console.WriteLine("Deposit amount"+ _balance);
        }
        public void Withdraw(decimal amount)
        {
            if (_balance - amount < 500)
                Console.WriteLine("Insufficient Balance");
            else
                this._balance -= amount;
            Console.WriteLine("Balance after withdrawal" +_balance);
        

        
        }
        public void CheckBalance()
        {
            Console.WriteLine("Balance is"+_balance);
        }

    }
}
