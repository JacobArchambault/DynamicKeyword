using System;
using System.Collections.Generic;
using static System.Console;
namespace DynamicKeyword
{
    class Program
    {
        static void Main()
        {
            WriteLine("***** Fun with the dynamic keyword *****");

            ImplicitlyTypedVariable();

            UseObjectVariable();

            PrintThreeStrings();

            ChangeDynamicDataType();

            InvokeMembersOnDynamicData();

            VeryDynamicClass d = new VeryDynamicClass();
            WriteLine($"Dynamic method returned {d.DynamicMethod("foobar")}");

            ReadLine();
        }
        static void ImplicitlyTypedVariable()
        {
            // a is of type List<int>
            var a = new List<int> { 90 };
            // This would be a compile-time error.
            // a = "Hello";
            WriteLine(a);
        }
        static void UseObjectVariable()
        {
            // Assume we have a class named Person.
            object o = new Person() { FirstName = "Mike", LastName = "Larson" };

            // Must cast object as Person to gain access to the Person properties.
            WriteLine("Person's first name is {0}", ((Person)o).FirstName);
            WriteLine();

        }
        static void PrintThreeStrings()
        {
            var s1 = "Greetings";
            object s2 = "From";
            dynamic s3 = "Minneapolis";

            WriteLine("s1 is of type: {0}", s1.GetType());
            WriteLine("s2 is of type: {0}", s2.GetType());
            WriteLine("s3 is of type: {0}", s3.GetType());
            WriteLine();

        }
        static void ChangeDynamicDataType()
        {
            // Declare a single dynamic data point named "t".
            dynamic t = "Hello!";
            WriteLine("t is of type: {0}", t.GetType());

            t = false;
            WriteLine("t is of type: {0}", t.GetType());

            t = new List<int>();
            WriteLine("t is of type: {0}", t.GetType());
            WriteLine();

        }
        static void InvokeMembersOnDynamicData()
        {
            dynamic textData1 = "Hello";

            try
            {
                WriteLine(textData1.ToUpper());
                WriteLine(textData1.toupper());
                WriteLine(textData1.Foo(10, "ee", DateTime.Now));
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                WriteLine(ex.Message);
            }
            WriteLine();

        }
    }
}
