using System;

namespace praca_domowa_5
{
    public class Menu
    {
        string name;
        Product[] products;

        public Menu()
        {
            this.name = "Food Hall";
            this.products = new Product[] {
                new Product("Sushi", 33.59),
                new Product("Ramen", 31.50),
                new Product("Zielona herbata", 12.39),
                new Product("Hummus", 17.29),
                new Product("Vege burger", 29.99)
            };
        }

        public void ShowMenu(int capacity)
        {
            if (capacity > 0) {
                Console.WriteLine("Czy chcesz jeszcze coś zamówić?");
            } else {
                Console.WriteLine("Witamy w " + this.name + ", co podać?");
            }
            
            for(int i = 0; i < 5; i++) 
            {
                Console.WriteLine((i+1) + ". " + this.products[i].name + " - " + this.products[i].price + " zł.");
            }
            Console.WriteLine("6. Koniec zamówienia");
            Console.WriteLine("7. Usuń z zamówienia");
        }

        public Product ChooseProduct(int choice)
        {
            if (choice <= 0 || choice >= 8)
            {
                Console.WriteLine("Takiej pozycji raczej nie mamy w Menju, joł");
                return null;
            }

            return this.products[--choice];
        }
    }
}