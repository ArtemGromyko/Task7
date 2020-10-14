using System;

namespace Task7
{
    class Program
    {
        static void Main(string[] args)
        {

            Human h = new Human("Tom", 21);
            TypeInfo<Human>.DisplaTypeName(h);
            Console.WriteLine();
            TypeInfo<Human>.DisplayPropertiesInfo(h);
            Console.WriteLine();
            TypeInfo<Human>.DisplayConstructorsInfo(h);
            Console.WriteLine();
            TypeInfo<Human>.DisplayMethodsInfo(h);
            Console.WriteLine();
        }
    }
}
