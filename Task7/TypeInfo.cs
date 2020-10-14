using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace Task7
{
    static class TypeInfo<T> where T : class
    {
        public static void DisplaTypeName(T type)
        {
            Type t = type.GetType();
            Console.WriteLine("type name: " + t.Name);
        }
        public static void DisplayPropertiesInfo(T type)
        {
            Console.WriteLine("Properties info: ");
            Type t = type.GetType();
            foreach (PropertyInfo p in t.GetProperties())
                Console.WriteLine("   " + p.PropertyType + " " + p.PropertyType.Name);
        }
        public static void DisplayConstructorsInfo(T type)
        {
            Console.WriteLine("Constructors info: ");
            Type t = type.GetType();
            foreach (ConstructorInfo c in t.GetConstructors())
            {
                Console.Write("   " + t.Name + " (");
                ParameterInfo[] parameters = c.GetParameters();
                for (int i = 0; i < parameters.Length; i++)
                {
                    Console.Write(parameters[i].ParameterType.Name);
                    if (i + 1 < parameters.Length)
                        Console.Write(", ");
                }
                Console.WriteLine(")");
            }
        }
        public static void DisplayMethodsInfo(T type)
        {
            Console.WriteLine("Methods info: ");
            Type t = type.GetType();
            foreach (MethodInfo m in t.GetMethods())
            {
                Console.Write("   " + m.ReturnType.Name+" "+m.Name+"(");
                ParameterInfo[] parameters = m.GetParameters();
                for (int i = 0; i < parameters.Length; i++)
                {
                    Console.Write(parameters[i].ParameterType.Name);
                    if (i + 1 < parameters.Length) 
                        Console.Write(", ");
 
                }
                Console.WriteLine(")");
            }
        }       
    }
}
