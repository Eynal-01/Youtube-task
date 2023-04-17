using DesignPatterns_Task8.Models;
using DesignPatterns_Task8.Views;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace DesignPatterns_Task8
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static Grid MyGrid { get; set; }
        public static HomeUC HomePage { get; set; }
        public static Youtuber Youtuber { get; set; } = new Youtuber();
        public static YoutuberPageUC YoutuberView { get; internal set; }
    }
}
