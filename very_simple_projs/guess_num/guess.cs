using System;

namespace guess_num{
    class guess_num_proj{
        static void Main(string[] args){

            Random rnd = new Random();
            int num_to_guess = rnd.Next(1, 21);

            Console.WriteLine("Guess a number 1 through 20");
            int guess = Convert.ToInt32(Console.ReadLine());

            if(guess == num_to_guess){
                Console.WriteLine("no way you got it first try");
            }else if(guess.GetType() != typeof(int)){
                Console.WriteLine("Rerun and input a num");
            }else{
                do{
                    if(num_to_guess > guess){
                        Console.WriteLine("guess higher! Try again:");
                        guess = Convert.ToInt32(Console.ReadLine());
                    }else if(num_to_guess < guess){
                        Console.WriteLine("guess lower! Try again:");
                        guess = Convert.ToInt32(Console.ReadLine());
                    }
                }while(guess!=num_to_guess);
            }

            Console.WriteLine("You got it!");
        }
    }
}