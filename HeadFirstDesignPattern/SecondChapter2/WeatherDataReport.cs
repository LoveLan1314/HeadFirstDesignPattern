using System;

namespace HeadFirstDesignPattern.SecondChapter2
{
    internal class WeatherDataReport : IObserver<WeatherData>
    {
        private IDisposable _unsubscriber;

        public WeatherDataReport(string instName)
        {
            InstName = instName;
        }

        public string InstName { get; }

        public void OnCompleted()
        {
            Console.WriteLine("The WeatherData Tracker has completed transmitting data to {0}.", InstName);
            Unsubscribe();
        }

        public void OnError(Exception error)
        {
            Console.WriteLine("{0}: The WeatherData cannot be determined.", InstName);
        }

        public void OnNext(WeatherData value)
        {
            Console.WriteLine($"Current conditions {value.Temperature} F degrees and {value.Humidity} % humidity.By {InstName}");
        }

        public virtual void Subscribe(IObservable<WeatherData> provider)
        {
            if (provider != null)
            {
                _unsubscriber = provider.Subscribe(this);
            }
        }

        public virtual void Unsubscribe()
        {
            _unsubscriber.Dispose();
        }
    }
}
