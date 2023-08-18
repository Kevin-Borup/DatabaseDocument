using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;

namespace WinFormsApp_CakeTable
{
    public partial class CakeTableForm : Form
    {
        CakeManager ck = new CakeManager();

        int position = 0;

        List<Cake> cakes;
        CakeDisplayUserControl currentCake;
        private bool editing;
        private bool newCakeEdit;
        private string[] sortSearch = new string[] { "All", "" };

        public CakeTableForm()
        {
            InitializeComponent();
            editing = false;

            UpdateCakes();
            LoadStartCakes();

            btnLeftCake.BackgroundImage = Properties.Resources.LeftArrow;
            btnRightCake.BackgroundImage = Properties.Resources.RightArrow;
            btnLeftCake.BackgroundImageLayout = ImageLayout.Stretch;
            btnRightCake.BackgroundImageLayout = ImageLayout.Stretch;

            btnLeftCake.MouseHover += button_MouseHover;
            btnRightCake.MouseHover += button_MouseHover;
            btnLeftCake.MouseLeave += button_MouseLeave;
            btnRightCake.MouseLeave += button_MouseLeave;
        }

        private void LoadStartCakes()
        {
            position = 0;
            if (cakes.Count > 0)
            {
                DisplayCake();
            }
        }

        private void UpdateCakes()
        {
            cakes = ck.GetAllCakes(sortSearch);
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

        private void DisplayCake()
        {
            if (cakes.Count > 0)
            {
                currentCake = new CakeDisplayUserControl(cakes[position]);
                this.pnlCake.Controls.Add(new CakeDisplayUserControl(cakes[position]));
                this.pnlCake.Controls[0].Dock = DockStyle.Fill;
            }
        }

        private void RemoveDisplay()
        {
            if (this.pnlCake.Controls.Count > 0)
            {
                this.pnlCake.Controls.RemoveAt(0);
            }
        }

        private void btnLeftCake_Click(object sender, EventArgs e)
        {
            position--;
            if (cakes.Count == 0)
            {
                position = 0;
            } 
            else if (position < 0)
            {
                position = cakes.Count - 1;
            }

            RemoveDisplay();
            DisplayCake();
        }

        private void btnRightCake_Click(object sender, EventArgs e)
        {
            position++;
            if (position >= cakes.Count)
            {
                position = 0;
            }

            RemoveDisplay();
            DisplayCake();
        }

        private void button_MouseHover(object? sender, EventArgs e)
        {
            if (sender is Button)
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
        }

        private void button_MouseLeave(object? sender, EventArgs e)
        {
            if (sender is Button)
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

        private void btnEdit_Click(object sender, EventArgs e)
        {
            editing = !editing;

            if (editing) // Initiate editing
            {
                RemoveDisplay();
                this.pnlCake.Controls.Add(new CakeEditUserControl(cakes[position]));
                this.pnlCake.Controls[0].Dock = DockStyle.Fill;
                UpdateEditingUI();
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (editing) // Cancellation action
            {
                editing = false;
                RemoveDisplay();
                this.pnlCake.Controls.Add(new CakeDisplayUserControl(cakes[position]));
                this.pnlCake.Controls[0].Dock = DockStyle.Fill;
                UpdateEditingUI();
            }
            else
            { //Normal removal action
                var cake = cakes[position];
                ck.RemoveCake(cake);
                UpdateCakes();
                btnLeftCake.PerformClick();

                TestAttemptToGetDeletedCake(cake);
            }
        }

        private void TestAttemptToGetDeletedCake(Cake cake)
        {
            try
            {
                ck.GetSingleCake(cake);
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            if (editing) // Confirm Edit
            {
                editing = false;

                var editor = this.pnlCake.Controls[0] as CakeEditUserControl;
                if (editor != null)
                {
                    Cake newCake = editor.GetEditedCake();

                    ck.InsertCake(newCake);
                }

                UpdateCakes();

                if (newCakeEdit)
                {
                    position = cakes.Count - 1;
                }

                this.pnlCake.Controls.Add(new CakeDisplayUserControl(cakes[position]));
                this.pnlCake.Controls[0].Dock = DockStyle.Fill;
                UpdateEditingUI();
            }
            else
            { // Normal new action
                editing = true;
                newCakeEdit = true;
                RemoveDisplay();
                this.pnlCake.Controls.Add(new CakeEditUserControl());
                this.pnlCake.Controls[0].Dock = DockStyle.Fill;
                UpdateEditingUI();
            }
        }

        private void UpdateEditingUI()
        {
            if (editing)
            {
                this.btnNew.Text = "Bekræft";
                this.btnRemove.Text = "Anullér";
                this.btnEdit.Visible = false;
            }
            else
            {
                this.btnNew.Text = "Ny";
                this.btnRemove.Text = "Fjern";
                this.btnEdit.Visible = true;
                newCakeEdit = false;
            }
        }

        private void rbSub30_CheckedChanged(object sender, EventArgs e)
        {
            ReSortCakes();
        }

        private void rbAll_CheckedChanged(object sender, EventArgs e)
        {
            ReSortCakes();
        }

        private void ReSortCakes()
        {
            if (this.rbSub30.Checked)
                sortSearch[0] = "Sub30";
            else
                sortSearch[0] = "All";

            UpdateCakes();
            position = 0;
            RemoveDisplay();
            DisplayCake();
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            base.OnTextChanged(e);
            sortSearch[1] = this.tbSearch.Text;
            UpdateCakes();
            RemoveDisplay();
            DisplayCake();
        }
    }
}