using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Picross
{
    class PicrossGrid : DataTable
    {
        public PicrossGrid(int size)
        {
            for (int i = 0; i < size; i++)
            {
                Rows.Add();
                Columns.Add();
            }
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Rows[i][j] = "O";
                }
            }

            Rows[0][5] = "_";
            Rows[5][1] = "X";
            Rows[7][5] = "X";
            Rows[2][3] = "X";
            Rows[2][6] = "_";
        }
    }
}
