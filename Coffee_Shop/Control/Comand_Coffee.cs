using Coffee_Shop.Model;
using Coffee_Shop.Properties;
using System;
using System.Collections.Generic;
using System.Data;

using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coffee_Shop.Control
{
    public class Comand_Coffee
    {
        internal void Select_coffee_in_BD()
        {
            using (SqlConnection connection = new SqlConnection(Resources.ConectString))
            {
                connection.Open(); // открываем соидинение
                SqlCommand sqlComm = new SqlCommand("SELECT * FROM [DB_A71194_CoffeeShopDB].[dbo].[Coffee];", connection);
                SqlDataAdapter adapter = new SqlDataAdapter(sqlComm.CommandText, connection);
                DataSet data = new DataSet();
                adapter.Fill(data);
                for (int i = 0; i < data.Tables[0].Rows.Count; i++) // бежим по строкам таблицы
                {
                    Model_Coffe model_Coffe = new Model_Coffe(); // временная переменная для листа
                    for (int q = 1; q < data.Tables[0].Columns.Count; q++) // бежим по колонкам таблица
                    {
                        string row_name = data.Tables[0].Columns[q].ToString(); // название колонки для свич
                        switch (row_name)
                        {
                            case "Name":
                                model_Coffe.name = data.Tables[0].Rows[i].ItemArray[q].ToString();
                                break;
                            case "Cost_price":
                                model_Coffe.cost_price = Convert.ToDouble(data.Tables[0].Rows[i].ItemArray[q].ToString());
                                break;
                            case "Price":
                                model_Coffe.price = Convert.ToDouble(data.Tables[0].Rows[i].ItemArray[q].ToString());
                                break;
                            case "Gram_per_serving":
                                model_Coffe.gram_per_serving = Convert.ToInt32(data.Tables[0].Rows[i].ItemArray[q].ToString());
                                break;
                            case "Grain_type":
                                model_Coffe.grain_type = data.Tables[0].Rows[i].ItemArray[q].ToString();
                                break;
                            case "Country_of_origin":
                                model_Coffe.country_of_origin = data.Tables[0].Rows[i].ItemArray[q].ToString();
                                break;
                            case "Info":
                                model_Coffe.info = data.Tables[0].Rows[i].ItemArray[q].ToString();
                                break;
                            default:
                                break;
                        }
                    }
                    // убераем лишнии пробелы
                    model_Coffe.name = model_Coffe.name.Trim();
                    model_Coffe.grain_type = model_Coffe.grain_type.Trim();
                    model_Coffe.country_of_origin = model_Coffe.country_of_origin.Trim();
                    model_Coffe.info = model_Coffe.info.Trim();
                    // чистим память за временной переменной
                    Coffee_list.coffee_list.Add(model_Coffe);
                    GC.Collect(GC.GetGeneration(model_Coffe));
                }
             
            }
        }
    }
}
