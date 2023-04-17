using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace DesignPatterns_Task8.ViewModels
{
    public class PostUCViewModel : BaseViewModel
    {
        public ImageSource ImageSource{ get; set; }
        public string Text { get; set; }
    }
}
