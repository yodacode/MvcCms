using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace MvcCms.Models
{
    public class Page
    {
        [ScaffoldColumn(false)]
        public int PageId { get; set; }
        [DisplayName("Auteur")]
        public int AuthorId { get; set; }
        [Required(ErrorMessage = "Un titre pour le post est requis")]
        [StringLength(160)]
        public string Title { get; set; }
        [DisplayName("Date")]
        [Required(ErrorMessage = "La date est requise")]
        public DateTime Date { get; set; }
        [Required(ErrorMessage = "Vous devez renseigner un contenu")]
        public string Content { get; set; }
        public Author Author { get; set; }
        public bool Online { get; set; }
    }
}