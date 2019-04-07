using Xunit;
using CoreSudoku;

namespace CoreSudoku.tests
{
    public class CoreSudoku_RegionShould
    {
        private readonly Region _region;

        public CoreSudoku_RegionShould()
        {
            _region = new Region();
        }

        [Fact]
        public void ConstructorWorks()
        {
            Assert.Equal(_region.cells.Count, 9);
            
            Assert.True(_region.cells.Exists(x => x.index == 1));
        }

        [Fact]
        public void PopSetsCells()
        {
            string input = "9,8,7,6,5,4,3,2,1";

            _region.Populate(input);

            Assert.True(_region.cells.Exists(x => x.index == 1 && x.value == 9));
            Assert.True(_region.cells.Exists(x => x.index == 2 && x.value == 8));
            Assert.True(_region.cells.Exists(x => x.index == 3 && x.value == 7));
            Assert.True(_region.cells.Exists(x => x.index == 4 && x.value == 6));
            Assert.True(_region.cells.Exists(x => x.index == 5 && x.value == 5));
            Assert.True(_region.cells.Exists(x => x.index == 6 && x.value == 4));
            Assert.True(_region.cells.Exists(x => x.index == 7 && x.value == 3));
            Assert.True(_region.cells.Exists(x => x.index == 8 && x.value == 2));
            Assert.True(_region.cells.Exists(x => x.index == 9 && x.value == 1));

        }

        [Fact]
        public void PopSetsCellsWithEmpties()
        {
            string input = "9,-,7,6,0,4,,2,.";

            _region.Populate(input);

            Assert.True(_region.cells.Exists(x => x.index == 1 && x.value == 9));
            Assert.True(_region.cells.Exists(x => x.index == 2 && !x.value.HasValue));
            Assert.True(_region.cells.Exists(x => x.index == 3 && x.value == 7));
            Assert.True(_region.cells.Exists(x => x.index == 4 && x.value == 6));
            Assert.True(_region.cells.Exists(x => x.index == 5 && !x.value.HasValue));
            Assert.True(_region.cells.Exists(x => x.index == 6 && x.value == 4));
            Assert.True(_region.cells.Exists(x => x.index == 7 && !x.value.HasValue));
            Assert.True(_region.cells.Exists(x => x.index == 8 && x.value == 2));
            Assert.True(_region.cells.Exists(x => x.index == 9 && !x.value.HasValue));

        }
    }
}
