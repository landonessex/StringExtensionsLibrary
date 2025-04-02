using StringExtensions;

string testString1 = "Hello world";
string testString2 = "hello world";

Console.WriteLine($"'{testString1}' starts with uppercase: {testString1.StartsWithUpperCase()}");
Console.WriteLine($"'{testString2}' starts with uppercase: {testString2.StartsWithUpperCase()}");

Console.ReadLine();