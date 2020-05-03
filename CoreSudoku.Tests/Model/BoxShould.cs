using CoreSudoku.Model;
using Xunit;

namespace CoreSudoku.tests
{
    public class BoxShould
    {
        private readonly Box _region;

        public BoxShould()
        {
            _region = new Box();
        }

        [Fact]
        public void AssignsCell()
        {
            Cell testCell = new Cell(3);
            _region.AssignCell(testCell,0);

            Assert.Equal(3,_region.cells[0].index);
        }
    }
}
