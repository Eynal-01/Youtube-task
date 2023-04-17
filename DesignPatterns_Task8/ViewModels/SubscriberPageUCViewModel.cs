using DesignPatterns_Task8.Commands;
using DesignPatterns_Task8.Models;
using DesignPatterns_Task8.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace DesignPatterns_Task8.ViewModels
{
    public class SubscriberPageUCViewModel : BaseViewModel
    {
        public RelayCommand BackCommand { get; set; }

        private List<PostUC> posts = new List<PostUC>();

        public List<PostUC> Posts
        {
            get { return posts; }
            set { posts = value; OnPropertyChanged(); }
        }

        public SubscriberPageUCViewModel(Subscriber sub)
        {
            foreach (var post in sub.Posts)
            {
                Posts.Add(Helper.GetPostView(post));
            }

            BackCommand = new RelayCommand((b) =>
            {
                App.MyGrid.Children.RemoveAt(0);
                App.MyGrid.Children.Add(App.HomePage);
            });
        }
    }
}
