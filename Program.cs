using System.Reflection.Emit;

namespace CSharpExercises;

class Program
{
    static void Main(string[] args)
    {
        // collect input from user and store each into an array
        Console.WriteLine("How many numbers do you want to enter: ");
        double userInput = 0.0;

        repeat:
        bool toContinue = true;
        while (toContinue)
        {
            toContinue = double.TryParse(Console.ReadLine(), out userInput);

            if (!toContinue)
            {
                Console.WriteLine("Please enter a valid input e.g 1, 3, 5, ...");
                goto repeat;
            }

            toContinue = false;

        }

        int noOfElement = (int)userInput;
        secondRepeat:
        System.Console.WriteLine("Number of array is: {0}", noOfElement);

        double[] numberArray = new double[noOfElement];

        for (int i = 0; i < numberArray.Length; i++)
        {
            Console.Write($"Enter the {i+1} number: ");

            if(!double.TryParse(Console.ReadLine(), out numberArray[i])) {
                System.Console.WriteLine(
                """
                 You entered an invalid character.
                 Please start over again and this time with valid numbers
                """);
                goto secondRepeat;
            }
        }

        System.Console.WriteLine();
        numberArray.ToList().ForEach(i => System.Console.WriteLine(i));
        System.Console.WriteLine(String.Join(", ", numberArray));
        
        
        // reverse the array
        double[] newArray = new double[numberArray.Length];
        for (int i = 0; i < numberArray.Length; i++)
        {
            newArray[numberArray.Length - (i+1)] = numberArray[i];
        }

        newArray.ToList<double>().ForEach(n => Console.WriteLine(n));

    }
}
