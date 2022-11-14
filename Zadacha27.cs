Console.WriteLine("Введите число :");
int Number = Convert.ToInt32(Console.ReadLine());
int Sum = 0;
while (Number > 0)
{
int num = Number % 10;
Number = Number / 10;
Sum = Sum + num;
}
Console.WriteLine("Cумма цифр в числе равна: " + Sum);
