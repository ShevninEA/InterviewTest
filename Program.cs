using System;

class Segment
{
    public double startX;
    public double startY;
    public double endX;
    public double endY;

    public Segment(double startX, double startY, double endX, double endY) =>
        (this.startX, this.startY, this.endX, this.endY) = (startX, startY, endX, endY);

    // Необходимо реализовать метод, который возвращает true, если два отрезка параллельны, иначе - false.
    public static bool AreParallel(Segment first, Segment second)
    {
        throw new NotImplementedException();
    }
}

class Program
{
    static void Main()
    {
        var forward = new Segment(0, 0, 1, 1);
        var backward = new Segment(0, 0, -1, -1);
        var sideways = new Segment(0, 0, -1, 1);

        Console.WriteLine(Segment.AreParallel(forward, forward));  // true
        Console.WriteLine(Segment.AreParallel(forward, backward));  // true
        Console.WriteLine(Segment.AreParallel(forward, sideways));  // false
        Console.WriteLine(Segment.AreParallel(backward, sideways));  // false

        Console.ReadLine();
    }
}
