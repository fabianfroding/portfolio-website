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
        public Project()
        {
            Images = new List<string>();
            ImageFiles = new List<HttpPostedFileBase>();
        }
        
        public int Id { get; set; }

        [DisplayName("Title")]
        [Required]
        [StringLength(30)]
        public string Title { get; set; }

        [DisplayName("Description")]
        public string Description { get; set; }

        [DisplayName("Images")]
        [NotMapped]
        public List<string> Images { get; set; }

        public string ImagesAsString {
            get { return string.Join(",", Images); }
            set { Images = value.Split(',').ToList(); } 
        }

        [NotMapped]
        public List<HttpPostedFileBase> ImageFiles { get; set; }

    }
}