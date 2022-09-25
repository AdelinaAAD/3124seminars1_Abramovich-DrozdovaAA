// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
int[] CreateRandomArray (int size, int minVal, int maxVal)
{
    int[] newArray = new int[size];
    for (int i=0; i<size; i++) newArray[i] = new Random().Next(minVal,maxVal + 1);
    return newArray;
}
void ShowArray (int[] array)
{
    for (int i = 0; i < array.Length; i++)
    Console.Write (array[i] + " ");
    
Console.WriteLine();
}
int SumEvenNumber(int[] array)
{
    int k=0;
    for (int i = 1; i < array.Length; i+=2)
        {
            k+=array[i];
        }
    return k;
}
Console.WriteLine ("Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.");
Console.Write ("Введите количество элементов массива ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write ("Введите минимальное значение диапазона ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write ("Введите максимальное значение диапазона ");
int max = Convert.ToInt32(Console.ReadLine());
int[] myArray = CreateRandomArray (a, min, max);
ShowArray(myArray);
Console.WriteLine ($"Сумма чисел на нечётных позициях: {SumEvenNumber(myArray)}");