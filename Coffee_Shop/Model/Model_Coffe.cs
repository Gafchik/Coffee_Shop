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
    }
    public class Model_Coffe
    {
        public string name { get; set; } // Название
        public string cost_price { get; set; } //   Себестоимость
        public string price { get; set; } //  Цена
        public string grain_type { get; set; } // Вид зерна
        public string country_of_origin { get; set; } // Страна происхождения
        public string gram_per_serving { get; set; } // грамм на порцию
        public string description { get; set; } // Описание
    }
}
