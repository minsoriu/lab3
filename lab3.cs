Console.WriteLine("Введите конечное число:");
int x = Convert.ToInt32(Console.ReadLine());
double s = 0;
for (double i = 1;  i <= x; i++)
{
    s += 1 / i;
}
Console.WriteLine(s);