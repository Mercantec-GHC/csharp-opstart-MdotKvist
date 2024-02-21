
Console.Write("How many coins do you wanna flip?");
int coinsTotal = Convert.ToInt32(Console.ReadLine());

for (int i = 0; i < coinsTotal; i++)
{
    Random random = new Random();

    int randomNumber = random.Next(0, 2);

    int result = (randomNumber == 0) ? 0 : 1;

    if (result == 0)
    {
        Console.WriteLine("Congratulations, you flipped the coin and got a Head");
    }
    else if (result == 1)
    {
        Console.WriteLine("congratulations, you flipped the coin and got a Tale");
    }
}

