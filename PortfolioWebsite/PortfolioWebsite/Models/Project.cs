using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web;

namespace PortfolioWebsite.Models
{
    public class Project
    {
        public Project()
        {
            Images = new List<string>();
        }
        
        public int Id { get; set; }

        [DisplayName("Title")]
        [Required]
        [StringLength(30)]
        public string Title { get; set; }

        [DisplayName("Description")]
        public string Description { get; set; }

        [DisplayName("Images")]
        public List<string> Images { get; set; }

        //========== Test ==========//
        public string ImagePath { get; set; }

        [NotMapped]
        public HttpPostedFileBase ImageFile { get; set; }
    }
}