Console.Clear();

int aX = 0, aY = 0,
    bX = 0, bY = 30,
    cX = 0, cY = 15,
    dX = 45, dY = 0,
    Repeats = 1;

while (Repeats <= 31)
{
    Console.SetCursorPosition(aX, aY);
    Console.WriteLine("*");

    Console.SetCursorPosition(bX, bY);
    Console.WriteLine("*");

    Console.SetCursorPosition(cX, cY);
    Console.WriteLine("*");

    Console.SetCursorPosition(dX, dY);
    Console.WriteLine("*");

    aX += 3;
    aY ++;

    bX += 3;
    bY --;

    cX += 3;

    dY ++;

    Repeats ++;
}
Console.ReadLine();