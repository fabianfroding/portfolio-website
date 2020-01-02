using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PortfolioWebsite.Models
{
    public class Project
    {
        public int Id { get; set; }
        [Required]
        [StringLength(30)]
        public string Title { get; set; }
        public string Description { get; set; }
        [DisplayName("Upload file")]
        public string[] Images { get; set; }
        [NotMapped]
        public HttpPostedFileBase CoverImageFile { get; set; }
    }
}