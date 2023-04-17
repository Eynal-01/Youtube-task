using DesignPatterns_Task8.Commands;
using DesignPatterns_Task8.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns_Task8.ViewModels
{
    public class ShowSubscribersPageUCViewModel : BaseViewModel
    {
        public RelayCommand BackCommand { get; set; }

        private List<IObserver> subscribers;

        public List<IObserver> Subscribers
        {
            get { return subscribers; }
            set { subscribers = value; OnPropertyChanged(); }
        }

        public ShowSubscribersPageUCViewModel()
        {
            BackCommand = new RelayCommand((b) =>
            {
                App.MyGrid.Children.RemoveAt(0);
                App.MyGrid.Children.Add(App.YoutuberView);
            });
        }
    }
}
