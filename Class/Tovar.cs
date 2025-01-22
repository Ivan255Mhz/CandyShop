using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandyShop.Class
{
    public class Tovar
    {
        public string Name { get; set; }

        public decimal Prise { get; set; }

        public string Manufacturer { get; set; }

        public double Weight { get; set; }

        public Tovar() { }

        public Tovar(string name, decimal prise, string manufacturer, double weight)
        {
            Name = name;
            Prise = prise;
            Manufacturer = manufacturer;
            Weight = weight;
        }

        public Tovar(string name, decimal prise, double weight)
        {
            Name = name;
            Prise = prise;
            Weight = weight;
        }

        private string ManuFact()
        {
            if (Manufacturer == null)
            {
                return "Нет производителя";
            }

            return Manufacturer;
        }

        public override string ToString()
        {
            var temp = "Нет производителя";
            return $"Название: {Name}, Производитель: {ManuFact()}, Цена: {Prise} за кг.";
        }
    }
}
