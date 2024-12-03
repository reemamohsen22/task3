using System.Reflection.Metadata;
using System;
using System.Text;
using static System.Formats.Asn1.AsnWriter;

namespace prob2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            problem1();
            //prob2();
            //prob3();
            //prob4();
            //prob5();
            //prob6();

        }
        static void problem1()
        {
            Console.Write("Enter a number: ");
            string input = Console.ReadLine();

            // Try to parse the input
            if (int.TryParse(input, out int result))
            {
                Console.WriteLine($"You entered a valid number: {result}");
            }
            else
            {
                Console.WriteLine("Error: The input is not a valid integer.");
            }

            #region 2question2
            //because the tryparse No Exceptions with Invalid Input:
            //it return 0 instead exceptions
            #endregion

        }

        static void prob2()
        {
            object obj;

            // Assign int data type to obj
            obj = 42;
            Console.WriteLine(obj.GetHashCode());

            obj = "Hello, world!";
            Console.WriteLine(obj.GetHashCode());
            obj = 3.99;
            Console.WriteLine(obj.GetHashCode());
            obj = true;
            Console.WriteLine(obj.GetHashCode());

            //Hash codes allow objects to be stored
            //Instead of comparing the actual content of objects
            //hash codes can be compared
        }
        static void prob3()
        {
            var R = new { Value = 42 };
            Console.WriteLine($"Original object value: {R.Value}");
            var secondReference = R;
            string R2 = "Hello";
            Console.WriteLine($"Original string: {R2}");
            Console.WriteLine($"HashCode of R2: {R2.GetHashCode()}");
            string R3 = R2 + " Hi Willy";
            Console.WriteLine($"R3 IS: {R3}");
            Console.WriteLine($"HashCode of R3: {R3.GetHashCode()}");

            //// IT Is immutable 
            ////because the string is array of charactar >> fixed 

        }
        public void prob4()
        {

            StringBuilder sb = new StringBuilder("Hello");
            Console.WriteLine($"Initial content : {sb}");
            Console.WriteLine($"HashCode before modification: {sb.GetHashCode()}");

            sb.Append(" Hi Willy");
            Console.WriteLine($"Modified StringBuilder content: {sb}");
            Console.WriteLine($"HashCode after modification: {sb.GetHashCode()}");


            ////StringBuilder class used in immutable
            ////Each concatenation creates a new string object and
            ////copies the existing data, which is expensive.
            ////The StringBuilder appends to the internal buffer,
            ////minimizing allocations and improving performance.

        }

        public void prob5()
        {
            //StringBuilder is faster for large - scale string modifications because of the way it
            //handles memory and avoids the inefficiencies of string immutability in C#
            //Strings are Immutable:
            //StringBuilder Uses a Mutable Buffer
            Console.Write("Enter the first int: ");
            int input1 = int.Parse(Console.ReadLine());
            Console.Write("Enter the second int: ");
            int input2 = int.Parse(Console.ReadLine());
            int sum = input1 + input2;
            Console.WriteLine("Sum concatenation: " + "Sum is " + input1 + "+" + input2 + " = " + sum);

            Console.WriteLine("composite formatting: {0} + {1} = {2}", input1, input2, sum);

            Console.WriteLine($" string interpolation: {input1} + {input2} = {sum}");
            ////The most commonly used string formatting method
            ////Less Error-Prone:
            ////it easier to read and understand.
        }

        //////////////////////////////
        public void prob6()
        {
            StringBuilder sb1 = new StringBuilder("Hello World");
            Console.WriteLine("Initi StriBuild content: " + sb1);

            sb1.Append(" Welcome");
            Console.WriteLine("After Append: " + sb1);

            // Step 3: Replace a substring
            sb1.Replace("World", "reemohsen");
            Console.WriteLine("After Replace: " + sb1);

            sb1.Insert(6, "Beautiful ");
            Console.WriteLine("After Insert: " + sb1);

            sb1.Remove(6, 10); // Removes "Beautiful "
            Console.WriteLine("After Remove: " + sb1);
            //How StringBuilder Handles Frequent Modifications Compared to string
            //strings are immutable, meaning every time you modify a string
            //a new string instance is created
            //. This design can lead to performance issues when performing many string operations
        }

    }
}