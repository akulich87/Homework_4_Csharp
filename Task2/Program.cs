// Напишите программу, которая принимает на вход число
// и выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());

int SumNumber(int num)
{
  int sum = 0;

  while(num > 0)
  {
   sum = sum + num % 10;
   num /= 10;
  }
  return sum;
}

int sumNumber = SumNumber(num);

Console.Write($"Сумма цифр введенного числа, равна: {sumNumber}");