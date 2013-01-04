using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcCms.Models
{
    public class Tag
    {
        public int TagId { get; set; }
        public string Name { get; set; }
        public List<Post> Posts { get; set; }
    }

}