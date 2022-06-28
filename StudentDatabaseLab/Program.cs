//Arrays of class information and variables
string[] name = { "Justin Jones","Connor Wood","Kris Pranger","Josh Carolin","Krista Anderson","Travis Amador","Asia Drew","Ali Al-Hashemi",
    "Vinh Dang","Tolulope Olubunmi", "Robot Haupt","Matt Fox","Daniel Schuler","Anthony Ventura","Mara Johnson","Brandon Harman","Olukayode Olubunmi"};
string[] food = {"Baja Blast","Chicken Sandwich","Sushi","Nalesniki","Sushi","General Tso's","Jerk chicken","Steak",
    "Sushi","Rice and Dodo","Bread","Steak","BBQ","Thai", "Tacos","Pasta","Pounded Yam"};
string[] hometown = {"Wyoming, MI","Grosse Pointe, MI","Grosse Pointe, MI","Westland, MI","Grosse Ile, MI","Brown City, MI","Detroit, MI","Dearborn Heights, MI",
    "Shelby, MI", "Asese, Nigeria","Green Bay, WI","Sterling Heights, MI","Potterville, MI","Canton, MI","Rochester,MI","Dallas, TX","Ibadan, Nigeria"};
int index = 0;
bool isrunning = true;




do
{
    //prompt user and take their input, store in variable above
    Console.WriteLine("Welcome to the Student Database. Please enter a number, 1-17, for the classmate you'd like to know more about.\nOtherwise, Type in 'D' in order to see a list of the current students.");
    string input = Console.ReadLine();
    //loop to make sure user enters correct option
    if(input.ToLower().Trim() == "d")
    {
        foreach(string n in name)
        {
            Console.WriteLine(n);
        }
        continue;
    }
    index = int.Parse(input) - 1;
    if (index < 0 || index + 1 > name.Length)
    {
        Console.WriteLine("Number not found in index, please try again.");
        continue;
    }


    do
    {
        Console.WriteLine($"You've selected {name[index]}. What would you like to know about this person?\n Enter a number below:\n 1.Favorite Food\n 2.Hometown");
        string response = Console.ReadLine();
        if (response.Trim().ToLower() == "favorite food")
        {
            Console.WriteLine($"Name: {food[index]}");
            break;
        }
        else if (response.Trim().ToLower() == "hometown")
        {
            Console.WriteLine($"Hometown: {hometown[index]}");
            break;
        }
        else
        {
            Console.WriteLine("Incorrect response. Please try again.");
            continue;
        }
    }
    while (true);

            Console.WriteLine("Would you like to continue? (y/n)");
        if (Console.ReadLine().ToLower().Trim() == "y")
        {
            continue;
        }
        else
        {
            break;
        }


    }
    while (isrunning == true);
