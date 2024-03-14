namespace AbstractFactory
{
    public class BMWBikeEngine : IEngine
    {
        private string BikeEngine { get; set; }
        public string getEngine()
        {
            return BikeEngine;
        }

        public string setEngine(string EngineName)
        {
            return this.BikeEngine = EngineName;
        }
    }
}