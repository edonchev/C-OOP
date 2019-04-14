using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Problem_2_Book_Shop
{
    public class Book
    {
        private string author;
        private string title;
        private decimal price;

        public Book(string author, string title, decimal price)
        {
            Author = author;
            Title = title;
            Price = price;
        }
        
        public string Author
        {
            get
            {
                return author;
            }
            protected set
            {
                string[] names = value.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                if (names.Length > 1)
                {
                    if (char.IsDigit(names[1][0]))
                    {
                        throw new ArgumentException("Author not valid!");
                    }
                }
                author = value;
            }
        }

        public string Title
        {
            get
            {
                return title;
            }
            protected set
            {
                if (value.Length < 3)
                {
                    throw new ArgumentException("Title not valid!");
                }
                title = value;
            }
        }
        public virtual decimal Price
        {
            get
            {
                return price;
            }
            protected set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Price not valid!");
                }
                price = value;
            }
        }

        public override string ToString()
        {
            var resultBuilder = new StringBuilder();
            resultBuilder.AppendLine($"Type: {this.GetType().Name}")
                .AppendLine($"Title: {this.Title}")
                .AppendLine($"Author: {this.Author}")
                .AppendLine($"Price: {this.Price:F2}");
            return resultBuilder.ToString();
        }
    }
}
