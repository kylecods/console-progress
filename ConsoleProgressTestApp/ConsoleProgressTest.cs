
using ConsoleProgress;

namespace ConsoleProgressTest;

class Program
{
    static void Main(string[] args)
    {

        Progress progress = new("Loading...");
        // Simulate a task that takes 5 seconds to complete
        Task.Delay(5000).GetAwaiter().GetResult();

        progress.Complete("Done!");
    }

}

