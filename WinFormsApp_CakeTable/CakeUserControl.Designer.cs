namespace WinFormsApp_CakeTable
{
    partial class CakeUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            btnRemove = new Button();
            btnEdit = new Button();
            panel2 = new Panel();
            tbName = new TextBox();
            panel3 = new Panel();
            panel7 = new Panel();
            panel8 = new Panel();
            tbDescription = new TextBox();
            label3 = new Label();
            panel5 = new Panel();
            panel6 = new Panel();
            tbIngredients = new TextBox();
            label2 = new Label();
            panel4 = new Panel();
            tbTime = new TextBox();
            label1 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel7.SuspendLayout();
            panel8.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnRemove);
            panel1.Controls.Add(btnEdit);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(318, 29);
            panel1.TabIndex = 0;
            // 
            // btnRemove
            // 
            btnRemove.Dock = DockStyle.Right;
            btnRemove.Location = new Point(243, 0);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(75, 29);
            btnRemove.TabIndex = 1;
            btnRemove.Text = "Fjern";
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += btnRemove_Click;
            // 
            // btnEdit
            // 
            btnEdit.Dock = DockStyle.Left;
            btnEdit.Location = new Point(0, 0);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(75, 29);
            btnEdit.TabIndex = 0;
            btnEdit.Text = "Rediger";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // panel2
            // 
            panel2.AutoSize = true;
            panel2.Controls.Add(tbName);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 29);
            panel2.Name = "panel2";
            panel2.Size = new Size(318, 36);
            panel2.TabIndex = 1;
            // 
            // tbName
            // 
            tbName.BackColor = SystemColors.Control;
            tbName.BorderStyle = BorderStyle.None;
            tbName.Dock = DockStyle.Top;
            tbName.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            tbName.Location = new Point(0, 0);
            tbName.Name = "tbName";
            tbName.ReadOnly = true;
            tbName.Size = new Size(318, 36);
            tbName.TabIndex = 0;
            tbName.Text = "Name";
            // 
            // panel3
            // 
            panel3.Controls.Add(panel7);
            panel3.Controls.Add(panel5);
            panel3.Controls.Add(panel4);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 65);
            panel3.Name = "panel3";
            panel3.Padding = new Padding(5);
            panel3.Size = new Size(318, 183);
            panel3.TabIndex = 2;
            // 
            // panel7
            // 
            panel7.AutoSize = true;
            panel7.Controls.Add(panel8);
            panel7.Controls.Add(label3);
            panel7.Dock = DockStyle.Top;
            panel7.Location = new Point(5, 100);
            panel7.Name = "panel7";
            panel7.Size = new Size(308, 65);
            panel7.TabIndex = 2;
            // 
            // panel8
            // 
            panel8.AutoSize = true;
            panel8.Controls.Add(tbDescription);
            panel8.Dock = DockStyle.Fill;
            panel8.Location = new Point(0, 25);
            panel8.MinimumSize = new Size(0, 40);
            panel8.Name = "panel8";
            panel8.Padding = new Padding(20, 0, 0, 0);
            panel8.Size = new Size(308, 40);
            panel8.TabIndex = 5;
            // 
            // tbDescription
            // 
            tbDescription.BackColor = SystemColors.Control;
            tbDescription.BorderStyle = BorderStyle.None;
            tbDescription.Dock = DockStyle.Fill;
            tbDescription.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tbDescription.Location = new Point(20, 0);
            tbDescription.Multiline = true;
            tbDescription.Name = "tbDescription";
            tbDescription.ReadOnly = true;
            tbDescription.Size = new Size(288, 40);
            tbDescription.TabIndex = 3;
            tbDescription.Text = "Danmark\r\n1930\r\n\r\n";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Top;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(0, 0);
            label3.Name = "label3";
            label3.Size = new Size(77, 25);
            label3.TabIndex = 0;
            label3.Text = "Historie";
            // 
            // panel5
            // 
            panel5.AutoSize = true;
            panel5.Controls.Add(panel6);
            panel5.Controls.Add(label2);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(5, 35);
            panel5.Name = "panel5";
            panel5.Size = new Size(308, 65);
            panel5.TabIndex = 1;
            // 
            // panel6
            // 
            panel6.AutoSize = true;
            panel6.Controls.Add(tbIngredients);
            panel6.Dock = DockStyle.Fill;
            panel6.Location = new Point(0, 25);
            panel6.MinimumSize = new Size(0, 40);
            panel6.Name = "panel6";
            panel6.Padding = new Padding(20, 0, 0, 0);
            panel6.Size = new Size(308, 40);
            panel6.TabIndex = 4;
            // 
            // tbIngredients
            // 
            tbIngredients.BackColor = SystemColors.Control;
            tbIngredients.BorderStyle = BorderStyle.None;
            tbIngredients.Dock = DockStyle.Fill;
            tbIngredients.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tbIngredients.Location = new Point(20, 0);
            tbIngredients.Multiline = true;
            tbIngredients.Name = "tbIngredients";
            tbIngredients.ReadOnly = true;
            tbIngredients.Size = new Size(288, 40);
            tbIngredients.TabIndex = 3;
            tbIngredients.Text = "Mel\r\nMælk\r\n";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Top;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(118, 25);
            label2.TabIndex = 2;
            label2.Text = "Ingredienser";
            // 
            // panel4
            // 
            panel4.Controls.Add(tbTime);
            panel4.Controls.Add(label1);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(5, 5);
            panel4.Name = "panel4";
            panel4.Size = new Size(308, 30);
            panel4.TabIndex = 0;
            // 
            // tbTime
            // 
            tbTime.BackColor = SystemColors.Control;
            tbTime.BorderStyle = BorderStyle.None;
            tbTime.Dock = DockStyle.Fill;
            tbTime.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            tbTime.Location = new Point(42, 0);
            tbTime.Name = "tbTime";
            tbTime.ReadOnly = true;
            tbTime.Size = new Size(266, 25);
            tbTime.TabIndex = 1;
            tbTime.Text = "30";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Left;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(42, 25);
            label1.TabIndex = 0;
            label1.Text = "Tid:";
            // 
            // CakeUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "CakeUserControl";
            Size = new Size(318, 248);
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button btnRemove;
        private Button btnEdit;
        private Panel panel2;
        private TextBox tbName;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private Panel panel6;
        private TextBox tbIngredients;
        private Label label2;
        private TextBox tbTime;
        private Label label1;
        private Panel panel7;
        private Panel panel8;
        private TextBox tbDescription;
        private Label label3;
    }
}
