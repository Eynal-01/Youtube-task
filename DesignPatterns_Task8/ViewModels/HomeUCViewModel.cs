using DesignPatterns_Task8.Commands;
using DesignPatterns_Task8.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns_Task8.ViewModels
{
    public class HomeUCViewModel : BaseViewModel
    {
        public RelayCommand YoutuberCommand { get; set; }
        public RelayCommand SubscriberCommand { get; set; }

        public HomeUCViewModel()
        {
            YoutuberCommand = new RelayCommand((y) => 
            {
                App.MyGrid.Children.RemoveAt(0);
                var youtuberView = new YoutuberPageUC();
                var youtuberViewModel = new YoutuberPageUCViewModel();
                youtuberView.DataContext = youtuberViewModel;
                App.YoutuberView = youtuberView;
                App.MyGrid.Children.Add(youtuberView);
            });

            SubscriberCommand = new RelayCommand((s) => 
            {
                App.MyGrid.Children.RemoveAt(0);
                var signInView = new SignInUC();
                var signInViewModel = new SignInUCViewModel();
                signInView.DataContext = signInViewModel;
                signInViewModel.PasswordBox = signInView.passwordBox;
                App.MyGrid.Children.Add(signInView);
            });
        }
    }
}

