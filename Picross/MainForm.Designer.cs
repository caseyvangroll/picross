namespace Picross
{
    partial class MainForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.picrossGridView = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.mainLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.colCluesGridView = new System.Windows.Forms.DataGridView();
            this.rowCluesGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.picrossGridView)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.mainLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.colCluesGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rowCluesGridView)).BeginInit();
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
            this.picrossGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.picrossGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.picrossGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.picrossGridView.ColumnHeadersVisible = false;
            this.picrossGridView.Cursor = System.Windows.Forms.Cursors.Cross;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.picrossGridView.DefaultCellStyle = dataGridViewCellStyle4;
            this.picrossGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picrossGridView.Enabled = false;
            this.picrossGridView.EnableHeadersVisualStyles = false;
            this.picrossGridView.Location = new System.Drawing.Point(20, 20);
            this.picrossGridView.Margin = new System.Windows.Forms.Padding(0);
            this.picrossGridView.MultiSelect = false;
            this.picrossGridView.Name = "picrossGridView";
            this.picrossGridView.ReadOnly = true;
            this.picrossGridView.RowHeadersVisible = false;
            this.picrossGridView.RowHeadersWidth = 4;
            this.picrossGridView.RowTemplate.Height = 20;
            this.picrossGridView.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.picrossGridView.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.picrossGridView.Size = new System.Drawing.Size(364, 317);
            this.picrossGridView.TabIndex = 0;
            this.picrossGridView.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.picrossGridView_CellFormatting);
            this.picrossGridView.SelectionChanged += new System.EventHandler(this.picrossGridView_SelectionChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(384, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.toolStripSeparator,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.toolStripSeparator2,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripMenuItem.Image")));
            this.newToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.newToolStripMenuItem.Text = "&New";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripMenuItem.Image")));
            this.openToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.openToolStripMenuItem.Text = "&Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(149, 6);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripMenuItem.Image")));
            this.saveToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveToolStripMenuItem.Text = "&Save";
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveAsToolStripMenuItem.Text = "Save &As";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(149, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.InitialDirectory = "C:\\Users\\Chipmunk\\source\\repos\\Picross\\Puzzles";
            // 
            // mainLayoutPanel
            // 
            this.mainLayoutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mainLayoutPanel.ColumnCount = 2;
            this.mainLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.mainLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.mainLayoutPanel.Controls.Add(this.picrossGridView, 1, 1);
            this.mainLayoutPanel.Controls.Add(this.colCluesGridView, 1, 0);
            this.mainLayoutPanel.Controls.Add(this.rowCluesGridView, 0, 1);
            this.mainLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainLayoutPanel.Location = new System.Drawing.Point(0, 24);
            this.mainLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
            this.mainLayoutPanel.Name = "mainLayoutPanel";
            this.mainLayoutPanel.RowCount = 2;
            this.mainLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.mainLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.mainLayoutPanel.Size = new System.Drawing.Size(384, 337);
            this.mainLayoutPanel.TabIndex = 2;
            // 
            // colCluesGridView
            // 
            this.colCluesGridView.AllowUserToAddRows = false;
            this.colCluesGridView.AllowUserToDeleteRows = false;
            this.colCluesGridView.AllowUserToResizeColumns = false;
            this.colCluesGridView.AllowUserToResizeRows = false;
            this.colCluesGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.colCluesGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.colCluesGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.colCluesGridView.ColumnHeadersVisible = false;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.colCluesGridView.DefaultCellStyle = dataGridViewCellStyle5;
            this.colCluesGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.colCluesGridView.Enabled = false;
            this.colCluesGridView.EnableHeadersVisualStyles = false;
            this.colCluesGridView.Location = new System.Drawing.Point(20, 0);
            this.colCluesGridView.Margin = new System.Windows.Forms.Padding(0);
            this.colCluesGridView.Name = "colCluesGridView";
            this.colCluesGridView.ReadOnly = true;
            this.colCluesGridView.RowHeadersVisible = false;
            this.colCluesGridView.RowTemplate.Height = 80;
            this.colCluesGridView.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.colCluesGridView.Size = new System.Drawing.Size(364, 20);
            this.colCluesGridView.TabIndex = 1;
            this.colCluesGridView.SelectionChanged += new System.EventHandler(this.colCluesGridView_SelectionChanged);
            // 
            // rowCluesGridView
            // 
            this.rowCluesGridView.AllowUserToAddRows = false;
            this.rowCluesGridView.AllowUserToDeleteRows = false;
            this.rowCluesGridView.AllowUserToResizeColumns = false;
            this.rowCluesGridView.AllowUserToResizeRows = false;
            this.rowCluesGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.rowCluesGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rowCluesGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rowCluesGridView.ColumnHeadersVisible = false;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.rowCluesGridView.DefaultCellStyle = dataGridViewCellStyle6;
            this.rowCluesGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rowCluesGridView.Enabled = false;
            this.rowCluesGridView.EnableHeadersVisualStyles = false;
            this.rowCluesGridView.Location = new System.Drawing.Point(0, 20);
            this.rowCluesGridView.Margin = new System.Windows.Forms.Padding(0);
            this.rowCluesGridView.Name = "rowCluesGridView";
            this.rowCluesGridView.ReadOnly = true;
            this.rowCluesGridView.RowHeadersVisible = false;
            this.rowCluesGridView.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.rowCluesGridView.Size = new System.Drawing.Size(20, 317);
            this.rowCluesGridView.TabIndex = 2;
            this.rowCluesGridView.SelectionChanged += new System.EventHandler(this.rowCluesGridView_SelectionChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.mainLayoutPanel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "PicrossGrid";
            ((System.ComponentModel.ISupportInitialize)(this.picrossGridView)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.mainLayoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.colCluesGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rowCluesGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView picrossGridView;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TableLayoutPanel mainLayoutPanel;
        private System.Windows.Forms.DataGridView colCluesGridView;
        private System.Windows.Forms.DataGridView rowCluesGridView;
    }
}

