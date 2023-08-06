using InterviewTest;
using System;

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
