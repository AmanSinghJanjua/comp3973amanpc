using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProvinceCity.Models
{
    public class City
    {
        public int CityId { get; set; }
        public string CityName { get; set; }
        public int Population { get; set; }
        public string ProvinceCode { get; set; }
        [ForeignKey("ProvinceCode")]
        public Province Province { get; set; }

        public static List<City> GetCities()
        {
            List<City> cities = new List<City> {
                    new City () {
                    CityId = 1,
                    CityName = "Surrey",
                    Population = 616896,
                    ProvinceCode = "BC",
                    },
                    new City () {
                    CityId = 2,
                    CityName = "Richmond",
                    Population = 1104980,
                    ProvinceCode = "BC",
                    },
                    new City () {
                    CityId = 3,
                    CityName = "Coquitlam",
                    Population = 175791,
                    ProvinceCode = "BC",
                    },
                    new City () {
                    CityId = 4,
                    CityName = "Calgary",
                    Population = 1547484,
                    ProvinceCode = "AB",
                    },
                    new City () {
                    CityId = 5,
                    CityName = "Edmonton",
                    Population = 1461000,
                    ProvinceCode = "AB",
                    },
                    new City () {
                    CityId = 6,
                    CityName = "Airdrie",
                    Population = 68091,
                    ProvinceCode = "AB",
                    },
                    new City () {
                    CityId = 7,
                    CityName = "Mississauga",
                    Population = 801877,
                    ProvinceCode = "ON",
                    },
                    new City () {
                    CityId = 8,
                    CityName = "Brampton",
                    Population = 735850,
                    ProvinceCode = "ON",
                    },
                    new City () {
                    CityId = 9,
                    CityName = "Oakville",
                    Population = 193832,
                    ProvinceCode = "ON",
                    },
            };
            return cities;
        }

    }
}
