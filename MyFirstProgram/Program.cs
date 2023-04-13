using System.Collections.Generic;

internal class Program
{

    static string PlayerName = string.Empty;
    static string ChallengeSelection = string.Empty;
    static int Difficulty;
    static int Score = 0;

    const string ChallengeOptionsMenu = @"Choose where to prove them wrong: 
            A - Addition
            S - Substraction
            M - Multiplication
            D - Division
            Q - Quit";

    static Dictionary<string, string> ChallengeOptions = new Dictionary<string, string>()
        {
            {"A","Addition"},
            {"S","Substraction" },
            {"M","Multiplication" },
            {"D","Division" },
            {"Q","Quit" }
        };

    const string DifficultyMenu = @"Select Difficulty:
            1 - Easy
            2 - Medium
            3 - Hard
            4 - Insane";

    static Dictionary<int, string> DifficultyOptions = new Dictionary<int, string>()
    {
        {1, "Easy" },
        {2, "Medium" },
        {3, "Hard" },
        {4, "Insane" }
    };
    private static void Main(string[] args)
    {
        GetName();
        ShowIntro();
        GetChallenge();
        GetDifficulty();
        StartGame();

    }

    static void GetName()
    {
        bool nameSuccess = false;
        Console.WriteLine("Name motherfucker, do you have it?");
        while (!nameSuccess)
        {
            var inputName = Console.ReadLine();
            if (inputName is string)
            {
                nameSuccess = true;
                PlayerName = inputName;
            }
            else
            {
                Console.WriteLine("I said Name motherfucker, do you have it?");
            }
        }
    }

    static void ShowIntro()
    {
        DateTime date = DateTime.UtcNow;
        Console.WriteLine("----------------------------------------");
        Console.WriteLine($"Hey foo {PlayerName}. It's {date}. People say you suck at math. Prove them wrong");
        Console.WriteLine(ChallengeOptionsMenu);
        Console.WriteLine("----YOUR REPUTATION IS ON THE LINE FOO-----");
    }

    static void GetChallenge()
    {
        bool correctSelection = false;

        while (!correctSelection)
        {
            var sel = Console.ReadLine();
            if (sel is not null)
            {
                sel = sel.ToUpper();
                 if (ChallengeOptions.ContainsKey(sel))
                    {
                        correctSelection = true;
                        ChallengeSelection = sel;
                    }
            }
           
            else Console.WriteLine("Invalid choice foo");
        }

        Console.WriteLine($"You have selected the following challenge: {ChallengeOptions[ChallengeSelection]}");
    }

    static void GetDifficulty()
    {
        Console.WriteLine(DifficultyMenu);
        bool difficultySelectionSuccess = false;

        while (!difficultySelectionSuccess)
        {
            var sel = Console.ReadLine();
            if (int.TryParse(sel, out int trySel))
            {
                if (trySel > 0 && trySel < 4)
                {
                    difficultySelectionSuccess = true;
                    Difficulty = trySel;
                }
            }
            if(!difficultySelectionSuccess) Console.WriteLine("Invalid Choice. Select Again.");
        }
    }

    static void StartGame()
    {
        Console.WriteLine(@$"GAME IS STARTING!
        {PlayerName} you are playing {ChallengeOptions[ChallengeSelection]} challenge in {DifficultyOptions[Difficulty]} mode.
        Your current score is {Score}");

    }

    
}
