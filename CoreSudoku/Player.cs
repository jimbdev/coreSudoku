using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace CoreSudoku
{
    public class Player
    {
        Grid board;
        List<Box> regions;

        public Player()
        {
            board = new Grid();
            regions.Add(new Box());
            var mapper = new RegionMapper();
            mapper.MapRegions(board, regions);


        }

    }
}
