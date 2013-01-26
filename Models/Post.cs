using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace MvcCms.Models
{
    public class Post
    {
        [ScaffoldColumn(false)]
        public int PostId { get; set; }
        
        [DisplayName("Tag")]
        public int TagId { get; set; }
       
        //[DisplayName("Auteur")]
        //public int AuthorId { get; set; }
        
        [Required(ErrorMessage = "Vous devez renseigner un titre")]
        public string Author { get; set; }

        //[DisplayName("Key")]
        //public int KeyId { get; set; }
        [Required(ErrorMessage = "Vous devez renseigner un titre")]
        [StringLength(160)]
        public string Title { get; set; }
        
        [StringLength(50)]
        public string Slug { get; set; }
        
        [DisplayName("Date")]
        public DateTime Date { get; set; }

        public string Month { get; set; }

        public string Year { get; set; }

        [Required(ErrorMessage = "Vous devez renseigner un contenu")]
        public string Content { get; set; }

        //public virtual ICollection<Key> Keys { get; set; }

        public Tag Tag { get; set; }
        
        //public Author Author { get; set; }

        public bool Online { get; set; }


       
    }
}
