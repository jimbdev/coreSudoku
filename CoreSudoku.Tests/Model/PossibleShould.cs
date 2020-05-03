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

        [Fact]
        public void RemovesItem()
        {
            HashSet<int> expected = new HashSet<int> { 1, 2, 3, 4, 6, 7, 8, 9 };
            Possible actual = new Possible();

            actual.Remove(5);

            Assert.Equal(expected, actual.poss);

        }

        [Fact]
        public void RemovesSubset()
        {
            HashSet<int> expected = new HashSet<int> { 2, 4, 6, 8};
            Possible actual = new Possible();

            HashSet<int> toRemove = new HashSet<int> { 1, 3, 5, 7, 9};

            actual.Remove(toRemove);

            Assert.Equal(expected, actual.poss);

        }
    }
}
