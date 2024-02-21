
Console.Write("How many coins do you wanna flip?");
int coinsTotal = Convert.ToInt32(Console.ReadLine());

for (int i = 0; i < coinsTotal; i++)
{
    Random random = new Random();

    int randomNumber = random.Next(0, 2);

    string result = (randomNumber == 0) ? "HEAD" : "TALE";

    Console.WriteLine($"You flipped a {result}!");
}

Console.Clear();

string permission = "Admin|Manager";
int level = 55;

