using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;

namespace FAQ.Models
{
    public class FAQDB : DbContext
    {

        public FAQDB()
            : base("name=FAQDB")
        {
        }

        public DbSet<Questions> Questions { get; set; }
        public DbSet<Categories> Categories { get; set; }


    }

    public class Questions
    {
        [Key]
        public int Id { get; set; }
        public int Categoryid { get; set; }
        public Categories Category { get; set; }
        public DateTime Date { get; set; }
        public String Question { get; set; }
        public String Answer { get; set; }
        public bool Isfequant { get; set; }
        public String email { get; set; }
    }

    public class Categories
    {
        [Key]
        public int CategoryId { get; set; }
        public String Category { get; set; }

        public List<Questions> Question { get; set; }
    }


}