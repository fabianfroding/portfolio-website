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

        // Returns a string of all image filenames combined
        // and adds a comma between each.
        public string ImagesToString()
        {
            string result = "";
            
            foreach (var image in Images)
            {
                // Only add comma if current item is not the last item in the list.
                // To prevent a comme at the end of the combined string.
                if (Images.IndexOf(image) == Images.Count - 1)
                {
                    result += image;
                }
                else
                {
                    result += image + ",";
                }
            }
            return result;
        }

        //========== Test ==========//
        public string ImagePath { get; set; }

        [NotMapped]
        public HttpPostedFileBase ImageFile { get; set; }
    }
}