using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandyShop.Class
{
    public static class Sklad
    {

        public static List<Tovar> GetTovars()
        {
            return Tovars;
        }


        public static List<Tovar> Tovars = new List<Tovar>
        {

           new Tovar("Коровка", 155m, 0.2),
           new Tovar("Золотая Лилия", 249m, 0.158),
           new Tovar("Мишка в лесу", 120m, 0.125),
           new Tovar("Шоколадный фонтан", 199m, 0.3),
           new Tovar("Малиновый рай", 179m, 0.25),
           new Tovar("Карамельная вишня", 135m, 0.18),
           new Tovar("Сливочный облако", 165m, 0.22),
           new Tovar("Ореховая феерия", 225m, 0.28),
           new Tovar("Цитрусовый взрыв", 145m, 0.17),
           new Tovar("Ванильная мечта", 155m, 0.19),
           new Tovar("Кофейный бриз", 189m, 0.23),
           new Tovar("Клубничная поляна", 169m, 0.21),
           new Tovar("Фисташковый рай", 239m, 0.12),
           new Tovar("Мятное свечение", 129m, 0.14)
        };




    }


}
