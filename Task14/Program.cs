using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task14
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat("Кошка", "мяу");
            cat.ShowInfo();
            Dog dog = new Dog("Собака", "гав");
            dog.ShowInfo();
            Console.ReadKey();
        }
    }
}
