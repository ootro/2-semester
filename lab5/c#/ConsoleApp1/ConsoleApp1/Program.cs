using System;

public static class MainClass
{

    static int Main()
    {
        Console.WriteLine("Пiнчук Артур, IС-93");
        CharString string1 = new CharString("This is the first string!");
        Console.Write(string1.data);
        Console.Write("\n");
        int length1 = string1.counter();
        Console.Write("It's length: ");
        Console.Write(length1);
        Console.Write("\n");
        CharString string2 = new CharString("This is the second string!");
        Console.Write(string2.data);
        Console.Write("\n");
        int length2 = string2.counter();
        Console.Write("It's length: ");
        Console.Write(length2);
        Console.Write("\n");
        CharString string3 = new CharString("This is the third string!");
        Console.Write(string3.data);
        Console.Write("\n");
        int length3 = string3.counter();
        Console.Write("It's length: ");
        Console.Write(length3);
        Console.Write("\n");

        if (length1 > length2 && length1 > length3)
        {
            Console.Write("The first string is the longest!");
            Console.Write("\n");
        }
        else if (length2 > length1 && length2 > length3)
        {
            Console.Write("The second string is the longest!");
            Console.Write("\n");
        }
        else if (length3 > length1 && length3 > length2)
        {
            Console.Write("The third string is the longest!");
            Console.Write("\n");
        }

        return 1;
    }
}