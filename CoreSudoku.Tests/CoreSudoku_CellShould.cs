using Xunit;
using CoreSudoku;
using System.Collections.Generic;

namespace CoreSudoku.tests
{
    public class CoreSudoku_CellShould
    {

        [Fact]
        public void ConstructorWorks()
        {
            Cell test = new Cell(1);

            Assert.Equal(1,test.index);
            Assert.Null(test.value);
            Assert.Empty(test.Notes);
        }

        [Fact]
        public void AddNoteSuccessfully()
        {
            Cell test = new Cell(1);

            test.AddNote(3);
            test.AddNote(7);
            var notes = test.Notes;

            Assert.Equal(2,notes.Count);
            Assert.Contains(3,notes);
            Assert.Contains(7,notes);
        }

        [Fact]
        public void RemovesNoteSuccessfully()
        {
            Cell test = new Cell(1);

            test.AddNote(3);
            test.AddNote(7);
            var notes = test.Notes;

            Assert.Equal(2,notes.Count);
            Assert.Contains(3,notes);
            Assert.Contains(7,notes);
            
            test.RemoveNote(3);
            notes = test.Notes;
            Assert.Equal(1,notes.Count);
            Assert.DoesNotContain(3,notes);
            Assert.Contains(7,notes);

        }

        [Fact]
        public void ClearsNotesSuccessfully()
        {
            Cell test = new Cell(1);

            test.AddNote(3);
            test.AddNote(7);
            var notes = test.Notes;

            Assert.Equal(2,notes.Count);
            Assert.Contains(3,notes);
            Assert.Contains(7,notes);
            
            test.ClearNotes();
            notes = test.Notes;
            Assert.Equal(0,notes.Count);
            
            
        }
    }
} 
