using System;
using System.Collections.Generic;

namespace Cross_Zero
{
    internal class TicTacToe
    {
        private char[] ticTac;
        private char empty;
        private int position;        
        public int Position 
        { get => position; 
          set 
          {
                if (value > 8)
                    position = value - 9;
                else if (value < 0)
                    position = value + 9;
                else
                    position = value;
          }
        }
        public TicTacToe()
        {
            empty = '_';
            ticTac = new char[9];
            for (int i = 0; i < ticTac.Length; i++)
            {
                ticTac[i] = empty;
            }
            position = 0;
        }

        public void Move(char pc, char rival) //метод для обработки хода ПК
        {
            if (Stamp(4, pc))
            {
                return;
            }

            for (int i = 0; i < ticTac.Length; i++)
            {
                //реализует свои предвыигрышные ситуации победой
                if (i > 2 && ticTac[i] == pc && ticTac[i] == ticTac[i - 3])
                {
                    Position = i + 3;
                    if (Stamp(Position, pc))
                    {
                        return;
                    }
                }
                if (i > 0 && (i + 2) % 3 == 0 && ticTac[i] == pc && ticTac[i] == ticTac[i - 1])
                {
                    Position = i + 1;
                    if (Stamp(Position, pc))
                    {
                        return;
                    }
                }
                if (i < 8 && (i + 2) % 3 == 0 && ticTac[i] == pc && ticTac[i] == ticTac[i + 1])
                {
                    Position = i - 1;
                    if (Stamp(Position, pc))
                    {
                        return;
                    }
                }
                //противостоит предвыигрышным ситуациям игрока
                if (i > 2 && ticTac[i] == rival && ticTac[i] == ticTac[i - 3])
                {
                    Position = i + 3;
                    if (Stamp(Position, pc))
                    {
                        return;
                    }
                }
                if (i > 0 && (i + 2) % 3 == 0 && ticTac[i] == rival && ticTac[i] == ticTac[i - 1])
                {
                    Position = i + 1;
                    if (Stamp(Position, pc))
                    {
                        return;
                    }
                }
                if (i < 8 && (i + 2) % 3 == 0 && ticTac[i] == rival && ticTac[i] == ticTac[i + 1])
                {
                    Position = i - 1;
                    if (Stamp(Position, pc))
                    {
                        return;
                    }
                }
                
            }
            if (ticTac[4] == ticTac[0])
            {
                if (Stamp(8, pc))
                {
                    return;
                }
            }
            if (ticTac[4] == ticTac[8])
            {
                if (Stamp(0, pc))
                {
                    return;
                }
            }
            for (int i = 0; i < ticTac.Length; i++)
            {
                if (ticTac[i] == pc)
                {
                    if (Stamp(i + 1, pc))
                    {
                        return;
                    }
                    if (Stamp(i + 3, pc))
                    {
                        return;
                    }
                }
            }
            for (int i = 0; i < ticTac.Length; i++)
            {
                if (Stamp(i, pc))
                {                    
                    return;
                }
            }
        }

        public void Move()
        {
            ConsoleKeyInfo key = Console.ReadKey();
            if (key.Key == ConsoleKey.W)
            {
                Position -= 3;
            }
            else if (key.Key == ConsoleKey.S)
            {
                Position += 3;
            }
            else if (key.Key == ConsoleKey.A)
            {
                Position -= 1;
            }
            else if (key.Key == ConsoleKey.D)
            {
                Position += 1;
            }
        }

        public void Show(char player)
        {
            Console.Clear();
            Console.WriteLine($"Ход {player}\n");
            for (int i = 0; i < ticTac.Length; i++)
            {
                if(i > 0 && i % 3 == 0)
                    Console.WriteLine();
                if(i == position)
                {
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Black;
                }
                else
                {
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.White;
                }
                Console.Write(ticTac[i]);
            }
        }  
        
        public bool Stamp(int index, char pc)//Компьютер ставит свой знак
        {
            if (ticTac[index] == empty)
            {
                Position = index;
                ticTac[Position] = pc;
                return true;
            }
            else return false;
        }
        public bool Stamp(char xo)//Игрок ставит знак
        {
            ConsoleKeyInfo key = Console.ReadKey();
            if(key.Key == ConsoleKey.Spacebar)
            {
                if (ticTac[Position] == empty)
                {
                    ticTac[Position] = xo;
                    return true;
                }                
            }
            return false;                
        }

        public bool GameOver()
        {
            bool gameOver = false;
            //проверяем условия выигрыша по диагонали
            if (ticTac[0] != empty && ticTac[0] == ticTac[4] && ticTac[4] == ticTac[8])
                gameOver = true;
            if (ticTac[2] != empty && ticTac[2] == ticTac[4] && ticTac[2] == ticTac[6])
                gameOver = true;
            if(gameOver)
            {
                Console.WriteLine($"\n{ticTac[4]} выигрывают!");
                return true;
            }                
            //проходим по полю для проверки выигрыша по горизонтали и вертикали
            for (int i = 0; i < ticTac.Length; i++)
            {
                if (i % 3 == 0 && ticTac[i] != empty && ticTac[i] == ticTac[i + 1] && ticTac[i] == ticTac[i + 2])
                    gameOver = true;

                if (i < 3 && ticTac[i] != empty && ticTac[i] == ticTac[i + 3] && ticTac[i] == ticTac[i + 6])
                    gameOver = true;
                
                if (gameOver)
                {
                    Console.WriteLine($"\n{ticTac[i]} выигрывают!");
                    break;
                }                    
            }

            //проверка на ничью
            if(!gameOver)
            {
                for (int i = 0; i < ticTac.Length; i++)
                {
                    if (ticTac[i] == empty)
                        break;
                    if (i == 8)
                    {
                        gameOver = true;
                        Console.WriteLine("Ничья!");
                    }                        
                }
            }            

            return gameOver;                      
        }
    }
}
