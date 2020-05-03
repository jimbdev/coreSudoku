using Xunit;
using CoreSudoku.Model;
using System.Collections.Generic;

namespace CoreSudoku.tests.Model
{
    public class PossibleShould
    {
        [Fact]
        public void ConstructorWorks()
        {
            Possible actual = new Possible();
            HashSet<int> expected = new HashSet<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            Assert.Equal(expected, actual.poss);

        }
    }
}
