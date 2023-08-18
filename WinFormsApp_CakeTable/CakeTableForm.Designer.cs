namespace WinFormsApp_CakeTable
{
    partial class CakeTableForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CakeTableForm));
            toolTip1 = new ToolTip(components);
            panel1 = new Panel();
            btnLeftCake = new Button();
            mnuCakeTable = new MenuStrip();
            cakeDBTableToolStripMenuItem = new ToolStripMenuItem();
            mnuItemDBFill = new ToolStripMenuItem();
            mnuItemDBClear = new ToolStripMenuItem();
            pnlCake = new Panel();
            panel4 = new Panel();
            rbSub30 = new RadioButton();
            rbAll = new RadioButton();
            label2 = new Label();
            tbSearch = new TextBox();
            label1 = new Label();
            panel3 = new Panel();
            btnRightCake = new Button();
            ilLeftArrows = new ImageList(components);
            ilRightArrows = new ImageList(components);
            panel2 = new Panel();
            btnEdit = new Button();
            btnNew = new Button();
            btnRemove = new Button();
            panel1.SuspendLayout();
            mnuCakeTable.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnLeftCake);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 24);
            panel1.Name = "panel1";
            panel1.Size = new Size(60, 426);
            panel1.TabIndex = 0;
            // 
            // btnLeftCake
            // 
            btnLeftCake.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnLeftCake.FlatAppearance.BorderSize = 0;
            btnLeftCake.FlatStyle = FlatStyle.Flat;
            btnLeftCake.Location = new Point(3, 184);
            btnLeftCake.Name = "btnLeftCake";
            btnLeftCake.Size = new Size(57, 57);
            btnLeftCake.TabIndex = 0;
            btnLeftCake.UseVisualStyleBackColor = true;
            btnLeftCake.Click += btnLeftCake_Click;
            // 
            // mnuCakeTable
            // 
            mnuCakeTable.Items.AddRange(new ToolStripItem[] { cakeDBTableToolStripMenuItem });
            mnuCakeTable.Location = new Point(0, 0);
            mnuCakeTable.Name = "mnuCakeTable";
            mnuCakeTable.Size = new Size(548, 24);
            mnuCakeTable.TabIndex = 1;
            mnuCakeTable.Text = "menuStrip1";
            // 
            // cakeDBTableToolStripMenuItem
            // 
            cakeDBTableToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { mnuItemDBFill, mnuItemDBClear });
            cakeDBTableToolStripMenuItem.Name = "cakeDBTableToolStripMenuItem";
            cakeDBTableToolStripMenuItem.Size = new Size(93, 20);
            cakeDBTableToolStripMenuItem.Text = "Cake DB Table";
            // 
            // mnuItemDBFill
            // 
            mnuItemDBFill.Name = "mnuItemDBFill";
            mnuItemDBFill.Size = new Size(101, 22);
            mnuItemDBFill.Text = "Fill";
            mnuItemDBFill.Click += fillToolStripMenuItem_Click;
            // 
            // mnuItemDBClear
            // 
            mnuItemDBClear.Name = "mnuItemDBClear";
            mnuItemDBClear.Size = new Size(101, 22);
            mnuItemDBClear.Text = "Clear";
            mnuItemDBClear.Click += clearToolStripMenuItem_Click;
            // 
            // pnlCake
            // 
            pnlCake.Dock = DockStyle.Fill;
            pnlCake.Location = new Point(60, 51);
            pnlCake.Name = "pnlCake";
            pnlCake.Size = new Size(428, 364);
            pnlCake.TabIndex = 1;
            // 
            // panel4
            // 
            panel4.Controls.Add(rbSub30);
            panel4.Controls.Add(rbAll);
            panel4.Controls.Add(label2);
            panel4.Controls.Add(tbSearch);
            panel4.Controls.Add(label1);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(60, 24);
            panel4.Name = "panel4";
            panel4.Size = new Size(428, 27);
            panel4.TabIndex = 0;
            // 
            // rbSub30
            // 
            rbSub30.AutoSize = true;
            rbSub30.Location = new Point(97, 3);
            rbSub30.Name = "rbSub30";
            rbSub30.Size = new Size(96, 19);
            rbSub30.TabIndex = 6;
            rbSub30.Text = "Under 30 min";
            rbSub30.UseVisualStyleBackColor = true;
            rbSub30.CheckedChanged += rbSub30_CheckedChanged;
            // 
            // rbAll
            // 
            rbAll.AutoSize = true;
            rbAll.Checked = true;
            rbAll.Location = new Point(46, 4);
            rbAll.Name = "rbAll";
            rbAll.Size = new Size(45, 19);
            rbAll.TabIndex = 5;
            rbAll.TabStop = true;
            rbAll.Text = "Alle";
            rbAll.UseVisualStyleBackColor = true;
            rbAll.CheckedChanged += rbAll_CheckedChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(254, 6);
            label2.Name = "label2";
            label2.Size = new Size(27, 15);
            label2.TabIndex = 4;
            label2.Text = "Søg";
            // 
            // tbSearch
            // 
            tbSearch.Location = new Point(287, 3);
            tbSearch.Name = "tbSearch";
            tbSearch.Size = new Size(138, 23);
            tbSearch.TabIndex = 3;
            tbSearch.TextChanged += tbSearch_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(7, 6);
            label1.Name = "label1";
            label1.Size = new Size(33, 15);
            label1.TabIndex = 1;
            label1.Text = "Filter";
            // 
            // panel3
            // 
            panel3.Controls.Add(btnRightCake);
            panel3.Dock = DockStyle.Right;
            panel3.Location = new Point(488, 24);
            panel3.Name = "panel3";
            panel3.Size = new Size(60, 426);
            panel3.TabIndex = 2;
            // 
            // btnRightCake
            // 
            btnRightCake.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnRightCake.FlatAppearance.BorderSize = 0;
            btnRightCake.FlatStyle = FlatStyle.Flat;
            btnRightCake.Location = new Point(0, 184);
            btnRightCake.Name = "btnRightCake";
            btnRightCake.Size = new Size(57, 57);
            btnRightCake.TabIndex = 1;
            btnRightCake.UseVisualStyleBackColor = true;
            btnRightCake.Click += btnRightCake_Click;
            // 
            // ilLeftArrows
            // 
            ilLeftArrows.ColorDepth = ColorDepth.Depth8Bit;
            ilLeftArrows.ImageStream = (ImageListStreamer)resources.GetObject("ilLeftArrows.ImageStream");
            ilLeftArrows.TransparentColor = Color.Transparent;
            ilLeftArrows.Images.SetKeyName(0, "LeftArrow.jpg");
            ilLeftArrows.Images.SetKeyName(1, "LeftArrowHover.jpg");
            // 
            // ilRightArrows
            // 
            ilRightArrows.ColorDepth = ColorDepth.Depth8Bit;
            ilRightArrows.ImageStream = (ImageListStreamer)resources.GetObject("ilRightArrows.ImageStream");
            ilRightArrows.TransparentColor = Color.Transparent;
            ilRightArrows.Images.SetKeyName(0, "RightArrow.jpg");
            ilRightArrows.Images.SetKeyName(1, "RightArrowHover.jpg");
            // 
            // panel2
            // 
            panel2.Controls.Add(btnEdit);
            panel2.Controls.Add(btnNew);
            panel2.Controls.Add(btnRemove);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(60, 415);
            panel2.Name = "panel2";
            panel2.Size = new Size(428, 35);
            panel2.TabIndex = 0;
            // 
            // btnEdit
            // 
            btnEdit.Dock = DockStyle.Fill;
            btnEdit.Location = new Point(75, 0);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(278, 35);
            btnEdit.TabIndex = 2;
            btnEdit.Text = "Rediger";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnNew
            // 
            btnNew.Dock = DockStyle.Left;
            btnNew.Location = new Point(0, 0);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(75, 35);
            btnNew.TabIndex = 4;
            btnNew.Text = "Ny";
            btnNew.UseVisualStyleBackColor = true;
            btnNew.Click += btnNew_Click;
            // 
            // btnRemove
            // 
            btnRemove.Dock = DockStyle.Right;
            btnRemove.Location = new Point(353, 0);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(75, 35);
            btnRemove.TabIndex = 3;
            btnRemove.Text = "Fjern";
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += btnRemove_Click;
            // 
            // CakeTableForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(548, 450);
            Controls.Add(pnlCake);
            Controls.Add(panel4);
            Controls.Add(panel2);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(mnuCakeTable);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MainMenuStrip = mnuCakeTable;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "CakeTableForm";
            ShowIcon = false;
            Text = "Kage Bord";
            panel1.ResumeLayout(false);
            mnuCakeTable.ResumeLayout(false);
            mnuCakeTable.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolTip toolTip1;
        private Panel panel1;
        private MenuStrip mnuCakeTable;
        private ToolStripMenuItem cakeDBTableToolStripMenuItem;
        private ToolStripMenuItem mnuItemDBFill;
        private ToolStripMenuItem mnuItemDBClear;
        private Panel pnlCake;
        private Panel panel3;
        private ImageList ilLeftArrows;
        private Button btnLeftCake;
        private Button btnRightCake;
        private ImageList ilRightArrows;
        private Panel panel2;
        private Button btnRemove;
        private Button btnEdit;
        private Button btnNew;
        private Panel panel4;
        private Label label1;
        private Label label2;
        private TextBox tbSearch;
        private RadioButton rbSub30;
        private RadioButton rbAll;
    }
}