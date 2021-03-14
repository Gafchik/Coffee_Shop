using Coffee_Shop.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coffee_Shop.View
{
    public partial class Form_edit_selected : Form
    {
        Model_Coffe edit_coffee;
        public Form_edit_selected(ComboBox comboBox_select_coffe)
        {
            InitializeComponent();
            Сancel.Click += Сancel_Click;
            Edit.Click += Edit_Click;
            Load += Form_edit_selected_Load;
            edit_coffee = Coffee_list.coffee_list.Find(i => i.name == comboBox_select_coffe.SelectedItem.ToString());

        }

        private void Form_edit_selected_Load(object sender, EventArgs e)
        {
            info_textBox.Text = edit_coffee.info;
            Country_textBox.Text = edit_coffee.country_of_origin;
            grain_type_textBox.Text = edit_coffee.grain_type;
            Price_textBox.Text = edit_coffee.price.ToString();
            cost_price_textBox.Text = edit_coffee.cost_price.ToString();
            Name_textBox.Text = edit_coffee.name;
            Gramm_numericUpDown.Value = edit_coffee.gram_per_serving;
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            if (info_textBox.Text != string.Empty &&
                Country_textBox.Text != string.Empty &&
                grain_type_textBox.Text != string.Empty &&
                Price_textBox.Text != string.Empty &&
                cost_price_textBox.Text != string.Empty &&
                Name_textBox.Text != string.Empty &&
                Gramm_numericUpDown.Value != 0)
            {


                Coffee_list.coffee_list.Find(i => i.name == edit_coffee.name).Edit_Coffe(Name_textBox.Text, Convert.ToDouble(cost_price_textBox.Text), Convert.ToDouble(Price_textBox.Text), grain_type_textBox.Text, Country_textBox.Text, Convert.ToInt32(Gramm_numericUpDown.Value), info_textBox.Text);
                MessageBox.Show("Элемент успешно изменен", "Элемент изменен", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
                MessageBox.Show("Заполните все поля", "Не все поля заполнены", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void Сancel_Click(object sender, EventArgs e) => this.Close();
    }
}
