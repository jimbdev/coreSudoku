using System;
using System.Collections.Generic;
using System.Text;
using CoreSudoku.Data;
using Xunit;

namespace CoreSudoku.tests.Data
{
    public class PersistenceShould
    {
        string path = @"C:\Users\Jim\Desktop\coreSudoku\CoreSudoku.Data\Import\";
        string filename = "sudoku.json";
        string loadFilename = "sudoku_test_data.json";

        [Fact]
        public void SaveWorks()
        {
            string fullFilename = string.Concat(path, filename);

            GridData dataToSave = new GridData();
            dataToSave.cells = FillCells();

            Persistence exporter = new Persistence();
            exporter.Save(dataToSave, fullFilename);
        }

        [Fact]
        public void LoadWorks()
        {
            GridData data;

            string fullFilename = string.Concat(path, loadFilename);

            Persistence importer = new Persistence();
            data = importer.Load(fullFilename);

            for (int i = 0; i < 81; i++)
            {
                if (i % 5 == 0)
                {
                    Assert.Null( data.cells[i]);
                }
                else
                {
                    Assert.Equal( data.cells[i],  (i % 9) + 1);
                }
            }

        }

        private int?[] FillCells()
        {
            int?[] cells = new int?[81];
            for (int i = 0; i < 81; i++)
            {
                cells[i] = (i % 9) + 1;
                if (i%5 == 0)
                {
                    cells[i] = null;
                }
            }

            return cells;
        }
    }
}
