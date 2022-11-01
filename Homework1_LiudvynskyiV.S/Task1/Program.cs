// See https://aka.ms/new-console-template for more information

using Task1.Models;

namespace Task1
{
    public static class Program
    {// Вітаю. Все доступно.
        public static void Main()
        {// Окремо мав бути клас Product. І окремо сутність, яка вказує скільки одиниць товару взяли.
            var product1 = new Product(1, "Banana", 2.50m, 1.25);
            var product2 = new Product(2, "Bread", 1.50m, 0.5);
            var product3 = new Product(3, "Eggs", 0.50m, 1);
            var product4 = new Product(4, "Pizza", 8m, 2);
// Краще, коли масив огорнений класом.
            var buy = new Buy(new [] {product1, product2, product1, product3, product4, product3, product2, product1});

            var check = new Check(buy);
            check.CheckOut();
        }
    }
}
