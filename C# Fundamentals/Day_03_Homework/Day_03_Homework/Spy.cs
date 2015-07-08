using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_03_Homework
{
    class Spy
    {
        
        private string codeName;
        private string notes;
        private DateTime dateLastSeen;
        private Agency agency;

        public string CodeName
        {
            get { return codeName; }
            set { codeName = value; }
        }

        

        public Agency SpyAgency
        {
            get { return agency; }
            set { agency = value; }
        }

       

        public DateTime DateLastSeen
        {
            get { return dateLastSeen; }
            set { dateLastSeen = value; }
        }

        

        public string Notes
        {
            get { return notes; }
            set { notes = value; }
        }


        public void DisplaySpyInfo()
        {

            //TODO
            Console.WriteLine(CodeName + " " + SpyAgency.GetAgencyInfo() + " Date Last Seen: " + DateLastSeen.ToString() + " " + " (" + Notes + ") ");
            Console.ReadLine();
        }
    }
}
