Console.Clear();
// Console.SetCursorPosition(10,4);
// Console.WriteLine("+");

int xa = 20, ya = 1, xb = 1, yb = 15, xc = 40, yc = 15;

Console.SetCursorPosition(xa, ya);
Console.WriteLine("+");
Console.SetCursorPosition(xb, yb);
Console.WriteLine("+");
Console.SetCursorPosition(xc, yc);
Console.WriteLine("+");

int count = 0;
int x = xa, y = ya;

while (count < 10000)
{
    int pointsTriangle = new Random().Next(0, 3);
    if (pointsTriangle == 0)
    {
        x = (x + xa) / 2;
        y = (y + ya) / 2;
    }
    if (pointsTriangle == 1)
    {
        x = (x + xb) / 2;
        y = (y + yb) / 2;
    }
    if (pointsTriangle == 2)
    {
        x = (x + xc) / 2;
        y = (y + yc) / 2;
    }
    Console.SetCursorPosition(x, y);
    Console.WriteLine("+");
    count++;
}