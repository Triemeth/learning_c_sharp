// using System;

// namespace str{
//     class Prog{
//         static void Main(string[] args){
//             string text = "qwertyuiopasdfghjklzxccvbnm";
//             Console.WriteLine("text length: " + text.Length);

//             //concat
//             string x = "20";
//             string y = "10";
//             Console.WriteLine(x + y);
//             string xy = string.Concat(x, y);
//             Console.WriteLine(xy);

//             //Interpolation
//             string first = "John";
//             string last = "Doe";
//             string full = $"full name: {first} {last}";
//             Console.WriteLine(full);

//             //access
//             string full_name = "John Doe";
//             Console.WriteLine(full_name[2]);

//             int index = full_name.IndexOf("D");
//             Console.WriteLine(index);

//             string last_name = full_name.Substring(index);
//             Console.WriteLine(last_name);

//             string sentence = "It\'s the \"sentence\" \\ \n word \t gang";
//             Console.WriteLine(sentence);

//         }
//     }
// }