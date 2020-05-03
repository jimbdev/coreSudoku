using CoreSudoku.Model;
using System.Collections.Generic;

namespace CoreSudoku
{
    public class RegionMapper
    {
        public void MapRegions(Grid grid, List<Box> boxes)
        {
            //will be conventions based
            //Something like: 0-8 = rows 1-9, 9-17 = cols 1-9, 18-26 - blocks 1-9

            // map cells
            for (int i = 0; i < 9; i++)
            {
                boxes[0].AssignCell(grid.Cells[i],i);
            }
        }
    }
}