using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace MoodAnalyser
{
    public class Reflection
    {
        public static void test()
        {
            Type type = Type.GetType("TestReflections.Customer");

            ///printing fullname
            Console.WriteLine("FullName is {0} " + type.FullName);

            ///printing class name
            Console.WriteLine("FullName is {0} " + type.Name);

            ///printing methods of customer
            MethodInfo[] methods = type.GetMethods();
            Console.WriteLine("Methods present in Customer class");
            foreach (MethodInfo method in methods)
            {
                Console.WriteLine(method.ReturnType.Name + " " + method.Name);
            }

            ///printing properties
            Console.WriteLine("Properties present in Customer class");
            PropertyInfo[] properties = type.GetProperties();
            foreach (PropertyInfo property in properties)
            {
                Console.WriteLine("Methods are {0} {1} " + property.PropertyType.Name + " " + property.Name);
            }

            ///printing constructors
            Console.WriteLine("Constructors present in Customer class");
            ConstructorInfo[] constructors = type.GetConstructors();
            foreach (ConstructorInfo constructor in constructors)
            {
                Console.WriteLine(constructor.ToString());
            }
        }
    }
}
