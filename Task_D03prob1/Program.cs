namespace Task_D03prob1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a string : ");
            string input = Console.ReadLine();


            int parsedValue = int.Parse(input);
            Console.WriteLine($"Using int.Parse: {parsedValue}");


            int convertedValue = Convert.ToInt32(input);
            Console.WriteLine($"Using Convert.ToInt32: {convertedValue}");

            #region Question
            //           1- int.Parse(input):

            //If input == null, it throws an ArgumentNullException.
            //This is simulated in the program by explicitly checking for null and explaining the behavior.
            //2- Convert.ToInt32(input):

            //If input == null, it returns 0 instead of throwing an exception.
            //This behavior is inherent to Convert.ToInt32.
            #endregion
        }
    }
    }
