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
            groupBox1.Location = new Point(12, 31);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(594, 340);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Касса";
            // 
            // button4
            // 
            button4.Location = new Point(200, 278);
            button4.Name = "button4";
            button4.Size = new Size(145, 23);
            button4.TabIndex = 7;
            button4.Text = "Выдать чек";
            button4.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(549, 278);
            label3.Name = "label3";
            label3.Size = new Size(17, 15);
            label3.TabIndex = 6;
            label3.Text = "р.";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.Location = new Point(511, 272);
            label2.Name = "label2";
            label2.Size = new Size(32, 21);
            label2.TabIndex = 5;
            label2.Text = "0,0";
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Location = new Point(15, 89);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(528, 166);
            checkedListBox1.TabIndex = 4;
            // 
            // button1
            // 
            button1.Location = new Point(200, 51);
            button1.Name = "button1";
            button1.Size = new Size(145, 23);
            button1.TabIndex = 3;
            button1.Text = "Добавить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(549, 31);
            label1.Name = "label1";
            label1.Size = new Size(21, 15);
            label1.TabIndex = 2;
            label1.Text = "кг.";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(484, 23);
            numericUpDown1.Maximum = new decimal(new int[] { 250, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(59, 23);
            numericUpDown1.TabIndex = 1;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
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
            comboBox1.Items.AddRange(new object[] { tovar1, tovar2, tovar3 });
            comboBox1.Location = new Point(15, 22);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(463, 23);
            comboBox1.TabIndex = 0;
            // 
            // button2
            // 
            button2.Location = new Point(27, 387);
            button2.Name = "button2";
            button2.Size = new Size(119, 51);
            button2.TabIndex = 1;
            button2.Text = "Склад";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(487, 387);
            button3.Name = "button3";
            button3.Size = new Size(119, 51);
            button3.TabIndex = 2;
            button3.Text = "Завершить смену";
            button3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(625, 450);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(groupBox1);
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
