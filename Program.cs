using System;

class Program
{
    private static void Main()
    {
        PrintTrianglePattern();
    }
    private static void PrintTrianglePattern() //Percobaan Nested Loop
    {
        for (int i = 1; i <= 5; i++) //TOP
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
        for (int i = 5; i >= 1; i--) //BOTTOM
        {
            for (int j = i; j >= 1; j--)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }

    }
    private static void PrintDialog() // For Loop with Timing
    {
        const string value = "Halo Perkenalkan nama saya Satriyo";
        // Version 2: use for-loop.
        string textOut = "";
        char[] characters = value.ToCharArray();
        for (int i = 0; i < characters.Length; i++)
        {
            textOut += characters[i];
            Thread.Sleep(125);
            Console.Clear();
            Console.WriteLine(textOut);
        }
    }
}
