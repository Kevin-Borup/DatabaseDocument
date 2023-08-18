using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp_CakeTable
{
    public partial class CakeEditUserControl : UserControl
    {
        private Cake cake;

        public CakeEditUserControl(Cake cake = null)
        {
            InitializeComponent();
            if (cake is not null)
            {
                this.cake = cake;

                this.tbName.Text = cake.Name;
                this.tbTime.Text = cake.Time.ToString();
                this.tbDescription.Text = cake.Description;
                this.tbIngredients.Text = string.Join(Environment.NewLine, cake.Ingredients);
            }
            else
            {
                this.tbName.Text = "Navn";
                this.tbTime.Text = "00";
                this.tbDescription.Text = "Beskrivelse";
                this.tbIngredients.Text = "";
            }
        }

        public Cake GetEditedCake()
        {
            string name = this.tbName.Text;
            int.TryParse(this.tbTime.Text, out int min);
            string description = this.tbDescription.Text;
            string[] ingredients = this.tbIngredients.Text.Split(Environment.NewLine);

            if (cake is null)
            {
                cake = new Cake(name, min, description, ingredients);
            }
            else
            {
                cake.UpdateCake(this.tbName.Text, min, description, ingredients);
            }


            return cake;
        }

        private void tbIngredients_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.tbIngredients.Text = this.tbIngredients.Text + Environment.NewLine;
            }
        }

        private void tbDescription_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.tbDescription.Text = this.tbDescription.Text + Environment.NewLine;
            }
        }
    }
}
