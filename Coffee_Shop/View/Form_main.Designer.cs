
namespace Coffee_Shop.View
{
    partial class Form_main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBox_select_coffe = new System.Windows.Forms.ComboBox();
            this.label_select_coffee = new System.Windows.Forms.Label();
            this.label_count_coffe = new System.Windows.Forms.Label();
            this.numeric_count = new System.Windows.Forms.NumericUpDown();
            this.button_add_to_chek = new System.Windows.Forms.Button();
            this.textBox_coffe_info = new System.Windows.Forms.TextBox();
            this.label_coffee_info = new System.Windows.Forms.Label();
            this.label_chek = new System.Windows.Forms.Label();
            this.textBox_chek = new System.Windows.Forms.TextBox();
            this.label_price = new System.Windows.Forms.Label();
            this.label_mony = new System.Windows.Forms.Label();
            this.button_sell = new System.Windows.Forms.Button();
            this.button_drop_chek = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Coffe_editor_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Add_new_coffeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Delete_selected_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Edit_selected_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reports_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_count)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox_select_coffe
            // 
            this.comboBox_select_coffe.FormattingEnabled = true;
            this.comboBox_select_coffe.Location = new System.Drawing.Point(140, 52);
            this.comboBox_select_coffe.Name = "comboBox_select_coffe";
            this.comboBox_select_coffe.Size = new System.Drawing.Size(171, 21);
            this.comboBox_select_coffe.TabIndex = 0;
            // 
            // label_select_coffee
            // 
            this.label_select_coffee.AutoSize = true;
            this.label_select_coffee.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_select_coffee.ForeColor = System.Drawing.Color.Blue;
            this.label_select_coffee.Location = new System.Drawing.Point(24, 55);
            this.label_select_coffee.Name = "label_select_coffee";
            this.label_select_coffee.Size = new System.Drawing.Size(65, 13);
            this.label_select_coffee.TabIndex = 1;
            this.label_select_coffee.Text = "Ваш кофе";
            // 
            // label_count_coffe
            // 
            this.label_count_coffe.AutoSize = true;
            this.label_count_coffe.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_count_coffe.ForeColor = System.Drawing.Color.Blue;
            this.label_count_coffe.Location = new System.Drawing.Point(24, 106);
            this.label_count_coffe.Name = "label_count_coffe";
            this.label_count_coffe.Size = new System.Drawing.Size(116, 13);
            this.label_count_coffe.TabIndex = 2;
            this.label_count_coffe.Text = "Количество чашек";
            // 
            // numeric_count
            // 
            this.numeric_count.Location = new System.Drawing.Point(180, 104);
            this.numeric_count.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numeric_count.Name = "numeric_count";
            this.numeric_count.Size = new System.Drawing.Size(131, 20);
            this.numeric_count.TabIndex = 3;
            this.numeric_count.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // button_add_to_chek
            // 
            this.button_add_to_chek.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button_add_to_chek.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_add_to_chek.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_add_to_chek.Location = new System.Drawing.Point(92, 186);
            this.button_add_to_chek.Name = "button_add_to_chek";
            this.button_add_to_chek.Size = new System.Drawing.Size(108, 29);
            this.button_add_to_chek.TabIndex = 4;
            this.button_add_to_chek.Text = "Добавить в чек";
            this.button_add_to_chek.UseVisualStyleBackColor = false;
            // 
            // textBox_coffe_info
            // 
            this.textBox_coffe_info.BackColor = System.Drawing.Color.White;
            this.textBox_coffe_info.Location = new System.Drawing.Point(330, 52);
            this.textBox_coffe_info.Multiline = true;
            this.textBox_coffe_info.Name = "textBox_coffe_info";
            this.textBox_coffe_info.ReadOnly = true;
            this.textBox_coffe_info.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_coffe_info.Size = new System.Drawing.Size(182, 163);
            this.textBox_coffe_info.TabIndex = 5;
            this.textBox_coffe_info.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label_coffee_info
            // 
            this.label_coffee_info.AutoSize = true;
            this.label_coffee_info.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_coffee_info.ForeColor = System.Drawing.Color.Blue;
            this.label_coffee_info.Location = new System.Drawing.Point(370, 27);
            this.label_coffee_info.Name = "label_coffee_info";
            this.label_coffee_info.Size = new System.Drawing.Size(128, 13);
            this.label_coffee_info.TabIndex = 6;
            this.label_coffee_info.Text = "Информация о кофе";
            // 
            // label_chek
            // 
            this.label_chek.AutoSize = true;
            this.label_chek.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_chek.ForeColor = System.Drawing.Color.Blue;
            this.label_chek.Location = new System.Drawing.Point(400, 233);
            this.label_chek.Name = "label_chek";
            this.label_chek.Size = new System.Drawing.Size(30, 13);
            this.label_chek.TabIndex = 8;
            this.label_chek.Text = "Чек";
            // 
            // textBox_chek
            // 
            this.textBox_chek.BackColor = System.Drawing.Color.White;
            this.textBox_chek.Location = new System.Drawing.Point(330, 259);
            this.textBox_chek.Multiline = true;
            this.textBox_chek.Name = "textBox_chek";
            this.textBox_chek.ReadOnly = true;
            this.textBox_chek.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_chek.Size = new System.Drawing.Size(182, 163);
            this.textBox_chek.TabIndex = 7;
            this.textBox_chek.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label_price
            // 
            this.label_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_price.Location = new System.Drawing.Point(12, 259);
            this.label_price.Name = "label_price";
            this.label_price.Size = new System.Drawing.Size(133, 105);
            this.label_price.TabIndex = 9;
            this.label_price.Text = "0";
            this.label_price.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_mony
            // 
            this.label_mony.AutoSize = true;
            this.label_mony.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_mony.ForeColor = System.Drawing.Color.Black;
            this.label_mony.Location = new System.Drawing.Point(151, 310);
            this.label_mony.Name = "label_mony";
            this.label_mony.Size = new System.Drawing.Size(49, 25);
            this.label_mony.TabIndex = 10;
            this.label_mony.Text = "Грн";
            // 
            // button_sell
            // 
            this.button_sell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button_sell.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_sell.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_sell.Location = new System.Drawing.Point(12, 393);
            this.button_sell.Name = "button_sell";
            this.button_sell.Size = new System.Drawing.Size(283, 29);
            this.button_sell.TabIndex = 11;
            this.button_sell.Text = "Продажа";
            this.button_sell.UseVisualStyleBackColor = false;
            // 
            // button_drop_chek
            // 
            this.button_drop_chek.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button_drop_chek.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_drop_chek.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_drop_chek.Location = new System.Drawing.Point(12, 358);
            this.button_drop_chek.Name = "button_drop_chek";
            this.button_drop_chek.Size = new System.Drawing.Size(283, 29);
            this.button_drop_chek.TabIndex = 12;
            this.button_drop_chek.Text = "Сбросить чек";
            this.button_drop_chek.UseVisualStyleBackColor = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Silver;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Coffe_editor_ToolStripMenuItem,
            this.reports_ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(553, 24);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Coffe_editor_ToolStripMenuItem
            // 
            this.Coffe_editor_ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Add_new_coffeeToolStripMenuItem,
            this.Delete_selected_ToolStripMenuItem,
            this.Edit_selected_ToolStripMenuItem});
            this.Coffe_editor_ToolStripMenuItem.Name = "Coffe_editor_ToolStripMenuItem";
            this.Coffe_editor_ToolStripMenuItem.Size = new System.Drawing.Size(100, 20);
            this.Coffe_editor_ToolStripMenuItem.Text = "Редактор кофе";
            // 
            // Add_new_coffeeToolStripMenuItem
            // 
            this.Add_new_coffeeToolStripMenuItem.Name = "Add_new_coffeeToolStripMenuItem";
            this.Add_new_coffeeToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.Add_new_coffeeToolStripMenuItem.Size = new System.Drawing.Size(255, 22);
            this.Add_new_coffeeToolStripMenuItem.Text = "Добавить новый";
            // 
            // Delete_selected_ToolStripMenuItem
            // 
            this.Delete_selected_ToolStripMenuItem.Name = "Delete_selected_ToolStripMenuItem";
            this.Delete_selected_ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Delete)));
            this.Delete_selected_ToolStripMenuItem.Size = new System.Drawing.Size(255, 22);
            this.Delete_selected_ToolStripMenuItem.Text = "Удалить выбраный";
            // 
            // Edit_selected_ToolStripMenuItem
            // 
            this.Edit_selected_ToolStripMenuItem.Name = "Edit_selected_ToolStripMenuItem";
            this.Edit_selected_ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.Edit_selected_ToolStripMenuItem.Size = new System.Drawing.Size(255, 22);
            this.Edit_selected_ToolStripMenuItem.Text = "Редактировать выбраный";
            // 
            // reports_ToolStripMenuItem
            // 
            this.reports_ToolStripMenuItem.Name = "reports_ToolStripMenuItem";
            this.reports_ToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.reports_ToolStripMenuItem.Text = "Отчеты";
            // 
            // Form_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(553, 434);
            this.Controls.Add(this.button_drop_chek);
            this.Controls.Add(this.button_sell);
            this.Controls.Add(this.label_mony);
            this.Controls.Add(this.label_price);
            this.Controls.Add(this.label_chek);
            this.Controls.Add(this.textBox_chek);
            this.Controls.Add(this.label_coffee_info);
            this.Controls.Add(this.textBox_coffe_info);
            this.Controls.Add(this.button_add_to_chek);
            this.Controls.Add(this.numeric_count);
            this.Controls.Add(this.label_count_coffe);
            this.Controls.Add(this.label_select_coffee);
            this.Controls.Add(this.comboBox_select_coffe);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form_main";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Coffee Shop";
            ((System.ComponentModel.ISupportInitialize)(this.numeric_count)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_select_coffe;
        private System.Windows.Forms.Label label_select_coffee;
        private System.Windows.Forms.Label label_count_coffe;
        private System.Windows.Forms.NumericUpDown numeric_count;
        private System.Windows.Forms.Button button_add_to_chek;
        private System.Windows.Forms.TextBox textBox_coffe_info;
        private System.Windows.Forms.Label label_coffee_info;
        private System.Windows.Forms.Label label_chek;
        private System.Windows.Forms.TextBox textBox_chek;
        private System.Windows.Forms.Label label_price;
        private System.Windows.Forms.Label label_mony;
        private System.Windows.Forms.Button button_sell;
        private System.Windows.Forms.Button button_drop_chek;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Coffe_editor_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reports_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Add_new_coffeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Delete_selected_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Edit_selected_ToolStripMenuItem;
    }
}