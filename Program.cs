
namespace DZ_5_Interface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var quad = new Quadcopter();
            Console.WriteLine("Сам объект класса ничего не говорит, но через призму интерфейсов можно пообщаться");

            Console.WriteLine("IRobot говорит:");
            IRobot quad1 = quad as IRobot;//new Quadcopter();
            Console.WriteLine(quad1.GetInfo());
            Console.WriteLine(quad1.GetRobotType());
            Console.WriteLine("Компоненты робота:");
            foreach (var item in quad1.GetComponents())
            {
                Console.WriteLine($"  {item}");
            }
            Console.WriteLine();

            Console.WriteLine("IChargeable говорит:");
            IChargeable quad2 = quad as IChargeable;//new Quadcopter();
            quad2.Charge();
            Console.WriteLine(quad2.GetInfo());
            Console.WriteLine();

            Console.WriteLine("IFlyingRobot говорит:");
            IFlyingRobot quad3 = quad as IFlyingRobot;//new Quadcopter();
            Console.WriteLine(quad3.GetRobotType());
            Console.WriteLine();

        }
    }
}
