using System;

namespace Tic_Tac{
    class Proj{
        static string[] board = {"0", "1", "2", "3", "4", "5", "6", "7", "8"};
        static int game_end = 0;
        static int choice;

        static string[] player_prompt(string player, string[] board){

            Console.WriteLine($"Player {player} make a choice(0-8):");
            choice = Convert.ToInt32(Console.ReadLine());
            string choice_string =  Convert.ToString(choice);

            while(board.Contains(choice_string) == false || board[choice] == "X" || board[choice] == "O"){
                Console.WriteLine("Try again silly");
                Console.WriteLine($"Player {player} make a choice(0-8):");
                choice = Convert.ToInt32(Console.ReadLine());
                choice_string =  Convert.ToString(choice);
            }

            if(player == "1"){
                board[choice] = "X";
            }else{
                board[choice] = "O";
            }

            return board;
        }

        static void who_won(string[] board){
            
        }

        static int win_check(string[] board, int game_end = 0){
            int draw_flag = 0;

            for(int i = 0; i<9; i++){
                if(board[i] == "X" || board[i] == "O"){
                    draw_flag++;
                }
            }
            if(board[0] == board[1] && board[1] == board[2] ||
                board[3] == board[4] && board[4] == board[5] ||
                board[6] == board[7] && board[7] == board[8]){

                game_end = 1;
                Console.WriteLine("over");
            }else if(board[0] == board[3] && board[3] == board[6] ||
                    board[1] == board[4] && board[4] == board[7] || 
                    board[2] == board[5] && board[5] == board[8]){

                game_end = 1;
                Console.WriteLine("over");
            }else if(board[0] == board[4] && board[4] == board[8] ||
                    board[2] == board[4] && board[4] == board[6]){
                            
                game_end = 1;
                Console.WriteLine("over");
            }else if(draw_flag == 8){
                game_end = 1;
                Console.WriteLine("Tie Game");
            }else{
                game_end = 0;
            }

            return game_end;
        }

        static void print_board(string[] board){
            Console.WriteLine("Player 1 = X and Player 2 = O");
            Console.WriteLine("Curr Board: \n");
            Console.WriteLine(board[0] + "|" + board[1] + "|" + board[2]);
            Console.WriteLine("------");
            Console.WriteLine(board[3] + "|" + board[4] + "|" + board[5]);
            Console.WriteLine("------");
            Console.WriteLine(board[6] + "|" + board[7] + "|" + board[8]);
        }
        
        static void Main(string[] args){

            do{
                Console.Clear();

                print_board(board);

                board = player_prompt("1", board);
                game_end = win_check(board, game_end);

                if(game_end != 1){
                    board = player_prompt("2", board);
                    game_end = win_check(board, game_end);
                }

                print_board(board);

                

            }while(game_end != 1);
        }
    }
}