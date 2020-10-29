using System;
using System.Collections.Generic;

namespace _02._MuOnline
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] rooms = Console.ReadLine().Split("|", StringSplitOptions.RemoveEmptyEntries);

            int health = 100;
            int bitcoins = 0;
            int bestRoom = 0;
            bool flag = true;
            bool stop = false;
            for (int i = 0; i < rooms.Length; i++)
            {
                List<string> write = new List<string>();

                string[] inCurrentRoom = rooms[i].Split(" ");
                string creaturetOrLoot = inCurrentRoom[0];
                int number = int.Parse(inCurrentRoom[1]);

                bestRoom++;

                if (creaturetOrLoot == "potion")
                {

                    int currentHealth = health;
                    health += number;
                    if (health > 100)
                    {
                        health = 100;
                    }
                    write.Add($"You healed for {health - currentHealth} hp.");
                    write.Add($"Current health: {health} hp.");

                }

                else if (creaturetOrLoot == "chest")
                {

                    bitcoins += number;
                    write.Add($"You found {number} bitcoins.");

                }

                else
                {

                    health -= number;
                    if (health <= 0)
                    {
                        write.Add($"You died! Killed by {creaturetOrLoot}.");
                        write.Add($"Best room: {bestRoom}");
                        flag = false;
                        stop = true;
                    }
                    else
                    {

                        write.Add($"You slayed {creaturetOrLoot}.");

                    }
                }

                Console.WriteLine(string.Join(Environment.NewLine, write));
                if(stop)
                {
                    break;
                }

            }
            if (flag)
            {
                string[] alive = new[] { $"You've made it!", $"Bitcoins: {bitcoins}", $"Health: {health}" };
                Console.WriteLine(string.Join(Environment.NewLine, alive));
            }
        }
    }
}