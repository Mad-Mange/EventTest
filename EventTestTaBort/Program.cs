class Program
{
    static void Main(string[] args)
    {
        BankStuff obj = new();
        do
        {
            obj.GetKeyInput();
        } while (obj.GetKeyInput());
    }
}

class BankStuff
{
    public event EventHandler MyEvent;
    public enum keyValue { s, i, u, q }
    public bool GetKeyInput()
    {
        Console.Write("Ange vad du vill göra [s=SeSaldo, i=SättaIn, u=TaUt, q=Quit] : ");
        var inKey = Console.ReadLine();
        int? sendKey = null;
        if (inKey == "s") { sendKey = 1; }
        else if (inKey == "i") { sendKey = 2; }
        else if (inKey == "u") { sendKey = 3; }
        else if (inKey == "q") { sendKey = 4; }
        else{ sendKey = null; }
        return HandleKey(sendKey);
    }

    public bool HandleKey(int? key)
    {
        bool runAgain = true;
        switch (key)
        {
            case 1: Console.WriteLine("Du angav \"s\""); break;
            case 2: Console.WriteLine("Du angav \"i\""); break;
            case 3: Console.WriteLine("Du angav \"u\""); break;
            case 4: Console.WriteLine("Du angav \"q\""); break;
            default: Console.WriteLine("Du angav ogiltligt alternativ"); runAgain = false; break;
        }
        return runAgain;
    }

    public void SeSaldo() { }
    public void SattaIn() { }
    public void TaUt() { }
}

