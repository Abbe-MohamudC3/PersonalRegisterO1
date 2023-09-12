using System.Security.Cryptography;

namespace PersonalRegisterO1
{
   // 1 - Vilka klasser bör ingå i programmet?
     //   2 Main och en person class har jag skapat. går att göra bättre om man hade mer tid 
  //  2 - Vilka attribut och metoder bör ingå i dessa klasser?
    //     har själv inga just nu men inser nu att det hade varit bättre med metoder.

   class Person
    {
        public string Name { get; set; }
        public double Salary { get; set; }

        public Person(string name, double salary)
        {
            Name = name;
            Salary = salary;
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> employees = new List<Person>();

            while (true)
            {
                 // List<Person> employees = new List<Person>();

                  Console.WriteLine("Skriv namn: ");
                  String name = Console.ReadLine();

                  Console.WriteLine("Skriv Lön: ");
                  double salary = double.Parse(Console.ReadLine());

                  employees.Add(new Person(name, salary));

                  // Console.WriteLine(employees);

                   foreach (var person in employees)
                   {
                      Console.WriteLine($"Name: {person.Name}, Salary: {person.Salary:C}");
                   }
                        

                  // int.TryParse(Console.ReadLine(), out int id);
                  // {
                   // Environment.Exit(0);
                  // }
            }

            int.TryParse(Console.ReadLine(), out int id);
            {
                Environment.Exit(0);
            }





        }
    }


}