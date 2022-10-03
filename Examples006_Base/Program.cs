int a = 1;
int b = 8;
int c = 3;
int d = 12;
int e = 6;
int valueMax = a;

if (valueMax < b) valueMax = b;
if (valueMax < c) valueMax = c;
if (valueMax < d) valueMax = d;
if (valueMax < e) valueMax = e;

Console.WriteLine("Максимальное число равно: " + valueMax);