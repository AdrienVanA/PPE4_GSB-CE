using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPE4._2_GSB_CE
{


    public partial class Employee
    {
        public string FullName
        {
            
            get
            {
                return string.Format("{0}{1}", FirstName, LastName);
            }
        }

        public override string ToString()
        {
            return FullName;
        }
    }

    public partial class Order_Detail
    {

        public decimal CA()
        { 
                return Quantity * UnitPrice * (1 - (decimal)Discount);
            

        }


        //calculate amount for this order detail
        public decimal Amount
        {
            get
            {
                return Quantity * UnitPrice * (1 - (decimal)Discount);
            }
        }

    }


    public partial class Order
    {

        public decimal Amount
        {
            get
            {
                 
               return Order_Details.Sum(n => n.Amount);
                
            }
        }
    }

    public partial class Customer
    {
        public decimal Sale
        {

            get
            {
                return Orders.Sum(n => n.Amount);
            }
        }

  
    }



    public partial class Shipper
    {
        public decimal CA
        {

            get
            {
                return Orders.Sum(n => n.Amount);
            }
        }


    }


}
