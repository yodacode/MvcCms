using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcCms.Models
{
    public class Author
    {
        public int AuthorId { get; set; }
        public string Name { get; set; }
        public List<Post> Posts { get; set; }
        public List<Post> Tests { get; set; }
    }
}