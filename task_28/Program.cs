// Задача 28: Напишите программу, которая
// принимает на вход число N и выдаёт
// произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120
int number = Prompt("Введите число: ");
// Console.WriteLine(number);
ProductNumbe(number);

int Prompt(string messeg)
  {
    Console.WriteLine(messeg);
    int number = int.Parse(Console.ReadLine()!);
    return number;
  }

void ProductNumbe(int num)
  {
    int sum = 1;
   for (int prod = 1; prod<=number; prod++) // можно без {}, если одно действие
         sum = sum*prod;
    Console.WriteLine($"произведение чисел от 1 до {num} = {sum}");
  }
