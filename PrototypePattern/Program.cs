using System;
using PrototypePattern.Conceptual;

namespace PrototypePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var personFoo = new Person
            {
                Age = 42,
                BirthDate = Convert.ToDateTime("1977-01-01"),
                Name = "Foo",
                Id = new PersonId { IdNumber = 666 }
            };
            var personBar = personFoo.ShallowCopy();
            var personBaz = personFoo.DeepCopy();
            
            Console.WriteLine("Origin: ");
            Console.WriteLine("Foo: ");
            DisplayValues(personFoo);
            Console.WriteLine("Bar: ");
            DisplayValues(personBar);
            Console.WriteLine("Baz: ");
            DisplayValues(personBaz);

            personFoo.Age = 32;
            personFoo.BirthDate = Convert.ToDateTime("1900-01-01");
            personFoo.Name = "FOO";
            personBar.Id.IdNumber = 777;

            Console.WriteLine();
            Console.WriteLine("Changed: ");
            Console.WriteLine("Foo: ");
            DisplayValues(personFoo);
            Console.WriteLine("Bar: ");
            DisplayValues(personBar);
            Console.WriteLine("Baz: ");
            DisplayValues(personBaz);
        }

        private static void DisplayValues(Person p)
        {
            Console.WriteLine(
                $"  Name: {p.Name}\tAge: {p.Age}\tBirthday: {p.BirthDate:MM/dd/yy}\tID#: {p.Id.IdNumber}");
        }
    }
}