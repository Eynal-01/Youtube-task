using DesignPatterns_Task8.Commands;
using DesignPatterns_Task8.Models;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace DesignPatterns_Task8.ViewModels
{
    public class AddNewPostPageUCViewModel : BaseViewModel
    {
        public RelayCommand AddCommand { get; set; }
        public RelayCommand BackCommand { get; set; }
        public RelayCommand SaveCommand { get; set; }
        public RelayCommand FromFileCommand { get; set; }

        private ImageSource imageSource;

        public ImageSource ImageSource
        {
            get { return imageSource; }
            set { imageSource = value; OnPropertyChanged(); }
        }

        private string text = String.Empty;

        public string Text
        {
            get { return text; }
            set { text = value; OnPropertyChanged(); }
        }


        public AddNewPostPageUCViewModel()
        {
            AddCommand = new RelayCommand((a) => 
            { 
                
            });

            BackCommand = new RelayCommand((b) =>
            {
                App.MyGrid.Children.RemoveAt(0);
                App.MyGrid.Children.Add(App.YoutuberView);
            });

            FromFileCommand = new RelayCommand((f) =>
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                if (openFileDialog.ShowDialog() == true)
                {
                    Uri fileUri = new Uri(openFileDialog.FileName);
                    ImageSource = new BitmapImage(fileUri);
                }
            });

            SaveCommand = new RelayCommand((s) => 
            {
                if (Text.Trim() == string.Empty)
                {
                    MessageBox.Show("Please, enter a title");
                    return;
                }

                if (ImageSource == null)
                {
                    MessageBox.Show("Please, load a picture");
                    return;
                }

                Post post = new Post(Text, ImageSource);
                App.Youtuber.Posts.Add(post);
                MessageBox.Show("Post was added successfully!");
                App.Youtuber.Notify();
                BackCommand.Execute(null);
            });
        }
    }
}
