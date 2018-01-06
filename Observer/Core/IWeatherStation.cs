namespace Observer.Core
{
    public interface IWeatherStation:IObserable
    {
         void getTemp();
         void getHumidity();
         void getWind();
         void setTemp(double val);
         void setHumidity(double val);
         void setWind(double val);
    }
}