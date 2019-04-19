using System;
using System.Collections;
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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }




        private void Form5_Load(object sender, EventArgs e)
        {
            //  PPE4._2_GSB_CE.GSB_CEEntities c = new PPE4._2_GSB_CE.GSB_CEEntities();

            SetCountryBox();
            SetCityBox();

            //    comboBox1.colum
        }

        private void SetCountryBox()
        {
            try
            {
                using (GSB_CEEntities dtb = new GSB_CEEntities())
                {
                    List<string> ListCountry = new List<string>();

                    //dtb.Customers.ToList();
                    ListCountry = dtb.Customers.Select(xn => xn.Country).Distinct().ToList();
                    comboBox1.DataSource = ListCountry;

                
 
                }
   }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            
        }


private void SetCityBox()
        {


     using (GSB_CEEntities dtb = new GSB_CEEntities())
            {
                List<string> ListCity = new List<string>();
                string FP = comboBox1.SelectedValue.ToString();

                var helpme = dtb.Customers.Select(xn => new { xn.City, xn.Country }).Distinct();
 

                       foreach (var h in helpme) {  // textBox1.Text += " Vile=" + h.City.ToString();


                    if (h.Country == FP) { ListCity.Add(h.City); }

 

                }
   comboBox2.DataSource = ListCity;
            }


        }

        private void Form5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                MessageBox.Show(" Enter pressed, value is "+ comboBox1.SelectedValue.ToString());
                SetCityBox();
            }
        }


        private void pRefresh()
        {

            if (comboBox2.SelectedValue is null ) { } else
            {
                var filter = "";

                string zer = comboBox1.SelectedValue.ToString();
                string un = comboBox2.SelectedValue.ToString();
                filter += String.Format("(Country = '{0}') And (City = '{1}')", zer, un);

                bindingSource1.Filter = filter;
                SetCityBox();
                comboBox2.SelectedIndex = comboBox2.FindStringExact(un);
 
            }
           
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

           


        }

        private void Form5_MouseEnter(object sender, EventArgs e)
        {
          
        }

        private void dataGridView1_MouseEnter(object sender, EventArgs e)
        {
            pRefresh();
        }
    }
}
