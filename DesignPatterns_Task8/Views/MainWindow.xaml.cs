using DesignPatterns_Task8.Models;
using DesignPatterns_Task8.ViewModels;
using DesignPatterns_Task8.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DesignPatterns_Task8
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            App.MyGrid = MyGrid;
            var homeView = new HomeUC();
            var homeViewModel = new HomeUCViewModel();
            homeView.DataContext = homeViewModel;
            App.MyGrid.Children.Add(homeView);
            App.HomePage = homeView;

            var sub1 = new Subscriber("John", "john123");
            var sub2 = new Subscriber("Tural", "tural123");
            var sub3 = new Subscriber("Memmed", "memmed123");
            var sub4 = new Subscriber("Max", "max123");
            App.Youtuber.Attach(sub1);
            App.Youtuber.Attach(sub2);
            App.Youtuber.Attach(sub3);
            App.Youtuber.Attach(sub4);

            BitmapImage myBitmapImage1 = new BitmapImage(new Uri(@"\Images\post1.jpeg", UriKind.Relative));
            myBitmapImage1.CacheOption = BitmapCacheOption.OnLoad;

            BitmapImage myBitmapImage2 = new BitmapImage(new Uri(@"\Images\post2.jpeg", UriKind.Relative));
            myBitmapImage2.CacheOption = BitmapCacheOption.OnLoad;

            BitmapImage myBitmapImage3 = new BitmapImage(new Uri(@"\Images\post3.jpeg", UriKind.Relative));
            myBitmapImage3.CacheOption = BitmapCacheOption.OnLoad;

            BitmapImage myBitmapImage4 = new BitmapImage(new Uri(@"\Images\post4.jpeg", UriKind.Relative));
            myBitmapImage4.CacheOption = BitmapCacheOption.OnLoad;

            BitmapImage myBitmapImage5 = new BitmapImage(new Uri(@"\Images\post5.jpeg", UriKind.Relative));
            myBitmapImage5.CacheOption = BitmapCacheOption.OnLoad;

            BitmapImage myBitmapImage6 = new BitmapImage(new Uri(@"\Images\post6.jpeg", UriKind.Relative));
            myBitmapImage6.CacheOption = BitmapCacheOption.OnLoad;

            BitmapImage myBitmapImage7 = new BitmapImage(new Uri(@"\Images\post7.jpeg", UriKind.Relative));
            myBitmapImage7.CacheOption = BitmapCacheOption.OnLoad;

            Post p1 = new Post("Nice Mountains!", myBitmapImage1);
            Post p2 = new Post("Nice Cat!", myBitmapImage2);
            Post p3 = new Post("Nice Dog!", myBitmapImage3);
            Post p4 = new Post("Nice View!", myBitmapImage4);
            Post p5 = new Post("Nice View Again!", myBitmapImage5);
            Post p6 = new Post("Nice Sea!", myBitmapImage6);
            Post p7 = new Post("Nice Gorilla!", myBitmapImage7);

            App.Youtuber.Posts.Add(p1);
            App.Youtuber.Posts.Add(p2);
            App.Youtuber.Posts.Add(p3);
            App.Youtuber.Posts.Add(p4);
            App.Youtuber.Posts.Add(p5);
            App.Youtuber.Posts.Add(p6);
            App.Youtuber.Posts.Add(p7);
        }
    }
}
