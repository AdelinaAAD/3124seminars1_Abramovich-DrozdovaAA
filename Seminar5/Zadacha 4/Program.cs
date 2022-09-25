// Задача 38: Задайте с клавиатуры массив вещественных (double) чисел.
// Найдите разницу между максимальным и минимальным элементов массива.
// Задать размер (int) массива с клавиатуры
// [3 7 22 2 78] => 76
double[] CreateRandomArray (int size, int minVal, int maxVal)
{
    double[] newArray = new double[size];

    for (int i=0; i<size; i++) newArray[i] = new Random().Next(minVal,maxVal + 1);
    return newArray;
}
void ShowArray (double[] array)
{
    for (int i = 0; i < array.Length; i++)
    Console.Write (array[i] + " ");
    
Console.WriteLine();
}
double FindMinNumber(double[] array)
{
    double k=array[0];
    for (int i = 1; i < array.Length; i++)
        {
            if (array[i]<k) k=array[i];
        }
    return k;
}
double FindMaxNumber(double[] array)
{
    double k=array[0];
    for (int i = 1; i < array.Length; i++)
        {
            if (array[i]>k) k=array[i];
        }
    return k;
}

Console.WriteLine ("Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.");
Console.Write ("Введите количество элементов массива ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write ("Введите минимальное значение диапазона ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write ("Введите максимальное значение диапазона ");
int max = Convert.ToInt32(Console.ReadLine());

double[] myArray = CreateRandomArray (a, min, max);
ShowArray(myArray);
Console.WriteLine ($"Разница между максимальным ({FindMaxNumber(myArray)}) и минимальным ({FindMinNumber(myArray)}) значениями: {FindMaxNumber(myArray)-FindMinNumber(myArray)}");

    

