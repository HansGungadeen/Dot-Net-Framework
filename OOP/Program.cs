using System;

namespace OOP
{
    class Customer
    {
        int AccNo;
        string Name;
        double Bal;

        public void CreateCustomer(int a,string n,double b)
        {
            AccNo = a;
            Name = n;
            Bal = b;
        }

        public void BalEnq()
        {
            Console.WriteLine("AccNo:{0} Name:{1} Balance:{2}",AccNo,Name,Bal);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Customer c = new Customer();

            c.CreateCustomer(1234, "Hack", 7800);
            c.BalEnq();


            Console.ReadLine();
            


        }
    }
}
