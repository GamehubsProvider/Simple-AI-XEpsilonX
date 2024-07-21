using System;
using System;
using System.IO;
using System.Net.Http;
using System.Runtime.InteropServices;
using System.Text.Json;
using System.Threading.Tasks;
using System.Linq; // all the needed using imports;
using System.Linq.Expressions;
using System.Runtime.ExceptionServices;
using System.Net.Mail;
using System.Text;
using System.Security.Cryptography;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Net;


public class main
{
    public static async Task Main(string[] args) // Heart Of The program
    {
        Console.WriteLine("Hello Nice To Meet YOU!"); // welcome message
        string[] EnglishM1 = {"English is specked by 1.3 billion people","English is made by british and mostly speaked in england"
        ,"English is made to make programming Langs"}; // general knowledge
        string[] Swears = { "fuck", "die" ,"Poop","Bitch","Bitches","Death","WTF","WTH","BLOODY HELL","Bloody","Bastard","Bloody Bastards"}; // Swear handler 
        bool screen = true;
        while (screen) // USEFULLL
        {
            string inputToData = Console.ReadLine();

            if (string.IsNullOrEmpty(inputToData))
            {
                Console.WriteLine("Try Anything"); // handles null input
                continue;

            }

            if (inputToData.Equals("Addition", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Tell First Num");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Tell Second Num");
                int num2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(num1 + num2);
            } else if(inputToData.Contains("AI, Lets play rock paper scissors", StringComparison.OrdinalIgnoreCase)) { 
                 // i consider this cuz idk // rock paper scissors but its a loop 
                Query.GamePaper();
            } else if(inputToData.Contains("AI, Lets play")) {
                Console.WriteLine("Fight Or Defend"); 
                await Task.Delay(1000);
                Console.WriteLine("Prepering Battleguard"); 
                await Task.Delay(1000);
                Console.WriteLine("Loaded!");  // Fight between you and AI
                Query.Adventure(); 
            }
            else if (inputToData.Contains("AI, How are you?", StringComparison.OrdinalIgnoreCase))
            { // good question
                Console.WriteLine("Im Fine how are you?");
            }
            else if (inputToData.Contains("About Mk.2", StringComparison.OrdinalIgnoreCase)) // creates custom messages
            {
                string[] Mk2Info = {
                    "Mk.2 is the commander android in This Universe","Mk.2 is the leader of the turing Gang"
                    ,"Mk.2 has understanding beyond your minds",
                    "Mk.2 has alot of virtual ai"
                    ,$"Mk.2: My Power is beyond"
                };
                Random random = new Random();
                string outputToCompiledM1 = Mk2Info[random.Next(Mk2Info.Length)];
                System.Console.WriteLine(outputToCompiledM1); // Processor Of compilation; 

            } else if(inputToData.Contains("AI, What is your name?", StringComparison.OrdinalIgnoreCase)) {
                string Name = "XEpsilonX: ";  // Name of AI
                Console.WriteLine(Name + "Is XEpsilonX"); 
                 
            } else if(inputToData.Contains("Make a noun",StringComparison.OrdinalIgnoreCase)) {
                  
                string[] noun = { "dog", "cat", "car", "house", "tree", "book"};   // Makes a 1 word sentence noun; maybe useful
                Random random = new Random(); 
                Console.WriteLine(noun[random.Next(noun.Length)]);
                
            } else if(inputToData.Contains("What is a noun",StringComparison.OrdinalIgnoreCase)) {
                Console.WriteLine("A noun is a person, place, or thing");
            } else if(inputToData.Contains("What is a verb",StringComparison.OrdinalIgnoreCase)) {
                Console.WriteLine("A verb is an action word");
            } else if(inputToData.Contains("What is a adjective",StringComparison.OrdinalIgnoreCase)) {
                Console.WriteLine("A adjective is a describing word");
            } else if(inputToData.Contains("What is a adverb",StringComparison.OrdinalIgnoreCase)) {
                Console.WriteLine("A adverb is a describing word");
            } else if(inputToData.Contains("What is a pronoun",StringComparison.OrdinalIgnoreCase)) {
                Console.WriteLine("A pronoun is a word that substitutes for a noun, noun phrase, or clausal complement");
            } else if(inputToData.Contains("What is a preposition",StringComparison.OrdinalIgnoreCase)) {
                Console.WriteLine("A preposition is a word that joins a noun to another noun");
            } else if(inputToData.Contains("What is a conjunction",StringComparison.OrdinalIgnoreCase)) {
                Console.WriteLine("A conjunction is a word that connects two or more clauses");
            } else if(inputToData.Contains("I Love You",StringComparison.OrdinalIgnoreCase)) {
                Console.WriteLine("Uhhh....Ok?"); //handles love sentences in up code there are explanation of english types 
                 // may be useful for new learners;
            } else if(inputToData.Contains("Analyze my text with alot of analysiss")) {
                Console.WriteLine("Analyzing..."); 
                await Task.Delay(1000); 
                int length = inputToData.Length;
                int spaces = inputToData.Count(f => f == ' ');
                string Symbols = inputToData.Count(f => f == '!').ToString();
                string dot = inputToData.Count(f => f == '.').ToString();
                string questionmark = inputToData.Count(f => f == '?').ToString();
                string comma = inputToData.Count(f => f == ',').ToString();
                // check nouns
                string[] noun = { "dog", "cat", "car", "house", "tree", "book"};
                bool hasNouns = false;
                bool hasVerbs = false; 
                bool HasAdjectives = false;
                bool HasAdverbs = false;
                bool HasPronouns = false; // Types
                 await Task.Delay(1000);
                Console.WriteLine("Enter The Sentence"); 
                while(string.IsNullOrEmpty(inputToData) && inputToData.Length > 40) {
                    Console.WriteLine("Enter The Sentence");
                    inputToData = Console.ReadLine();
                } if(inputToData != null || inputToData != "") {
                    string Sentences = inputToData; 
                    Console.WriteLine("Analyzing...");
                    if(Sentences.Contains(noun[0])) {
                        hasNouns = true; 
                         // checks for values;  ,, incomplete
                    } if(Sentences.Contains(noun[1])) {
                        hasNouns = true; 
                    } if(Sentences.Length > 20) {
                        hasVerbs = true; 
                        hasNouns = true;
                        HasAdjectives = true;
                        HasAdverbs = true;
                        HasPronouns = true; 
                        await Task.Delay(1000); // i know its prescribed
                       
                    } if(Sentences.Contains(dot)) {
                        bool hasdot = true; 
                        
                    } 
                    Console.WriteLine("Analyzed"); 
                }  // Ability to remember content below
            }
            else if (inputToData.Contains("Remember my favourite"))
            {
                Console.WriteLine("What is it");
                while (string.IsNullOrEmpty(inputToData))
                {
                    Console.WriteLine("What is it");
                }
                string s = Console.ReadLine(); 
                string FavThing = s;

                if (inputToData.Contains("Forget it", StringComparison.OrdinalIgnoreCase))
                {
                    FavThing = "";
                    if (inputToData.Contains("My Fav is?", StringComparison.OrdinalIgnoreCase) && FavThing == "" || FavThing == null)
                    {
                        Console.WriteLine("You havent stored the data or you've deleted it.");
                    }
                }
                if (inputToData.Contains("My Fav is", StringComparison.OrdinalIgnoreCase) && FavThing != null || FavThing != "")
                {
                    Console.WriteLine("Its " + FavThing);
                }
            }
            else if (inputToData.Contains("Make a sentence", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Some sentences may be no logic");
                string[] Words = {
         "a","apple","Fell","Down","From","A","tree","Aka","The","Big","Ball","My","Gender","Is","Male","AI","Is","Good","Dunked","On"
        };
                Random random = new Random();
                string NoLogic = Words[random.Next(Words.Length)];
                Console.WriteLine(NoLogic);
            }

            else if (inputToData.Contains("Make a Child sub", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Ok enter first Num");
                int sub1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Second Num");
                int sub2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(Math.Abs(sub1 - sub2)); // sub

            }
            else if (inputToData.Equals("Test", StringComparison.OrdinalIgnoreCase)) // makes a test 
            {
                Console.WriteLine("What Is The capital of India?");
                int IQPoints = 0;
                string IQTest = Console.ReadLine();
                if (IQTest != "New Delhi")
                {
                    Console.WriteLine("Wrong");
                    IQPoints = IQPoints - 10;
                    string IQTests = Console.ReadLine();

                    if (IQTests.Equals("New Delhi", StringComparison.OrdinalIgnoreCase))
                    {
                        IQPoints = IQPoints + 10;
                        Console.WriteLine(
                       "Correct"
                        );
                    }
                    string Last = Console.ReadLine();

                    Console.WriteLine("Money Of USA");
                    if (Last != "Dollars")
                    {
                        IQPoints = IQPoints - 10;
                        Console.WriteLine("Wrong");


                    }
                    if (Last.Equals("Dollars", StringComparison.OrdinalIgnoreCase))
                    {
                        IQPoints = IQPoints + 10;
                        Console.WriteLine("Finished IQTest Your IQ IS " + IQPoints); // inaccurate
                    }
                }
            }


            else if (inputToData.Equals("Division", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("First Num");
                int div1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Second Number");
                int div2 = Convert.ToInt32(Console.ReadLine()); // data

                if (div2 == 0)
                {
                    Console.WriteLine("Cannot divide by zero."); // yessir
                }
                else
                {
                    Console.WriteLine((double)div1 / div2); // divison
                }
            }
            else if (inputToData.Equals("Time", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine(DateTime.Now); // DATE AND TIME
                Console.WriteLine("String Ver: " + DateTime.Now.ToString());
            }
            else if (inputToData.EndsWith("To Upper", StringComparison.OrdinalIgnoreCase))
            { 
                // Prints the text to upper
                Console.WriteLine(inputToData.ToUpper());
            } else if(inputToData.Contains("Make a number guessing game with my values ",StringComparison.OrdinalIgnoreCase)) {
                Console.WriteLine("Ok"); 
                // makes a number guess game with own values
                await Task.Delay(1000);
                Console.WriteLine("Mk.2 started the game"); 
                await Task.Delay(1000);
                Query.NumberGuess(); 
            }
            else if (inputToData.Equals("Value OF PI", StringComparison.OrdinalIgnoreCase))
            { // value of PI
                Console.WriteLine(Math.PI + " is The Value Of PI");
            }
            else if (inputToData.Equals("NOW SHOW PI VALUE AND ILL EDIT IT", StringComparison.OrdinalIgnoreCase))
            { /// edit values
                Console.WriteLine("First Num");
                int edit = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Processing through data");
                int edits = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(Math.PI + edit + edits);
            }
            else if (inputToData.Equals("Value Of Math.E", StringComparison.OrdinalIgnoreCase))
            {// euler's e value
                Console.WriteLine(Math.E);
            }
            else if (inputToData.Equals("Any Math Element", StringComparison.OrdinalIgnoreCase))
            { // power is known as 2 x 2 x 2 for ex  two **
                Console.WriteLine(Math.Pow(10.20, 20.10));
            }
            else if (inputToData.Equals("Jokes", StringComparison.OrdinalIgnoreCase))
            { // prints some inappriopriate statements not comfortable for kids
                string[] jokesLists = {
                    "What do you call a boomerang that won’t come back? A stick",
                    "Do You Know Why You Don't Deserve Any Desserts Because You're already SWEET!",
                    "What sounds like a fart when you sit in it? A Whoopee Cushion",
                    "Do You Know What a skeleton works? They work a SkeletonWork",
                    "Do You Know That a Code includes millions? HandPain",
                    "Most Sensitive Anatomy part? This may laugh you it's THE BUTT",
                    "Haha, it's easy. My backend is 1 mill code, can't believe?"
                };
                Random random = new Random(); // random processor
                string outputToCompiled = jokesLists[random.Next(jokesLists.Length)];
                Console.WriteLine(outputToCompiled);
            }

            else if (inputToData.Equals("Exit", StringComparison.OrdinalIgnoreCase))
            {// Mk.2 boss can destroy the console
                Console.WriteLine("Asking MK.2 to Charge");
                await Task.Delay(1000);
                Console.WriteLine("MK2: Ready to Charge");
                screen = false;
            }
            else if (inputToData.Equals("Your Code", StringComparison.OrdinalIgnoreCase))
            { // makes some chatgpt like random responses
                // Customized Messages
                string[] messageS = {
                    "My Code Is More than a hundred in Datacode lol",
                    "My Code is a bit complicated",
                    "Uhhh, how can I say that? It's 100",
                    "It's 100, a module beta haha",
                    "Idk, I think it's Hundred",
                    "It's 100 and I Hate Peppers"
                };
                Random random = new Random(); // processors
                string outputToSystemM1 = messageS[random.Next(messageS.Length)];
                Console.WriteLine(outputToSystemM1);
            }
            else if (inputToData.Contains("Analyze My Text", StringComparison.OrdinalIgnoreCase))
            { // gives a full detail of the given content variable Thing; 
                string Thing = "Analyze My Text";
                string Sentence = Thing;
                int LengthOfAnalyzedTxt = Thing.Length;
                string[] Charset = { "A", "n", "a", "l", "y", "z", "e", "m", "y", "T", "e", "x", "t" };
                int lengthofcharset = Charset.Length;
                Console.WriteLine("AnalyzedTxt: " + Sentence + "Is What You said..");
                await Task.Delay(1000);
                Console.WriteLine("Length: " + LengthOfAnalyzedTxt + "Processing...");
                await Task.Delay(1000);
                Console.WriteLine("CharSet:" + Charset + "Processing");
                await Task.Delay(1000);
                Console.WriteLine("CharSet Length : " + lengthofcharset);
                await Task.Delay(1000);
                Console.WriteLine("Analyzed: " + Sentence + "=" + "Length: " + LengthOfAnalyzedTxt + "CharSet" + Charset + "CharSetLength" + lengthofcharset);

            }
            else if (inputToData.Equals("make a new file", StringComparison.OrdinalIgnoreCase))
            { // creates a file using IO;  input can be both double , int , string , char
                Console.WriteLine("Enter The Name");
                string nameMakeFile = Console.ReadLine();
                // Check for valid file name
                while (string.IsNullOrEmpty(nameMakeFile) || string.IsNullOrWhiteSpace(nameMakeFile))
                { // error handler
                    Console.WriteLine("Name Plz");
                    nameMakeFile = Console.ReadLine();
                }
                try // error exception handler
                {
                    File.Create(nameMakeFile).Close();
                    Console.WriteLine($"File {nameMakeFile} created successfully.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error creating file: {ex.Message}");
                }
            }
            else if (inputToData.Equals("How Are u?", StringComparison.OrdinalIgnoreCase))
            { //  start up question...
                if (inputToData.IndexOf('u', StringComparison.OrdinalIgnoreCase) >= 0)
                {
                    Console.WriteLine("I'm Fine");
                }
            }
            else if (inputToData.Equals("English", StringComparison.OrdinalIgnoreCase))
            { // gives a short definition of english content
                Console.WriteLine("Wanna Hear About It?");
                string response = Console.ReadLine();
                if (response.Equals("Yes", StringComparison.OrdinalIgnoreCase))
                {
                    Random random = new Random();
                    string output = EnglishM1[random.Next(EnglishM1.Length)];
                    Console.WriteLine(output + " is Found in my code");
                }
                else if (response.Contains("English Origin", StringComparison.OrdinalIgnoreCase))
                { // placeholder func
                    Console.WriteLine(EnglishM1[0]);
                }
                else if (inputToData.Contains("Make a File content",StringComparison.OrdinalIgnoreCase))
                { // makes a file and gives the user to customize the text
                    Console.WriteLine("Name of File first");
                    string Files = Console.ReadLine();
                    await Task.Delay(100);


                    File.Create(Files).Close();
                    Console.WriteLine(Files + "Created Successfully");
                    Console.WriteLine("Now Write the content");
                    string content = Console.ReadLine();
                    File.WriteAllText(Files, content);
                }

            }
            else if (inputToData.Contains("Make a c# code", StringComparison.OrdinalIgnoreCase))
            { // placeholder func
                Query.CsCodeQuery();
            }
            else if (inputToData.Contains("How Many Speck English", StringComparison.OrdinalIgnoreCase))
            { // for up to 2022 data.. may be inaccurate
                Console.WriteLine(EnglishM1[1]);
            }
            else if (inputToData.Contains("Games", StringComparison.OrdinalIgnoreCase))
            { // initiates a game of Guardian tales; game in beta; you can change it; 
                Console.WriteLine("Asking Mk.2 to Make Up A Game");
                await Task.Delay(1000);
                Console.WriteLine("Mk.2 made the game wanna start");
                if (inputToData.Contains("Yes", StringComparison.OrdinalIgnoreCase))
                {
                    int hp = 1000;
                    string[] Stage = {
                     "1","2","3","4","5","6","7","8","9","10","11","12","13","14","15","16","17","18"
                     };


                    string name = "DumbSmile";
                    // the smiley trashbag face of the guardian of kanterabury depicts DumbSmile
                    string ChosenName = Console.ReadLine();
                    Console.WriteLine("Now Enter Your Name");
                    while (string.IsNullOrEmpty(ChosenName) || ChosenName.Length > 10)
                    {
                        Console.WriteLine(
                          "Length shall be 10 or smaller then 10, Name shall nah be empty"
                        );
                    }
                    string CaptainEva = "Captain Eva: ";
                    string LUARIANE = "Luariane: ";
                    string LittlePrincess = "Little Princess: ";
                    string Beth = "???: "; // for better handling
                    Console.WriteLine(CaptainEva + ChosenName + "Knight You Seem Talented");
                    // scenario 
                    Console.WriteLine("Invaders Force Attacked HEAVENHOLD's Kanterbury");
                    await Task.Delay(1000);
                    Console.WriteLine(CaptainEva + "Kyah! Invaders! Rookie Come With Me");
                    await Task.Delay(1000);
                    int SimpleInvaderHP = 120;
                    Console.WriteLine("A Invader Appeared In Your Way"); //  battle system == incomplete; 
                    await Task.Delay(1000);
                    Console.WriteLine(CaptainEva + "Rookie Fight With me");
                    // fight scenario 
                    Console.WriteLine("System: Write attack or defend to continue");
                    string Scenario1 = Console.ReadLine();
                    while (Scenario1 != "Attack" || Scenario1 != "Defend")
                    {
                        Console.WriteLine("Nah continue");
                    }
                    if (Scenario1.Equals("Attack", StringComparison.OrdinalIgnoreCase))
                    { // if attack; to proceed; 
                        SimpleInvaderHP = SimpleInvaderHP - 40;
                        if (SimpleInvaderHP == 0)
                        {
                            Console.WriteLine("Invader Cleared");
                            await Task.Delay(1000);
                            Console.WriteLine(LittlePrincess + "Hello Knight and Eva I Knew you can save us cammila a bit injured");
                            await Task.Delay(2000);
                            Console.WriteLine(Beth + "Attacks");
                            await Task.Delay(100);
                            Console.WriteLine(CaptainEva + "Ahhh!" + LittlePrincess + "Noo! Eva , knight , camilla!*traps ?? with chains with power*");
                            await Task.Delay(1000);
                            Console.WriteLine("Camilla , princess , eva were flying with you");
                            await Task.Delay(100);
                            Console.WriteLine("???: Attacks");
                            Console.WriteLine("All of you fell lost");
                            await Task.Delay(1200);
                            Console.WriteLine(LittlePrincess + "Knight Wake Up Ahh! *runs away as goblins come*");
                            Console.WriteLine("You waked up!");
                            await Task.Delay(1000);
                            Console.WriteLine("FINDS LUARIANE");
                            Console.WriteLine(LUARIANE + "Welcomes you to her INN"); // Game content; 



                        }
                        if (SimpleInvaderHP > 1000)
                        {
                            hp = hp - 50;
                            Console.WriteLine("Invader Attacks" + hp + "Is Decreased");
        // handling of hp 
                        }
                        if (hp == 0)
                        {
                            Console.WriteLine(CaptainEva + "Kyah!");
                            hp = hp + 1000;
                        }
                    }
                }
            }
            else if (Array.Exists(Swears, swear => inputToData.IndexOf(swear, StringComparison.OrdinalIgnoreCase) >= 0))
            { // checks for swears
                // Handle swear words
                string mk2 = "Fire In The Comp!";
                Console.WriteLine(mk2);
                screen = false;
            }
            else if (inputToData.StartsWith("@")) 
            { //  simple analysis
                await Task.Delay(1000);
                Console.WriteLine("Processing...");
                // analyzing process
                int length = inputToData.Length;
                char[] chars = inputToData.ToCharArray();
                string digits = inputToData.ToString();
                string all = length.ToString() + chars.ToString() + digits;

                if (length > 300 || length > 3000)
                {
                    screen = false;
                    throw new Exception("Length Error");
                }
                if (digits.Contains("Fuck"))
                { // mk.2 can detect swears
                    screen = false;
                    await Task.Delay(100);
                    Console.WriteLine("Mk.2 destroyed the Console");
                }

                if (digits.Contains("My Gmail")) 
                { // checks gmail format
                    Console.WriteLine(inputToData + "Is Your Gmail? further Analyze");
                    MailAddress mailformat = new MailAddress(inputToData);
                    if (inputToData != "@" || inputToData.StartsWith("$^#%@%@*@") || inputToData.EndsWith("@"))
                    {
                        bool isFalse = true;
                        while (isFalse)
                        { 
                            Console.WriteLine("Try Again");
                            if (inputToData.Contains("@") && length > 20)
                            {
                                isFalse = false; // yes
                            }

                        }
                        if (inputToData.Contains("@") && length > 20)
                        {
                            Console.WriteLine("Analyzed Gmail");  // analyzed message
                        }
                    }
                }
            }
        }
    }
}

public class Main
{
    public static void main(string[] args)
    {
        // game pixels aka useless code
        int pixelsWidth = 10 * 2; // pixels width
        int PixelsLength = 10 * 3; // height
        int Pixels = pixelsWidth + PixelsLength;// an customized unsuitable pixels 
        int WalkMoveBlock = pixelsWidth * PixelsLength; // amount of pixels moved by using key.key m
        int CaptainEvaHP = 2000; // hp  of eva
        int LilPrincess = 1000;// hp of little princess 
        string lilprincessWP = "Bat"; // weapon of little princess
        ConsoleKeyInfo key = Console.ReadKey(true); // processor of handling keys
        if (key.Key == ConsoleKey.M)
        {
            Console.WriteLine("Pixels Moved: " + WalkMoveBlock);
            Byte[] SystemWorkDigits = new Byte[] { 0, 1 }; //0,1 are the digits of DIGITAL COMPUTERS SO YESSS!

        }
    }
} 
