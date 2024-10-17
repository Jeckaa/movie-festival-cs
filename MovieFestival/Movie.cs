using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieFestival
{
    public class Movie
    {
        public string Title { get; set; }
        public string Genre { get; set; }
        public string Length { get; set; }

        public Movie(string title, string genre, string length)
        {
            Title = title;
            Genre = genre;
            Length = length;
        }

        public string GetData() => $"{Title} {Genre} {Length}";
    }
}
