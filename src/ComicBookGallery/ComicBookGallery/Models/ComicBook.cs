using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ComicBookGallery.Models
{
    public class ComicBook
    {
        public int Id { get; set; }
        public string SeriresTtile { get; set; }
        public int IssueNumber { get; set; }
        public string DescriptionHtml { get; set; }
        public Artist [] Artists { get; set; }
        public bool Favorite { get; set; }

        public string DisplayText
        {
            get
            {
                return SeriresTtile + "#" + IssueNumber;
            }
        }
        //series-title-issuenumber.jpg
        public string CoverImageFileName
        {
            get
            {
                return SeriresTtile.Replace(" ", "-").ToLower() + "-" + IssueNumber+".jpg";
            }
        }
    }
}