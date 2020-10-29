using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace _03._Inventory
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> items = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries)
                                                   .ToList();
            string[] command = Console.ReadLine().Split(" - ").ToArray();

            while (command[0] != "Craft!")
            {
                switch (command[0])
                {
                    case "Collect":
                        if (items.Any(x => x == command[1]))
                        {
                            break;
                        }
                        else
                        {
                            items.Add(command[1]);
                        }
                        break;
                    case "Drop":
                        if (items.Any(x => x == command[1]))
                        {
                            items.Remove(command[1]);
                        }
                        break;
                    case "Combine Items":
                        string[] combineItems = command[1].Split(":");
                        string oldItem = combineItems[0];
                        string newItem = combineItems[1];
                        int curentItem = 0;
                        if (items.Any(x => x == oldItem))
                        {
                            foreach (var item in items)
                            {
                                curentItem++;
                                if (item == oldItem)
                                {
                                    items.Insert(curentItem, newItem);
                                    break;
                                }
                            }
                        }
                        break;
                    case "Renew":
                        if (items.Any(x=>x==command[1]))
                        {
                            items.Remove(command[1]);
                            items.Add(command[1]);
                        }
                        break;
                }

                command = Console.ReadLine().Split(" - ").ToArray();

            }
            Console.WriteLine(string.Join(", ", items));
        }
    }
}