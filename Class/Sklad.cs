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

            new Tovar("Коровка",155,0.2),
            new Tovar("Золотая Лилия",249,0.158 ),
            new Tovar("Мишка в лесу",120,0.125)
        };


        

    }

      
}
