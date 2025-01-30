using CandyShop.Class;

namespace CandyShop
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Tovar tovar1 = new Tovar();
            Tovar tovar2 = new Tovar();
            Tovar tovar3 = new Tovar();
            Tovar tovar4 = new Tovar();
            Tovar tovar5 = new Tovar();
            Tovar tovar6 = new Tovar();
            Tovar tovar7 = new Tovar();
            Tovar tovar8 = new Tovar();
            Tovar tovar9 = new Tovar();
            Tovar tovar10 = new Tovar();
            Tovar tovar11 = new Tovar();
            Tovar tovar12 = new Tovar();
            Tovar tovar13 = new Tovar();
            Tovar tovar14 = new Tovar();
            groupBox1 = new GroupBox();
            button4 = new Button();
            label3 = new Label();
            label2 = new Label();
            checkedListBox1 = new CheckedListBox();
            button1 = new Button();
            label1 = new Label();
            numericUpDown1 = new NumericUpDown();
            comboBox1 = new ComboBox();
            button2 = new Button();
            button3 = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(checkedListBox1);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(numericUpDown1);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Location = new Point(14, 41);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(679, 453);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Касса";
            // 
            // button4
            // 
            button4.Location = new Point(229, 371);
            button4.Margin = new Padding(3, 4, 3, 4);
            button4.Name = "button4";
            button4.Size = new Size(166, 31);
            button4.TabIndex = 7;
            button4.Text = "Выдать чек";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(627, 371);
            label3.Name = "label3";
            label3.Size = new Size(21, 20);
            label3.TabIndex = 6;
            label3.Text = "р.";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.Location = new Point(584, 363);
            label2.Name = "label2";
            label2.Size = new Size(39, 28);
            label2.TabIndex = 5;
            label2.Text = "0,0";
            label2.Click += label2_Click;
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Location = new Point(17, 119);
            checkedListBox1.Margin = new Padding(3, 4, 3, 4);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(603, 202);
            checkedListBox1.TabIndex = 4;
            checkedListBox1.SelectedIndexChanged += checkedListBox1_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.Location = new Point(229, 68);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(166, 31);
            button1.TabIndex = 3;
            button1.Text = "Добавить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(627, 41);
            label1.Name = "label1";
            label1.Size = new Size(25, 20);
            label1.TabIndex = 2;
            label1.Text = "кг.";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(553, 31);
            numericUpDown1.Margin = new Padding(3, 4, 3, 4);
            numericUpDown1.Maximum = new decimal(new int[] { 250, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(67, 27);
            numericUpDown1.TabIndex = 1;
            // 
            // comboBox1
            // 
            tovar1.Manufacturer = null;
            tovar1.Name = "Коровка";
            tovar1.Prise = new decimal(new int[] { 155, 0, 0, 0 });
            tovar1.Weight = 0.2D;
            tovar2.Manufacturer = null;
            tovar2.Name = "Золотая Лилия";
            tovar2.Prise = new decimal(new int[] { 249, 0, 0, 0 });
            tovar2.Weight = 0.158D;
            tovar3.Manufacturer = null;
            tovar3.Name = "Мишка в лесу";
            tovar3.Prise = new decimal(new int[] { 120, 0, 0, 0 });
            tovar3.Weight = 0.125D;
            tovar4.Manufacturer = null;
            tovar4.Name = "Шоколадный фонтан";
            tovar4.Prise = new decimal(new int[] { 199, 0, 0, 0 });
            tovar4.Weight = 0.3D;
            tovar5.Manufacturer = null;
            tovar5.Name = "Малиновый рай";
            tovar5.Prise = new decimal(new int[] { 179, 0, 0, 0 });
            tovar5.Weight = 0.25D;
            tovar6.Manufacturer = null;
            tovar6.Name = "Карамельная вишня";
            tovar6.Prise = new decimal(new int[] { 135, 0, 0, 0 });
            tovar6.Weight = 0.18D;
            tovar7.Manufacturer = null;
            tovar7.Name = "Сливочный облако";
            tovar7.Prise = new decimal(new int[] { 165, 0, 0, 0 });
            tovar7.Weight = 0.22D;
            tovar8.Manufacturer = null;
            tovar8.Name = "Ореховая феерия";
            tovar8.Prise = new decimal(new int[] { 225, 0, 0, 0 });
            tovar8.Weight = 0.28D;
            tovar9.Manufacturer = null;
            tovar9.Name = "Цитрусовый взрыв";
            tovar9.Prise = new decimal(new int[] { 145, 0, 0, 0 });
            tovar9.Weight = 0.17D;
            tovar10.Manufacturer = null;
            tovar10.Name = "Ванильная мечта";
            tovar10.Prise = new decimal(new int[] { 155, 0, 0, 0 });
            tovar10.Weight = 0.19D;
            tovar11.Manufacturer = null;
            tovar11.Name = "Кофейный бриз";
            tovar11.Prise = new decimal(new int[] { 189, 0, 0, 0 });
            tovar11.Weight = 0.23D;
            tovar12.Manufacturer = null;
            tovar12.Name = "Клубничная поляна";
            tovar12.Prise = new decimal(new int[] { 169, 0, 0, 0 });
            tovar12.Weight = 0.21D;
            tovar13.Manufacturer = null;
            tovar13.Name = "Фисташковый рай";
            tovar13.Prise = new decimal(new int[] { 239, 0, 0, 0 });
            tovar13.Weight = 0.12D;
            tovar14.Manufacturer = null;
            tovar14.Name = "Мятное свечение";
            tovar14.Prise = new decimal(new int[] { 129, 0, 0, 0 });
            tovar14.Weight = 0.14D;
            comboBox1.Items.AddRange(new object[] { tovar1, tovar2, tovar3, tovar4, tovar5, tovar6, tovar7, tovar8, tovar9, tovar10, tovar11, tovar12, tovar13, tovar14 });
            comboBox1.Location = new Point(17, 29);
            comboBox1.Margin = new Padding(3, 4, 3, 4);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(529, 28);
            comboBox1.TabIndex = 0;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // button2
            // 
            button2.Location = new Point(31, 516);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(136, 68);
            button2.TabIndex = 1;
            button2.Text = "Склад";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(557, 516);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(136, 68);
            button3.TabIndex = 2;
            button3.Text = "Завершить смену";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(714, 600);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(groupBox1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Shop";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button button1;
        private Label label1;
        private NumericUpDown numericUpDown1;
        private ComboBox comboBox1;
        private Label label3;
        private Label label2;
        private CheckedListBox checkedListBox1;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}
