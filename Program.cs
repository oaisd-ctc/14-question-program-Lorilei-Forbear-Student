using System;


public class Program
{
    static string name;
    static string ageString;
    static string eyeColor;
    static string hairColor;
    static string shoeSize;
    static string favColor;
    static string favMovie;
    static string favTeacher;
    static string favClass;
    static string favHoliday;
    static string favSeason;
    static string dreamJob;
    static string siblingNum;
    static int age = int.Parse (ageString);

    public static void Main(string[] args)
    {
        AskName();
        AskAge();
        CalculateAgeIn5Years("You will be " + (age + 5) + " in 5 years.");
        AskEyeColor();
        AskHairColor();
        AskShoeSize();
        AskFavoriteColor();
        AskFavoriteMovie();
        AskFavoriteHoliday();
        AskFavoriteSeason();
        AskDreamJob();
        AskNumberOfSiblings();
        DisplaySummaryMessage();

    }
    public static void AskName()
    {
        Console.WriteLine("Hello, User!");
        Console.WriteLine("What is your name?");
        string name = Console.ReadLine();
    }
    public static void AskAge()
    {
        Console.WriteLine("How old are you?");
        string ageString = Console.ReadLine();
    }
        public static void CalculateAgeIn5Years(string ageString)
    {
        int age = int.Parse (ageString);
        Console.WriteLine("You will be " + (age + 5) + " in 5 years!");
    }
    public static void AskEyeColor()
    {
        Console.WriteLine("What color are your eyes?");
        string eyeColor = Console.ReadLine();
    }
    public static void AskHairColor()
    {
        Console.WriteLine("What color is your hair?");
        string hairColor = Console.ReadLine();
    }
    public static void AskShoeSize()
    {
       Console.WriteLine("What's your shoe size?");
       string shoeSize = Console.ReadLine();
    }
    public static void AskFavoriteColor()
    {
       Console.WriteLine("What's your favorite color?");
       string favColor = Console.ReadLine();
       Console.WriteLine("I like that one too! :]");
    }
    public static void AskFavoriteMovie()
    {
        Console.WriteLine("What's your favorite TV show or movie?");
        string favMovie = Console.ReadLine();
    }
    public static void AskFavoriteTeacher()
    {
       Console.WriteLine("Who's your favorite teacher?");
       string favTeacher = Console.ReadLine ();
    }
    public static void AskFavoriteClass()
    {
       Console.WriteLine("What's your favorite class or subject?");
       string favClass = Console.ReadLine ();
    }
    public static void AskFavoriteHoliday()
    {
        Console.WriteLine("What's your favorite holiday?");
        string favHoliday = Console.ReadLine();
    }
    public static void AskFavoriteSeason()
    {
       Console.WriteLine("What's your favorite season?");
       string favSeason = Console.ReadLine();
    }
    public static void AskDreamJob()
    {
       Console.WriteLine("What's your dream job?");
       string dreamJob = Console.ReadLine();
       Console.WriteLine("Good luck!");
    }
    public static void AskNumberOfSiblings()
    {
       Console.WriteLine("How many sibligs do you have?");
       string siblingNum = Console.ReadLine();
    }

    public static void DisplaySummaryMessage()
    {
         Console.WriteLine("I think I know you a little better now! Your name is " + name + ", and you are " + age + " years old. Your eyes are " + eyeColor + ", your hair is " + hairColor + ", and you will be  " + (age + 5) + " in 5 years. You have " + siblingNum + " siblings.");
    }
}
