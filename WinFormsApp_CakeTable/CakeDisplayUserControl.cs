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
    public partial class CakeDisplayUserControl : UserControl
    {
        public CakeDisplayUserControl(Cake cake)
        {
            InitializeComponent();
            this.tbName.Text = cake.Name;
            this.tbTime.Text = cake.Time.ToString();
            this.tbIngredients.Text = string.Join("\r\n", cake.Ingredients);
            this.tbDescription.Text = cake.Description;
        }
    }
}
