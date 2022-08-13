using System;

class Program
{
    private static void Main()
    {
        DialogWithNPC();
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

    private static void DialogWithNPC()
    {
        Random rand = new Random();
        NPC npc = new NPC();
        npc.nama = "Budi";
        int randText = rand.Next(0, npc.greetings.Length);

        Console.WriteLine(npc.greetings[randText]);
        Console.Write("Masukkan Respon Anda: ");
        Console.WriteLine(Console.ReadLine());

        int randRespond = rand.Next(0, npc.responds.Length);
        Console.WriteLine(npc.responds[randRespond]);
    }
}

public class Humanoid
{
    public string nama = "";
    public string[] greetings, responds;
}
public class NPC : Humanoid
{
    public string[] greetings = new string[]{
        "Halo Apa Kabar ?",
        "Hari ini cuacanya bagus",
        "Selamat pagi",
        "Selamat siang"
    };

    public string[] responds = new string[]{
        "Halo, nama saya {0}",
        "Saya senang bisa bertemu denganmu",
        "Saya juga senang bisa bertemu denganmu",
        "Sampai jumpa lagi"
    };
}
