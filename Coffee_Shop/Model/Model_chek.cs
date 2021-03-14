using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coffee_Shop.Model
{
    public static class Chek_list
    {
        public static List<Model_chek> list_chel = new List<Model_chek>();
        public static string Get_Full_Price()
        {
            double full_price = 0;
            list_chel.ForEach(i => full_price += (i.coffee.price*i.count));
            return full_price.ToString();
        }
    }
    public class Model_chek
    {
        public static DateTime time { get; private set; }
        public Model_chek(Model_Coffe coffee, int count)
        {
            time = DateTime.Now;
            this.coffee = coffee;
            this.count = count;
        }
        public Model_Coffe coffee { get; set; }
        public int count { get; set; }
       
       

    }
}
