using Coffee_Shop.Control;
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
    public partial class Form_main : Form
    {
        Controls_Coffee control;
        public Form_main()
        {
            InitializeComponent();
            control = new Controls_Coffee();
            Load += Form_main_Load;
            comboBox_select_coffe.SelectedIndexChanged += ComboBox_select_coffe_SelectedIndexChanged;
            button_add_to_chek.Click += Button_add_to_chek_Click;
            button_drop_chek.Click += Button_drop_chek_Click;
            this.MainMenuStrip = menuStrip1;
            Add_new_coffeeToolStripMenuItem.Click += Add_new_coffeeToolStripMenuItem_Click;
            Delete_selected_ToolStripMenuItem.Click += Delete_selected_ToolStripMenuItem_Click;
            Edit_selected_ToolStripMenuItem.Click += Edit_selected_ToolStripMenuItem_Click;
        }

        private void Edit_selected_ToolStripMenuItem_Click(object sender, EventArgs e)
        { control.Edit_selected(comboBox_select_coffe); control.Load_coffee(comboBox_select_coffe, textBox_coffe_info); }
        private void Delete_selected_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            control.Delete_selected(comboBox_select_coffe);
            MessageBox.Show("Елемент удален", "!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            control.Load_coffee(comboBox_select_coffe, textBox_coffe_info); 
        }      
        private void Add_new_coffeeToolStripMenuItem_Click(object sender, EventArgs e)
        { control.Add_new_Coffee();  control.Load_coffee(comboBox_select_coffe, textBox_coffe_info); }
        private void Button_drop_chek_Click(object sender, EventArgs e)=> control.drop_chek(numeric_count, textBox_chek, comboBox_select_coffe, label_price);
        private void Button_add_to_chek_Click(object sender, EventArgs e) => control.add_to_chek(numeric_count, textBox_chek,comboBox_select_coffe, label_price);      
        private void ComboBox_select_coffe_SelectedIndexChanged(object sender, EventArgs e) => control.Selected_coffee(comboBox_select_coffe, textBox_coffe_info);      
        private void Form_main_Load(object sender, EventArgs e) => control.Load_coffee(comboBox_select_coffe,textBox_coffe_info);
       
    }
}
