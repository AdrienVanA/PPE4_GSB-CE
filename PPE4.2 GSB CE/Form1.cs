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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BT_ProdductUnitPrice_Click(object sender, EventArgs e)
        {
            Form2 optionForm = new Form2();
            optionForm.Show();
            this.Hide();

            
        }

        private void BT_ClientCommande_Click(object sender, EventArgs e)
        {
            Form3 optionForm = new Form3();
            optionForm.Show();
            this.Hide();

           
        }

        private void BT_Orders_Click(object sender, EventArgs e)
        {
            Orders optionForm = new Orders();
            optionForm.Show();
            this.Hide();
        }

        private void BT_Customer_Click(object sender, EventArgs e)
        {
            Form5 optionForm = new Form5();
            optionForm.Show();
            this.Hide();
        }

        private void BT_Cat_Product_Click(object sender, EventArgs e)
        {
            Form4 optionForm = new Form4();
            optionForm.Show();
            this.Hide();
        }

        private void BT_Commands_Click(object sender, EventArgs e)
        {
            Form6 optionForm = new Form6();
            optionForm.Show();
            this.Hide();
        }

        private void BT_PieChart_Click(object sender, EventArgs e)
        {
            PieChart optionForm = new PieChart();
            optionForm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
