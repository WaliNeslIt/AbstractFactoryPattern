

namespace AbstractFactory
{
    public interface IRoadVehicleFactory
    {
        public IEngine processEngine();
        public ITyres processTyre();
    }
}
