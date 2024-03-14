

namespace AbstractFactory
{
    public class BMWCarEngine : IEngine
    {
        private string CarEngine { get; set; }
        public string getEngine()
        {
            return CarEngine;
        }

        public string setEngine(string EngineName)
        {
            return this.CarEngine = EngineName;
        }
    }
}
