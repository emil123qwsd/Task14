using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task14
{
    abstract class Animal
    {
        public abstract string Name { get; set; }

        public Animal(string name)
        {
            Name = name;
        }
        public abstract void GetSay();

        public void ShowInfo()
        {
            Console.WriteLine($"Животное:{ Name}");
            GetSay();
        }
    }
    class Cat : Animal
    {
        public string say;
        public string name;
        public override string Name
        {
            get => name;
            set => name = value;
        }
        public Cat(string name, string say)
            : base(name)
        {
            this.say = say;

        }

        public override void GetSay()
        {
            Console.WriteLine($"Звук:{say}");
        }
    }
    class Dog : Animal
    {

        public string say;
        public string name;
        public override string Name
        {
            get => name;
            set => name = value;
        }
        public Dog(string name, string say)
            : base(name)
        {
            this.say = say;
        }

        public override void GetSay()
        {
            Console.WriteLine($"Звук:{say}");
        }
    }
}

