// See https://aka.ms/new-console-template for more information
Console.WriteLine("***Basic String processing Lab");
do
{
    Console.WriteLine("Enter Some sentence");
    string str = Console.ReadLine();
    Console.WriteLine(str);
    string[] words = str.Split(' ');
    foreach (string word in words)
    {
        Console.WriteLine(word);
    }

} while (GetPlayAgainAnswer() == true);

//Console.ReadKey();

bool GetPlayAgainAnswer(string strMessage = "Would you like to Continue? y/n")
{
    Console.WriteLine(strMessage);
    string userAnswer = Console.ReadLine();
    if (userAnswer.ToLower() != "y")
    {
        return false;
    }

    //Console.WriteLine("YEAH LETS PLAY");
    return true;
}

List<string> addTextInList = new List<string>();
do
{
    Console.WriteLine("Enter Some Text");
    string str = Console.ReadLine().Trim();
    Console.WriteLine("You have entered "+str);
    addTextInList.Add(str);
   
} while (GetPlayAgainAnswer() == true);

string concantenateText = "";
foreach (string word in addTextInList)
{
    concantenateText += word + " ";
}
Console.WriteLine(concantenateText);


