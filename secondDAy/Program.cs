// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// See https://aka.ms/new-console-template for more information
using System.Net.Security;
string x = "Dad Jokes"; // Dad Jokes are stored in x
Console.WriteLine(x);
string y = "Mom Jokes"; // Mom Jokes are stored in y
string sampleConcatenation = "A" + "B" + "c"; // ABC are stored in sampleConcatenation
Console.WriteLine(sampleConcatenation);
string sillyBookTitle = "           If You Give A Mouse A Cookie            ";
Console.WriteLine(sillyBookTitle);
Console.WriteLine("we liked to trim it again" + sillyBookTitle.Trim().Length  + y);
string trim = sillyBookTitle.Trim(); // Trim is cuting the space
Console.WriteLine(trim);


string bracken = x + ","+y +","+ sampleConcatenation; //this one is adding strings
Console.WriteLine(bracken);
Console.WriteLine(
    "The length is "+sillyBookTitle.Length+"\n"+ // \n is new line
    "The trimed length is "+sillyBookTitle.Trim().Length);
Console.WriteLine("print ");

