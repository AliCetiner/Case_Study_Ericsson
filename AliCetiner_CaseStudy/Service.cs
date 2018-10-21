using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AliCetiner_CaseStudy
{
    public class Service
    {
        public void SetMarsMaxCoords()
        {
            string marsMaxCoords = "";
            while (marsMaxCoords.Count(x => x == ' ') != 1)
            {
                Console.WriteLine("Mars'taki yüzeyin sağ üst köşesinin koordinatı. (örn:5 5)");
                marsMaxCoords = Console.ReadLine();

                try
                {
                    MarsMaxCoords.MaxX = Convert.ToInt32(marsMaxCoords.Split(' ')[0]);
                    MarsMaxCoords.MaxY = Convert.ToInt32(marsMaxCoords.Split(' ')[1]);
                }
                catch (Exception)
                {
                    marsMaxCoords = "";
                    continue;
                }
            }
        }

        public RobotLocation SetRobotFirstLocation(string robotNo)
        {
            RobotLocation robot = new RobotLocation();
            string robotLoc = "";
            while (robotLoc.Count(x => x == ' ') != 2)
            {
                Console.WriteLine("\n" + robotNo + " Robotun ilk konumu ve yönü (N,E,S,W) (örn:1 3 E)");
                robotLoc = Console.ReadLine();

                try
                {
                    robot.X = Convert.ToInt32(robotLoc.Split(' ')[0]);
                    robot.Y = Convert.ToInt32(robotLoc.Split(' ')[1]);
                    robot.Direction = robotLoc.Split(' ')[2];

                    if (!RobotLocation.Directions.Contains(robot.Direction))
                    {
                        robotLoc = "";
                        continue;
                    }
                }
                catch (Exception)
                {
                    robotLoc = "";
                    continue;
                }
            }

            return robot;
        }

        public string SetNasaCommands(string robotNo)
        {
            string nasaCommands = "";
            while (string.IsNullOrEmpty(nasaCommands))
            {
                Console.WriteLine("\n" + robotNo + " Robotun için harf katarları. (Komutlar:'L','R've'M' olabilir.)");
                nasaCommands = Console.ReadLine();

                if (nasaCommands.Any(x => !RobotLocation.NasaCommands.Contains(x.ToString())))
                {
                    nasaCommands = "";
                    continue;
                }
            }
            return nasaCommands;
        }
        
        public RobotLocation GetRobotLastLocation(string nasaCommands, RobotLocation robot)
        {
            foreach (var item in nasaCommands)
            {
                if (item == 'L')
                {
                    if (robot.Direction == "N")
                    {
                        robot.Direction = "W";
                    }
                    else if (robot.Direction == "W")
                    {
                        robot.Direction = "S";
                    }
                    else if (robot.Direction == "S")
                    {
                        robot.Direction = "E";
                    }
                    else // robot.Direction == "E"
                    {
                        robot.Direction = "N";
                    }
                }

                else if (item == 'R')
                {
                    if (robot.Direction == "N")
                    {
                        robot.Direction = "E";
                    }
                    else if (robot.Direction == "W")
                    {
                        robot.Direction = "N";
                    }
                    else if (robot.Direction == "S")
                    {
                        robot.Direction = "W";
                    }
                    else // robot.Direction == "E"
                    {
                        robot.Direction = "S";
                    }
                }

                else // item == 'M'
                {
                    if (robot.Direction == "N")
                    {
                        robot.Y++;
                    }
                    else if (robot.Direction == "W")
                    {
                        robot.X--;
                    }
                    else if (robot.Direction == "S")
                    {
                        robot.Y--;
                    }
                    else // robot.Direction == "E"
                    {
                        robot.X++;
                    }
                }
            }

            return robot;
        }
    }
}