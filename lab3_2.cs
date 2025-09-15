Console.WriteLine("Введите конечное число:");
int x = Convert.ToInt32(Console.ReadLine());
double s = 0;
double i = 1;
while (i <= x) {
    s += 1 / i;
    i++;
}
Console.WriteLine(s);
