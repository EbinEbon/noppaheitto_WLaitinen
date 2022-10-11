using System;
using System.Collections.Generic;
using System.Text;

namespace noppaheitto_WLaitinen
{
    class Dice
    {
        public int Value;

        public static int Roll()
        {
            Random rnd = new Random();
            int noppa = rnd.Next(1, 6 + 1);
            return noppa;
        }

    }
}
