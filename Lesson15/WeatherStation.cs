using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson15
{
    public interface IObserver
    {
        void Update(ISubject subject);
    }

    public interface ISubject
    {
        void Attach(IObserver observer);
        void Detach(IObserver observer);
        void Notify();
    }
    
    public class WeatherStation : ISubject
    {
        private List<IObserver> observers = new List<IObserver>();
        private int _temperature;
        public int Temperature
        {
            get => _temperature;
            set
            {
                _temperature = value;
                Notify();
            }
        }
        public void Attach(IObserver observer)
        {
            observers.Add(observer);
        }
        public void Detach(IObserver observer)
        { 
            observers.Remove(observer); 
        }
        public void Notify()
        {
            foreach (var observer in observers)
            { 
                observer.Update(this);
            }
        }
    }
    public class TemperatureDisplay : IObserver
    {
        public void Update(ISubject subject)
        {
            if (subject is WeatherStation weatherStation)
            { 
                Console.WriteLine("Temperature display updated " + weatherStation.Temperature);
            }
        }
    }
}
