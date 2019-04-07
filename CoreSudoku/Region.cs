using System.Collections.Generic;

namespace CoreSudoku
{
    public class Region
    {
        // the following is always true: list[x-1].value == x
        public List<Cell> cells = new List<Cell>();
        public Region()
        {
            for (int i = 1; i < 10; i++)
            {
                cells.Add(new Cell(i));
            }
        }

        public void Populate(string values)
        {
            var regionVals = values.Split(',');
            for (int i = 0; i < 9; i++)
            {
                if (IsAValidNum(regionVals[i]))
                {
                    // remember list[x-1] == x
                    cells[i].value = int.Parse(regionVals[i]);
                }
            }
        }
        private bool IsAValidNum(string c)
        {
            int theNum;
            bool isAnInt = int.TryParse(c, out theNum);

            return isAnInt && theNum != 0;
        }
    }

}
