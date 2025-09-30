// using System;

// namespace inter{
//     interface IAnimal{
//         void animalSound();
//     }

//     interface farmAnimal{
//         void food();
//     }

//     class Pig : IAnimal, farmAnimal{
//         public void animalSound(){
//             Console.WriteLine("oink");
//         }

//         public void food(){
//             Console.WriteLine("pigs like carrots");
//         }
//     }

//     class Prog{
//         static void Main(string[] args){
//             Pig myPig = new Pig();
//             myPig.animalSound();
//             myPig.food();
//         }
//     }
// }