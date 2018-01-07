using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Picross
{
    class PicrossGrid : DataTable
    {
        private int _width, _height;

        public PicrossGrid(int width, int height)
        {
            _width = width;
            _height = height;
            for (int i = 0; i < _height; i++)
                Rows.Add();
            for (int i = 0; i < _width; i++)
                Columns.Add();

            for (int i = 0; i < _height; i++)
                for (int j = 0; j < _width; j++)
                    Rows[i][j] = "_";
        }

    }
}
