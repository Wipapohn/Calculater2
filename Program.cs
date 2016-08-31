using System;

class Program
{
    static int addInt(int a, int b)
    {
        return a + b;
    }

    static int subInt(int a, int b)
    {
        return a - b;
    }

    static float addFloat(float a, float b)
    {
        return a + b;
    }

    static float subFloat(float a, float b)
    {
        return a - b;
    }

    static void Main(string[] args)
    {
        Console.WriteLine(addInt(0, 1));
        Console.WriteLine(subInt(5, 3));
        Console.WriteLine(addFloat(1.5f, 1.5f));
        Console.WriteLine(subFloat(5.5f, 1.5f));
    }

}
    
