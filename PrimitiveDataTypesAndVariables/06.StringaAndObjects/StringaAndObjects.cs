using System;

class StringaAndObjects
{
    static void Main()
    {
        string hello = "Hello ";
        string world = "World!";
        object helloWorld = hello + world;
        string strHelloWolrd = (string)helloWorld;
        Console.WriteLine(hello);
        Console.WriteLine(world);
        Console.WriteLine(strHelloWolrd);
    }
}

