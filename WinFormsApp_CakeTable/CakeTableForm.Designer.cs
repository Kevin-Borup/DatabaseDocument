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
            fillToolStripMenuItem = new ToolStripMenuItem();
            clearToolStripMenuItem = new ToolStripMenuItem();
            pnlCake = new Panel();
            panel3 = new Panel();
            btnRightCake = new Button();
            ilLeftArrows = new ImageList(components);
            ilRightArrows = new ImageList(components);
            panel1.SuspendLayout();
            mnuCakeTable.SuspendLayout();
            panel3.SuspendLayout();
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
            cakeDBTableToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { fillToolStripMenuItem, clearToolStripMenuItem });
            cakeDBTableToolStripMenuItem.Name = "cakeDBTableToolStripMenuItem";
            cakeDBTableToolStripMenuItem.Size = new Size(93, 20);
            cakeDBTableToolStripMenuItem.Text = "Cake DB Table";
            // 
            // fillToolStripMenuItem
            // 
            fillToolStripMenuItem.Name = "fillToolStripMenuItem";
            fillToolStripMenuItem.Size = new Size(101, 22);
            fillToolStripMenuItem.Text = "Fill";
            fillToolStripMenuItem.Click += fillToolStripMenuItem_Click;
            // 
            // clearToolStripMenuItem
            // 
            clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            clearToolStripMenuItem.Size = new Size(101, 22);
            clearToolStripMenuItem.Text = "Clear";
            clearToolStripMenuItem.Click += clearToolStripMenuItem_Click;
            // 
            // pnlCake
            // 
            pnlCake.Dock = DockStyle.Fill;
            pnlCake.Location = new Point(60, 24);
            pnlCake.Name = "pnlCake";
            pnlCake.Size = new Size(428, 426);
            pnlCake.TabIndex = 1;
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
            // CakeTableForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(548, 450);
            Controls.Add(pnlCake);
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
            panel3.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolTip toolTip1;
        private Panel panel1;
        private MenuStrip mnuCakeTable;
        private ToolStripMenuItem cakeDBTableToolStripMenuItem;
        private ToolStripMenuItem fillToolStripMenuItem;
        private ToolStripMenuItem clearToolStripMenuItem;
        private Panel pnlCake;
        private Panel panel3;
        private ImageList ilLeftArrows;
        private Button btnLeftCake;
        private Button btnRightCake;
        private ImageList ilRightArrows;
    }
}