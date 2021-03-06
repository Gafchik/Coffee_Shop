using Coffee_Shop.Model;
using Coffee_Shop.View;
using System;
using System.Windows.Forms;

namespace Coffee_Shop.Control
{
    public class Controls_Coffee
    {
        Comand_Coffee comand = new Comand_Coffee();
        internal void Load_coffee(ComboBox comboBox_select_coffe, TextBox textBox_coffe_info)
        {
            Coffee_list.coffee_list.Clear();
            comboBox_select_coffe.Items.Clear();
            comand.Select_coffee_in_BD();
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
                textBox_coffe_info.Text = Coffee_list.coffee_list.Find(i => i.name == comboBox_select_coffe.SelectedItem.ToString()).Get_All_info(); 
            }
            catch (Exception) { }
        }
        internal void Edit_selected(ComboBox comboBox_select_coffe)
        {
            Form_edit_selected form_edit = new Form_edit_selected(comboBox_select_coffe);
            form_edit.ShowDialog();
            GC.Collect(GC.GetGeneration(form_edit));
        }
        internal void Delete_selected(ComboBox comboBox_select_coffe) => comand.Delete_selected(comboBox_select_coffe);
           
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
