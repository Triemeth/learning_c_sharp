// using System;

// namespace Params{
//     class Proj{
//         static void name_age(string name = "Ethan", int age = 22){
//             Console.WriteLine(name + " is " + age + " years old");        
//         }

//         static int add(int x, int y){
//             return x + y;
//         }

//         static double add(double x, double y){
//             return x + y;
//         }

//         static float add(float x, float y){
//             return x + y;
//         }

//         static void child_func(string child1, string child2, string child3){
//             Console.WriteLine("Youngest child is " + child3);
//         }

//         static void Main(string[] args){
//             name_age("tim", 23);
//             name_age("jog", 12);
//             name_age();

//             int sum1 = add(1231, 4780);
//             Console.WriteLine(sum1);

//             double sum2 = add(2.2, 1.7);
//             Console.WriteLine(sum2);

//             float sum3 = add(12.253F, 7.894F);
//             Console.WriteLine(sum3);

//             child_func(child3: "jimyy", child1: "clint", child2: "rory");

//         }
//     }
// }