using System; 
using System.IO; 
using System.Net; 

public class Query {   
  public async static void Adventure() {
    string you = "You: ";  // continuation of the game; 
    string XEpsilonX = "XEpsilonX *assistant of Mk.2* : "; 
    int XEpsilonXHP = 100; 
    int PlayerHP = 100;   
    bool Fight = true; 
    
    string Start = Console.ReadLine();

    if(Start.Contains("DeadHit")) {
      XEpsilonXHP = 0; 
      Console.WriteLine("Mk.2: You Won"); 
    }
  if(Start.Contains("Fight",StringComparison.OrdinalIgnoreCase)) {
      Console.WriteLine(XEpsilonX + "AH!"); 
      XEpsilonXHP = XEpsilonXHP - 30; // YOUR A MIGHTEST WARRIOR IMAGINE THAT;
    Fight = true; 
       if(Start.Contains("Defend",StringComparison.OrdinalIgnoreCase)) {
         Console.WriteLine(XEpsilonX + "ILL DEFEAT YOU!"); 
         PlayerHP = PlayerHP - 28; 
         Fight = true; 
         
       } if(PlayerHP == 0 && XEpsilonXHP == 0) {
         Console.WriteLine(XEpsilonX + "Its a Tie Mk.2 boss");
       } else if(PlayerHP == 0) {
         Fight = false; 
         Console.WriteLine(XEpsilonX + "I WON Mk.2 boss");
       } else if(XEpsilonXHP == 0) { 
         Fight = false; 
         Console.WriteLine("Mk.2: Wow you won!"); 
         
       }
    }
  } 
    
  public async static void GamePaper() {
    bool screen = true; 
    
    while (screen) { 
      string[] keywords = {"Rock","Paper","Scissors"};  // rock paper scissors but the computer output is hidden
      Random random = new Random(); 
      string Output = keywords[random.Next(keywords.Length)];
      string OutPut = keywords[random.Next(keywords.Length)]; 
      Console.WriteLine("3.."); 
      await Task.Delay(1000);
      Console.WriteLine("Enter Your Choice"); 
      string Choice = Console.ReadLine();  

      if(Choice.Contains("Paper",StringComparison.OrdinalIgnoreCase) && OutPut == "Scissors")
      if(Choice.Contains("Rock",StringComparison.OrdinalIgnoreCase) && OutPut ==  "Paper") {
        Console.WriteLine("You Lose");
        Console.WriteLine("Computer Choice: " + Output);
        Console.WriteLine("Play Again?"); 
        if(Choice.Contains("Y",StringComparison.OrdinalIgnoreCase)) {
        GamePaper(); 
        } else if(Choice.Contains("N", StringComparison.OrdinalIgnoreCase)) {
          screen = false; 
        }
      }
      if(Choice.Contains("Scissors",StringComparison.OrdinalIgnoreCase) && OutPut == "Paper") {
        Console.WriteLine("You Won");  
        Console.WriteLine("PlayAgain?"); 
        if(Choice.Contains("Y",StringComparison.OrdinalIgnoreCase)) {
        GamePaper(); 
        } else if(Choice.Contains("N", StringComparison.OrdinalIgnoreCase)) {
          screen = false; 
        }
      }
   if(Choice.Contains("Paper") && OutPut == "Rock") {
     Console.WriteLine("You Win");
    Console.WriteLine("Play Again?");  
     if(Choice.Contains("Y",StringComparison.OrdinalIgnoreCase)) {
     GamePaper(); 
     } else if(Choice.Contains("N", StringComparison.OrdinalIgnoreCase)) {
       screen = false; 
     }
     
   }   if(Choice.Contains("Rock",StringComparison.OrdinalIgnoreCase ) && OutPut == "Paper") {
        Console.WriteLine("You Lost"); 
        Console.WriteLine("Play Again? Y/N"); 
        if(Choice.Contains("Y",StringComparison.OrdinalIgnoreCase)) {
        GamePaper(); 
        } else if(Choice.Contains("N", StringComparison.OrdinalIgnoreCase)) { // comparisons
          screen = false; 
        }
      }
    }
  }
  public async static void CsCodeQuery() {
    Console.WriteLine("Error");  // incomplete
  }
  public async static void NumberGuess() { 
    bool screen = true; 
    while(screen) {
    Console.WriteLine("first number value"); 
      int Value = Convert.ToInt32(Console.ReadLine()); 
      int Values = Value;
      Console.WriteLine("second number value");
      int Value2 = Convert.ToInt32(Console.ReadLine());
      int Valuess = Value2;  // own value number guessing game
      
    bool HasWon = false; 
    Random random = new Random(); 
    int randomNumber = random.Next(Values, Valuess); 
    int guess = Convert.ToInt32(Console.ReadLine()); 
    if(guess > randomNumber) {
      Console.WriteLine("Too high");
    } else if(guess < randomNumber) {
      Console.WriteLine("Too low");
    } else if(guess == randomNumber) {
      HasWon = true; 
      Console.WriteLine("You won!");
      Console.WriteLine("The Number is " + randomNumber); 
      await Task.Delay(1000); 
      Console.WriteLine("Want to play again?"); 
      string input = Console.ReadLine();
      if(input.Contains("Yes", StringComparison.OrdinalIgnoreCase)) {
        NumberGuess();
      } else if(input.Contains("No", StringComparison.OrdinalIgnoreCase)) {
        Console.WriteLine("Okay");
        Console.WriteLine("Quitting...to..Main"); 
      }
    }
   }
}  
  }

