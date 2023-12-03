// Задача 27: Напишите программу, которая принимает на
// вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12


Console.Write("Введите число - ");
int num = int.Parse(Console.ReadLine()!);
int raz =RazradNumber(num);
Console.WriteLine(raz);
GetSumm(num, raz);
int RazradNumber(int number) //нахожу разряд числа, потом буду это использовать как длину масива
  {
    int raz = 0;
    while (number>0)
    {
        number = number/10;
        raz++;
    }
    return raz;
  }
void GetSumm(int num, int raz)
{
int sum = 0;
for (int i = 0; i < raz; i++)
{
  sum = sum + num%10;
  num = num/10;
}
Console.WriteLine(sum);
}



  
