using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace DesignPatterns_Task8.Models
{
    public class Post
    {
        public Post(string title, ImageSource imageSource)
        {
            Title = title;
            ImageSource = imageSource;
        }

        public string Title { get; set; }
        public ImageSource ImageSource { get; set; }
    }
}
