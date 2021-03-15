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
                connection.Open();
                string sqlComm = "SELECT * FROM Coffee;";
                SqlDataAdapter adapter = new SqlDataAdapter(sqlComm, connection);
                DataSet data = new DataSet();
                adapter.Fill(data);
                for (int i = 0; i < data.Tables[0].Rows.Count; i++)
                {
                    for (int q = 0; q < data.Tables[0].Rows[i].ItemArray.Length; q++)
                    {
                        Coffee_list.coffee_list.Add((data.Tables[0].Rows[i].ItemArray[q] as Model_Coffe));
                    }
                }

            }
        }
    }
}
