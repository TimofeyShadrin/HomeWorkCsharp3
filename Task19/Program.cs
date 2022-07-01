namespace HelloWorld
{
    class Program
    {
        int[] Data(string text) //метод для вытягивания цифр из строки и создания из них массива типа int[]
        {
            int[] data = new int[0];
            int index = 0;

            foreach (char c in text)
            {
                if (c == '0' || c == '1' || c == '2' || c == '3' || c == '4' || c == '5' || c == '6' || c == '7' || c == '8' || c == '9')
                {
                    index++;
                    Array.Resize(ref data, index + 1);
                    data[index - 1] = Convert.ToInt32(c.ToString());
                }

                else
                {
                    continue;
                }
                Array.Resize(ref data, index);
            }
            return data;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Input five-digits number: ");
            string? number = Console.ReadLine();
            if (!string.IsNullOrEmpty(number))
            {
                int[] digits = Data(number.ToString());
                double size = (double)digits.Length;
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

                if (mark == (size - size % 2) / 2)
                {
                    Console.WriteLine("Polindrome");
                }

                else
                {
                    Console.WriteLine("!Polindrome");
                }
            }

        }
    }
}