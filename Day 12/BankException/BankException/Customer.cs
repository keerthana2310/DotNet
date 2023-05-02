using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankException
{
    internal class Customer
    {
        private string v1;
        private int v2;
        private int v3;

        public Customer(string v1, int v2, int v3)
        {
            this.v1 = v1;
            this.v2 = v2;
            this.v3 = v3;
        }

        class customer

        {

            string name; int accno; int balance;

            public customer(string n, int a, int b)

            {

                name = n;

                accno = a;

                balance = b;

            }

            public void withdraw(int amt)

            {

                if (balance - amt <= 100)

                    throw new bankexception(accno, balance);

                balance -= amt;

            }

            public int getbalance()

            {

                return balance;

            }

        }
    }
}
