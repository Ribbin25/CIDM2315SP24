using System.IO.Compression;

namespace Bonus;

class HumanPlayer{
    private int points;
    public HumanPlayer(int initial)
    {
        this.points = initial;
    }
    public int GetPoints()
    {
        return this.points;
    }
    public void WinRound()
    {
        this.points = this.points +5;
    }
    public void LoseRound()
    {
        this.points = this.points -5;
    }
    public string HumanDecision()
    {
        Console.Write("Please input your choice: ");
        string human_choice = Console.ReadLine();
        return human_choice;
    }
}

class ComputerPlayer{
    public string ComputerDecision()
    {
        Random rnd = new Random();
        int rnd_num = rnd.Next(1,4);
       
        if(rnd_num == 1)
        {
            return "R";
        }
        else if(rnd_num == 2)
        {
            return "P";
        }
        else
        {
            return "S";
        }
    }
}

class RockPaperScissors{
    static bool HumanWins(string human_choice, string computer_choice)
    {
        
        if((human_choice == "R") && computer_choice == "S")
        {
            return true;
        }
        else if((human_choice == "S") && computer_choice == "P")
        {
            return true;
        }
        else if((human_choice == "P") && computer_choice == "R")
        {
            return true;
        }
        else
        {
            return false;
        }
    }
static void Main(){

    HumanPlayer HP = new HumanPlayer(5);
    ComputerPlayer CP = new ComputerPlayer();
    Console.WriteLine("Your score is: "+HP.GetPoints());
    
    while(true)
    {
        string human_choice = HP.HumanDecision();
        string computer_choice = CP.ComputerDecision();
        Console.WriteLine("Computer Selects: "+computer_choice);
       
        if(human_choice == computer_choice)
        {
            Console.WriteLine("It was a tie!");
        }
        else
        {
            if(HumanWins(human_choice, computer_choice))
            {
                Console.WriteLine("You win!");
                HP.WinRound();
            }
            else
            {
                Console.WriteLine("You lose!");
                HP.LoseRound();
            }
            
        }
        Console.WriteLine("Your current score is: "+HP.GetPoints());
        
        if(HP.GetPoints() == 0)
        {
            Console.WriteLine("You have lost all your points!");
            break;
        }
       Console.WriteLine("Thank you for playing");
   
         }
   
     }
}

