using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MajoSiriusApi.Models
{

    /*
    Test POST JSON
    {
        "Device":"Mdv1",
        "Altitude":245,
        "Latitude":3.773567,
        "Longitude":1.265076,
        "NominalPower":3000
    }
    */
    public class Stage
    {
        public long Id { get; set; }
        public string Device { get; set; }
        public int Altitude { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public int NominalPower { get; set; }
    }
}
