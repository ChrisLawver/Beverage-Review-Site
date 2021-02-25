using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;


namespace ReviewsSite.Models
{
    public class Bev
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public string Category { get; set; }
        public string Review { get; set; }

        //public List<Bev> BevList { get; set; }

        public Bev()
        {

        }

        public Bev(int id , string description, string name, string category, string review, string image)
        {
            Id = id;
            Description = description;
            Name = name;
            Image = image;
            Category = category;
            Review = review;
        }
    }
}
