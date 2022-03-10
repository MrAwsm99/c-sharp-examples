using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Task 1
            var customers = new List<Customer>()
            {
                new Customer() { Id = 1, Fname = "John", Lname = "Doe" },
                new Customer() { Id = 2, Fname = "Mint", Lname = "Leaf" },
                new Customer() { Id = 3, Fname = "Elo", Lname = "Omi" }
            };

            Console.WriteLine("Enter User ID : ");
            int Id = int.Parse(Console.ReadLine());
            Console.WriteLine("Edit last name : ");
            string lastname = Console.ReadLine();


            for (int i = 0; i < customers.Count; i++)
            {
                if (customers[i].Id == Id)
                {
                    customers[i].Lname = lastname;
                }
            }

            for (int i = 0; i < customers.Count; i++)
            {
                Console.WriteLine(customers[i].Fname + " " + customers[i].Lname);
            }
        }
        public class Customer
        {
            public int Id { get; set; }
            public string Fname { get; set; }
            public string Lname { get; set; }
        }
        //Task 

        String user, pass, place, pet, school;
        int mob;
        Console.WriteLine("Enter the username");
            user = Console.ReadLine();
            Console.WriteLine("Enter the password");
            pass = Console.ReadLine();
            Console.WriteLine("Enter the mobile number");
            mob = int.Parse(Console.ReadLine());

        Console.WriteLine();
            if (pass == "admin" && user == "admin@mail.com" && mob == 12345)
            { Console.WriteLine("Welcome"); }
            else
            {
                Console.WriteLine("Try again");
            }
Console.WriteLine("forgot the password type 1");
y = int.Parse(Console.ReadLine());
if (y == 0)
{
    Console.WriteLine("see you again");
}
else
{
    Console.WriteLine("Select security question");
    Console.WriteLine("Enter the name of your born place");
    place = Console.ReadLine();
    if (place == "true")
    {
        Console.WriteLine("Welcome");
    }
    else
    {
        Console.WriteLine("Try another question");
        Console.WriteLine("Enter the name of pet");
        pet = Console.ReadLine();
        if (pet == "tom")
        {
            Console.WriteLine("Welcome");
        }
        else
        {
            Console.WriteLine("Try another question");
            Console.WriteLine("Enter the name of your school");
            school = Console.ReadLine();
            if (place == "Hogwart")
            {
                Console.WriteLine("Welcome");
            }
            else
            {
                Console.WriteLine("Please Create a new Account");
            }

            //Task 

            List<string> ports = new List<string>()
            { "USA", "UK", "IND", "MAL", "AFC", "JAP"};
            List<string> from = new List<string>();
            List<string> to = new List<string>();
            List<string> type = new List<string>();
            List<int> Id = new List<int>();
            dynamic f, t, op, id = 0, k = "y", a = 0, b = 0;

            IDictionary<int, string> portid = new Dictionary<int, string>();

            for (int i = 0, j = 21; i < ports.Count; i++, j++)
            {
                portid.Add(j, ports[i]);

            }
            while (k == "y")
            {
                Console.WriteLine("enter export or import");
                op = Console.ReadLine();
                if (op == "export")
                {
                    type.Add("EXPORT");
                    Console.WriteLine("list of ports:");

                    foreach (var i in ports)
                    {
                        Console.WriteLine(i);
                    }
                    Console.WriteLine("enter from adderess:");
                    f = Console.ReadLine();
                    Console.WriteLine("list of destination ports ports:");
                    foreach (var i in ports)
                    {
                        if (f != i)
                        {
                            Console.WriteLine(i);
                        }
                    }
                    Console.WriteLine("enter destination port:");
                    t = Console.ReadLine();
                    id++;
                    from.Add(f);
                    to.Add(t);
                    Id.Add(id);
                }
                else
                {
                    type.Add("IMPORT");
                    Console.WriteLine("list of ports:");
                    foreach (var i in ports)
                    {
                        Console.WriteLine(i);
                    }
                    Console.WriteLine("enter from adderess:");
                    f = Console.ReadLine();
                    Console.WriteLine("list of destination ports ports:");
                    foreach (var i in ports)
                    {
                        if (f != i)
                        {
                            Console.WriteLine(i);
                        }
                    }
                    Console.WriteLine("enter destination port:");
                    t = Console.ReadLine();
                    id++;
                    from.Add(f);
                    to.Add(t);
                    Id.Add(id);
                }
                Console.WriteLine("you want to  import or export again:(y/n)");
                k = Console.ReadLine();
                if (k == "n")
                {
                    break;
                }
            }
            Console.WriteLine("list of orders:");
            for (int i = 0; i < from.Count; i++)
            {
                foreach (var j in portid)
                {
                    if (from[i] == j.Value)
                    {
                        a = j.Key;
                        break;
                    }
                }
                foreach (var j in portid)
                {
                    if (to[i] == j.Value)
                    {
                        b = j.Key;
                        break;
                    }
                }
                Console.WriteLine($"from port id:{a} to port id:{b} user id:{ Id[i]} type:{ type[i]}");
            }
        }