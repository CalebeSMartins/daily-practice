using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace daily_practice.HackerRank
{
    public class _4LeftRotation
    {
        public static List<int> leftRotation()
        {
            int rot = Convert.ToInt32(Console.ReadLine());

            List<int> a = new List<int>() { 41, 73, 89, 7, 10, 1, 59, 58, 84, 77,
                                            77, 97, 58, 1, 86, 58, 26, 10, 86, 51 };
            int count = a.Count();

            for (int i = 0; i < rot; i++)
            {
                a.Insert(count, a.First<int>());
                a.RemoveAt(0);
            }
            a.ForEach(Console.Write);
            return a;
        }
    }
}
