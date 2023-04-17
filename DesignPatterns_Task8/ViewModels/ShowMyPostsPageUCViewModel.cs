using DesignPatterns_Task8.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns_Task8.ViewModels
{
    public class ShowMyPostsPageUCViewModel : BaseViewModel
    {
        public RelayCommand BackCommand { get; set; }

        public ShowMyPostsPageUCViewModel()
        {
            BackCommand = new RelayCommand((b) =>
            {
                App.MyGrid.Children.RemoveAt(0);
                App.MyGrid.Children.Add(App.YoutuberView);
            });
        }
    }
}
