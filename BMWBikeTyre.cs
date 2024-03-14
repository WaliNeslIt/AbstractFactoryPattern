

namespace AbstractFactory
{
    public class BMWBikeTyre : ITyres
    {
        private int BikeTyreInches { get; set; }
        public string getTyreInches()
        {
            return this.BikeTyreInches.ToString();
        }

        public void setTyreInches(int Inches)
        {
            this.BikeTyreInches = Inches;
        }
    }
}
