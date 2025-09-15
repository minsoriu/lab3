Console.WriteLine("Введите конечное число:");
int x = Convert.ToInt32(Console.ReadLine());
double s = 0;
double f = 1;
for (int i = 1;  i <= x; i++)
{
    f *= i;
    s += 1 / f;
}
Console.WriteLine(s);

