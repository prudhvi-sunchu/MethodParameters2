using System;

namespace MethodParameters2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] EvenNumber = new int[3];
            EvenNumber[0] = 20;
            EvenNumber[1] = 22;
            EvenNumber[2] = 24;

            //ParamsDemo(EvenNumber);
            ParamsDemo(102,104,106,108); // arguments// in an integer array cannot accept ,(coma seperated value) so we use Params key word

        }
        public static void ParamsDemo(params int[] ListEvenNumberes)//parameters //so we use Params key word
        {
            foreach(int i in ListEvenNumberes)
            {
                Console.WriteLine(i);
            }
        }
    }
}
/*
Parameter Arrays:C# Parameter array is decleared with the params modifier.Parameter type must be decleared as an array-
Single params array per method is allowed. Must be the last argument in the method's parameter list.
 

 */
