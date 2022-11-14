Console.WriteLine("Ввод массива");
int[] array = new int[8];
for (int i = 0; i < 8; i++)
{
 Console.Write($"Введите элемент массива под индексом {i}:\t");
 array[i] = int.Parse(Console.ReadLine());
}
for (int i = 0; i < 8; i++)
{
 Console.Write(array[i]);
}
