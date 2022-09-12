// Задача 10. 

// Напишите программу, которая принимает на вход трёхзначное число и на
// выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.");

var num = 0;
var str = "";

while(true) {
Console.WriteLine("Введите трёхзначное число: ");
str = Console.ReadLine();
if(int.TryParse(str, out int number)) {
    num = number;
    if(num < 0) { str = str.Remove(0,1); num = num * -1; }
    if(str.Length == 3) {
        break;
    }
    else Console.WriteLine("Введено НЕ трёхзначное число!");
}
else Console.WriteLine("Некорректно введено число!");
}

Console.WriteLine("Вторая цифра числа " + num + ": " + str[1]);
