using System;

namespace praca_domowa_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Basket basket = new Basket(0, 0.0);
            Menu menu = new Menu();

            Console.Clear();
            menu.ShowMenu(basket.capacity);
            int choice = Convert.ToInt32(Console.ReadLine());

            while(choice != 6)
            {
                if (choice == 7)
                {
                    Console.WriteLine("Wybierz produkt do usunięcia:");
                    int deleteChoice = Convert.ToInt32(Console.ReadLine());
                    basket.RemoveProduct(deleteChoice);

                    Console.Clear();
                    basket.ShowProducts();
                    basket.ShowTotalCost();
                    menu.ShowMenu(basket.capacity);
                    choice = Convert.ToInt32(Console.ReadLine());
                }

                Product selectedProduct = menu.ChooseProduct(choice);

                basket.AddProduct(selectedProduct);

                Console.Clear();
                basket.ShowProducts();
                basket.ShowTotalCost();
                menu.ShowMenu(basket.capacity);
                choice = Convert.ToInt32(Console.ReadLine());
            }

            basket.ShowTotalCost();
        }
    }
}
