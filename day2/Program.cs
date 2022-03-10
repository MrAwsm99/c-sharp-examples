using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            

            //Task 1//
            //int age;
            //Console.Write("Enter birthdate \n");
            //DateTime data = DateTime.Parse(Console.ReadLine());
            //age = DateTime.Now.Subtract(data).Days;
            //Console.WriteLine($" age is {age / 365}.");

            //Task 2//
            var message = $" the date is {DateTime.Now}.";
            Console.WriteLine(message);

            //Task 3//
            Console.WriteLine("Enter name");
            string fname = Console.ReadLine();

            StringBuilder name = new StringBuilder();
            string y = Console.ReadLine();
            if(y == "yes")
            {
                string s = Console.ReadLine();
                name.Append(s);
                Console.WriteLine(name);
            }




            //Task 4//
            int f = 0;
            Console.Write(f.GetType() == typeof(int));

            //Task 5//
            //    Customer customer = new Customer();
            //    Console.WriteLine("Enter Name");
            //    customer.Name = Console.ReadLine();
            //    Console.WriteLine("Enter Amount");
            //    customer.TotalAmount = int.Parse(Console.ReadLine());
            //    Console.WriteLine("Enter Age");
            //    customer.age = int.Parse(Console.ReadLine());

            //    switch (customer.age)
            //    {
            //        case int n when (n <= 25):
            //            Console.WriteLine("Eligible for 10% loan " + customer.TotalAmount * 10 / 100); break;

            //        case int n when (n > 25 && n <= 30):
            //            Console.WriteLine("Eligible for 20% loan " + customer.TotalAmount * 20 / 100); break;

            //        case int n when (n > 30 && n <= 35):
            //            Console.WriteLine("Eligible for 30% loan " + customer.TotalAmount * 30 / 100); break;

            //        case int n when (n > 35 && n <= 40):
            //            Console.WriteLine("Eligible for 35% loan " + customer.TotalAmount * 35 / 100); break;

            //        case int n when (n > 40 && n <= 45):
            //            Console.WriteLine("Eligible for 40% loan " + customer.TotalAmount * 40 / 100); break;


            //        case int n when (n > 45 && n <= 50):
            //            Console.WriteLine("Eligible for 45% loan " + customer.TotalAmount * 45 / 100); break;


            //        default:
            //            Console.WriteLine("Eligible for 50% loan " + customer.TotalAmount * 50 / 100); break;
            //    }
            //}
            //struct Customer
            //{
            //    public string Name;
            //    public int TotalAmount;
            //    public int age;
            //}
        }
    }
}

