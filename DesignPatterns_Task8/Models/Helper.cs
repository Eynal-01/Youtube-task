using DesignPatterns_Task8.ViewModels;
using DesignPatterns_Task8.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace DesignPatterns_Task8.Models
{
    public class Helper
    {
        public static PostUC GetPostView(Post post)
        {
            var postView = new PostUC();
            var postViewModel = new PostUCViewModel();
            postView.DataContext = postViewModel;

            BitmapImage myBitmapImage = new BitmapImage(new Uri($@"..\..\{post.ImageSource}", UriKind.Relative)); // bin/O

            if (myBitmapImage.ToString().Contains("C:/Users/"))
            {
                myBitmapImage = new BitmapImage(new Uri($@"{post.ImageSource.ToString().Replace(@"file:///", "")}", UriKind.Relative)); ;
            }
            myBitmapImage.CacheOption = BitmapCacheOption.OnLoad;

            postViewModel.ImageSource = myBitmapImage;
            postViewModel.Text = post.Title;
            return postView;
        }
    }
}
