using System;
using System.Collections.Generic;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coffee_Shop.Model
{
    public static class Coffee_list
    {
        public static List<Model_Coffee> coffee_list = new List<Model_Coffee>(); // коллекция для видов кофе
         static Coffee_list()
        {

           /* coffee_list.Add(new Model_Coffe("Американо", 4.5, 15.6, "арабика", "США", 30, "Америкашка"));
            coffee_list.Add(new Model_Coffe("Еспрессо", 2.3, 10.6, "арабика", "США", 10, "еспрессо"));
            coffee_list.Add(new Model_Coffe("Горячий шоколад", 4.5, 15.6, "арабика", "США", 50, "Горячий шоколад"));
            coffee_list.Add(new Model_Coffe("Латк", 4.5, 15.6, "арабика", "США", 70, "Латк"));*/
        }
    }
    [Table(Name = "Coffee")]
    public class Model_Coffee
    {
        public Model_Coffee() { }

        public Model_Coffee(string name, double cost_price, double price, string grain_type, string country_of_origin, int gram_per_serving, string info)
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
        public void Edit_Coffe(Model_Coffee coffee)
        {

            this.name = coffee.name;
            this.cost_price = coffee.cost_price;
            this.price = coffee.price;
            this.grain_type = coffee.grain_type;
            this.country_of_origin = coffee.country_of_origin;
            this.gram_per_serving = coffee.gram_per_serving;
            this.info = coffee.info;
        }
        public string Get_All_info()
        {
           return "========================\r\n" +
           $"Название : {this.name}\r\n" +
           $"Цена : {this.price}\r\n" +
           $"Вид : зерна {this.grain_type}\r\n" +
           $"Страна  происхождения : {this.country_of_origin}\r\n" +
           $"грамм  на порцию : {this.gram_per_serving}\r\n" +
           $"Описание : {this.info}\r\n" +
           "========================\r\n";
        }

        [Column(IsPrimaryKey = true, IsDbGenerated = true)]
        public int Id { get; set; }

        [Column(Name = "Name")]
        public string name { get; set; } // Название

        [Column(Name = "Cost_price")]
        public double cost_price { get; set; } //   Себестоимость

        [Column(Name = "Price")]
        public double price { get; set; } //  Цена

        [Column(Name = "Grain_type")]
        public string grain_type { get; set; } // Вид зерна

        [Column(Name = "Country_of_origin")]
        public string country_of_origin { get; set; } // Страна происхождения

        [Column(Name = "Gram_per_serving")]
        public int gram_per_serving { get; set; } // грамм на порцию

        [Column(Name = "Info")]
        public string info { get; set; } // Описание
    }
}
