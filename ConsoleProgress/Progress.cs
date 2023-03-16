namespace ConsoleProgress;

public class Progress
{
    private readonly string _message;

    private readonly Spinner _spinner;

    public Progress(string message)
    {
        _message = message;

        _spinner = new Spinner();

        Console.Write(message);

        _spinner.Start();

    }

    public void Complete(string? update = null)
    {
        ClearLine();
        Console.ForegroundColor = ConsoleColor.Green;
        Write($":) {update ?? _message}");
        Console.ResetColor();

        _spinner.Stop();
    }

    public void Fail(string? update = null)
    {
        ClearLine();
        Console.ForegroundColor = ConsoleColor.Red;
        Write($"X {update ?? _message}");
        Console.ResetColor();
        _spinner.Stop();

    }

    private static void Write(string message)
    {
        Console.Write(message);
    }

    private static void ClearLine()
    {
        Console.CursorLeft = 0;
        Console.Write(new string(' ', Console.WindowWidth));
        Console.CursorLeft = 0;
    }

}

