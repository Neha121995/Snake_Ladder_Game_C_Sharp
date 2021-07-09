﻿using System;

namespace Sneak_Ladder_Game
{
    class Program
    {
        public int Roll_Dice()
        {
            Random random = new Random();
            int Roll_Dice_Value = random.Next(1, 7);
            return Roll_Dice_Value;
        }

        public int Check_Option(int Roll_Dice_Value, int Player_1)
        {
            Random random = new Random();
            int Option = random.Next(0, 3);
            //Console.WriteLine("Option" + Option);
            switch (Option)
            {
                case 1:
                    Console.WriteLine("Ladder");
                    Player_1 = Player_1 + Roll_Dice_Value;
                    break;
                case 2:
                    Console.WriteLine("Sneak");
                    Player_1 = Player_1 - Roll_Dice_Value;
                    if (Player_1 < 0)
                    {
                        Player_1 = 0;
                    }
                    break;
                default:
                    Console.WriteLine("No Play");
                    break;
            }
            return Player_1;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the sneak ladder Game");
            int Player_1 = 0;
            Console.WriteLine("Player 1 Position is " + Player_1);
            Program sneakladderobj = new Program();
            int Roll_Dice_value = sneakladderobj.Roll_Dice();
            Console.WriteLine("Roll Dice value is : " + Roll_Dice_value);
            Console.WriteLine("Player_1 Status And Value is : " + sneakladderobj.Check_Option(Roll_Dice_value, Player_1));
        }
    }
}