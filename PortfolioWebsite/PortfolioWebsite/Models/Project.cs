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

        [DisplayName("Title")]
        [Required]
        [StringLength(30)]
        public string Title { get; set; }

        [DisplayName("Description")]
        public string Description { get; set; }

        [DisplayName("Images")]
        public string[] Images { get; set; }

        //========== Test ==========//
        public string ImagePath { get; set; }

        [NotMapped]
        public HttpPostedFileBase ImageFile { get; set; }
    }
}