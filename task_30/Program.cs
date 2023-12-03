// Задача 30: Напишите программу, которая
// выводит массив из 8 элементов, заполненный
// нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

// int[] array = new int[8]; //создали новый массив в котором 10 элум.(по умолчанию он заполнен "0")
// // FillArray(array); //вызываем метод для нового массива
// int[] array2 = FillArray2(array); //вызываем метож для создания массива

// int[] FillArray2(int[] arr) //метод создания массива, возвращаемого типв
//   {
//     int leng = arr.Length;
//     int index = 0;
//     while (index < leng)
//     {
//         arr[index] = new Random().Next(0, 6);
//         Console.Write($" | {arr[index]}");
//         index++;
//     }
//     return arr;
//   }
int numb = GetNumber("Введите длинну массива:");
int nummin = GetNumber("Введите минимальное число: ");
int nummax = GetNumber("Введите максимальное число: ");
int[] array2 = FillArray(numb, nummin, nummax);
PrintArrey(array2);

int GetNumber(string messeg)// метод работы с пользователем(запрашиваем длинну и min, max массива)
  {
    Console.WriteLine(messeg);
    return int.Parse(Console.ReadLine()!);
  }
int[] FillArray(int number, int minnum, int maxnum) // метод создания массива
{
int[] array = new int [number];
for (int i = 0; i < number; i++)
{
  array[i] = new Random().Next(minnum, maxnum);
}
return array;
}

void PrintArrey(int[] array)// метод распечатывания, очень красивый
 {
  Console.Write($"[{array[0]}"); //это - чтобы убрать "," в после последнего элемента
  for (int i = 1; i < array.Length; i++)
  {
   Console.Write($", {array[i]}"); //начинаем печатать с "," и далее 2 элесент до конца
  }
  Console.Write("]");// для добавления вконце "]"
 }
