namespace ConsoleProgress;

public class Spinner
{
    private bool isSpinning = false;
    private int currentFrame = 0;
    private readonly char[] frames = { '|', '/', '-', '\\' };

    public void Start()
    {
        isSpinning = true;
        Thread spinnerThread = new(Spin);
        spinnerThread.Start();
    }

    public void Stop()
    {
        isSpinning = false;
    }

    private void Spin()
    {
        while (isSpinning)
        {
            Console.Write($"{frames[currentFrame]}");
            Console.CursorLeft--;
            currentFrame = (currentFrame + 1) % frames.Length;
            Thread.Sleep(100);
        }
        Console.Write(" ");
    }
}


