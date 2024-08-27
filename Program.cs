// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, Lalit!");

using System.Collections.Generic;

string firstfriend = "Hi!";
string lastfriend = "You";

// Console.WriteLine($"My friend name is {firstfriend} and {lastfriend}");

// Trimming
// string greeting="       Good Afternoon          ";
// Console.WriteLine(greeting);
// Console.WriteLine();
// Console.WriteLine($"{greeting}");
// Console.WriteLine("");
// Console.WriteLine($"[{greeting}]");
// Console.WriteLine();
// string trimsentence=greeting.TrimStart();
// Console.WriteLine($"[{trimsentence}]");

// string trimatend=greeting.TrimEnd();
// Console.WriteLine($"[{trimatend}]");

// string fulltrim=greeting.Trim();
// Console.WriteLine($"[{fulltrim}]");

// string test_replace=$"My friends {firstfriend} and {lastfriend}  are here.";
// Console.WriteLine(test_replace.Replace("Hi","Hello"));
// Console.WriteLine(test_replace.Contains("friends"));
// Console.WriteLine("Hi Team!".ToUpper());
// Console.WriteLine(test_replace.Length);
// Console.WriteLine(test_replace.StartsWith("Sco")); 
// Console.WriteLine(test_replace.StartsWith("M"));


// int a=18;
// int b=6;
// int c=a+b;
// //Console.WriteLine(c);
// Console.WriteLine();
// int d=2100000000; // the maximum values which can be store is 2^32 hence if I put extra 0 here error.  
// int e=333333333;
// //int f=d+e;
// //long f=(long)d+(long)e;  correct result here
// long f=checked(d+e); // this will return an exception if overflow  occurs 

// Console.WriteLine(f); // the result will be wrong as we have overflown


//int counter=0;
// counter++;
// Console.WriteLine(counter);
// counter++;
// Console.WriteLine(counter);
// counter++; // now instead of repeating so many steps, I can use for or while loop
// Console.WriteLine(counter);

// while(counter<5){
//     counter++;
//     Console.WriteLine(counter);
// }


// other approach

// int counter=5;
// do{
//     Console.WriteLine(counter);
//     counter++;
// }
// while(counter<5);

// For loop Approach
int counter = 10;
// for (int i = 0; i < counter; i++)
// {
//     Console.WriteLine(i);

// }


// having nested for loops
// for (int row = 1; row < 11; row++)
// {
//     for (char column = 'a'; column < 'k'; column++)
//     {

//         Console.WriteLine($"The cell is ({row},{column})");
//     }
// }

Console.WriteLine();
// Collections
var names = new List<string> { "Lalit", "Ana" };
// for (int i = 0; i < names.Count; i++)
// {
//     Console.WriteLine(names[i]);
// }

// names.Add("India");
// names.Add("Poland");

// or
// foreach (var name in names[1..3])
// {
//     Console.WriteLine(name);
// }

// foreach ij in names{
//     Console.WriteLine(ij)
// }
// // or
// List<string> name=new List<string> {"Lalit"};
// names.Add("India");
// names.Add("Poland");
// Console.WriteLine(names);

var namess = new string[] { "Lal", "It", "JJ" };
// names.Add(); // wont work as array is fixed
// foreach (var name in namess){
//     Console.WriteLine(name);
// }



//Searching & Sorting

// var nam = new List<string> { "1", "0", "3", "5", "Hi", "-1" };
// var tea = new List<int> { 1, 55, 22, 0, 1 };
// nam.Sort();
// tea.Sort();
// foreach (var na in nam)
// {
//     Console.WriteLine(na);
// }



//LINQ 
int[] scores = [ 97, 92, 81, 60 ];
// or
// int[] scores=[91,22,34,1];
//or
// var score=new List<int>{222,11};
//or
// List<int> score=[92,333,5];  this is an example of syntatc sugar.
//IEnumerable<int> scorequery
// Finding list of score above 80;
// for (int i = 0; i < scores.Length; i++)
// {
//     if(scores[i]>50){
//         Console.WriteLine(scores[i]);
//     }
//  }

//  return;

// Now we use LINQ instead of above - Declaraitve programming
IEnumerable<string> scoreQuery=from score in scores where score >50 orderby score ascending select $"The score is {score}"  ;
foreach(string i in scoreQuery){
    Console.WriteLine(i);
}

// What does IEnumerable do? 
// What is the difference b/w IEnumerable and for loop?
// Difference b/w Query Syntax and Method based syntax.
