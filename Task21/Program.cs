namespace HelloWorld
{
    class Program
    {

        static int[] ConvertToIntArray(string[] array)
        {
            int[] coordinates = new int[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                coordinates[i] = Convert.ToInt32(array[i].ToString());
            }
            return coordinates;
        }

        static void Main(string[] args)
        {
            // Задача 21
            // Напишите программу, которая принимает на вход координаты двух точек и 
            // находит расстояние между ними в 3D пространстве.

            // A (3,6,8); B (2,1,-7), -> 15.84
            // A (7,-5, 0); B (1,-1,9) -> 11.53


            try
            {
                Console.Clear();
                Console.Write("Enter the coordinates of point A in the style X,Y,Z : ");
                string? pointA = Console.ReadLine();
                Console.Write("Enter the coordinates of point B in the style X,Y,Z : ");
                string? pointB = Console.ReadLine();
                if (!string.IsNullOrEmpty(pointA) && !string.IsNullOrEmpty(pointB))
                {
                    string[] coordinatesA = pointA.Split(',');
                    string[] coordinatesB = pointB.Split(',');

                    int[] xyzA = ConvertToIntArray(coordinatesA);
                    int[] xyzB = ConvertToIntArray(coordinatesB);

                    if (xyzA.Length == 3 && xyzB.Length == 3)
                    {
                        int x = xyzB[0] - xyzA[0];
                        int y = xyzB[1] - xyzA[1];
                        int z = xyzB[2] - xyzA[2];

                        double length_AB = Math.Round(Math.Sqrt(x * x + y * y + z * z), 2);
                        Console.WriteLine($"The distance between points = {length_AB}");
                    }
                    else
                    {
                        Console.WriteLine("Invalid coordinates!");
                    }
                }
            }
            catch
            {
                Console.WriteLine("Invalid coordinates!");
            }
        }
    }
}