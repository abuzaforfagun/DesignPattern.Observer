namespace Observer.Core
{
    public class Subscriber : IObserver,IDisplay
    {
        IWeatherStation station;
        public string Name { get; set; }
        public Subscriber(IWeatherStation weatherStation){
            this.station = weatherStation;
        }

        public void Display()
        {
            throw new System.NotImplementedException();
        }

        void IObserver.Update()
        {
            System.Console.WriteLine("Updating " + Name);
            this.station.getHumidity();
            this.station.getTemp();
            this.station.getWind();
        }
    }
}