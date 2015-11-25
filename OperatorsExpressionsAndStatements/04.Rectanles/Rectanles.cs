using System;
//Write an expression that calculates rectangle’s perimeter and area by given width
//and height
class Rectanles
{
    static void Main()
    {
        double width = double.Parse(Console.ReadLine());
        double height = double.Parse(Console.ReadLine());

        double perimeter= (width*2)+(height*2);
        double area = width * height;
        Console.WriteLine("perimeter:{0}",perimeter);
        Console.WriteLine("area:{0}",area);
    }
}

