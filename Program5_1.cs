class Program
{
    static void Main(string[] args)
    {
        int[,] array = new int[2, 4];

        // Заполнение массива
        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                array[i, j] = i * j;
            }
        }

        Console.WriteLine("Массив:");
        PrintArray(array);

        int x = 1;
        int y = 2;

        if (CheckPosition(array, x, y))
        {
            Console.WriteLine($"Элемент с координатами ({x}, {y}) равен {array[x, y]}");
        }
        else
        {
            Console.WriteLine($"{x}, {y} - такого элемента в массиве нет");
        }
    }

    static bool CheckPosition(int[,] array, int x, int y)
    {
        return x >= 0 && x < array.GetLength(0) && y >= 0 && y < array.GetLength(1) && array[x, y] != 0;
    }

    private static void PrintArray(int[,] arr)
    {
        Console.Write("|");
        for (int col = 0; col < arr.GetLength(1); col++)
        {
            if (col != 0)
            {
                Console.Write(", ");
            }
            Console.Write(arr[0, col]);
        }
        Console.WriteLine();

        for (int row = 1; row < arr.GetLength(0); row++)
        {
            Console.Write($"|{arr[row, 0]} ");
            for (int col = 1; col < arr.GetLength(1); col++)
            {
                if (col != arr.GetLength(1))
                {
                    Console.Write(", ");
                }
                Console.Write("{0}", arr[row, col]);
            }
            Console.WriteLine();
        }
    }
}