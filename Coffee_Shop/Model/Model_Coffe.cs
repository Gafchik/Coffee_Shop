using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coffee_Shop.Model
{
    public static class Coffee_list
    {
        public static List<Model_Coffe> coffee_list = new List<Model_Coffe>(); // коллекция для видов кофе
         static Coffee_list()
        {

           /* coffee_list.Add(new Model_Coffe("Американо", 4.5, 15.6, "арабика", "США", 30, "Америкашка"));
            coffee_list.Add(new Model_Coffe("Еспрессо", 2.3, 10.6, "арабика", "США", 10, "еспрессо"));
            coffee_list.Add(new Model_Coffe("Горячий шоколад", 4.5, 15.6, "арабика", "США", 50, "Горячий шоколад"));
            coffee_list.Add(new Model_Coffe("Латк", 4.5, 15.6, "арабика", "США", 70, "Латк"));*/
        }
    }
    public class Model_Coffe
    {
        public Model_Coffe() { }
       
        public Model_Coffe(string name, double cost_price, double price, string grain_type, string country_of_origin, int gram_per_serving, string info)
        {
            this.name = name;
            this.cost_price = cost_price;
            this.price = price;
            this.gram_per_serving = gram_per_serving;
            this.grain_type = grain_type;
            this.country_of_origin = country_of_origin;
            this.info = info;

    /*        [Name]
      ,[Cost_price]
      ,[Price]
      ,[Gram_per_serving]
      ,[Grain_type]
      ,[Country_of_origin]
      ,[Info]*/
        }
        public void Edit_Coffe(string name, double cost_price, double price, string grain_type, string country_of_origin, int gram_per_serving, string info)
        {
            this.name = name;
            this.cost_price = cost_price;
            this.price = price;
            this.grain_type = grain_type;
            this.country_of_origin = country_of_origin;
            this.gram_per_serving = gram_per_serving;
            this.info = info;
        }

        public string name { get; set; } // Название
        public double cost_price { get; set; } //   Себестоимость
        public double price { get; set; } //  Цена
        public string grain_type { get; set; } // Вид зерна
        public string country_of_origin { get; set; } // Страна происхождения
        public int gram_per_serving { get; set; } // грамм на порцию
        public string info { get; set; } // Описание
    }
}
