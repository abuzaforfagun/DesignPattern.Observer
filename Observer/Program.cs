using System;
using Observer.Core;

namespace Observer
{
    class Program
    {
        static IWeatherStation station;
        static void Main(string[] args)
        {
            station = new WeatherStation();
            Subscriber s1 = new Subscriber(station);
            s1.Name="Station 1";
            Subscriber s2 = new Subscriber(station);
            s2.Name="Station 2";
            station.Add(s1);
            station.Add(s2);
            station.Notify();

            station.setHumidity(10.1);
            station.setTemp(1.9);
            station.setWind(3.1);

            station.Notify();
            Console.Read();
        }
    }
}
