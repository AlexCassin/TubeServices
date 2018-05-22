using System;
using System.Collections.Generic;
using System.Text;

namespace TubeServicea
{
    public class Line
    {

        public string LineName { get; set; }
        public string LineService { get; set; }
        public string LineDetails { get; set; }
        public int LineServiceNumber
        {
            get
            {
                switch (LineService.ToUpper())
                {
                    case "SEVERE DELAYS":
                        return 2;
                    case "MINOR DELAYS":
                        return 1;
                    default:
                        return 0;
                }
            }
        }


        public string ImageSource
        {
            get
            {
                return LineService.ToUpper() == "GOOD SERVICE" ? "good_icon.png" : "bad_icon.png";
            }
        }

        public Line(string lineName, string lineService, string lineDetails)
        {
            LineName = lineName;
            LineService = lineService;
            LineDetails = lineDetails;
        }



    }

    
}
