// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и 
// проверяет, является ли оно палиндромом.

// 14212 -> нет
// 12821 -> да
// 23432 -> да

namespace HelloWorld
{
    class Program
    {

        static int[] Data(string text) //метод для вытягивания цифр из строки и создания из них массива типа int[]
        {
            int[] data = new int[0];
            int index = 0;

            foreach (char c in text)
            {
                if (c == '0' || c == '1' || c == '2' || c == '3' || c == '4' || c == '5' || c == '6' || c == '7' || c == '8' || c == '9')
                {
                    index++;
                    Array.Resize(ref data, index);
                    data[index - 1] = Convert.ToInt32(c.ToString());
                }
            }
            return data;
        }

        static void PrintArrayChar(char[] col) // метод для вывода массива в консоль в виде [a, b, c, d, e, f, g, h, i]
        {
            int count = col.Length;
            int position = 1;

            Console.Write($"{col[0]},");

            while (position < count - 1)
            {
                Console.Write($" {col[position]},");
                position++;
            }

            Console.WriteLine($" {col[count - 1]}");
        }

        static void PrintArrayInt(int[] col) // метод для вывода массива в консоль в виде [1, 2, 3, 4, 5, 6, 7, 8, 9]
        {
            int count = col.Length;
            int position = 1;

            Console.Write($"{col[0]}");

            while (position < count - 1)
            {
                Console.Write($"{col[position]}");
                position++;
            }

            Console.WriteLine($"{col[count - 1]}");
        }


        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Please, input some-digits integer number: ");
            string? number = Console.ReadLine();
            if (!string.IsNullOrEmpty(number))
            {
                char[] collection = number.ToString().ToCharArray();

                Console.WriteLine();
                Console.WriteLine("You have entered the following characters:");
                Console.WriteLine();

                PrintArrayChar(collection);

                int[] digits = Data(number);

                if (digits.Length > 1)
                {
                    Console.WriteLine();
                    Console.WriteLine("It's okay if you made a mistake");
                    Console.WriteLine("We will choose digits from the one you entered!");
                    Console.WriteLine("Total your number is: ");
                    Console.WriteLine();
                    PrintArrayInt(digits);

                    Console.WriteLine();
                    Console.WriteLine("And result!");
                    Console.WriteLine();
                }

                else
                {
                    Console.WriteLine();
                    Console.WriteLine("The input is incorrect!");
                    Console.WriteLine();
                }

                int size = digits.Length;
                int i = 0;
                int mark = 0;

                while (i < size / 2)
                {
                    if (digits[i] == digits[size - i - 1])
                    {
                        mark++;
                    }
                    i++;
                }

                if (digits.Length > 1)
                {
                    if (mark == size / 2)
                    {
                        Console.WriteLine("Palindrome");
                        Console.WriteLine();
                    }

                    else
                    {
                        Console.WriteLine("Not palindrome");
                        Console.WriteLine();
                    }
                }
            }

        }

    }
}
