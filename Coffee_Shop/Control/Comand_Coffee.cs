using Coffee_Shop.Model;
using Coffee_Shop.Properties;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Linq.Mapping;
using System.Data.SqlClient;
using System.Linq;
using System.Data.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coffee_Shop.Control
{
    public class Comand_Coffee
    {
        internal void Select_coffee_in_BD()
        {
            using(DataContext db = new DataContext(Resources.ConectString))
            {
                /*А ЭТУ ХУЙНЮ Я НАПИСАЛ В 2 СТРОЧКИ  ПОСЛЕ ТОГО ЧТО НИЖЕ В КОММЕНТАХ !!!*/
                Table<Model_Coffee> coffees = db.GetTable<Model_Coffee>();
                coffees.ToList<Model_Coffee>().ForEach(i => Coffee_list.coffee_list.Add(i));            
            }

            /*НА ЭТУ ХУЙНЮ Я УБИЛ СУКА ЧАС!!!!!!*/
            /*using (SqlConnection connection = new SqlConnection(Resources.ConectString))
            {
                connection.Open(); // открываем соидинение
                SqlCommand SQL_SELECT = new SqlCommand(Resources.SQL_Select_ALL, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(SQL_SELECT.CommandText, connection);
                DataSet data = new DataSet();
                adapter.Fill(data);
                for (int i = 0; i < data.Tables[0].Rows.Count; i++) // бежим по строкам таблицы
                {
                    Model_Coffee model_Coffe = new Model_Coffee(); // временная переменная для листа
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
                    data.Clear();
                    connection.Close(); // закрываем соединение
             
            }*/
        }
        internal void Edit(Model_Coffee edit_coffee,Model_Coffee rezult_coffee)
        {          
            using (DataContext db = new DataContext(Resources.ConectString))
            {
                // Получаем таблицу пользователей                
                Model_Coffee up_data_coffe = db.GetTable<Model_Coffee>().FirstOrDefault<Model_Coffee>(i => i.name == edit_coffee.name);
                // и изменим у него возраст
                up_data_coffe.Edit_Coffe(rezult_coffee);
                // сохраним изменения
                db.SubmitChanges();
            }
        }
        internal void Delete_selected(ComboBox comboBox_select_coffe)
        {
            using (DataContext db = new DataContext(Resources.ConectString))
            {
                try
                {
                    db.GetTable<Model_Coffee>().DeleteOnSubmit(db.GetTable<Model_Coffee>().FirstOrDefault<Model_Coffee>(i => i.name == comboBox_select_coffe.SelectedItem.ToString()));
                    db.SubmitChanges();
                }
                catch (Exception)
                {
                    MessageBox.Show("Не найден нужный элемент", "нЕ УДАЛЕНО", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
               
            }

           /* using (SqlConnection connection = new SqlConnection(Resources.ConectString))
            {
                connection.Open(); // открываем соидинение

                SqlCommand SQL_SELECT = new SqlCommand(Resources.SQL_Select_ALL, connection); // команда селект все в таблицйу внутри проги
                SqlDataAdapter adapter = new SqlDataAdapter(SQL_SELECT.CommandText, connection); // Адаптер для всего этого


                DataSet data = new DataSet(); // класс для хранения всего что выбрали
                adapter.Fill(data); // через адаптер заполняем  наш датасет
                *//* ищем то что нужно удалить *//*
                data.Tables[0].Select($"Name = '{comboBox_select_coffe.SelectedItem}'").ToList<DataRow>().ForEach(i => i.Delete());
              
                SqlCommandBuilder commandBuilder = new SqlCommandBuilder(adapter); // строим ему строку обновления
                adapter.DeleteCommand = commandBuilder.GetDeleteCommand(); // присваеваем команду удаления в адаптер
                int g = adapter.Update(data); // обновляем в нутри бд нашу табл
                data.Clear();                // чистим датасет
            }*/
        }    
        internal void Add_BD(Model_Coffee temp)
        {
            using (DataContext db = new DataContext(Resources.ConectString))
            {
            db.GetTable<Model_Coffee>().InsertOnSubmit(temp);
            db.SubmitChanges();
            }
               
            /* using (SqlConnection connection = new SqlConnection(Resources.ConectString))
             {
                 connection.Open(); // открываем соидинение
                 SqlCommand sqlComm = new SqlCommand(Resources.SQL_Select_ALL, connection);
                 SqlDataAdapter adapter = new SqlDataAdapter(sqlComm.CommandText, connection);
                 DataSet data = new DataSet();
                 adapter.Fill(data);
                 DataTable dt = data.Tables[0];
                 DataRow newRow = dt.NewRow();
                 newRow["Name"] = temp.name;
                 newRow["Cost_price"] = temp.cost_price;
                 newRow["Price"] = temp.price;
                 newRow["Gram_per_serving"] = temp.gram_per_serving;
                 newRow["Grain_type"] = temp.grain_type;
                 newRow["Country_of_origin"] = temp.country_of_origin;
                 newRow["Info"] = temp.info;
                 dt.Rows.Add(newRow);


                 SqlCommandBuilder commandBuilder = new SqlCommandBuilder(adapter);
                 adapter.Update(data);
                 data.Clear();
                 adapter.Fill(data);
             }*/
        }

    }
}
