namespace Picross
{
    partial class Picross
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.picrossGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.picrossGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // picrossGridView
            // 
            this.picrossGridView.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.picrossGridView.AllowUserToAddRows = false;
            this.picrossGridView.AllowUserToDeleteRows = false;
            this.picrossGridView.AllowUserToResizeColumns = false;
            this.picrossGridView.AllowUserToResizeRows = false;
            this.picrossGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.picrossGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.picrossGridView.ColumnHeadersVisible = false;
            this.picrossGridView.Cursor = System.Windows.Forms.Cursors.Cross;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.picrossGridView.DefaultCellStyle = dataGridViewCellStyle1;
            this.picrossGridView.Enabled = false;
            this.picrossGridView.EnableHeadersVisualStyles = false;
            this.picrossGridView.Location = new System.Drawing.Point(0, 0);
            this.picrossGridView.Margin = new System.Windows.Forms.Padding(0);
            this.picrossGridView.MultiSelect = false;
            this.picrossGridView.Name = "picrossGridView";
            this.picrossGridView.ReadOnly = true;
            this.picrossGridView.RowHeadersVisible = false;
            this.picrossGridView.RowHeadersWidth = 4;
            this.picrossGridView.RowTemplate.Height = 20;
            this.picrossGridView.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.picrossGridView.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.picrossGridView.Size = new System.Drawing.Size(200, 200);
            this.picrossGridView.TabIndex = 0;
            this.picrossGridView.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.picrossGridView_CellFormatting);
            this.picrossGridView.SelectionChanged += new System.EventHandler(this.picrossGridView_SelectionChanged);
            // 
            // Picross
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(184, 161);
            this.Controls.Add(this.picrossGridView);
            this.Name = "Picross";
            this.Text = "PicrossGrid";
            ((System.ComponentModel.ISupportInitialize)(this.picrossGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView picrossGridView;
    }
}

