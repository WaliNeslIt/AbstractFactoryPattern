using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class BMWCarTyre : ITyres
    {
        private int CarTyreInches { get; set; }

        public string getTyreInches()
        {
            return this.CarTyreInches.ToString();
        }

        public void setTyreInches(int Inches)
        {
            this.CarTyreInches = Inches;
        }
    }
}
