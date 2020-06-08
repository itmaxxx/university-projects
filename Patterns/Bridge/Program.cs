using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    class Program
    {
        private static Random random = new Random();

        interface Component
        {
            void ShowInfo();
        }

        class PC
        {
            private Component component;

            public PC(Component _component)
            {
                component = _component;
            }

            public void ShowComponentInfo()
            {
                component.ShowInfo();
            }
        }

        class GraphicsCard : Component
        {
            public void ShowInfo()
            {
                Console.WriteLine("Graphic Card status : (working)");
                Console.WriteLine($"3D : {random.Next(0, 100)}%");
                Console.WriteLine($"Copy : {random.Next(0, 100)}%");
                Console.WriteLine($"Vieo encode : {random.Next(0, 100)}%");
                Console.WriteLine($"Video decode :  {random.Next(0, 100)}%");
                Console.WriteLine($"Graphic memory use :  {random.Next(0, 1024 * 8)} MB");
            }
        }

        class Processor : Component
        {
            public void ShowInfo()
            {
                Console.WriteLine("Processor status : (working)");
                Console.WriteLine($"Usage : {random.Next(0, 100)}%");
                Console.WriteLine($"Processes : {random.Next(0, 500)} processes");
            }
        }

        class HDD : Component
        {
            public void ShowInfo()
            {
                Console.WriteLine("HDD status : (working)");
                Console.WriteLine($"Active time : {random.Next(0, 100)}%");
            }
        }

        class RAM : Component
        {
            public void ShowInfo()
            {
                Console.WriteLine("RAM status : (working)");
                Console.WriteLine($"Memory usage : {random.Next(0, 1024 * 16)} MB");
            }
        }

        static void Main(string[] args)
        {
            GraphicsCard graphicsCard = new GraphicsCard();
            PC pc = new PC(graphicsCard);
            pc.ShowComponentInfo();
        }
    }
}
