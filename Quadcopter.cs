using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DZ_5_Interface
{
    public class Quadcopter : IFlyingRobot, IChargeable
    {

        List<string> _components = new List<string>() { "rotor1", "rotor2", "rotor3", "rotor4" };
      
        List<string> IRobot.GetComponents()
        {
            return _components;
        }

        string IRobot.GetInfo()
        {
            return "Слово «робот» произошло от чешского - robot, от robota - «подневольный труд» и\n" +
                    "было впервые придумано чешским художником Йозефом Чапеком и использовано его братом,\n" +
                    "писателем Карелом Чапеком, - впервые в пьесе «Р.у.р.» ( «Россумские универсальные роботы», 1920 г.)."
        }

        void IChargeable.Charge()
        {
            Console.WriteLine("Charging...");
            Thread.Sleep(3000);
            Console.WriteLine("Charged!");
        }
        string IChargeable.GetInfo()
        {
            return "Робот питается электроэнергией и думает как захватить мир";
        }

        string IFlyingRobot.GetRobotType()
        {
            return "Этот робот - четырехкоптёр";
        }
    }
}
