// using System;

// namespace Poly{
//     class animals{
//         public virtual void animalNoise(){
//             Console.WriteLine("Animal noise");
//         }
//     }
//     class dog : animals{
//         public override void animalNoise(){
//             Console.WriteLine("bark");
//         }
//     }
//     class cat : animals{
//         public override void animalNoise(){
//             Console.WriteLine("Meow");
//         }
//     }
//     class armidilo : animals{}

//     class Program{
//         static void Main(string[] args){
//             animals myAnimal = new animals();
//             animals mydog = new dog();
//             animals mycat = new cat();
//             animals myarmidilo = new armidilo();

//             myAnimal.animalNoise();
//             mydog.animalNoise();
//             mycat.animalNoise();
//             myarmidilo.animalNoise();
//         }
//     }
// }