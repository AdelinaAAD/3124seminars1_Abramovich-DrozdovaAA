// Задача 4.
// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44, 5, 78 -> 78
// 22, 3, 9 -> 22

System.Console.WriteLine("Введите три числа:");

        string first = Console.ReadLine();
        string second = Console.ReadLine();
        string third = Console.ReadLine();


        int number1 = int.Parse(first);

        int number2 = int.Parse(second);

        int number3 = int.Parse(third);

 int max = number1;

            if (number2 > max)
            {
                max = number2;
            }

            if (number3 > max)
            {
                max = number3;
            }

System.Console.WriteLine($"{max} Наибольшее число");
