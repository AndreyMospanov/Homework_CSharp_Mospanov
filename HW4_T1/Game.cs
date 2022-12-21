using System;
using System.Collections.Generic;

namespace Cross_Zero
{
    internal class Game
    {
        TicTacToe ttt;
        private bool inGame;
        private bool player1Turn;
        char p1 = 'x';
        char p2 = 'o';

        public Game()
        {
            ttt = new TicTacToe();
            inGame = true;
            Random rnd = new Random();
            player1Turn = rnd.Next(2) == 1;
        }

        private void MoveAction(char player)//ходит игрок
        {
            while(true)
            {
                ttt.Show(player);
                ttt.Move();
                ttt.Show(player);
                if (ttt.Stamp(player))
                    return;
            }
        }

        private void MoveAction(char pc, char human)//ходит компьютер
        {
            ttt.Move(pc, human);
            ttt.Show(pc);
        }
        public void Run(int regime)
        {
            switch (regime)
            {
                case 1:
                    {
                        while(inGame)
                        {
                            if(player1Turn)
                            {
                                MoveAction(p1);
                                player1Turn=false;
                            }
                            else
                            {
                                MoveAction(p2);
                                player1Turn = true;
                            }
                            if(ttt.GameOver())
                                inGame = false;                            
                        }
                        break;
                    }
                    case 2:
                    {
                        while (inGame)
                        {
                            if (player1Turn)
                            {
                                MoveAction(p1);
                                player1Turn = false;
                            }
                            else
                            {
                                MoveAction(p2, p1);
                                player1Turn = true;
                            }
                            if (ttt.GameOver())
                                inGame = false;
                        }
                        break;
                    }
                default:
                    break;
            }

        }
    }
}
