using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_03_Homework
{
    class Agency
    {

        private string agencyName;
        private int orginizationSize;
        private string country;


        public string AgencyName
        {
            get { return agencyName; }
            set { agencyName = value; }
        }

        public string Country
        {
            get { return country; }
            set { country = value; }
        }

        public int OrginizationSize
        {
            get { return orginizationSize; }
            set { orginizationSize = value; }
        }

        public string GetAgencyInfo()
        {
            //TODO
            string message = "";
            message = AgencyName + " " + " (" + Country + ") " + OrginizationSize;
            return message;
        }
    }
}
