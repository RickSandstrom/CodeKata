// See https://aka.ms/new-console-template for more information

Console.WriteLine("Welcome to Rot5-crypto.");

string answer;
do
{
    Console.Write("Enter a string to be encrypted:");
    string original = Console.ReadLine() ?? "";
    Console.WriteLine($"Encrypted string: {Rot5.Encrypt(original)}");
    Console.WriteLine();
    Console.WriteLine("Do you want to encrypt another one (y/n)?");
    answer = Console.ReadLine() ?? "";

} while (answer.ToLower() == "y");
