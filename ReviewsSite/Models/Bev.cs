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

        public Bev()
        {

        }

        public Bev(int id , string description)
        {
            Id = id;
            Description = description;
        }
    }
}
