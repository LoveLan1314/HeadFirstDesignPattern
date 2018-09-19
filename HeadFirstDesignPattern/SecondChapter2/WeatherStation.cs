namespace HeadFirstDesignPattern.SecondChapter2
{
    internal class WeatherStation
    {
        public static void Main(string[] args)
        {
            WeatherDataTracker provider = new WeatherDataTracker();
            WeatherDataReport report1 = new WeatherDataReport("A");
            report1.Subscribe(provider);
            WeatherDataReport report2 = new WeatherDataReport("B");
            report2.Subscribe(provider);

            provider.TrackWeatherData(new WeatherData(80, 65, 30.4f));
            report1.Unsubscribe();
            provider.TrackWeatherData(new WeatherData(82, 70, 29.2f));
        }
    }
}
