//средний 26
Console.WriteLine("|    x   |   y    |");
for (double x = -5; x <= 10; x ++)
{
        double y;
        double k=x-Math.Sin(x);
        if (x < 0) y = 1 - Math.Pow(x, 2);
        else if (x >= 0 && x <= 12.5) y = Math.Pow(Math.E,k)+Math.Cos(0.01*x);
        else y = Math.Pow(x,2)+2.5*Math.Pow(x,2);
        Console.WriteLine($"|{x,8:F2}|{y,8:F2}|");
 
}