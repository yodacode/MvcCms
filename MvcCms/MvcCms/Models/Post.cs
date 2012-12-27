using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcCms.Models
{
    public class Post
    {
        public int PostId { get; set; }
        public int TagId { get; set; }
        public int AuthorId { get; set; }
        public string Title { get; set; }
        public decimal Price { get; set; }
        public string AlbumArtUrl { get; set; }
        public Tag Tag { get; set; }
        public Author Author { get; set; }
    }
}
