using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Picross
{
    public partial class Picross : Form
    {

        private static int CELL_SIZE = 30;
        private static Color O_COLOR = Color.Black;
        private static Color X_COLOR = Color.PaleVioletRed;
        private static Color __COLOR = Color.White;


        private PicrossGrid grid;
        public Picross()
        {
            InitializeComponent();
            grid = new PicrossGrid(10);
            SetUpGridView();
        }

        private void SetUpGridView()
        {
            picrossGridView.DataSource = grid;
            picrossGridView.RowTemplate.Height = CELL_SIZE;
            foreach (DataGridViewColumn d in picrossGridView.Columns)
                d.Width = CELL_SIZE;

            picrossGridView.ClientSize = new Size(grid.Columns.Count * CELL_SIZE, grid.Rows.Count * CELL_SIZE);
            this.ClientSize = picrossGridView.Size;
        }

        private void picrossGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.Value.Equals("O"))
                e.CellStyle.BackColor = O_COLOR;
            else if (e.Value.Equals("X"))
                e.CellStyle.BackColor = X_COLOR;
            else
                e.CellStyle.BackColor = __COLOR;
        }

        private void picrossGridView_SelectionChanged(object sender, EventArgs e)
        {
            picrossGridView.ClearSelection();
        }
    }

}
