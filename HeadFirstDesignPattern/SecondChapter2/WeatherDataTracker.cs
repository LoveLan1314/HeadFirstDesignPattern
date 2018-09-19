using System;
using System.Collections.Generic;

namespace HeadFirstDesignPattern.SecondChapter2
{
    internal class WeatherDataTracker : IObservable<WeatherData>
    {
        private List<IObserver<WeatherData>> _observers;

        public WeatherDataTracker()
        {
            _observers = new List<IObserver<WeatherData>>();
        }

        public IDisposable Subscribe(IObserver<WeatherData> observer)
        {
            if (!_observers.Contains(observer))
            {
                _observers.Add(observer);
            }
            return new Unsubscriber(_observers, observer);
        }
        private class Unsubscriber : IDisposable
        {
            private List<IObserver<WeatherData>> _observers;
            private readonly IObserver<WeatherData> _observer;

            public Unsubscriber(List<IObserver<WeatherData>> observers, IObserver<WeatherData> observer)
            {
                _observers = observers;
                _observer = observer;
            }
            .
            public void Dispose()
            {
                if (_observer != null && _observers.Contains(_observer))
                {
                    _observers.Remove(_observer);
                }
            }
        }
        public void TrackWeatherData(WeatherData data)
        {
            foreach (var observer in _observers)
            {
                observer.OnNext(data);
            }
        }

        public void EndTransmission()
        {
            foreach (var observer in _observers)
            {
                if (_observers.Contains(observer))
                {
                    observer.OnCompleted();
                }
            }

            _observers.Clear();
        }
    }
}
