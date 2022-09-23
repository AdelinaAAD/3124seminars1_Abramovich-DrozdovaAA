// Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, 
// может ли существовать треугольник с сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух 
// других сторон.
            int Prompt(string massage)
{
    Console.WriteLine(massage);
    int Value = Convert.ToInt32(Console.ReadLine());
    return Value;

}

int a = Prompt("Введите A число: ");
int b = Prompt("Введите B число: ");
int c = Prompt("Введите C число: ");


if ( a + b > c && b + c > a && a + c > b)
{
    System.Console.WriteLine("Да. Может существовать треугольник с сторонами такой длины");
}

else System.Console.WriteLine("НЕТ. Не может существовать треугольник с сторонами такой длины");

