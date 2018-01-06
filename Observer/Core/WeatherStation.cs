using System.Collections.Generic;

namespace Observer.Core
{
    public class WeatherStation : IObserable,IWeatherStation
    {
        public List<IObserver> subscribers;
        double Humidity;
        double Temp;
        double Wind;

        public WeatherStation(){
            subscribers = new List<IObserver>();
            Humidity=2.5;
            Temp=3.0;
            Wind=8;
        }

        public void getHumidity()
        {
            System.Console.WriteLine("Current Humidity: " + this.Humidity.ToString());
        }

        public void getTemp()
        {
            System.Console.WriteLine("Current Temp: " + this.Temp.ToString());
        }

        public void getWind()
        {
            System.Console.WriteLine("Current Wind: " + this.Wind.ToString());
        }

        public void setHumidity(double val)
        {
            this.Humidity =val;
        }

        public void setTemp(double val)
        {
            this.Temp=val;
        }

        public void setWind(double val)
        {
            this.Wind=val;
        }

        public void Add(IObserver observer)
        {
            this.subscribers.Add(observer);
        }

        public void Notify()
        {
            foreach(var subscriber in subscribers){
                subscriber.Update();
            }
        }

        public void Remove(IObserver observer)
        {
            this.subscribers.Remove(observer);
        }
    }
}