using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day3
{
    //Task 1
    public interface userdata
    {
        void data();
    }
    public interface premium
    {
        void premiumamount();
    }
    public class displaypremium : premium
    {
        public void premiumamount()
        {
            persondata obj = new persondata();

            if (obj.age < 20)
            {
                Console.WriteLine("your premium amount is 10000");

            }
            else if (obj.age >= 20 && obj.age <= 30)
            {
                Console.WriteLine("your premium amount is 20000");
            }
            else
            {
                Console.WriteLine("your premium amount is 30000");
            }
        }
    }
    public class persondata : userdata
    {
        public int age;
        public string name;
        public dynamic dob;

        //Task 2

        public void data()
        {
            Console.WriteLine("enter your age:");
            age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter your dob:");
            dob = Console.ReadLine();
            Console.WriteLine("enter your name:");
            name = Console.ReadLine();

            int[] numbers = { 55, 40, 26, 78 };
            Console.WriteLine(numbers);
            foreach (int n in numbers)
                Console.WriteLine(n);
            numbers.Max();
            numbers.Min();
            numbers.Sum();
            numbers.Average();
            Array.Sort(numbers);
            Array.Reverse(numbers);
            Array.BinarySearch(numbers, 10);
            Array.ForEach(numbers, x => Console.WriteLine(x));


            //Task 3
            String[] male = { "Omega", "Dom", "Bruce", "Nemo" };
            String[] female = { "Scarlet", "Pooja", "Aditi" };

            Console.WriteLine("Enter your Gender:");
            string gen = Console.ReadLine();

            if (gen == "male")
            {
                foreach (String s in male)
                    Console.WriteLine(s);
            }
            else
            {
                foreach (string s in female)
                    Console.WriteLine(s);
            }

            string[] name1 = { "James", "Mint", "Dom", "john" };
            int[] age1 = { 22, 25, 30, 26 };
            Array.Sort(age1);

            foreach (string name in name1)
            {
                Console.WriteLine(name);

                foreach (int age in age1)
                {
                    Console.WriteLine(age);
                }
            }
            //Task 4

                ArrayList al = new ArrayList();

                al.Add(10);
                al.Add(20);
                al.Add(true);

                int[] ar = { 10, 20, 30 };
                al.AddRange(ar);
                Console.WriteLine(al.Count);

                Queue queue = new Queue(al);
                queue.Enqueue(10);
                Console.WriteLine(queue.Count);

                al.AddRange(queue);
                Console.WriteLine(al.Count);

            }
        }
    }

    