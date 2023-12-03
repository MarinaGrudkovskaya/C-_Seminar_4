// Задача 26: Напишите программу, которая принимает
// на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5 

int num = Prompt("Введите число: ");
CollNamber(num);
int Prompt(string messeg)
   {
    Console.WriteLine(messeg);
    int number = int.Parse(Console.ReadLine()!);
    return number;
   }
void CollNamber(int number)
{
    int i = 0;// т.к. i обьявили здесь, то в ()цикла ее просто можно убрать
    for ( ; number>0; i++)  //можно через цикл "for", но в этом конкретном случаае 
    {                            // нужно обьявить "i" или "count" и в скобках цикла убрать int,
      number = number / 10;      //  т.к. иницилизация была при обьявлении переменной
    }
    // int count = 0;
    // while (number != 0)
    // {
    //     number = number / 10;
    //     count++;
    // }
    // Console.WriteLine($" ->  {count}");
     Console.WriteLine($" ->  {i}");
}

