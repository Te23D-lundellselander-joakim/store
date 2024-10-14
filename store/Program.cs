
int playerMoney = 100;
string whatToBuy = "";

while (playerMoney > 0 && whatToBuy !="4")
{
    Console.WriteLine($"Du har {playerMoney} kronor kvar");

    // Vad man ska köpa

    Console.WriteLine("Vad vill du köpa?");
    Console.WriteLine("1. En bronsmedalj (10kr)");
    Console.WriteLine("2. En silvermedalj (20kr)");
    Console.WriteLine("3. En guldmedalj (30kr)");
    Console.WriteLine("4. gå ur affären");

    whatToBuy = "";
    while (whatToBuy != "1" && whatToBuy != "2" && whatToBuy != "3" && whatToBuy != "4")
    {
        whatToBuy = Console.ReadLine();
    }

    // Priset per pryl

    int pricePerItem = 0;

    if (whatToBuy == "1")
    {
        pricePerItem = 10;
    }
    else if (whatToBuy == "2")
    {
        pricePerItem = 20;
    }
    else if (whatToBuy == "3")
    {
        pricePerItem = 30;
    }

    // Hur många man vill köpa

    Console.WriteLine("Hur många vill du köpa?");
    int numToBuy = 0;
    while (numToBuy == 0)
    {
        string num = Console.ReadLine();
        bool success = int.TryParse(num, out numToBuy);
        if (success == false)
        {
            Console.WriteLine("Du måste skriva en siffra!");
        }
    }

    int finalCost = pricePerItem * numToBuy;

    if (finalCost <= playerMoney)
    {
        Console.WriteLine("Ja, det går bra.");
        playerMoney -= finalCost;
    }
    else
    {
        Console.WriteLine("Nej, det har du inte råd med!");
    }
}

Console.WriteLine("Nu har du slut på pengar!");
Console.WriteLine("Tryck på ENTER för att avsluta");
Console.ReadLine();
