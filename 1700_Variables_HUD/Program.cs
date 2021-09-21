﻿using System;

namespace _1700_Variables_HUD
{
    class Program
    {
        static void Main(string[] args)
        {
            float Score;
            int Health;
            int Shields;
            int Lives;
            float ScoreMultiplier;
            int Headshot;
            int Bodyshot;
            string firstName;
            string lastName;
            string fullName;
            int enemyKill;
            int healHealth;
            int healShields;
            float Banana;
            int baseHealth;
            int baseShields;
            baseShields = 150;
            baseHealth = 100;
            Banana = 1.0f;
            healShields = 50;
            healHealth = 25; 
            enemyKill = 50;
            firstName = "Monkey";
            lastName = "Lad";
            fullName = firstName + " " + lastName;
            Headshot = 50;
            Bodyshot = 25;
            ScoreMultiplier = 1.0f;
            Lives = 5;
            Shields = 150;
            Health = 100;
            Score = 0.0f;

            Console.WriteLine("Banana Brain Studios Presents:");
            Console.WriteLine("Monkey Business");
            Console.WriteLine("Score: " + Score * ScoreMultiplier);
            Console.WriteLine("Health: " + Health);
            Console.WriteLine("Shields: " + Shields);
            Console.WriteLine("Lives: " + Lives);
            Console.WriteLine("Score Multiplier: " + ScoreMultiplier);

            Console.ReadKey(true);

            Console.WriteLine(" ");
            Console.WriteLine("Go get your bananas back from the aliens " + fullName);
            Console.WriteLine(" ");

            Console.ReadKey(true);

            Console.WriteLine(" ");
            Console.WriteLine("You kill two aliens and take one hit to the chest");
            Console.WriteLine(" ");
            Console.WriteLine("--------------");

            Score = (int)(Score + enemyKill + enemyKill * ScoreMultiplier);
            Shields = Shields - Bodyshot;

            Console.WriteLine("Banana Brain Studios Presents:");
            Console.WriteLine("Monkey Business");
            Console.WriteLine("Score: " + Score * ScoreMultiplier);
            Console.WriteLine("Health: " + Health);
            Console.WriteLine("Shields: " + Shields);
            Console.WriteLine("Lives: " + Lives);
            Console.WriteLine("Score Multiplier: " + ScoreMultiplier);

            Console.ReadKey(true);

            Console.WriteLine(" ");
            Console.WriteLine("You kill one alien and you take two hits to the head, you also find one of your bananas");
            Console.WriteLine(" ");
            Console.WriteLine("--------------");

            ScoreMultiplier = ScoreMultiplier + Banana;
            Score = (int)(Score + enemyKill * ScoreMultiplier);
            Shields = Shields - Headshot - Headshot;


            Console.WriteLine("Banana Brain Studios Presents:");
            Console.WriteLine("Monkey Business");
            Console.WriteLine("Score: " + Score * ScoreMultiplier);
            Console.WriteLine("Health: " + Health);
            Console.WriteLine("Shields: " + Shields);
            Console.WriteLine("Lives: " + Lives);
            Console.WriteLine("Score Multiplier: " + ScoreMultiplier);

            Console.ReadKey(true);

            Console.WriteLine(" ");
            Console.WriteLine("You take one shot to the body and two shots to the head and die, losing a life");
            Console.WriteLine(" ");
            Console.WriteLine("--------------");

            Lives = Lives - 1;
            Shields = baseShields;
            Health = baseHealth;

            Console.WriteLine("Banana Brain Studios Presents:");
            Console.WriteLine("Monkey Business");
            Console.WriteLine("Score: " + Score * ScoreMultiplier);
            Console.WriteLine("Health: " + Health);
            Console.WriteLine("Shields: " + Shields);
            Console.WriteLine("Lives: " + Lives);
            Console.WriteLine("Score Multiplier: " + ScoreMultiplier);

            Console.ReadKey(true);

            Console.WriteLine(" ");
            Console.WriteLine("You kill three enemies and you find another banana taking one shot to the head in the process");
            Console.WriteLine(" ");
            Console.WriteLine("--------------");

            ScoreMultiplier = ScoreMultiplier + Banana;
            Score = Score + enemyKill + enemyKill + enemyKill * ScoreMultiplier;
            Shields = Shields - Headshot;

            Console.WriteLine("Banana Brain Studios Presents:");
            Console.WriteLine("Monkey Business");
            Console.WriteLine("Score: " + Score * ScoreMultiplier);
            Console.WriteLine("Health: " + Health);
            Console.WriteLine("Shields: " + Shields);
            Console.WriteLine("Lives: " + Lives);
            Console.WriteLine("Score Multiplier: " + ScoreMultiplier);

            Console.ReadKey(true);

            Console.WriteLine(" ");
            Console.WriteLine("You kill one enemy and take two shots to the head and one to the body");
            Console.WriteLine(" ");
            Console.WriteLine("--------------");

            Score = Score + enemyKill;
            Shields = Shields - Headshot - Headshot;
            Health = Health - Bodyshot;

            Console.WriteLine("Banana Brain Studios Presents:");
            Console.WriteLine("Monkey Business");
            Console.WriteLine("Score: " + Score * ScoreMultiplier);
            Console.WriteLine("Health: " + Health);
            Console.WriteLine("Shields: " + Shields);
            Console.WriteLine("Lives: " + Lives);
            Console.WriteLine("Score Multiplier: " + ScoreMultiplier);

            Console.ReadKey(true);

            Console.WriteLine(" ");
            Console.WriteLine("You find a monkey biscuit that heals some of your health and find another banana");
            Console.WriteLine(" ");
            Console.WriteLine("--------------");

            Health = Health + healHealth;
            ScoreMultiplier = ScoreMultiplier + Banana;

            Console.WriteLine("Banana Brain Studios Presents:");
            Console.WriteLine("Monkey Business");
            Console.WriteLine("Score: " + Score * ScoreMultiplier);
            Console.WriteLine("Health: " + Health);
            Console.WriteLine("Shields: " + Shields);
            Console.WriteLine("Lives: " + Lives);
            Console.WriteLine("Score Multiplier: " + ScoreMultiplier);

            Console.ReadKey(true);

            Console.WriteLine(" ");
            Console.WriteLine("You find a Monkey shield that repairs some of your shields and kill one enemy");
            Console.WriteLine(" ");
            Console.WriteLine("--------------");

            Shields = Shields + healShields;
            Score = Score + enemyKill;

            Console.WriteLine("Banana Brain Studios Presents:");
            Console.WriteLine("Monkey Business");
            Console.WriteLine("Score: " + Score * ScoreMultiplier);
            Console.WriteLine("Health: " + Health);
            Console.WriteLine("Shields: " + Shields);
            Console.WriteLine("Lives: " + Lives);
            Console.WriteLine("Score Multiplier: " + ScoreMultiplier);

            Console.ReadKey(true);

            Console.WriteLine(" ");
            Console.WriteLine("You find your last 2 Bananas and kill three enemies guarding them");
            Console.WriteLine(" ");
            Console.WriteLine("--------------");

            ScoreMultiplier = ScoreMultiplier + Banana + Banana;
            Score = Score + enemyKill + enemyKill + enemyKill;

            Console.WriteLine("Banana Brain Studios Presents:");
            Console.WriteLine("Monkey Business");
            Console.WriteLine("Score: " + Score * ScoreMultiplier);
            Console.WriteLine("Health: " + Health);
            Console.WriteLine("Shields: " + Shields);
            Console.WriteLine("Lives: " + Lives);
            Console.WriteLine("Score Multiplier: " + ScoreMultiplier);

            Console.ReadKey(true);

            Console.WriteLine(" ");
            Console.WriteLine("YOU WIN");
            Console.WriteLine("ENJOY YOUR BANANAS");
            Console.WriteLine(" ");

            Console.ReadKey(true);











        }
    }
}
