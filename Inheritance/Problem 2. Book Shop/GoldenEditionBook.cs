using System;
using System.Collections.Generic;
using System.Text;

namespace Problem_2_Book_Shop
{
    class GoldenEditionBook : Book
    {
        public GoldenEditionBook(string author, string title, decimal price) : base(author, title, price)
        {

        }

        public override decimal Price
        {
            get => base.Price * 1.3m;
        }
    }
}
