Console.Clear();
Console.WriteLine("Введите число");
int x = int.Parse(Console.ReadLine());
int[] resalt = new int [x];
for (int i = 1; i <= x; i++)
    resalt [i - 1] = i * i * i;
for (int i = 0; i <= x; i++)
    Console.Write($"{resalt[i]} ");