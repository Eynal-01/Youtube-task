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
    public class YoutuberPageUCViewModel : BaseViewModel
    {
        public RelayCommand BackCommand { get; set; }
        public RelayCommand ShowSubscribersCommand { get; set; }
        public RelayCommand AddNewPostCommand { get; set; }
        public RelayCommand ShowMyPostsCommand { get; set; }

        public YoutuberPageUCViewModel()
        {
            BackCommand = new RelayCommand((b) =>
            {
                App.MyGrid.Children.RemoveAt(0);
                App.MyGrid.Children.Add(App.HomePage);
            });

            ShowSubscribersCommand = new RelayCommand((b) =>
            {
                App.MyGrid.Children.RemoveAt(0);
                var showSubscribersPageView = new ShowSubscribersPageUC();
                var showSubscribersPageViewModel = new ShowSubscribersPageUCViewModel();
                showSubscribersPageView.DataContext = showSubscribersPageViewModel;
                showSubscribersPageViewModel.Subscribers = App.Youtuber.GetSubscribers();
                App.MyGrid.Children.Add(showSubscribersPageView);
            });

            AddNewPostCommand = new RelayCommand((a) =>
            {
                App.MyGrid.Children.RemoveAt(0);
                var addNewPostPageView = new AddNewPostPageUC();
                var addNewPostPageViewModel = new AddNewPostPageUCViewModel();
                addNewPostPageView.DataContext = addNewPostPageViewModel;
                App.MyGrid.Children.Add(addNewPostPageView);
            });

            ShowMyPostsCommand = new RelayCommand((s) =>
            {
                App.MyGrid.Children.RemoveAt(0);
                var showMyPostsView = new ShowMyPostsPageUC();
                var showMyPostsViewModel = new ShowMyPostsPageUCViewModel();
                showMyPostsView.DataContext = showMyPostsViewModel;

                foreach (var post in App.Youtuber.Posts)
                {
                    showMyPostsView.PostLB.Items.Add(Helper.GetPostView(post));
                }

                App.MyGrid.Children.Add(showMyPostsView);

            });
        }
    }
}
