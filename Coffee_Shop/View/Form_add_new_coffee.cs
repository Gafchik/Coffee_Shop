using Coffee_Shop.Control;
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
    public partial class Form_add_new_coffee : Form
    {
        Comand_Coffee comand;
        public Form_add_new_coffee()
        {
            InitializeComponent();
            Сancel.Click += Сancel_Click;
            Add.Click += Add_Click;
            comand = new Comand_Coffee();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            if (info_textBox.Text != string.Empty &&
                Country_textBox.Text != string.Empty &&
                grain_type_textBox.Text != string.Empty &&
                Price_textBox.Text != string.Empty &&
                cost_price_textBox.Text != string.Empty &&
                Name_textBox.Text != string.Empty &&
                Gramm_numericUpDown.Value != 0)
            { 
                Model_Coffee temp = new Model_Coffee(Name_textBox.Text,
                    Convert.ToDouble(cost_price_textBox.Text.Replace(".",",")), 
                    Convert.ToDouble(Price_textBox.Text.Replace(".", ",")),
                    grain_type_textBox.Text, Country_textBox.Text,
                    Convert.ToInt32(Gramm_numericUpDown.Value), info_textBox.Text);              
                comand.Add_BD(temp);
                MessageBox.Show("Новый элемент успешно добавлен", "Добавлен новый элемент", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GC.Collect(GC.GetGeneration(temp));
                this.Close();
            }
            else
                MessageBox.Show("Заполните все поля", "Не все поля заполнены", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void Сancel_Click(object sender, EventArgs e) => this.Close();
       
    }
}
