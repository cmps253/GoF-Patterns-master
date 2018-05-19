using System;

namespace Visitor
{
    public class Record
    {
        private String postalCode;
        private String town;
        private double elevation;
        private String district;

        public String getPostalCode()
        {
            return postalCode;
        }

        public String getTown()
        {
            return town;
        }

        public double getElevation()
        {
            return elevation;
        }

        public String getDistrict()
        {
            return district;
        }

        private Record(String postalCode, String town, double elevation, String district)
        {
            this.postalCode = postalCode;
            this.town = town;
            this.elevation = elevation;
            this.district = district;
        }

        public override String ToString()
        {
            return "[postalCode=" + postalCode + ", town=" + town + ", elevation=" + elevation + ", district=" + district + "]";
        }

        public static Record createFromCsvLine(String csv)
        {
            var arr = csv.Split(',');
            return new Record(arr[0], arr[1], Double.Parse(arr[2]), arr[3]);
        }
    }
}
