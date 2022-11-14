Console.WriteLine("Введите число A");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B");
int B = Convert.ToInt32(Console.ReadLine());
int C = A;

for (int index = 1; index < B; index++)
{
C = C * A;
}
Console.WriteLine("A в степени B равно: " + C);
