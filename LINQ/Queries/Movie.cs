using System;
using System.Collections.Generic;
using System.Text;

namespace Queries
{
    public class Movie
    {
        public string Title{ get; set; }
        public float Rating { get; set; }

        int year;
        public int Year
        {
            get
            {
                Console.WriteLine($"Returning {year} for {Title}");
                return year;
            }
            set
            {
                year = value;
            }
        }
    }
}
