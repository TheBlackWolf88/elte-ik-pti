using System;

namespace Lesson1 {
    class Program {
        static void Main (string[] args){
            int sum = 0;
            int h = 0;
            int m = 0;
            int s = 0;
            Console.Error.Write("Enter the time in seconds: ");
            int.TryParse(Console.ReadLine(), out sum);
            if (sum < 0) System.Environment.Exit(0);
            h = sum / 3600;
            m = (sum - (h * 3600)) / 60;
            s = (sum - (h * 3600 + m * 60));
            Console.Error.WriteLine("hours, minutes, seconds");
            Console.WriteLine(h + "\n" + m + "\n" + s+ "\n");
        }
    }
}
