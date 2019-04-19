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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        void TimeFilter()
        {
            var filter ="(Not Discontinued) ";

            DateTime Start=  dateTime_Start.Value;
            DateTime End = dateTime_End.Value;
            if ((Start!=null) && (End != null)) {
                filter += String.Format("AND OrderDate between {0} AND {1}",Start,End);
            }
          

            //dataGridView1

            bindingSource1.Filter = filter;
        }




        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void FiltreDate()
        {
            var filter = "(Not Discontinued)";
            
            var fin = dateTime_End.Value.ToShortDateString();
            var deb = dateTime_Start.Value.ToShortDateString();

            filter += String.Format(" AND (OrderDate BETWEEN  '{0}' And '{1}')", deb, fin);

            bindingSource1.Filter = filter;

        }


        private void button1_Click(object sender, EventArgs e)
        {
            FiltreDate();

            richTextBox1.Text = dateTime_End.Value.ToShortDateString();

       //     entityDataSource1.Refresh();
        //    dataGridView1.Refresh();
        }
    }
}
