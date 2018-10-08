using Lab3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab3.Data
{
    public class DummyData
    {
        public static List<City> GetCities()
        {
            List<City> cities = new List<City>
            {
                new City() {
                CityId=01,
                CityName="Vancouver",
                Population=100
                },
                new City() {
                CityId=02,
                CityName="Richmond",
                Population=200
                },
                new City() {
                CityId=03,
                CityName="Burnaby",
                Population=200
                }
            };

            return cities;
        }
    }
}
