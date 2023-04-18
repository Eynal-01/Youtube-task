using DesignPatterns_Task8.Commands;
using DesignPatterns_Task8.Models;
using DesignPatterns_Task8.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace DesignPatterns_Task8.ViewModels
{
    public class SignInUCViewModel : BaseViewModel
    {
        public RelayCommand BackCommand { get; set; }
        public RelayCommand SignInCommand { get; set; }

        public string Username { get; set; } 
        public PasswordBox PasswordBox { get; set; }

        public SignInUCViewModel()
        {
            BackCommand = new RelayCommand((b) =>
            {
                App.MyGrid.Children.RemoveAt(0);
                App.MyGrid.Children.Add(App.HomePage);
            });

            SignInCommand = new RelayCommand((s) =>
            {
                var subscribers = App.Youtuber.GetSubscribers();
                int count = subscribers.Count;
                for (int x = 0; x < count; x++)
                {
                    if (subscribers[x] is Subscriber sub)
                    {
                        if (sub.Username == Username)
                        {
                            if (sub.Password == PasswordBox.Password)
                            {
                                App.Youtuber.Notify();
                                App.MyGrid.Children.RemoveAt(0);
                                var subscriberView = new SubscriberPageUC();
                                var subscriberViewModel = new SubscriberPageUCViewModel(App.Youtuber.GetSubscribers()[x] as Subscriber);
                                subscriberView.DataContext = subscriberViewModel;
                                App.MyGrid.Children.Add(subscriberView);
                                return;
                            }
                        }
                    }
                }
                MessageBox.Show("Please, enter valid informations!");
            });
        }
    }
}