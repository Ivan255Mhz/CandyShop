using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandyShop.Class
{
    public class ShiftReport
    {

        private static int _clientsCount;
        private static decimal _totalRevenue;
        private static readonly List<string> Receipts = new List<string>();

        
        public static void AddReceipt(StringBuilder receiptContent, decimal receiptTotal)
        {
            _clientsCount++;
            _totalRevenue += receiptTotal;
            Receipts.Add(receiptContent.ToString());
        }

        
        public static void SaveAndReset(string filePath)
        {
            try
            {
                var reportContent = new StringBuilder();

                
                reportContent.AppendLine($"Отчет за смену {DateTime.Now:dd.MM.yyyy}");
                reportContent.AppendLine("========================================");

                
                foreach (var receipt in Receipts)
                {
                    reportContent.AppendLine(receipt);
                    reportContent.AppendLine("----------------------------------------");
                }

                
                reportContent.AppendLine($"1. Количество клиентов: {_clientsCount}");
                reportContent.AppendLine($"2. Общая выручка: {_totalRevenue:N2}₽");
                reportContent.AppendLine("========================================");

               
                File.WriteAllText(filePath, reportContent.ToString(), Encoding.UTF8);

                
                Reset();

                
                Process.Start(new ProcessStartInfo(filePath) { UseShellExecute = true });
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при сохранении отчета: {ex.Message}");
            }
        }

        
        private static void Reset()
        {
            _clientsCount = 0;
            _totalRevenue = 0;
            Receipts.Clear();
        }

    }
}
