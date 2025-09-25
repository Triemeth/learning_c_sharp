// using System;
// using System.Linq;

// namespace arr{
//     class Prog{
//         static void Main(string[] args){
//             string[] cars = {"Volvo", "BMW", "Ford", "Mazda"};
//             int[] nums = {1, 2, 3, 4, 8, 54};

//             Console.WriteLine(cars[0] + "\n");

//             cars[0] = "Audi";
//             Console.WriteLine(cars[0] + "\n");
//             Console.WriteLine(cars.Length + "\n");

//             string[] nothin = new string[4];
//             Console.WriteLine(nothin.Length + "\n");

//             Array.Sort(cars);
//             foreach(string car in cars){
//                 Console.WriteLine(car);
//             }

            
//             Array.Sort(nums);
//             foreach(int num in nums){
//                 Console.WriteLine(num);
//             }

//             Console.WriteLine();
//             Console.WriteLine(nums.Max());  
//             Console.WriteLine(nums.Min());  
//             Console.WriteLine(nums.Sum());  
//             Console.WriteLine();

//             //two-D arrays

//             int[,] two_D_nums = {{1, 2, 4}, {3, 6, 2}};
//             Console.WriteLine(two_D_nums[0, 2]);

//             two_D_nums[0, 0] = 5;
//             Console.WriteLine(two_D_nums[0, 0]);

//             foreach(int i in two_D_nums){
//                 Console.WriteLine(i);
//             }
//         }
//     }
// }