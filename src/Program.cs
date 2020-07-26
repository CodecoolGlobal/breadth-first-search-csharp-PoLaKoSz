using BFS_c_sharp.Model;
using System;
using System.Collections.Generic;

namespace BFS_c_sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            RandomDataGenerator generator = new RandomDataGenerator();
            List<UserNode> users = generator.Generate();

            foreach (var user in users)
            {
                //Console.WriteLine(user);
            }
/*
            int distance = DistanceBetween(users[0], users[1]);
            System.Console.WriteLine($"Distance between {users[0]} and {users[1]} = {distance}");
*/
            Console.WriteLine("Done");
        }

        public static int DistanceBetween(UserNode firstNode, UserNode otherNode)
        {
            System.Console.WriteLine($"{firstNode} friends:");
            foreach (UserNode friend in firstNode.Friends)
            {

                System.Console.WriteLine($"\t{friend}");
                if (friend == otherNode)
                {
                    return 1;
                }
            }

            return 0;
        }
    }
}
