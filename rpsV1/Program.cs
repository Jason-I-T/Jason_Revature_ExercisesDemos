// using System.Numberics;
using System.Collections;

namespace rpsV1;
class Program
{
    //public int myglobalint { get; set; } = 1;// it's considered bad practice toi hav eglobal variables. It's also a security risk.

    static void Main(string[] args)
    {
        #region
        Random rand = new Random();
        Console.WriteLine("Hello, World!");

        // first, just have the values.
        int rock = 1;
        int paper = 2;
        int scissors = 3;

        // V2 - then refactor to use a collection.

        // welcome the user
        Console.Write("Hello, \n");
        Console.Write("Welcome to Rock-");
        Console.Write("Paper-Scissors");
        Console.WriteLine();

        // V2 make a do/while loop to keep playing the game (depending on user desire) after a game ends.

        

        // get the users input
        // error check the input
        //here we will compare the input to the ex[ected string values, then assign the value to it's corresponding string.
        //int isRock = String.Compare(userInput, 0, "ROCK", 0, 4);
        #endregion
        
        // Challenge - finish out this code section to validate the users input is ROCK or PAPER or SCISSORS.
        // then assign the correct int to the choice.
        Hashtable map = new Hashtable();
        map.Add("ROCK", 1);
        map.Add("PAPER", 2);
        map.Add("SCISSORS", 3);
        
        int userInt = 0;

        int[] winsLossesTies = {0, 0, 0};

        do {
            //present the three choices and how to input user choice
            Console.WriteLine("Please enter:\n\tROCK,\n\tPAPER, \n\tSCISSORS");
            string? userInput = Console.ReadLine().ToUpper();
            if(userInput.Equals("ROCK") || userInput.Equals("PAPER") 
            || userInput.Equals("SCISSORS"))
                userInt = (int) map[userInput];
            else {
                Console.WriteLine($"Not that hard, try again (ROCK, PAPER,SCISSORS). You entered {userInput}");
                continue;
            }
                
            //Console.WriteLine(userInt);

            #region 
            //add validatoni in V2
            // int userInt = 0;
            // try
            // {
            //     userInt = Int32.Parse(userInput);
            // }
            // catch (FormatException ex)// catch a most specific exception first
            // {
            //     Console.WriteLine($"The first exception was - {ex.Message}");
            //     // here is where you log the exception to a file to use for diagnostics later.
            // }
            // catch (Exception ex)// catch the least specific exception last.
            // {
            //     Console.WriteLine($"The second exception was - {ex.Message}");
            //     //Console.WriteLine("inside the exception catch block.");
            // }
            // Console.WriteLine("Number 5 is ALIVE!");
            

            //int userInt = 0;// will hold the users int-validated input
            /** 
            tryParse will try to conver the 1st arg into an int. 
            If it's successful, it will return TRUE and place 
            the value into the out variable
            */
            //bool userInputValidated = Int32.TryParse(userInput, out userInt);
        

            // generate the computers random choices
            int compInt = rand.Next(1, 4);// 1st arg is incluxive, 2nd is exclusive.

            // compare the values with a switch statement?
            // this if statement is for if the user won the game
            
            string[] handStates = {"ROCK", "PAPER", "SCISSORS"};
            if (userInt == 1 && compInt == scissors || userInt == 2 && compInt == rock || userInt == 3 && compInt == paper)
            {
                //user won
                Console.WriteLine($"Congrats. You won with {handStates[--userInt]} against the computers {handStates[--compInt]}");
                // update wins
                winsLossesTies[0] = ++winsLossesTies[0];
            }
            else if (userInt == 1 && compInt == 2 || userInt == 2 && compInt == 3 || userInt == 3 && compInt == 1)
            {
                // computer won
                Console.WriteLine($"Too bad, so sad. You lost with {handStates[--userInt]} against the computers {handStates[--compInt]}");
                // update losses
                winsLossesTies[1] = ++winsLossesTies[1];
            }
            else
            {
                // there was a tie
                Console.WriteLine($"This game was a tie. You both chose {handStates[--compInt]}");
                //update ties
                winsLossesTies[2] = ++winsLossesTies[2];
            }

            Console.WriteLine($"Wins: {winsLossesTies[0]}, Losses: {winsLossesTies[1]}, Ties: {winsLossesTies[2]}");            

            Console.WriteLine("Press enter to continue, or type something to exit...");
            string cont = Console.ReadLine();
            if(cont.Length > 0)
                break;

        } while(true);
        #endregion
        // determine the winner

        // print winner info

        // V2 - update players W/L record

        // V2 - ask to play again
    }
}