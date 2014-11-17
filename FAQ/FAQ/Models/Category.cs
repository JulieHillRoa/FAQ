using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FAQ.Models
{
    public class Category
    {
        public int categoryID { get; set; }
        public String category { get; set; }
        public List<Question> questionlist {get; set;}


    }
}