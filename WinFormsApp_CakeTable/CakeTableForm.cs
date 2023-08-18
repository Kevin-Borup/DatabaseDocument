using System.Collections.Generic;
using System.Windows.Forms;

namespace WinFormsApp_CakeTable
{
    public partial class CakeTableForm : Form
    {
        public delegate void CakeDeletedEventHandler(object sender, EventArgs e);

        public event CakeDeletedEventHandler CakeDeletedEvent;

        CakeManager ck = new CakeManager();

        int position = 0;

        Cake[] cakes;
        CakeUserControl currentCate;

        public CakeTableForm()
        {
            InitializeComponent();

            UpdateCakes();

            btnLeftCake.BackgroundImage = Properties.Resources.LeftArrow;
            btnRightCake.BackgroundImage = Properties.Resources.RightArrow;
            btnLeftCake.BackgroundImageLayout = ImageLayout.Stretch;
            btnRightCake.BackgroundImageLayout = ImageLayout.Stretch;

            btnLeftCake.MouseHover += button_MouseHover;
            btnRightCake.MouseHover += button_MouseHover;
            btnLeftCake.MouseLeave += button_MouseLeave;
            btnRightCake.MouseLeave += button_MouseLeave;

            LoadStartCakes();
        }

        private void LoadStartCakes()
        {
            position = 0;
            if (cakes.Length > 0)
            {
                DisplayCake(cakes[position]);
            }
        }

        private void UpdateCakes()
        {
            cakes = ck.GetAllCakes();
        }

        private void fillToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ck.CreateInsertCakes();
            UpdateCakes();

            LoadStartCakes();
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ck.ClearCakeTable();
            UpdateCakes();
            btnLeftCake.PerformClick();
        }

        private void CakeDisplay_CakeDeletedEvent(object sender, EventArgs e)
        {
            ck.RemoveCake(cakes[position]);
            UpdateCakes();
            btnLeftCake.PerformClick();
        }

        private void DisplayCake(Cake cake)
        {
            currentCate = new CakeUserControl(cakes[position]);
            currentCate.CakeDeletedEvent += CakeDisplay_CakeDeletedEvent;
            this.pnlCake.Controls.Add(new CakeUserControl(cakes[position]));
            this.pnlCake.Controls[0].Dock = DockStyle.Fill;
        }

        private void RemoveDisplay()
        {
            currentCate.CakeDeletedEvent -= CakeDisplay_CakeDeletedEvent;
            this.pnlCake.Controls.RemoveAt(0);
        }

        private void btnLeftCake_Click(object sender, EventArgs e)
        {
            position--;
            if (position < 0)
            {
                position = cakes.Length - 1;
            }

            RemoveDisplay();
            DisplayCake(cakes[position]);
        }

        private void btnRightCake_Click(object sender, EventArgs e)
        {
            position++;
            if (position >= cakes.Length)
            {
                position = 0;
            }

            RemoveDisplay();
            DisplayCake(cakes[position]);
        }

        private void button_MouseHover(object sender, EventArgs e)
        {
            var btn = sender as Button;

            if (btn.Name.Contains("Left"))
            {
                btn.BackgroundImage = Properties.Resources.LeftArrowHover;
            }
            else
            {
                btn.BackgroundImage = Properties.Resources.RightArrowHover;
            }
        }

        private void button_MouseLeave(object sender, EventArgs e)
        {
            var btn = sender as Button;

            if (btn.Name.Contains("Left"))
            {
                btn.BackgroundImage = Properties.Resources.LeftArrow;
            }
            else
            {
                btn.BackgroundImage = Properties.Resources.RightArrow;
            }
        }
    }
}