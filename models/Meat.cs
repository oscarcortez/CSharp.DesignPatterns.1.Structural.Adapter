using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace models
{
    public class Meat
    {
        protected string MeatName;
        protected float SafeCookTempFahrenheit;
        protected float SafeCookTempCelsius;
        protected double CaloriesPerOunce;
        protected double ProteinPerOunce;

        public Meat(string meat) => MeatName = meat;

        public virtual void LoadData() => Console.WriteLine($"Meat: {MeatName}");
    }
}
