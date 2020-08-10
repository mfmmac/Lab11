using System;
using System.Collections.Generic;
using System.Text;

namespace Lab11
{
    public class Movie
    {
         public string title;

        public string category;

    public Movie(string title, string category)
        {
            this.title = title;
            this.category = category;
        }
        public string Title
        {
            get { return title; }
        }
        public string Category
        {
            get { return category; }
        }
    }
}
