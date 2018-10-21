using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AliCetiner_CaseStudy
{
    class Program
    {
        static void Main(string[] args)
        {
            Service entityServices = new Service();

            // First Input
            entityServices.SetMarsMaxCoords();

            // Second Input For First Robot Locations
            RobotLocation robot1 = entityServices.SetRobotFirstLocation("Birinci");

            // Third Input For First Robot Nasa Commands
            string nasaCommands = entityServices.SetNasaCommands("Birinci");

            // Output For First Robot
            robot1 = entityServices.GetRobotLastLocation(nasaCommands, robot1);
            Console.WriteLine("\nBirinci Robotun son konumu : " + robot1.X + " " + robot1.Y + " " + robot1.Direction);

            /*------------------------------------------------------------------------------*/

            // Second Robot First Locations
            RobotLocation robot2 = entityServices.SetRobotFirstLocation("İkinci");

            // Second Robot Nasa Commands
            nasaCommands = entityServices.SetNasaCommands("İkinci");

            // Output For Second Robot
            robot2 = entityServices.GetRobotLastLocation(nasaCommands, robot2);
            Console.WriteLine("\nİkinci Robotun Son Konumu : " + robot2.X + " " + robot2.Y + " " + robot2.Direction);

            Console.ReadKey();
        }
    }
}