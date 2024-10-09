using System;


public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello, User!");
       Console.WriteLine("What is your name?");
       string name = Console.ReadLine();
       Console.WriteLine("How old are you?");
       string ageString = Console.ReadLine();
       int age = int.Parse (ageString);
       Console.WriteLine("You will be " + (age + 5) + " in 5 years!");
       Console.WriteLine("What color are your eyes?");
       string eyeColor = Console.ReadLine();
       Console.WriteLine("What color is your hair?");
       string hairColor = Console.ReadLine();
       Console.WriteLine("What's your shoe size?");
       string shoeSize = Console.ReadLine();
       Console.WriteLine("What's your favorite color?");
       string favColor = Console.ReadLine();
       Console.WriteLine("I like that one too! :]");
       Console.WriteLine("What's your favorite TV show or movie?");
       string favMovie = Console.ReadLine();
       Console.WriteLine("Who's your favorite teacher?");
       string favTeacher = Console.ReadLine ();
       Console.WriteLine("What's your favorite class or subject?");
       string favSubject = Console.ReadLine ();
       Console.WriteLine("What's your favorite holiday?");
       string favHoliday = Console.ReadLine();
       Console.WriteLine("What's your favorite season?");
       string favSeason = Console.ReadLine();
       Console.WriteLine("What's your dream job?");
       string dreamJob = Console.ReadLine();
       Console.WriteLine("Good luck!");
       Console.WriteLine("How many sibligs do you have?");
       string siblingNum = Console.ReadLine();
       Console.WriteLine("I think I know you a little better now! Your name is " + name + ", and you are " + age + " years old. Your eyes are " + eyeColor + ", and your hair is " 
       hairColor + ". You will be " + (age + 5) + "in 5 years. You have " + siblingNum + " siblings.")
    }
}
