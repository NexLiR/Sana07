using System;

namespace Sana07
{
    public class ShoppingCart
    {
        protected List<Product> products;
        public ShoppingCart()
        {
            products = new List<Product>();
        }
        public void addToShoppingCart(Product product)
        {
            products.Add(product);
        }
        public void removeFromShoppingCart(Product product)
        {
            products.Remove(product);
        }
        public List<string> showShoppingCart()
        {
            List<string> productsInfo = new List<string>();
            foreach (Product product in products)
            {
                productsInfo.Add(product.Display());
            }
            return productsInfo;
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
