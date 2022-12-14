// Задайте массив вещественных чисел. Найдите разницу между максимальным и 
//минимальным элементов массива.
//[3 7 22 2 78] -> 76

double[] arr= new double [4];
void PrintArray (double [] arr)
{
    Random rand= new Random();
    for (int i=0; i<arr.Length; i++)
    {
        arr[i]=rand.Next(100);
        Console.Write($"{arr[i]}  ");
    }
}
PrintArray (arr);

double max=arr[0];
double min=arr[1];
foreach (double i in arr)
{
    if (i>max) max=i;
    if (i<min) min=i;
}
Console.WriteLine();
Console.WriteLine($"Разница между максимальным и минимальным элементом= {max-min}");
