using System;

namespace day2 
{
    internal class Program
    {
            enum Hands {
                ROCK,
                PAPER,
                SCISSORS
            }

        enum Result {
            WIN,
            LOSE,
            DRAW,
            UNCERTAIN
        }

        static Result check_result(Hands hand1, Hands hand2){
            if(hand1 == Hands.ROCK){
                switch(hand2){
                    case Hands.PAPER:
                    return Result.LOSE;

                    case Hands.SCISSORS:
                    return Result.WIN;

                    case Hands.ROCK:
                    return Result.DRAW;
                }
            }
            else if (hand1 == Hands.PAPER){
                switch(hand2){
                    case Hands.PAPER:
                    return Result.DRAW;

                    case Hands.SCISSORS:
                    return Result.LOSE;

                    case Hands.ROCK:
                    return Result.WIN;
                }
            }
            else if (hand1 == Hands.SCISSORS){
                switch(hand2){
                    case Hands.PAPER:
                    return Result.WIN;

                    case Hands.SCISSORS:
                    return Result.DRAW;

                    case Hands.ROCK:
                    return Result.LOSE;
                }
            }
            return Result.UNCERTAIN;
        }
        static void Main(string[] args)
        {


            var hand_code = new Dictionary<char, Hands>(){
                {'A', Hands.ROCK},
                {'B', Hands.PAPER},
                {'C', Hands.SCISSORS},
                {'X', Hands.ROCK},
                {'Y', Hands.PAPER},
                {'Z', Hands.SCISSORS}
            };


            int current_score = 0;
            foreach(string line in System.IO.File.ReadLines("input.txt"))
            {
                switch(hand_code[line[2]]){
                    case Hands.ROCK:
                        current_score += 1;
                        break;

                    case Hands.PAPER:
                        current_score += 2;
                        break;

                    case Hands.SCISSORS:
                        current_score += 3;
                        break;
                }
                switch(check_result(hand_code[line[2]],hand_code[line[0]]))
                {
                    case Result.WIN:
                        current_score += 6;
                        break;
                    
                    case Result.DRAW:
                        current_score += 3;
                        break;

                }
               
            }

            Console.WriteLine(current_score);
            
        }
    }
}