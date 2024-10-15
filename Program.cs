using System;


public class Program
{
    static string name;
    static string age;
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
    static int ageIn5Years;

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
        name = Console.ReadLine();
    }
    public static void AskAge()
    {
        Console.WriteLine("How old are you?");
        ageString = Console.ReadLine();
    }
        public static void CalculateAgeIn5Years(string ageString)
    {
        Console.WriteLine("You will be " + (age + 5) + " in 5 years!");
    }
    public static void AskEyeColor()
    {
        Console.WriteLine("What color are your eyes?");
        eyeColor = Console.ReadLine();
    }
    public static void AskHairColor()
    {
        Console.WriteLine("What color is your hair?");
        hairColor = Console.ReadLine();
    }
    public static void AskShoeSize()
    {
       Console.WriteLine("What's your shoe size?");
       shoeSize = Console.ReadLine();
    }
    public static void AskFavoriteColor()
    {
       Console.WriteLine("What's your favorite color?");
       favColor = Console.ReadLine();
       Console.WriteLine("I like that one too! :]");
    }
    public static void AskFavoriteMovie()
    {
        Console.WriteLine("What's your favorite TV show or movie?");
        favMovie = Console.ReadLine();
    }
    public static void AskFavoriteTeacher()
    {
       Console.WriteLine("Who's your favorite teacher?");
       favTeacher = Console.ReadLine ();
    }
    public static void AskFavoriteClass()
    {
       Console.WriteLine("What's your favorite class or subject?");
       favClass = Console.ReadLine ();
    }
    public static void AskFavoriteHoliday()
    {
        Console.WriteLine("What's your favorite holiday?");
        favHoliday = Console.ReadLine();
    }
    public static void AskFavoriteSeason()
    {
       Console.WriteLine("What's your favorite season?");
       favSeason = Console.ReadLine();
    }
    public static void AskDreamJob()
    {
       Console.WriteLine("What's your dream job?");
       dreamJob = Console.ReadLine();
       Console.WriteLine("Good luck!");
    }
    public static void AskNumberOfSiblings()
    {
       Console.WriteLine("How many sibligs do you have?");
       siblingNum = Console.ReadLine();
    }

    public static void DisplaySummaryMessage()
    {
         Console.WriteLine("I think I know you a little better now! Your name is " + name + ", and you are " + ageString + " years old. Your eyes are " + eyeColor + ", your hair is " + hairColor + ", and you will be  " + (age + 5) + " in 5 years. You have " + siblingNum + " siblings.");
    }
}
