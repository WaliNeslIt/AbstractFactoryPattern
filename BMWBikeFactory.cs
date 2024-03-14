namespace AbstractFactory
{
    public class BMWBikeFactory : IRoadVehicleFactory
    {   
        public IEngine processEngine()
        {
            return new BMWBikeEngine();
        }

        public ITyres processTyre()
        {
            return new BMWBikeTyre();
        }
    }
}