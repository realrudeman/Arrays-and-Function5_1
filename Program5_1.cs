int[,] array = {{1, 2, 3}, {4, 5, 6}, {7, 8, 9}};
Console.WriteLine("Введите номер строки и номер столбца через пробел:");
string input = Console.ReadLine();
string[] positions = input.Split(' ');
int row = int.Parse(positions[0]);
int column = int.Parse(positions[1]);

if (row < 0 || row >= array.GetLength(0) || column < 0 || column >= array.GetLength(1))
    {
        Console.WriteLine("Такого элемента нет");
    }
else
    {
        Console.WriteLine("Элемент на позиции ({0}, {1}): {2}", row, column, array[row, column]);
    }

