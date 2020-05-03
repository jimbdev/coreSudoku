using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace CoreSudoku.Model
{
    public class Cell
    {
        readonly int _index;
        public int? value;
        public Possible possible;
        //readonly ArrayList _notes;

        public int index { get => _index;}

        public Cell(int index)
        {
            _index = index;
            possible = new Possible();
        }

        public void RemovePoss(int i)
        {
            possible.Remove(i);
        }

        public void RemovePoss(HashSet<int> s)
        {
            possible.Remove(s);
        }

        //public void AddNote(int note)
        //{
        //    _notes.Add(note);
        //}

        //public void RemoveNote(int note)
        //{
        //    _notes.Remove(note);
        //}

        //public void ClearNotes()
        //{
        //    _notes.Clear();
        //}

        //public List<int> Notes
        //{
        //    get
        //    {
        //        List<int> outNotes = new List<int>(_notes.ToArray(typeof(int)) as int[]);
        //        return outNotes;
        //    }
        //}

    }
}
