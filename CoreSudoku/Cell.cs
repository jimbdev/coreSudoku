using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace CoreSudoku
{
    public class Cell
    {
        public Cell(int index)
        {
            _index = index;
            _notes = new ArrayList();
        }
        readonly int _index;
        public int? value;
        readonly ArrayList _notes;

        public int index { get => _index;}

        public void AddNote(int note)
        {
            _notes.Add(note);
        }

        public void RemoveNote(int note)
        {
            _notes.Remove(note);
            
        }

        public void ClearNotes()
        {
            _notes.Clear();
        }

        public List<int> Notes
        {
            get
            {
                List<int> outNotes = new List<int>(_notes.ToArray(typeof(int)) as int[]);
                return outNotes;
            }
        }
    }
}
