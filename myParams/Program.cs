using System;

class Program
{
    static void Main(string[] args)
    {
        Random r = new Random();
        Console.WriteLine("How many numbers?");
        int anwser = int.Parse(Console.ReadLine());
        Console.WriteLine("Please enter your numbers.");
        int[] numbers = new int[anwser];
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("Here are your numbers:");
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
        Console.WriteLine($"Total of the numbers array={Add(numbers)}");
        Console.WriteLine($"Sum of the numbers array={Multiply(numbers)}");

    }
    static int Add(params int[] numbers)
    {
        int total = 0;
        foreach (int number in numbers)
        {
            total += number;
        }
        return total;
    }
    static int Multiply(params int[] numbers)
    {
        int total = 1;
        foreach (int number in numbers)
        {
            total *= number;
        }
        return total;
    }
}
//Create random object
//Prompt for number of values to generate
//Read in number
//Create int numbers array
//For loop to fill in the array
//For loop to print out the random numbers that are in the array
//WriteLine to display the Total from the Add method
//WriteLine to display the Product from the Multiply method