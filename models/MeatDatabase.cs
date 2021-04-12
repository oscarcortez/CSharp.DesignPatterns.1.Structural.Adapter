using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace models
{
    public class MeatDatabase
    {
        public float GetSafeCookTemp(string meat, TemperatureType temperatureType)
        {
            if (temperatureType == TemperatureType.Farenheit)
            {
                return meat switch
                {
                    "beef" or "pork" => 145f,
                    "chicken" or "turkey" => 165f,
                    _ => 165f,
                };
            }
            else
            {
                return meat switch
                {
                    "beef" or "veal" or "pork" => 63f,
                    "chicken" or "turkey" => 74f,
                    _ => 74f,
                };
            }
        }

        public int GetCaloriesPerOunce(string meat)
        {
            return meat.ToLower() switch
            {
                "beef" => 71,
                "pork" => 69,
                "chicken" => 66,
                "turkey" => 38,
                _ => 0,
            };
        }

        public double GetProteinPerOunce(string meat)
        {
            return meat.ToLower() switch
            {
                "beef" => 7.33f,
                "pork" => 7.67f,
                "chicken" => 8.57f,
                "turkey" => 8.5f,
                _ => 0d,
            };
        }
    }
}
