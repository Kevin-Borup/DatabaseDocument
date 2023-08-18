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
    public partial class CakeUserControl : UserControl
    {
        public string CakeName { get; private set; }
        public TimeSpan Time { get; private set; }
        public string[] Ingredients { get; private set; }
        public string Description
        {
            get
            {
                return string.Empty;
            }
            private set
            {
                Description = value;
            }
        }

        private bool editing;
        private CakeManager ck = new CakeManager();
        private Cake cake;

        public delegate void CakeDeletedEventHandler(object sender, EventArgs e);

        public event CakeDeletedEventHandler CakeDeletedEvent;

        public CakeUserControl(Cake cake)
        {
            InitializeComponent();

            this.cake = cake;

            editing = false;

            this.btnEdit.Text = "Rediger";
            this.btnRemove.Text = "Fjern";

            FillData();
        }

        private void Editing()
        {
            editing = !editing;
        }

        private void FillData()
        {
            this.tbName.Text = cake.Name;
            this.tbTime.Text = cake.Time.ToString();
            this.tbIngredients.Text = string.Join("\r\n", cake.Ingredients);
            this.tbDescription.Text = cake.Description;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Editing();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            CakeDeletedEvent?.Invoke(sender, e);
        }
    }
}
