// Задача 25: Напишите цикл, который принимает на вход
// два числа (A и B) и возводит число A в натуральную
// степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16


int Prompt(string messag)
  {
    Console.WriteLine(messag);
    string? value = Console.ReadLine();
    int number = Convert.ToInt32(value);
    return number;
  }
int nam1 = Prompt("Введите 1 число - ");
int nam2 = Prompt("Введите 2 число - ");

void ProNumbers(int x, int y)
{int count = 1;
int pro = 1;
while (count <= nam2)
{
    pro = pro*nam1;
    count++;
}
Console.WriteLine(pro);
}

ProNumbers(nam1,nam2);