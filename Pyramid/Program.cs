void DrawPyramid(int n)
{
    for (int i = 1; i <= n; i++)
    {
        for (int j = i; j <= n; j++)
        {
            Console.Write("  ");        
        }

        for (int k = 1; k <= 2 * i - 1; k++)
        {
            Console.Write("*" + " ");        
        }
        Console.WriteLine();
    }
}

DrawPyramid(50);