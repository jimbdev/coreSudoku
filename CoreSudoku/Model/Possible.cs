using System;
using System.Collections.Generic;
using System.Text;

namespace CoreSudoku.Model
{
    public class Possible
    {
        public HashSet<int> poss = new HashSet<int>();

        public Possible()
        {
            for (int i = 1; i <= 9; i++)
            {
                poss.Add(i);
            }
        }

        public void Remove(HashSet<int> s)
        {
            poss.ExceptWith(s);
        }

        public void Remove(int i)
        {
            poss.Remove(i);
        }
    }
}
