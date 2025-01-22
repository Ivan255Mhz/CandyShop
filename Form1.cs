using CandyShop.Class;

namespace CandyShop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Product_before__payment temp = new Product_before__payment(numericUpDown1.Value, comboBox1.SelectedItem as Tovar);
            checkedListBox1.Items.Add(temp.ToString());
        }
    }
}
