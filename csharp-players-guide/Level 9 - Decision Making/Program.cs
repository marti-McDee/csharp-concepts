/*** THE IF STATEMENT ***/

string input = null;
int score = 0;

//while (input == null)
//{
//    input = Console.ReadLine();
//    score = Convert.ToInt32(input);
//}

if (score >= 70)
{
    string msg = "Congrats, you passed!";
    //Console.WriteLine(msg);
}


/*** USING BOOL IN DECISION MAKING ***/
int score1 = 45;
int pointsNeededToPass = 100;

bool levelComplete;

if(score1 >= pointsNeededToPass)
{
    levelComplete = true;
}
else
{
    levelComplete = false;
}

if(levelComplete) { Console.WriteLine("You've beaten the level!"); }


/* Challenge: Repairing the Clocktower */

// take a number as input from the console
string input1 = null;
int num = 0;

while(input1 == null)
{
    input1 = Console.ReadLine();
    num = Convert.ToInt32(input1);
}

// if the number is even, display the word 'tick'. if the number is odd, display the word 'tock'.
if (num % 2 == 0) Console.WriteLine("Tick");
else Console.WriteLine("Tock");
