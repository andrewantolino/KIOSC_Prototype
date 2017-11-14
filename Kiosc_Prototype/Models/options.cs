using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace Kiosc_Prototype.Models
{
    public class Selections
    {
        public string Options { get; set; }
        public string Filters { get; set; }
        public string Fdate { get; set; }
        public string Tdate { get; set; }
        public string Time { get; set; }

        public string CreateDateTime()
        {
            string[] splitDate = Fdate.Split('/');
            string[] splitTime = Time.Split(':');

            string formattedDate = splitDate[2] + "/" + splitDate[1] + "/" + splitDate[0] + " " + splitTime[0] + ":" + splitTime[1] + ":" + splitTime[2];
            // 01/11/17 10:00:00 
            return formattedDate;
        }
        
    }

}
    

