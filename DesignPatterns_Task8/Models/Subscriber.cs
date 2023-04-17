using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns_Task8.Models
{
    public class Subscriber : IObserver
    {
        public Subscriber(string username, string password)
        {
            Username = username;
            Password = password;
        }

        public string Username { get; set; }
        public string Password { get; set; }

        public List<Post> Posts { get; set; }

        public void Update()
        {
            Posts = App.Youtuber.Posts;
        }
    }
}
