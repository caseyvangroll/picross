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
    public partial class MainForm : Form
    {
        private static int CELL_SIZE = 20;
        private static Color O_COLOR = Color.Black;
        private static Color X_COLOR = Color.PaleVioletRed;
        private static Color __COLOR = Color.White;

        private Puzzle puzzle;

        public MainForm() {
            InitializeComponent();
            picrossGridView.RowTemplate.Height = CELL_SIZE;
            rowCluesGridView.RowTemplate.Height = CELL_SIZE;
        }

        private void LoadPuzzle(String file) {
            puzzle = new Puzzle(file);
            string num = file.Substring(file.LastIndexOf("\\") + 1);
            num = num.Substring(0,num.Length - 4);
            this.Text = num + "\""+puzzle.Title +"\"";

            SetUpPicrossGridView();
            SetUpClues();
            SizeEverything();
        }

        private void SetUpPicrossGridView() {
            picrossGridView.DataSource = puzzle.Grid;
            foreach (DataGridViewColumn d in picrossGridView.Columns)
                d.Width = CELL_SIZE;
            picrossGridView.ClientSize = new Size(puzzle.Width * CELL_SIZE, puzzle.Height * CELL_SIZE);
        }

        private void SetUpClues() {
            DataTable rowsTable = new DataTable();
            rowCluesGridView.DataSource = rowsTable;
            rowsTable.Columns.Add();
            int i = 0;
            foreach(List<int> list in puzzle.RowClues) {
                rowsTable.Rows.Add();
                rowsTable.Rows[i++][0] = list.Aggregate("", (acc, ele) => acc + "  " + ele.ToString());
            }


            DataTable colsTable = new DataTable();
            colCluesGridView.DataSource = colsTable;
            colsTable.Rows.Add();

            i = 0;
            foreach (List<int> list in puzzle.ColClues) {
                colsTable.Columns.Add();
                colCluesGridView.Columns[i].Width = CELL_SIZE;
                colsTable.Rows[0][i++] = list.Aggregate("", (acc, ele) => acc + "\n" + ele.ToString());
            }
        }

        private void SizeEverything() {
            Size s = picrossGridView.ClientSize;
            s.Width += colCluesGridView.PreferredSize.Height+3;
            s.Height += rowCluesGridView.PreferredSize.Width-12;
            ClientSize = s;

            mainLayoutPanel.RowStyles[0].Height = colCluesGridView.PreferredSize.Height-15;
            mainLayoutPanel.ColumnStyles[0].Width = rowCluesGridView.PreferredSize.Width-15;

            mainLayoutPanel.RowStyles[1].Height = picrossGridView.ClientSize.Height;
            mainLayoutPanel.ColumnStyles[1].Width = picrossGridView.ClientSize.Width;

        }

        private void picrossGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e) {
            if (e.Value.Equals("O"))
                e.CellStyle.BackColor = O_COLOR;
            else if (e.Value.Equals("X"))
                e.CellStyle.BackColor = X_COLOR;
            else
                e.CellStyle.BackColor = __COLOR;
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e) {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                LoadPuzzle(openFileDialog1.FileName);
        }

        private void picrossGridView_SelectionChanged(object sender, EventArgs e) {
            picrossGridView.ClearSelection();
        }

        private void colCluesGridView_SelectionChanged(object sender, EventArgs e) {
            colCluesGridView.ClearSelection();
        }

        private void rowCluesGridView_SelectionChanged(object sender, EventArgs e) {
            rowCluesGridView.ClearSelection();
        }
    }
}
