/*Console.Write("Fill in Your name :");
string username = Console.ReadLine()!;
Console.Write("HI,");
Console.Write(username);*/

/*Console.Write("What is your name ?");
string username = Console.ReadLine()!;
Console.Write("Hi ," + (username));*/

Console.WriteLine("Where are from ?");
string answer = Console.ReadLine() !;

if (answer.ToLower() == "tashkent")

{
  Console.WriteLine("Good City !");
}
else 
{
  Console.WriteLine("HMM ,never heard about");
  Console.Write(answer);
}