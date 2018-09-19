namespace HeadFirstDesignPattern.SecondChapter
{
    internal class CurrentConditionsDisplay : IObserver, IDisplayElement
    {
        private float _temperature;
        private float _humidity;
        private readonly ISubject _subject;

        public CurrentConditionsDisplay(ISubject weatherData)
        {
            _subject = weatherData;
            _subject.RegisterObserver(this);
        }

        public void Display()
        {
            System.Console.WriteLine($"Current conditions {_temperature} F degrees and {_humidity} % humidity");
        }

        public void Update(float temp, float humidity, float pressure)
        {
            _temperature = temp;
            _humidity = humidity;
            Display();
        }
    }
}
