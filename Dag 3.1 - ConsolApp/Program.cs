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

string[] names = { "Alex", "Eddie", "David", "Michael" };

for (int i = 0; i < names.Length; i++)
{
    if (names[i] == "David")
    {
        names[i] = "Sammy";
    }
}

foreach (var name in names)
{
    Console.WriteLine(name);
}