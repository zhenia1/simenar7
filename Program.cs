Console.WriteLine("Введите m:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите n:");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"m = {m}, n = {n}");
double[,] array = new double[m, n];
CreateArrayDouble(array);
WriteArray(array);

Console.WriteLine();

void CreateArrayDouble(double[,] array)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = new Random().Next() * 20 - 10;
        }
    }
}
void WriteArray(double[,] array)
{
    for (int i = 0; i < m; i++)
    {
        Console.Write("[");
        for (int j = 0; j < n; j++)
        {
            double alignNumber = Math.Round(array[i, j] + 1);
            Console.Write(alignNumber + " ");
        }
        Console.Write("]");
        Console.WriteLine(" ");
    }
}