
namespace Coffee_Shop.View
{
    partial class Form_add_new_coffee
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
            this.label1 = new System.Windows.Forms.Label();
            this.Add = new System.Windows.Forms.Button();
            this.Сancel = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel_data = new System.Windows.Forms.Panel();
            this.Gramm_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.info_textBox = new System.Windows.Forms.TextBox();
            this.Country_textBox = new System.Windows.Forms.TextBox();
            this.grain_type_textBox = new System.Windows.Forms.TextBox();
            this.Price_textBox = new System.Windows.Forms.TextBox();
            this.cost_price_textBox = new System.Windows.Forms.TextBox();
            this.Name_textBox = new System.Windows.Forms.TextBox();
            this.panel_data.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Gramm_numericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(27, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Название";
            // 
            // Add
            // 
            this.Add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Add.Location = new System.Drawing.Point(28, 320);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(94, 43);
            this.Add.TabIndex = 2;
            this.Add.Text = "Добавить";
            this.Add.UseVisualStyleBackColor = false;
            // 
            // Сancel
            // 
            this.Сancel.BackColor = System.Drawing.Color.Red;
            this.Сancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Сancel.Location = new System.Drawing.Point(232, 320);
            this.Сancel.Name = "Сancel";
            this.Сancel.Size = new System.Drawing.Size(94, 43);
            this.Сancel.TabIndex = 3;
            this.Сancel.Text = "Отменить";
            this.Сancel.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(27, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Себестоимость";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(27, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Цена";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(27, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Вид зерна";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Location = new System.Drawing.Point(27, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Страна происхождения";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Blue;
            this.label6.Location = new System.Drawing.Point(25, 164);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Грамм на порцию";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Blue;
            this.label7.Location = new System.Drawing.Point(27, 221);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Описание";
            // 
            // panel_data
            // 
            this.panel_data.Controls.Add(this.Gramm_numericUpDown);
            this.panel_data.Controls.Add(this.info_textBox);
            this.panel_data.Controls.Add(this.Country_textBox);
            this.panel_data.Controls.Add(this.grain_type_textBox);
            this.panel_data.Controls.Add(this.Price_textBox);
            this.panel_data.Controls.Add(this.cost_price_textBox);
            this.panel_data.Controls.Add(this.Name_textBox);
            this.panel_data.Location = new System.Drawing.Point(161, 12);
            this.panel_data.Name = "panel_data";
            this.panel_data.Size = new System.Drawing.Size(189, 266);
            this.panel_data.TabIndex = 16;
            // 
            // Gramm_numericUpDown
            // 
            this.Gramm_numericUpDown.Location = new System.Drawing.Point(15, 150);
            this.Gramm_numericUpDown.Name = "Gramm_numericUpDown";
            this.Gramm_numericUpDown.Size = new System.Drawing.Size(152, 20);
            this.Gramm_numericUpDown.TabIndex = 22;
            // 
            // info_textBox
            // 
            this.info_textBox.Location = new System.Drawing.Point(15, 175);
            this.info_textBox.Multiline = true;
            this.info_textBox.Name = "info_textBox";
            this.info_textBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.info_textBox.Size = new System.Drawing.Size(152, 76);
            this.info_textBox.TabIndex = 21;
            this.info_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Country_textBox
            // 
            this.Country_textBox.Location = new System.Drawing.Point(15, 123);
            this.Country_textBox.Name = "Country_textBox";
            this.Country_textBox.Size = new System.Drawing.Size(152, 20);
            this.Country_textBox.TabIndex = 19;
            this.Country_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // grain_type_textBox
            // 
            this.grain_type_textBox.Location = new System.Drawing.Point(15, 97);
            this.grain_type_textBox.Name = "grain_type_textBox";
            this.grain_type_textBox.Size = new System.Drawing.Size(152, 20);
            this.grain_type_textBox.TabIndex = 18;
            this.grain_type_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Price_textBox
            // 
            this.Price_textBox.Location = new System.Drawing.Point(15, 71);
            this.Price_textBox.Name = "Price_textBox";
            this.Price_textBox.Size = new System.Drawing.Size(152, 20);
            this.Price_textBox.TabIndex = 17;
            this.Price_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cost_price_textBox
            // 
            this.cost_price_textBox.Location = new System.Drawing.Point(15, 45);
            this.cost_price_textBox.Name = "cost_price_textBox";
            this.cost_price_textBox.Size = new System.Drawing.Size(152, 20);
            this.cost_price_textBox.TabIndex = 16;
            this.cost_price_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Name_textBox
            // 
            this.Name_textBox.Location = new System.Drawing.Point(15, 19);
            this.Name_textBox.Name = "Name_textBox";
            this.Name_textBox.Size = new System.Drawing.Size(152, 20);
            this.Name_textBox.TabIndex = 15;
            this.Name_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form_add_new_coffee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(362, 386);
            this.Controls.Add(this.panel_data);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Сancel);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form_add_new_coffee";
            this.Text = "Form_add_new_coffe";
            this.panel_data.ResumeLayout(false);
            this.panel_data.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Gramm_numericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Сancel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel_data;
        private System.Windows.Forms.TextBox info_textBox;
        private System.Windows.Forms.TextBox Country_textBox;
        private System.Windows.Forms.TextBox grain_type_textBox;
        private System.Windows.Forms.TextBox Price_textBox;
        private System.Windows.Forms.TextBox cost_price_textBox;
        private System.Windows.Forms.TextBox Name_textBox;
        private System.Windows.Forms.NumericUpDown Gramm_numericUpDown;
    }
}