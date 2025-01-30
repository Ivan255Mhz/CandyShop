using CandyShop.Class;
using System;
using System.Diagnostics;
using System.Text;

namespace CandyShop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            checkedListBox1.ItemCheck += checkedListBox1_ItemCheck;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Product_before__payment temp = new Product_before__payment(numericUpDown1.Value, comboBox1.SelectedItem as Tovar);
            checkedListBox1.Items.Add(temp);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_ItemCheck(object sender, ItemCheckEventArgs e)
        {


            bool isChecked = (e.NewValue == CheckState.Checked);

            decimal total = 0;


            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                if (i == e.Index)
                {

                    if (isChecked && checkedListBox1.Items[i] is Product_before__payment product)
                    {
                        total += (product.cout * product.tovar.Prise);
                    }
                }
                else
                {

                    if (checkedListBox1.GetItemChecked(i) &&
                        checkedListBox1.Items[i] is Product_before__payment product)
                    {
                        total += (product.cout * product.tovar.Prise);
                    }
                }
            }

            label2.Text = total.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            var selectedProducts = checkedListBox1.CheckedItems
                .Cast<Product_before__payment>()
                .ToList();

            if (selectedProducts.Count == 0)
            {
                MessageBox.Show("Нет выбранных товаров для чека!");
                return;
            }

            
            var receiptContent = new StringBuilder();

            
            receiptContent.AppendLine($"Чек от {DateTime.Now:yyyy-MM-dd HH:mm:ss}");
            receiptContent.AppendLine("----------------------------------------");

            
            foreach (var product in selectedProducts)
            {
                receiptContent.AppendLine($"{product.tovar.Name} - {product.cout} кг × {product.tovar.Prise}₽ = {(product.tovar.Prise*product.cout)}₽");
            }

            
            receiptContent.AppendLine("----------------------------------------");
            receiptContent.AppendLine($"ИТОГО: {selectedProducts.Sum(p => p.total)}₽");

            
            try
            {
                
                string fileName = $"Чек_{DateTime.Now:yyyyMMdd_HHmmss}.txt";
                string documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                string fullPath = Path.Combine(documentsPath, fileName);

                
                File.WriteAllText(fullPath, receiptContent.ToString(), Encoding.UTF8);

                
                Process.Start(new ProcessStartInfo
                {
                    FileName = fullPath,
                    UseShellExecute = true
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при сохранении чека: {ex.Message}");
            }
        }
    }




}
