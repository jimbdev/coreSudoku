using System.Collections.Generic;

namespace CoreSudoku.Model
{
    public class Box
    {
        // the following is always true: list[x-1].value == x
        public Cell[] cells = new Cell[9];
        public void AssignCell(Cell cell, int index)
        {
            cells[index] = cell;
        }
    }

}
