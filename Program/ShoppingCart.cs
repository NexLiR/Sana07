using System;

namespace Sana07
{
    public class ShoppingCart
    {
        protected List<Product> products;
        public void addToShoppingCart(Product product)
        {
            products.Add(product);
        }
        public void removeFromShoppingCart(Product product)
        {
            products.Remove(product);
        }
        public void showShoppingCart()
        {
            foreach (Product product in products)
            {
                product.Display();
            }
        }
        public float calcilateTotalPrice()
        {
            float totalPrice = 0;
            foreach (Product product in products)
            {
                totalPrice += product.Price;
            }
            return totalPrice;
        }
    }
}
