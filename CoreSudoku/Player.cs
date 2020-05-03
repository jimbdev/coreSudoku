using CoreSudoku.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;


namespace CoreSudoku
{
    public class Player
    {
        Grid grid;
        List<Box> boxes;

        public Player()
        {
            grid = new Grid();
            boxes.Add(new Box());
            var mapper = new RegionMapper();
            mapper.MapRegions(grid, boxes);


        }

    }
}
