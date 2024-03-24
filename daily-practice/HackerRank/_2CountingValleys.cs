using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace daily_practice.Beecrowd
{
    public class _2CountingValleys
    {
        public static int countingValleys()
        {
            int steps = 8;
            string[] path = { "D", "D", "U", "U", "U", "U", "D", "D" };

            int valley = 0;
            int altitude = 0;
            for (int i = 0; i < steps; i++)
            {
                if (path[i] == "U")
                {
                    if (altitude == -1)
                    {
                        valley++;
                    }
                    altitude++;
                }

                if (path[i] == "D")
                {
                    altitude--;
                }
            }
            return valley;
        }
    }
}

