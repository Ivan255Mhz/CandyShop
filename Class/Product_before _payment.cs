using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandyShop.Class
{
    public class Product_before__payment
    {
       

        public decimal cout { get; set; }

        public Tovar tovar { get; set; }


        public Product_before__payment(decimal cout, Tovar tovar)
        {
            this.cout = cout;
            this.tovar = tovar;
        }

        public override string ToString()
        {
            return tovar.Name + " * " + cout.ToString() + " - " + (tovar.Prise * cout).ToString() + "руб."; 
        }

    }
}
