using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PPE4._2_GSB_CE
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }



        void ApplyFilter()
        {
            var filter = "(Not Discontinued) ";
            //never show discontinued product
            double d;
            var MinPrice = TXT_MiniUnitPrice.Text.Trim();
            if (!(double.TryParse(MinPrice, out d)))
            {

                MessageBox.Show("Invalid Minimum");
            }
            else { filter += String.Format(" And (UnitPrice >= {0})", d); }

            //Set filter
            bindingSource1.Filter = filter;

        }




        private void Form2_Deactivate(object sender, EventArgs e)
        {
            Menu c = new Menu();
            c.Show();  // re-show original form
            this.Close();   // and CLOSE this second form...
        }

        private void TXT_MiniUnitPrice_Validated(object sender, EventArgs e)
        {
         //   if (e.KeyChar == 13) { ApplyFilter(); e.Handled = true; }
        }

        private void TXT_MiniUnitPrice_KeyUp(object sender, KeyEventArgs e)
        {
            
                if (e.KeyValue == 13) { ApplyFilter(); }
        }

        private void BT_Save_Click(object sender, EventArgs e)
        {
            entityDataSource1.SaveChanges();
        }

        private void BT_Cancel_Click(object sender, EventArgs e)
        {
            entityDataSource1.CancelChanges();
        }

        private void BT_Refresh_Click(object sender, EventArgs e)
        {
            entityDataSource1.Refresh();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*
            Menu optionForm = new Menu();
            optionForm.Hide();
            optionForm.Show();
            this.Close();
            */
        }
    }
}
