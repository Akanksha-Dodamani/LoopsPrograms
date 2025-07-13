using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopsProgram
{
    public class Book
    {
        public string Title, Author;
        public double Price;
        public bool IsBestSeller;

        public Book(string title, string author, double price, bool isBestSeller)
        {
            Title = title;
            Author = author;
            Price = price;
            IsBestSeller = isBestSeller;
        }

        public double CalculateDiscountedPrice()
        {
            double discountedPrice = Price;

            if (IsBestSeller)
            {
                discountedPrice *= 0.90;  // Apply 10% off
            }

            if (Price >= 500)
            {
                discountedPrice *= 0.95;  // Apply additional 5% off
            }

            return discountedPrice;
        }
        public override string ToString()
        {
            string result = $"Title: {Title}\nAuthor: {Author}\nOriginal Price: ${Price}\n";

            if (IsBestSeller)
                result += $"'{Title}' is a bestseller. Applying 10% discount.\n";

            if (Price >= 500)
                result += $"'{Title}' is priced over 500. Applying additional 5% discount.\n";

            result += $"Final Discounted Price: ${CalculateDiscountedPrice()}";

            return result;
        }
    }
}
