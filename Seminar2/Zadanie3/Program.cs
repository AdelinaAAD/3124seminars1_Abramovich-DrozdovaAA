// Задача 15: 
// Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.");

var num = 0;

while(true) {
Console.WriteLine("Введите любое целое число от 1 до 7 включительно: ");
string? str = Console.ReadLine();
if(int.TryParse(str, out int number)) {
    if(number > 7 || number < 1) {
        Console.WriteLine("Нет такого дня недели с числом " + number + "!");
    }
    else if(number == 6 || number == 7) {
        Console.WriteLine("Да, день недели под цифрой " + number + " является выходным!");
        break;
    }
    else {
        Console.WriteLine("Нет, день недели под цифрой " + number+ " НЕ является выходным!");
    break;
    }
}
else Console.WriteLine("Некорректно введено число!");
}
