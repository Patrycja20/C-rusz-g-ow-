using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_5
{
    class Stats
    {
        public int Total;
        public int Missed;
        public int Accuracy;
        public int Correct;

        public void Update(bool correctKey)
        {
            Total++;

            if (!correctKey)
                Missed++;
            else
                Correct++;
            Accuracy = 100 * Correct / Total;
        }
    }
}
