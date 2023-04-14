using System;

namespace AccountApp
{
    public class Account
    {
        public int Id;
        public string Name;
        public decimal Balance;


        public void createaccount(int id, string name, decimal balance)
        {
            Id = id;
            Name = name;
            Balance = balance;
        }

        public void displayinfo()
        {
            Console.WriteLine(" Account Information");
            Console.WriteLine("Account Id:" + Id);
            Console.WriteLine("Name:" + Name);
            Console.WriteLine("Opening Balance:" + Balance);
        }


        public void Deposit(decimal amount)
        {
            Balance += amount;
            Console.WriteLine("Deposit amount"+ Balance);
        }
        public void Withdraw(decimal amount)
        {
            if (Balance - amount < 500)
                Console.WriteLine("Insufficient Balance");
            else
                this.Balance -= amount;
            Console.WriteLine("Balance after withdrawal" +Balance);
        

        
        }
    }
}
