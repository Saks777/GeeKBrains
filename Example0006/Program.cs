Console.Write("Fill in Your name: ");
string username = Console.ReadLine()!;

if (username.ToLower() == "masha")

{
  Console.WriteLine("Hoora,this is Masha !!");
}
else
{
  Console.Write("Hi, ");
  Console.WriteLine(username);
}