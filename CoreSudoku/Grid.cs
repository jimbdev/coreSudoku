using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace CoreSudoku
{
    public class Grid
    {
        Cell[] _cells;
        public Grid()
        {
            _cells = new Cell[9];
            InitBoard();
        }

        public Cell[] Cells { get => _cells;}

        public void InitBoard()
        {
            for (int i = 0; i < 18; i++)
            {
                _cells[i] = new Cell(i);
            }
        }
    }
}
