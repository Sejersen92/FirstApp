using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace HelloWorld.Models
{
    public class Lists
    {
        public int ID { get; set; }
        public string Title { get; set; }

        [Display(Name = "Release Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:d}", ApplyFormatInEditMode = true)]

        public DateTime ReleaseDate { get; set; }
        public string Genre { get; set; }
        public decimal Price { get => price; set => price = decimal.Parse(value.ToString()); }

        private decimal price;
    }

    public class ListDBContext : DbContext
    {
        public DbSet<Lists> Lists { get; set; }
    }
}