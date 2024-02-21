//Console.Write("How many coins do you wanna flip?");
//int coinsTotal = Convert.ToInt32(Console.ReadLine());

//for (int i = 0; i < coinsTotal; i++)
//{
//    Random random = new Random();

//    int randomNumber = random.Next(0, 2);

//    string result = (randomNumber == 0) ? "HEAD" : "TALE";

//    Console.WriteLine($"You flipped a {result}!");
//}

//Console.Clear();

//string permission = "Admin|Manager";
//int level = 55;

//if (permission.Contains("Admin") && level > 55)
//{
//    Console.WriteLine("Welcome, Super Admin user."); 
//}

//else if(permission.Contains("Admin") && level <= 55)
//{
//    Console.WriteLine("Welcome, Admin user.");
//}

//else if(permission.Contains("Manager") && level >= 20)
//{
//    Console.WriteLine("Contact an Admin for access.");
//}

//else if(permission.Contains("Manager") && level <= 20)
//{
//    Console.WriteLine("You do not have sufficient privileges.");
//}

//else
//{
//    Console.WriteLine("You do not have sufficient privileges.");
//}



//Console.Clear();


//bool flag = true;
//int value = 10;
//if (flag)
//{

//    Console.WriteLine($"Inside the code block: {value}");
//}
//Console.WriteLine($"Outside the code block: {value}");


//using System;

//int[] numbers = { 4, 8, 15, 16, 23, 42 };

//int total = 0;

//foreach (int number in numbers)
//{


//    total += number;

//    if (number == 42)
//    {
//        Console.WriteLine("Set contains 42");
//    }

//}

//Console.WriteLine($"Total: {total}");

//string sku = "01-MN-L";

//string[] product = sku.Split('-');

//string type = "";
//string color = "";
//string size = "";

//switch (product[0])
//{
//    case "01":
//        type = "Sweat shirt";
//        break;

//    case "02":
//        type = "T-shirt";
//        break;

//    case "03":
//        type = "Sweat pants";
//        break;

//    default:
//        type = "Other";
//        break;
//}

//switch (product[1]) { 

//    case "BL":
//        color = "Black";
//        break;

//    case "MN":
//        color = "Maroon";
//        break;

//    default:
//        color = "White";
//        break;
//}

//switch (product[2])
//{
//    case "S":
//        size = "Small";
//        break;

//    case "M":
//        size = "Medium";
//        break;

//    case "L":
//        size = "Large";
//        break;

//    default:
//        size = "One Size Fits All";
//        break;
//}

//Console.WriteLine($"Product: {size} {color} {type}");

//string[] names = { "Alex", "Eddie", "David", "Michael" };

//for (int i = 0; i < names.Length; i++)
//{
//    if (names[i] == "David")
//    {
//        names[i] = "Sammy";
//    }
//}

//foreach (var name in names)
//{
//    Console.WriteLine(name);
//}



//for (int i = 1; i < 101; i++){
//    if (i % 3 == 0 && (i % 5 == 0)  )
//    {
//        Console.WriteLine($"{i} - FizzBuss");
//    }
//    else if (i % 3 == 0)
//    {
//        Console.WriteLine($"{i} - Fizz");       
//    }
//    else if (i % 5 == 0)
//    {
//        Console.WriteLine($"{i} - Buzz");
//    }
//    else { 
//        Console.WriteLine(i);
//    }
//}

//Random random = new Random();
//int current = random.Next(1, 11);

//do
//{
//    current = random.Next(1, 11);
//    Console.WriteLine(current);
//} while (current != 7);
//*/

//while (current >= 3)
//{
//    Console.WriteLine(current);
//    current = random.Next(1, 11);
//}
//Console.WriteLine($"Last number: {current}");

//int heroHealth = 10;
//int monsterHealth = 10;

//do
//{
//    Random random = new Random();
//    int attackDamage = random.Next(1, 11);

//    monsterHealth -= attackDamage;
//    Console.WriteLine($"Monster was damaged and lost {attackDamage} health and now has {monsterHealth} health");
//    Random random1 = new Random();
//    int attackDamage1 = random.Next(1, 11);
//    heroHealth -= attackDamage;
//    Console.WriteLine($"Hero was damaged and lost {attackDamage1} health and now has {heroHealth} health.");


//} while (heroHealth > 0 || monsterHealth > 0);

//if (heroHealth <= 0)
//{
//    Console.WriteLine("Monser wins!");
//}
//else if
//{
//    Console.WriteLine("Hero wins!");
//}

