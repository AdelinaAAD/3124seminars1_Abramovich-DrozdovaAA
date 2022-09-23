// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел
//  больше 0 ввёл пользователь. Ввод чисел останавливается при помощи ввода 
//  стоп-слова "stop"

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3

void ReadNumber(string message)
{
 
 int count = 0;
 
 while (true) 
 {
  Console.WriteLine(message);
  string text = Console.ReadLine();
  string stop = "stop";
  
  if(text == stop)
  {
    Console.WriteLine($"Число больше ноля было введено {count} раз(а).");
  return;
  }
   int.TryParse(text, out int number);
   
   if(number > 0)
  {
    count++;

  }
   
}  

}
  

ReadNumber("Введите число:");



