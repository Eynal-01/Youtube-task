using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace DesignPatterns_Task8.Models
{
    public class Youtuber : ISubject
    {
        private List<IObserver> Observers { get; set; } = new List<IObserver>();

        public List<Post> Posts { get; set; } = new List<Post>();

        public void Attach(IObserver observer)
        {
            Observers.Add(observer);
        }

        public void Detach(IObserver observer)
        {
            Observers.Remove(observer);
        }

        public List<IObserver> GetSubscribers()
        {
            return Observers;
        }

        public void Notify()
        {
            foreach (var observer in Observers)
            {
                observer.Update();
            }
        }
    }
}
