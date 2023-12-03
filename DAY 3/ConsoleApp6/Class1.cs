<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{

    public class account
    {
        String name;
        int id;
        double balance;

       public account(String name, int id , int balance)
        {
            this.name = name;
            this.id = id;
            this.balance = balance;

        }

        public void deposit(int amt)
        {
            balance += amt;
        }

    public void withdraw(int amt)
        {
            if (amt < balance )
                balance-= amt;
            else
            {
                Console.WriteLine("insufficient Balance");
            }
        }

        public void display()
        {
            Console.WriteLine($"name={name}  id={id} balance={balance}");
        }
    }
}
=======
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{

    public class account
    {
        String name;
        int id;
        double balance;

       public account(String name, int id , int balance)
        {
            this.name = name;
            this.id = id;
            this.balance = balance;

        }

        public void deposit(int amt)
        {
            balance += amt;
        }

    public void withdraw(int amt)
        {
            if (amt < balance )
                balance-= amt;
            else
            {
                Console.WriteLine("insufficient Balance");
            }
        }

        public void display()
        {
            Console.WriteLine($"name={name}  id={id} balance={balance}");
        }
    }
}
>>>>>>> c0f33018bab0ac77edefa338639e662c63245f23
