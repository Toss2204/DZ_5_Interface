using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_5_Interface
{
    public interface IRobot
    {
        public string GetInfo()
        {
            return "Ро́бот — автоматическое устройство, предназначенное для осуществления различного рода действий, обычно выполняемых человеком.";
        }


        public List<string> GetComponents();

        public string GetRobotType()
        {
            return "I am a simple robot.";
        }
    }
}
