// Напишите программу, которая принимает на вход число (N) и 
// выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Clear();
                Console.Write("Enter a number: ");
                string? number = Console.ReadLine();

                if (!String.IsNullOrEmpty(number))
                {
                    int digit = Convert.ToInt32(number.ToString());
                    Console.WriteLine("Your numbers in the third power: ");
                    for (int i = 1; i <= digit; i++)
                    {
                        int result = i * i * i;
                        Console.Write($"{result} ");
                    }
                }
                Console.WriteLine();
            }
            catch
            {
                Console.WriteLine("Invalid number!");
            }
        }
    }
}