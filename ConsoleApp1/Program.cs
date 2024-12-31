class GoldenRainRocket
{
    static Random rand = new Random();
    static void Main()
    {
        Console.CursorVisible = false;
        while (true)
        {
            HappyNewYear();
            Thread.Sleep(1000); 
        }
    }

    static void HappyNewYear()
    {
        int startX = rand.Next(30, 50);
        int startY = 24;
        for (int i = startY; i > 5; i--)
        {
            Console.SetCursorPosition(startX, i);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("^");
            Thread.Sleep(100); 
        }

        for (int i = 0; i < 35; i++)  
        {
            int offsetX = rand.Next(-5, 6);
            int offsetY = rand.Next(-3, 4);  
            Console.SetCursorPosition(startX + offsetX, 5 + offsetY);
            Console.ForegroundColor = (ConsoleColor)rand.Next(0,15);
            Console.Write("*");
            Thread.Sleep(50);
        }

        Thread.Sleep(600);
        Console.Clear();
    }
}
