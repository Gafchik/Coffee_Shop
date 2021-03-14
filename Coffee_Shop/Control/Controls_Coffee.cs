using Coffee_Shop.Model;
using Coffee_Shop.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coffee_Shop.Control
{
    public class Controls_Coffee
    {
        internal void Load_coffee(ComboBox comboBox_select_coffe, TextBox textBox_coffe_info)
        {
            comboBox_select_coffe.Items.Clear();
            Coffee_list.coffee_list.ForEach(i => comboBox_select_coffe.Items.Add(i.name));
            try
            {
                comboBox_select_coffe.SelectedIndex = 0;
                Selected_coffee(comboBox_select_coffe, textBox_coffe_info);
            }
            catch (Exception) { }

        }
        internal void Selected_coffee(ComboBox comboBox_select_coffe, TextBox textBox_coffe_info)
        {
            try
            {
                
                Model_Coffe temp = Coffee_list.coffee_list.Find(i => i.name == comboBox_select_coffe.SelectedItem.ToString());
                textBox_coffe_info.Text = "==========================\r\n"+
                                           $"Название : {temp.name}\r\n" +
                                           $"Цена : {temp.price}\r\n" +
                                           $"Вид : зерна {temp.grain_type}\r\n" +
                                           $"Страна  происхождения : {temp.country_of_origin}\r\n" +
                                           $"грамм  на порцию : {temp.gram_per_serving}\r\n" +
                                           $"Описание : {temp.info}\r\n" +
                                           "==========================\r\n";
            }
            catch (Exception) { }
        }

        internal void Edit_selected(ComboBox comboBox_select_coffe)
        {
            Form_edit_selected form_edit = new Form_edit_selected(comboBox_select_coffe);
            form_edit.ShowDialog();
            GC.Collect(GC.GetGeneration(form_edit));
        }

        internal void Delete_selected(ComboBox comboBox_select_coffe) => Coffee_list.coffee_list.RemoveAt(Coffee_list.coffee_list.FindIndex(i => i.name == comboBox_select_coffe.SelectedItem.ToString()));      
        internal void Add_new_Coffee()
        {
            Form_add_new_coffee form_add = new Form_add_new_coffee();
            form_add.ShowDialog();
            GC.Collect(GC.GetGeneration(form_add));
        }
        internal void drop_chek(NumericUpDown numeric_count, TextBox textBox_chek, ComboBox comboBox_select_coffe, Label label_price)
        {
            textBox_chek.Text = "";
            label_price.Text = "0";
        }
        internal void add_to_chek(NumericUpDown numeric_count, TextBox textBox_chek, ComboBox comboBox_select_coffe, Label label_price)
        {
            Chek_list.list_chel.Add(new Model_chek(Coffee_list.coffee_list.Find(i => i.name == comboBox_select_coffe.SelectedItem.ToString()),Convert.ToInt32( numeric_count.Value)));
            textBox_chek.Text = DateTime.Now.ToString()+"\r\n";
            Chek_list.list_chel.ForEach(i => textBox_chek.Text += $"Коффе : {i.coffee.name}\r\nКоличество : {i.count}\r\n" + "===============\r\n");
            label_price.Text = Chek_list.Get_Full_Price();
        }
    }
}
