using System;
using System.Collections.Generic;
using System.Text;

namespace Task7
{
    class Human
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Human() { }
        public Human(string n, int a)
        {
            Name = n;
            Age = a;
        }
        public void Display()
        {
            Console.WriteLine("name: "+Name+" age: "+Age);
        }
    }
}
