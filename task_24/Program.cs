// Задача 24: Напишите программу, которая
// принимает на вход число (А) и выдаёт сумму чисел
// от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36
int num = Prompt("Введите число: ");
SumNumbers(num);

int Prompt (string messeg)
  {
    Console.WriteLine(messeg);
    // int number = int.Parse(Console.ReadLine()!);
    // return number;
    return int.Parse(Console.ReadLine()!);  //можно не создавая доп переменную написать так
  }

void SumNumbers(int number)
  {
    int sum = 0;
    
    for (int num = 0; num <= number; num++)
    {
        sum += num;  // sum = sum + num; это разные варианты записи одного действия
    }
    Console.WriteLine($"Сумма чисел oт 1 до {number} = {sum}");// "$" перед ковызками - 
  }                                                            // загораются переменные в {}





