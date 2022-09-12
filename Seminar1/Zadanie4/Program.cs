// Задача 8: 
// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8
  

System.Console.WriteLine ("Введите любо целое положительное число");

string number = Console.ReadLine();

int number1 = int.Parse (number);

int n = 1;

bool not = true;

Console.WriteLine("Чётные числа от 1 до " + number1);
            while (n <= number1)
            {
                if (n % 2 != 1)
                {
                    Console.Write(n + ", ");
                    not = false;
                }
                n++;
            }
