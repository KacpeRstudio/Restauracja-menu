using System;
using System.Collections.Generic;

namespace praca_domowa_5
{
    public class Basket
    {
        public int capacity;
        double cost;
        List<Product> selectedProducts;

        public Basket(int cap, double cost1)
        {
            this.capacity = cap;
            this.cost = cost1;
            this.selectedProducts = new List<Product>();
        }

        public void ShowTotalCost() 
        {
            Console.WriteLine("Wartość w koszyku: " + this.cost + " zł.");
        }

        public void AddProduct(Product selectedProduct)
        {
            this.selectedProducts.Add(selectedProduct);
            this.capacity++;
            this.cost += selectedProduct.price;
        }

        public void RemoveProduct(int deletedChoice) 
        {
            Product deletedProduct = this.selectedProducts[--deletedChoice];
            this.capacity--;
            this.cost -= deletedProduct.price;
            
            this.selectedProducts.RemoveAt(deletedChoice);
        }

        public void ShowProducts()
        {
            Console.WriteLine("Wybrane produkty: ");
            for (int i = 0; i < this.selectedProducts.Count; i++)
            {
                Console.WriteLine((i+1) + ". " + this.selectedProducts[i].name + " - " + this.selectedProducts[i].price);
            }
        }
    }
}