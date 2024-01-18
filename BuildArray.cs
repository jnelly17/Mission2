using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mission2
{
    internal class BuildArray
    {
        public int[] ConfigArray(int numRolls)
        {

            int[] rolltotals = new int[13]; // 13 bc 2 is lowest and then can allocate exactly so 2-12

            System.Random random = new System.Random();

            //make a for loop for each roll
            for (int i = 0; i < numRolls; i++)
            {
                int die1 = 0;
                int die2 = 0;
                int total = 0;

                //roll the two dice

                die1 = random.Next(1, 7);
                die2 = random.Next(1, 7);
                total = die1 + die2;

                //add one to the tally for that corresponding number

                rolltotals[total]++;
            }

            return rolltotals;


        }
    }
}
