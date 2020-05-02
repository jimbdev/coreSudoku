using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace CoreSudoku
{
    public class Cell
    {
        readonly int _index;
        public int? value;
        readonly ArrayList _notes;
        public ArrayList _candidates;

        public int index { get => _index;}

        public Cell(int index)
        {
            _index = index;
            _notes = new ArrayList();
            _candidates = new ArrayList();
            InitCandidates();
        }

        public void AddNote(int note)
        {
            _notes.Add(note);
        }

        public void RemoveNote(int note)
        {
            _notes.Remove(note);
            
        }

        public void AddCandidate(int candidate)
        {
            _candidates.Add(candidate);
        }

        public void ClearNotes()
        {
            _notes.Clear();
        }

        public void InitCandidates()
        {
            _candidates.Clear();
            for (int i = 1; i < 4; i++)
            {
                _candidates.Add(i);
            }
        }

        public List<int> Notes
        {
            get
            {
                List<int> outNotes = new List<int>(_notes.ToArray(typeof(int)) as int[]);
                return outNotes;
            }
        }
        public List<int> Candidates
        {
            get
            {
                List<int> outCandidates = new List<int>(_candidates.ToArray(typeof(int)) as int[]);
                return outCandidates;
            }
        }

    }
}
