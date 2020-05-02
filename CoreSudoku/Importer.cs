using System.Collections.Generic;

namespace CoreSudoku
{
    public class Importer
    {
        public void Populate(Grid board, string values)
        {
            var charBoard = values.ToCharArray();
            //var regionVals = values.Split(',');
            for (int i = 0; i < 9; i++)
            {
                if (IsAValidNum(charBoard[i]))
                {
                    board.Cells[i].value = int.Parse(charBoard[i].ToString());
                }
            }
        }
        
        private bool IsAValidNum(char c)
        {
            int theNum;
            bool isAnInt = int.TryParse(c.ToString(), out theNum);

            return isAnInt && theNum != 0;
        }
    }
}