using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPRadiany
{
    static class  Prevodnik
    {
        
        public static string PrevedNaRadiany(double degreeInput)
        {
            double radians = Math.Round((Math.PI / 180) * degreeInput, 13);
           
            return String.Format("{0} stupňů na radiány: {1}", degreeInput, radians);
        }

        public static string PrevedNaStupne(double radianInput)
        {
            double degrees = (180 / Math.PI) * radianInput;

            return String.Format("{0} radiánů na stupně: {1}", radianInput, degrees);
        }
    }
}