using Coffee_Shop.Model;
using System;
using System.Collections.Generic;
using System.Linq;

using System.Windows.Forms;

namespace Coffee_Shop.View
{
    public partial class Form_search : Form
    {
        public Form_search()
        {
            InitializeComponent();
             checkBox_country.CheckedChanged += CheckBox_CheckedChanged;
            checkBox_cost_price.CheckedChanged += CheckBox_CheckedChanged;
            checkBox_gramm.CheckedChanged += CheckBox_CheckedChanged;
            checkBox_info.CheckedChanged += CheckBox_CheckedChanged;
            button_go.Click += Button_go_Click;
            Load += Form_search_Load;
           
           
        }
        private void update()
        {
            List<string> temp = new List<string>();
            Coffee_list.coffee_list.ForEach(i => temp.Add(i.country_of_origin));
            temp.Distinct<string>().ToList().ForEach(i => comboBox_country.Items.Add(i));
            GC.Collect(GC.GetGeneration(temp));
        }
        private void Form_search_Load(object sender, EventArgs e) => update();


        private void Button_go_Click(object sender, EventArgs e)
        {
            int count_true = 0;
            if (checkBox_country.Checked)
                count_true++;
            if (checkBox_info.Checked)
                count_true++;
            if (checkBox_cost_price.Checked)
                count_true++;
            if (checkBox_gramm.Checked)
                count_true++;

            update();
            List<Model_Coffee> search_list = new List<Model_Coffee>();
           
            textBox_rezult.Text = "";
            foreach (var item in Coffee_list.coffee_list)
            {
                int count_temp = 0;

                if (checkBox_country.Checked)
                    if (comboBox_country.SelectedItem.ToString() == item.country_of_origin)
                        count_temp++;

                if (checkBox_info.Checked)
                    if (!string.IsNullOrEmpty(textBox_info.Text))
                        if (item.info.Contains(textBox_info.Text))
                            count_temp++;

                if (checkBox_cost_price.Checked)
                    if (numericUpDown_cost_price_B.Value < numericUpDown_cost_price_E.Value)
                        if (item.cost_price < Convert.ToInt32(numericUpDown_cost_price_B.Value) ||
                            item.cost_price > Convert.ToInt32(numericUpDown_cost_price_E.Value))
                            count_temp++;

                if (checkBox_gramm.Checked)
                    if (numericUpDown_gramm_B.Value < numericUpDown_gramm_E.Value)
                        if (item.cost_price >= Convert.ToInt32(numericUpDown_gramm_B.Value) &&
                            item.cost_price <= Convert.ToInt32(numericUpDown_gramm_E.Value))
                            count_temp++;
                if (count_temp == count_true)
                    search_list.Add(item);
            }
            search_list.ForEach(i => textBox_rezult.Text += i.Get_All_info());
            GC.Collect(GC.GetGeneration(search_list));
        }

        private void CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            var sender2 = (sender as CheckBox);
           
            switch (sender2.Text)
            {
                case "Страна":
                    if (sender2.Checked)
                        comboBox_country.Enabled = true;
                    else
                        comboBox_country.Enabled = false;
                    break;
                case "Слово в описании":
                    if (sender2.Checked)
                        textBox_info.Enabled = true;
                    else
                        textBox_info.Enabled = false;
                    break;
                case "Себестоимость":
                    if (sender2.Checked)
                        panel_cost_price.Enabled = true;
                    else
                        panel_cost_price.Enabled = false;
                    break;
                case "Грамм на порцию":
                    if (sender2.Checked)
                        panel_gramm.Enabled = true;
                    else
                        panel_gramm.Enabled = false;
                    break;
                default:
                    break;
            }
        }
    }
}
