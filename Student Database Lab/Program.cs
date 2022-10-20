// See https://aka.ms/new-console-template for more information

string[] names = new string[7] { "Han Solo", "Franklin D. Roosevelt", "Oprah Winfrey", "Madisynn", "Rick Astley", "Samwise Gamgee" , "Leslie Knope"};

string[] hometowns = new string[7] { "Corellia", "Hyde Park", "Milwaukee", "Los Angeles", "Lancashire" , "The Shire" , "Pawnee"};
string[] favoriteFoods = new string[7] { "pizza", "grilled cheese sandwiches", "baklava", "martinis", "skittles", "po-tay-toes" , "waffles"};
string reply2;
do
{
    Console.WriteLine("Hello! Would you like to view a list of students in the database? y/n");
    string reply = Console.ReadLine();

    if (reply == "Y" || reply == "y")
    {
        foreach (var name in names)
        { Console.WriteLine(name.ToString()); }
    }

    Console.WriteLine("Which student would you like to know more about? Please enter a number 1 through 7.");
    int studentNumber = Convert.ToInt32(Console.ReadLine());

    if (studentNumber < 1 || studentNumber > names.Length)
    {
        Console.WriteLine("I'm sorry, that number is invalid. Please enter a number from 1 through 7.");
    }

    Console.WriteLine($"Student number {studentNumber} is named {names[studentNumber - 1]}. Would you like to like to know about their hometown or favorite food?");
    string inquiry = Console.ReadLine().ToLower();

    if (inquiry == "hometown" || inquiry == "town")
    { Console.WriteLine($"{names[studentNumber - 1]} is from {hometowns[studentNumber - 1]}"); }

    else if (inquiry == "favorite food" || inquiry == "food")
    { Console.WriteLine($"{names[studentNumber - 1]}'s favorite food is {favoriteFoods[studentNumber - 1]}"); }

    else { Console.WriteLine("I'm sorry, we do not have information about that category."); }

    Console.WriteLine("Would you like to learn about another student? y/n");
    reply2 = Console.ReadLine();
}
while (reply2 == "Y" || reply2 == "y");

Console.WriteLine("Thank you, have a nice day!");