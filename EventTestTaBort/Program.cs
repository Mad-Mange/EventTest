class Program
{
    static void Main(string[] args)
    {
        BankStuff obj = new();
        obj.GetKeyInput();
    }
}

class BankStuff
{
    public enum keyValue { s, i, u }
    public void GetKeyInput()
    {
        Console.Write("Ange vad du vill göra [s=SeSaldo,i=SättaIn, u=TaUt] : ");
        var inKey = Console.ReadLine();
        int? sendKey = null;
        if(inKey == "s") { sendKey = 1; } else if(inKey == "i") { sendKey = 2; } else if(inKey == "u") 
                                    { sendKey = 3; } else { sendKey = null; } 
        HandleKey(sendKey);
        //Console.ReadLine();
    }

    public void HandleKey(int? key)
    {
        switch (key)
        {
            case 1: Console.WriteLine("Du angav \"s\""); break;
            case 2: Console.WriteLine("Du angav \"i\""); break;
            case 3: Console.WriteLine("Du angav \"u\""); break;
            default: Console.WriteLine("Du angav ogiltligt alternativ"); break;
        }
    }

    public void SeSaldo() { }
    public void SattaIn() { }
    public void TaUt()
    {
        
    }
}

