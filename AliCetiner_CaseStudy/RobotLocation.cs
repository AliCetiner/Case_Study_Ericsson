using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AliCetiner_CaseStudy
{
    public class RobotLocation
    {
        public static List<string> Directions = new List<string>() { "N", "W", "S", "E" };
        public static List<string> NasaCommands = new List<string>() { "L", "R", "M" };

        private int x;
        public int X
        {
            get
            {
                return x;
            }
            set
            {
                if (value > MarsMaxCoords.MaxX)
                {
                    x = MarsMaxCoords.MaxX;
                }
                else if (value < 0)
                {
                    x = 0;
                }
                else
                {
                    x = value;
                }
            }
        }

        private int y;
        public int Y
        {
            get
            {
                return y;
            }
            set
            {
                if (value > MarsMaxCoords.MaxY)
                {
                    y = MarsMaxCoords.MaxY;
                }
                else if (value < 0)
                {
                    y = 0;
                }
                else
                {
                    y = value;
                }
            }
        }

        public string Direction { get; set; }

    }
}